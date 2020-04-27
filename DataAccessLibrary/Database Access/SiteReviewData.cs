using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Data;

namespace DataAccessLibrary
{
    public class SiteReviewData : ISiteReviewData
    {
        private readonly ISqlDataAccess _db;

        private string sError = "";

        public SiteReviewData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<double> Get_AVG_UserReview()
        {
            try
            {
                var dReviewAvg = Task.FromResult(_db.Get<double>($"Select AVG(Rating) From dbo.tblSiteReview", null, commandType: CommandType.Text));

                return dReviewAvg;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task<List<SiteReview>> Get_10LatestReveiws()
        {
            string sql = $"Select Top (10) ReviewText,UserID,Rating From dbo.tblSiteReview Order By ReviewID DESC";

            return _db.LoadData<SiteReview, dynamic>(sql, new { });
        }
    }
}
