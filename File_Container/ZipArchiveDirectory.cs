using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContainer
{
    public class ZipArchiveDirectory
    {
        private readonly string _directory;
        private ZipArchive _archive;

        internal ZipArchiveDirectory(ZipArchive archive, string directory)
        {
            _archive = archive;
            _directory = directory;
        }

        public ZipArchive Archive { get { return _archive; } }

        public ZipArchiveEntry CreateEntry(string entry)
        {
            return _archive.CreateEntry(_directory + entry);
        }

        public ZipArchiveEntry CreateEntry(string entry, CompressionLevel compressionLevel)
        {
            return _archive.CreateEntry(_directory + entry, compressionLevel);
        }
    }
}
