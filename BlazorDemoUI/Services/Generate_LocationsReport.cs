using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Services
{
    public class Generate_LocationsReport : IGenerate_LocationsReport
    {
        private string sPDF_body;
        public Generate_LocationsReport()
        {

        }

        public byte[] Completed_PDF()
        {
            return DataAccessLibrary.Utilities.CreatePDF(sPDF_body);
        }

        public void CompilePDF_Body(int[] arrTotalPosted, string[] arrProvince, int[] arrTotalInstitute, string[] arrInstutute)
        {
            sPDF_body = "Summary of total books posted according to province" + Environment.NewLine + "============================================" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < arrProvince.Length; i++)
            {
                string sProvinceInfo = arrProvince[i] + "   = " + arrTotalPosted[i].ToString() + Environment.NewLine + Environment.NewLine;

                sPDF_body = sPDF_body + sProvinceInfo;

            }
            sPDF_body = sPDF_body + Environment.NewLine + Environment.NewLine + "Total = " + arrTotalPosted.Sum() + Environment.NewLine + Environment.NewLine +
                        "Top 10 Institutes accordign to books posted" + Environment.NewLine + "============================================" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < arrInstutute.Length; i++)
            {
                string sInfo = arrInstutute[i] + " = " + arrTotalInstitute[i].ToString() + Environment.NewLine + Environment.NewLine;

                sPDF_body = sPDF_body + sInfo;
            }
        }
    }
}
