using BlazorInputFile;
using DataAccessLibrary.Models;
using System.Threading.Tasks;

namespace BlazorDemoUI.Services
{
    public interface IFileUpload
    {
        Task InsertImage(Books book);
        Task UploadAsync(IFileListEntry fileEntry);
        byte[] UploadAsync2(IFileListEntry fileEntry);
    }
}