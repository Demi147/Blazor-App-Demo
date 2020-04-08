using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using Dapper;
using System.Data;
using DataAccessLibrary.Models;
using DataAccessLibrary;

namespace BlazorDemoUI.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;
        private string sPath;
        private readonly ISqlDataAccess _db;
        private byte[] bImage2 = null;

        public FileUpload(IWebHostEnvironment environment, ISqlDataAccess db)
        {
            _environment = environment;
            _db = db;
            string stest = _db.ToString();
        }
        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Upload", fileEntry.Name);
            sPath = path;
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }

        public byte[] UploadAsync2(IFileListEntry fileEntry)
        {
            bImage2 = null;
            FileStream imageStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader binReader = new BinaryReader(imageStream);
            bImage2 = binReader.ReadBytes((int)imageStream.Length);

            return bImage2;
        }

        public Task InsertImage(Books book)
        {
            try
            {
                string sql = @"Insert into dbo.tblBookSales(SalesNumber,UserID,BookTitle,BookEdition,BookPrice,LocationID,ModuleCode,BookInstitute,DatePosted,BookImage)
                           values(@SalesNumber,@UserID,BookTitle,@BookEdition,@BookPrice,@LocationID,@ModuleCode,@BookInstitute,@DatePosted,@BookImage)";

                return _db.SaveData(sql, book);

            }
            catch (Exception ex)
            {
                string stest = ex.ToString();
                return null;
            }
        }
    }
}
