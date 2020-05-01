using BlazorInputFile;
using System.Threading.Tasks;

namespace BlazorDemoUI.Services
{
    public interface IFileUpload
    {
        void deleteLocal();
        byte[] getImageBytes();
        Task UploadAsync(IFileListEntry fileEntry);
    }
}