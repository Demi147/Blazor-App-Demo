using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using DataAccessLibrary.Models;
using DataAccessLibrary;

namespace BlazorDemoUI.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;
        private string sPath;

        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Upload", fileEntry.Name);
            sPath = path;
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream copyStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(copyStream);
            }
        }

        public byte[] getImageBytes()
        {
            byte[] bImageData = null;
            FileStream imageStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader binReader = new BinaryReader(imageStream);
            bImageData = binReader.ReadBytes((int)imageStream.Length);

            imageStream.Dispose();
            binReader.Dispose();
            return bImageData;
        }

        public void deleteLocal()
        {
            try
            {
                File.Delete(sPath);
            }
            catch (Exception ex)
            {
                string sError = ex.ToString();
            }
        }
    }
}
