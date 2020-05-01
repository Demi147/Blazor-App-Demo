namespace BlazorDemoUI.Services
{
    public interface IGenerate_LocationsReport
    {
        void CompilePDF_Body(int[] arrTotalPosted, string[] arrProvince, int[] arrTotalInstitute, string[] arrInstutute);
        byte[] Completed_PDF();
    }
}