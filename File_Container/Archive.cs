//Главное окно программы
//ст. 156 гр. Кульченко Алексей
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using FileContainer.Extensions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace FileContainer
{

     public partial class Form_cont : Form
    {

         Param overview = new Param();
        public Form_cont()
         {
             InitializeComponent();
             GetListFS();
             this.KeyPreview = true;
             try
             {
                 ReadXML();
             }
             catch
             {
                 comboBox_method.SelectedIndex = 0;
                 radioButton1.Checked = true;
             }
         }

        
        private string PathToFile = "";

        public void GetListFS()
        {
            //начало обновления(прорисовки) списка
            listViewFiles.BeginUpdate();
            listViewFiles.Items.Clear();

            if (PathToFile == "") //если значение пути пустое, то...
            {
                //получаем имена логических дисков в компе
                string[] drivers = Directory.GetLogicalDrives();
                foreach (string drive in drivers)
                {
                    listViewFiles.Items.Add(drive, 2);
                }
            }
            else
            {
                try
                {
                    //получаем список директорий
                    string[] dirs = Directory.GetDirectories(PathToFile);
                    foreach (string s in dirs)
                    {
                        string dirname = Path.GetFileName(s);
                        listViewFiles.Items.Add(dirname, 1);
                    }
                    
                    //получаем список файлов
                    string[] files = Directory.GetFiles(PathToFile);
                    foreach (var s in files)
                    {
                        string filename = Path.GetFullPath(s);
                        listViewFiles.Items.Add(filename, 0);
                    }
                }
                catch
                {
                }

                filePathLabel.Text = PathToFile;
                this.Text = PathToFile;
                listViewFiles.EndUpdate();
            }
        }

        //создание архива
        private void btnCreate_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;//выбор множества файлов     
            openFileDialog1.Title = "Выберите файлы, которые необходимо поместить в архив";
            DialogResult result = openFileDialog1.ShowDialog(); //запуск диалогового окна
            if (result == DialogResult.OK)
            {
                create_archive();
            }
        }

        //извлечение файлов
        private void btnExtract_Click(object sender, EventArgs e)
        {
           openFileDialog1.Title = "Выберите файловый архив";
            DialogResult result = openFileDialog1.ShowDialog();//запуск диалогового окна
            if (result == DialogResult.OK)
            {
                DialogResult result2 = folderBrowserDialog1.ShowDialog();//запуск диалогового окна
                if (result2 == DialogResult.OK)
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath);//извлечение файлов в выбранную директорию
                        MessageBox.Show("Данные успешно извлечены!", "Инфо!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось извлечь файлы в выбранное место!\n Попробуйте изменить место!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
                }
            }
        }

        //добавление файла в архив
        private void btnAddFile_Click(object sender, EventArgs e)
        {  
            string zip, filePath, fileName; 

            openFileDialog1.Title = "Выберите файл, который необходимо добавить в архив";
            DialogResult result = openFileDialog1.ShowDialog(); //запуск диалогового окна
            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName; //переменная для хранения полного пути к файлу
                fileName = openFileDialog1.SafeFileName;//имя файла
                openFileDialog1.Title = "Выберите архив, в который необходимо добавить файл";
                DialogResult result1 = openFileDialog1.ShowDialog();//запуск диалогового окна
                if (result1 == DialogResult.OK)
                {
                    zip= openFileDialog1.FileName;//полный путь контейнера
                    using (FileStream zipToOpen = new FileStream(zip, FileMode.Open))//открываем файловый контейнер
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))//обновляем файловый контейнер
                        {
                           // ZipArchiveEntry readmeEntry = archive.CreateEntryFromFile(filePath, fileName);//добавляем выбранный файл в контейнер
                            MessageBox.Show("Файл успешно добавлен!", "Инфо!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
           }
        }

        //добавление папки в архив
        private void btnAddFolder_Click1(object sender, EventArgs e)
        {
            string zip;
            string folderPath;

            openFileDialog1.Title = "Выберите архив, в который необходимо добавить папку";
            DialogResult result2 = folderBrowserDialog1.ShowDialog();//запуск диалогового окна
            if (result2 == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath; //переменная для хранения полного пути к папке
                DialogResult result1 = openFileDialog1.ShowDialog();//запуск диалогового окна
                if (result1 == DialogResult.OK)
                {
                    zip = openFileDialog1.FileName;//полный путь контейнера
                    using (FileStream zipToOpen = new FileStream(zip, FileMode.Open))//открываем файловый контейнер
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))//обновляем файловый контейнер
                        {
                            archive.AddDirectory(folderPath);//добавляем выбранную папку в контейнер

                            MessageBox.Show("Папка успешно добавлена!", "Инфо!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

         //выбор элемента в ListView
        private void listViewFiles_ItemActivate(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count == 0)
                return;
            ListViewItem item = listViewFiles.SelectedItems[0];
            switch (item.ImageIndex)
            {
                case 1:
                    {
                        PathToFile += "\\" + item.Text;

                        GetListFS();
                        break;
                    }
                default:
                    {
                        PathToFile += item.Text;
                        GetListFS();
                        break;
                    }
            }
        }

         //возврат в предыдущую директорию
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (PathToFile == "")
            {
                MessageBox.Show("Вы находитесь в корне.", "Пути выше нету");
            }
            else
            {
                try
                {
                    DirectoryInfo dirinfo = Directory.GetParent(PathToFile);
                    PathToFile = dirinfo.FullName;
                }
                catch (NullReferenceException)
                {
                    PathToFile = "";
                }
                
            }
            GetListFS();
        }

         //команды для меню "Файл"
        private void CreateArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreate_Click(sender,e);
        }

        private void AddFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFile_Click(sender,e);
        }

        private void AddFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFolder_Click1(sender, e);
        }

        private void ExtractAllFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExtract_Click(sender, e);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteXML();
            Close();
        }

        //вызов окна справки
        private void help_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help help_prog = new help();
            help_prog.Visible = true;    
        }

        //вызов окна о программе
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info show = new info();
            show.Visible = true;
        }

        //меню ПКМ
        private void listViewFiles_MouseDown(object sender, MouseEventArgs e)
        {
             string  fileName;
            // string tmp = listViewFiles.SelectedItems.ToString();

             
            if (listViewFiles.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewFiles.SelectedItems[0];
                fileName = item.Text;//имя файла

             
                if (e.Button == MouseButtons.Right)
                {
                    listViewFiles.ContextMenuStrip = contextMenu_Right;
                  
                    if (fileName.Contains(".rar") || fileName.Contains(".zip"))
                    {

                       listViewFiles.ContextMenuStrip = contextMenu_Right;
                       contextMenu_Right.Items[0].Visible = false;
                       contextMenu_Right.Items[1].Visible = false;
                       contextMenu_Right.Items[2].Visible = false;
                       contextMenu_Right.Items[3].Visible = true;
                    }
                   
                    else
                    {
                        if (fileName.Contains("."))
                        {
                            contextMenu_Right.Items[0].Visible = true;
                            contextMenu_Right.Items[1].Visible = true;
                            contextMenu_Right.Items[2].Visible = false;
                            contextMenu_Right.Items[3].Visible = false;
                        }
                        else
                        {
                            contextMenu_Right.Items[0].Visible = true;
                            contextMenu_Right.Items[2].Visible = true;
                            contextMenu_Right.Items[1].Visible = false;
                        }
                        contextMenu_Right.Items[3].Visible = false;
                    }
                }
            }
        }

        private void CreateArchivePKM_Click(object sender, EventArgs e)
        {
            btnCreate_Click(sender, e);
        }

        public void create_archive()
        {
             string[] files = openFileDialog1.FileNames; //создание массива для хранения файлов
                saveFileDialog1.Title = "Выберите место и имя для хранения файлового архива";
                if (radioButton1.Checked == true)
                {
                    saveFileDialog1.Filter = "Файл ZIP|*.zip|Файл RAR |*.rar";
                }
                else
                {
                    saveFileDialog1.Filter = "Файл RAR |*.rar|Файл ZIP|*.zip";
                }
                DialogResult result1 = saveFileDialog1.ShowDialog();//запуск диалогового окна
                if (result1 == DialogResult.OK)
                {
                    try
                    {
                        ZipArchive zip = ZipFile.Open(saveFileDialog1.FileName, ZipArchiveMode.Create);//создание архива
                        foreach (string file in files)
                        {

                            switch (comboBox_method.SelectedIndex)
                            {
                                case 1:
                                     zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Fastest);// записываем все выбраные файлы в архив с сжатием
                                    break;
                                case 2:
                                     zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);// записываем все выбраные файлы в архив с сжатием
                                    break;
                                default:
                                     zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.NoCompression);// записываем все выбраные файлы в архив без сжатия   
                                    break;        
                            }
          
                        }
                         MessageBox.Show("Данные успешно сохранены!", "Инфо!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        zip.Dispose(); //освобождение ресурсов

                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Не получилось заменить существующий архив", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }

        private void listViewFiles_MouseClick(object sender, MouseEventArgs e)
        {
            
            object result = listViewFiles.SelectedItems;
            string fileName;
            if (listViewFiles.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewFiles.SelectedItems[0];
                fileName = item.Text;//имя файла
                if (fileName.Contains(".txt") || fileName.Contains(".doc") || fileName.Contains(".pas"))
                {
                    fileName = fileName.Replace("\\", "\\\\");
                    Process.Start("C:\\Windows\\System32\\notepad.exe", fileName.Trim());
                }

                if (fileName.Contains(".zip") || fileName.Contains(".rar"))
                {
                    fileName = fileName.Replace("\\", "\\\\");
                    Process.Start("C:\\Program Files\\WinRAR\\winrar.exe", fileName.Trim());
                }
            }
            
           // listViewFiles_MouseDoubleClick(sender, e);
        }

        private void AddFilePKM_Click(object sender, EventArgs e)
        {
            string zip;
            string filePath, fileName;
            ListViewItem item = listViewFiles.SelectedItems[0];
         fileName = item.Text.Substring(PathToFile.Length);//имя файла
         filePath = PathToFile += "\\" + fileName; //переменная для хранения полного пути к файлу
            DialogResult result1 = openFileDialog1.ShowDialog();//запуск диалогового окна
            if (result1 == DialogResult.OK)
            {
                zip = openFileDialog1.FileName;//полный путь контейнера
                using (FileStream zipToOpen = new FileStream(zip, FileMode.Open))//открываем файловый контейнер
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))//обновляем файловый контейнер
                    {
                        //foreach (ZipArchiveEntry entry in archive.Entries)
                        //{
                        //    if (entry.FullName.EndsWith("zi_dz1.txt"))
                        //    {
                        //        entry.Delete();
                        //        return;
                        //    }
                        //}
                        ZipArchiveEntry readmeEntry = archive.CreateEntryFromFile(filePath, fileName);//добавляем выбранный файл в контейнер
                        MessageBox.Show("Файл успешно добавлен!", "Инфо!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void AddFolderPKM_Click(object sender, EventArgs e)
        {
            btnAddFolder_Click1(sender, e);
            }
        
        private void ExtractFilesPKM_Click(object sender, EventArgs e)
        {
            string filePath, fileName;
            ListViewItem item = listViewFiles.SelectedItems[0];
            fileName = item.Text.Substring(PathToFile.Length);//имя файла
            filePath = PathToFile += "\\" + fileName; //переменная для хранения полного пути к файлу

            try
            {
                DialogResult result2 = folderBrowserDialog1.ShowDialog();//запуск диалогового окна
                if (result2 == DialogResult.OK)
                {
                    ZipFile.ExtractToDirectory(filePath, folderBrowserDialog1.SelectedPath);//извлечение файлов в выбранную директорию
                    MessageBox.Show("Данные успешно извлечены", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Выберите другое место извлечения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
         
        //подсказки
        private void Method_label_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(label1, "Выбирается сила сжатия файлов");
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(groupBox1, "Выбирается формат в котором файлы будут храниться в архиве");
        }

        private void btnPrev_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button2, "Возврат в предыдущую директорию");
        }

        private void Form_cont_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteXML();
        }

         //запись параметров
         public void WriteXML()
        {
            overview.chak = comboBox_method.SelectedIndex;
            overview.type_archiv_1 = radioButton1.Checked;
            overview.type_archiv_2 = radioButton2.Checked;
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Param));
            var path = "parameters.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, overview);
            file.Close();
        }

         //считывание параметров
         public void ReadXML()
         {
             System.Xml.Serialization.XmlSerializer reader =
                 new System.Xml.Serialization.XmlSerializer(typeof(Param));
             System.IO.StreamReader file = new System.IO.StreamReader(
                 "parameters.xml");
             overview = (Param)reader.Deserialize(file);
             comboBox_method.SelectedIndex = overview.chak;
             radioButton1.Checked = overview.type_archiv_1;
             radioButton2.Checked = overview.type_archiv_2;
             file.Close();
         }


         protected override void OnKeyDown(KeyEventArgs e)
         {
             base.OnKeyDown(e);
             if (e.KeyCode == Keys.F1)
             {
                 help help_prog = new help();
                 help_prog.Visible = true;  
             }
         }

         public void listViewFiles_MouseDoubleClick(object sender, MouseEventArgs e)
         {
            
         }






    }


        public class Param
        {
            public int chak;
            public bool type_archiv_1, type_archiv_2;
        }

}
