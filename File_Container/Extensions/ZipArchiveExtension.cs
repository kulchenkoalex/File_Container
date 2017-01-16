//Добавление папки
//ст. 156 гр. Кульченко Алексей
//02.02.15
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContainer.Extensions
{
    public static class ZipArchiveExtension
    {
        public static ZipArchiveDirectory CreateDirectory(this ZipArchive archive, string directoryPath)
        {
            return new ZipArchiveDirectory(archive, directoryPath);
        }

        public static void AddDirectory(this ZipArchive archive, string sourceFolderPath, string destFolderPath = null)
        {
            destFolderPath = (destFolderPath ?? Path.GetFileName(sourceFolderPath)).Replace("\\", "/") + "/";

            var zipDirectory = archive.CreateDirectory(destFolderPath);//создает папку с именем пути

            string[] files = Directory.GetFiles(sourceFolderPath);//массив для хранения файлов в папке
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);//Возвращает имя файла и его расширение указанной строки пути

                var entry = zipDirectory.CreateEntry(fileName, CompressionLevel.NoCompression);//Создает пустую запись с указанным именем записи и без сжатия
                using (BinaryWriter writer = new BinaryWriter(entry.Open()))
                {
                    writer.Write(File.ReadAllBytes(file));//записываем файлы
                }
            }

            string[] folders = Directory.GetDirectories(sourceFolderPath);//массив для хранения папок
            foreach (string folder in folders)
            {
                string folderName = Path.GetFileName(folder);//возвращает имя папки

                archive.AddDirectory(folder, Path.Combine(destFolderPath, folderName));//добавляем папку в контейнер
            }
        }
    }
}
