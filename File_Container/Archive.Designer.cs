namespace FileContainer
{
    partial class Form_cont
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cont));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАрхивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извлечьВсеФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.create = new System.Windows.Forms.Button();
            this.извлечь = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.comboBox_method = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.contextMenu_Right = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПапкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.извлечьФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenu_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьАрхивToolStripMenuItem,
            this.добавитьФайлыToolStripMenuItem,
            this.добавитьПапкуToolStripMenuItem,
            this.извлечьВсеФайлыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьАрхивToolStripMenuItem
            // 
            this.создатьАрхивToolStripMenuItem.Name = "создатьАрхивToolStripMenuItem";
            this.создатьАрхивToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.создатьАрхивToolStripMenuItem.Text = "Создать архив";
            this.создатьАрхивToolStripMenuItem.Click += new System.EventHandler(this.CreateArchiveToolStripMenuItem_Click);
            // 
            // добавитьФайлыToolStripMenuItem
            // 
            this.добавитьФайлыToolStripMenuItem.Name = "добавитьФайлыToolStripMenuItem";
            this.добавитьФайлыToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.добавитьФайлыToolStripMenuItem.Text = "Добавить файлы";
            this.добавитьФайлыToolStripMenuItem.Click += new System.EventHandler(this.AddFileToolStripMenuItem_Click);
            // 
            // добавитьПапкуToolStripMenuItem
            // 
            this.добавитьПапкуToolStripMenuItem.Name = "добавитьПапкуToolStripMenuItem";
            this.добавитьПапкуToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.добавитьПапкуToolStripMenuItem.Text = "Добавить папку";
            this.добавитьПапкуToolStripMenuItem.Click += new System.EventHandler(this.AddFolderToolStripMenuItem_Click);
            // 
            // извлечьВсеФайлыToolStripMenuItem
            // 
            this.извлечьВсеФайлыToolStripMenuItem.Name = "извлечьВсеФайлыToolStripMenuItem";
            this.извлечьВсеФайлыToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.извлечьВсеФайлыToolStripMenuItem.Text = "Извлечь файлы";
            this.извлечьВсеФайлыToolStripMenuItem.Click += new System.EventHandler(this.ExtractAllFilesToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_ToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            this.help_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.help_ToolStripMenuItem.Text = "Вызвать справку F1";
            this.help_ToolStripMenuItem.Click += new System.EventHandler(this.help_ToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.LargeImageList = this.imageList;
            this.listViewFiles.Location = new System.Drawing.Point(142, 100);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(279, 151);
            this.listViewFiles.SmallImageList = this.imageList;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.List;
            this.listViewFiles.ItemActivate += new System.EventHandler(this.listViewFiles_ItemActivate);
            this.listViewFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFiles_MouseClick);
            this.listViewFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFiles_MouseDoubleClick);
            this.listViewFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewFiles_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "file.png");
            this.imageList.Images.SetKeyName(1, "directory.png");
            this.imageList.Images.SetKeyName(2, "disks.png");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "<-------";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPrev_Click);
            this.button2.MouseHover += new System.EventHandler(this.btnPrev_MouseHover);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(13, 276);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(0, 13);
            this.filePathLabel.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(9, 27);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(100, 38);
            this.create.TabIndex = 3;
            this.create.Text = "Создать архив";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // извлечь
            // 
            this.извлечь.Location = new System.Drawing.Point(318, 27);
            this.извлечь.Name = "извлечь";
            this.извлечь.Size = new System.Drawing.Size(103, 38);
            this.извлечь.TabIndex = 4;
            this.извлечь.Text = "Извлечь файлы";
            this.извлечь.UseVisualStyleBackColor = true;
            this.извлечь.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(215, 27);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(97, 38);
            this.btnAddFolder.TabIndex = 6;
            this.btnAddFolder.Text = "Добавить папку";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click1);
            // 
            // comboBox_method
            // 
            this.comboBox_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_method.Items.AddRange(new object[] {
            "Без сжатия",
            "Быстрый",
            "Оптимальный"});
            this.comboBox_method.Location = new System.Drawing.Point(9, 125);
            this.comboBox_method.Name = "comboBox_method";
            this.comboBox_method.Size = new System.Drawing.Size(111, 21);
            this.comboBox_method.TabIndex = 11;
            this.comboBox_method.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Метод сжатия";
            this.label1.MouseHover += new System.EventHandler(this.Method_label_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 73);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат архива";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "RAR";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ZIP";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // contextMenu_Right
            // 
            this.contextMenu_Right.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.добавитьФайлToolStripMenuItem,
            this.добавитьПапкуToolStripMenuItem1,
            this.извлечьФайлыToolStripMenuItem});
            this.contextMenu_Right.Name = "contextMenu_Right";
            this.contextMenu_Right.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenu_Right.Size = new System.Drawing.Size(162, 92);
            this.contextMenu_Right.RightToLeftChanged += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem2.Text = "Создать архив";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.CreateArchivePKM_Click);
            // 
            // добавитьФайлToolStripMenuItem
            // 
            this.добавитьФайлToolStripMenuItem.Name = "добавитьФайлToolStripMenuItem";
            this.добавитьФайлToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.добавитьФайлToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.добавитьФайлToolStripMenuItem.Text = "Добавить файл";
            this.добавитьФайлToolStripMenuItem.Click += new System.EventHandler(this.AddFilePKM_Click);
            // 
            // добавитьПапкуToolStripMenuItem1
            // 
            this.добавитьПапкуToolStripMenuItem1.Name = "добавитьПапкуToolStripMenuItem1";
            this.добавитьПапкуToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.добавитьПапкуToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.добавитьПапкуToolStripMenuItem1.Text = "Добавить папку";
            this.добавитьПапкуToolStripMenuItem1.Click += new System.EventHandler(this.AddFolderPKM_Click);
            // 
            // извлечьФайлыToolStripMenuItem
            // 
            this.извлечьФайлыToolStripMenuItem.Name = "извлечьФайлыToolStripMenuItem";
            this.извлечьФайлыToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.извлечьФайлыToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.извлечьФайлыToolStripMenuItem.Text = "Извлечь файлы";
            this.извлечьФайлыToolStripMenuItem.Click += new System.EventHandler(this.ExtractFilesPKM_Click);
            // 
            // Form_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_method);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.извлечь);
            this.Controls.Add(this.create);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_cont";
            this.Text = "Архиватор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_cont_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenu_Right.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАрхивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извлечьВсеФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStripMenuItem;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button извлечь;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.ComboBox comboBox_method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Right;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПапкуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem извлечьФайлыToolStripMenuItem;
    }
}

