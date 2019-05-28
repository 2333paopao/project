using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface IFileProxy
    {
        void Save(string name, byte[] fileBytes);
        MemoryStream Read(string name);
    }

    public class LocalStorageFileProxy : IFileProxy
    {
        private readonly string _folder;

        public LocalStorageFileProxy()
        {
            _folder = ConfigurationManager.AppSettings["UploadPath"];
            if (!Directory.Exists(_folder))
            {
                Directory.CreateDirectory(_folder);
            }
        }
        public void Save(string name, byte[] formFile)
        {
            var uploadPath = _folder + "/" + name;
            File.WriteAllBytes(uploadPath, formFile);
        }

        public MemoryStream Read(string name)
        {
            var downloadPath = _folder + "/" + name;
            var result = new MemoryStream();
            using (var stream = new FileStream(downloadPath, FileMode.Open, FileAccess.Read))
            {

                stream.CopyTo(result);
            }

            result.Position = 0;
            return result;
        }
    }
}
