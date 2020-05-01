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

        //###############################################################################################################################################################################################
        #region Get Methods for Site Review Data Model

        public Task<List<SiteReview>> Get_SingleReview_UserID(int iUserID)
        {
            try
            {
                string sql = "Select * from dbo.tblSiteReview Where UserID = " + iUserID + "";

                return _db.LoadData<SiteReview, dynamic>(sql, new { });
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
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
        #endregion

        //###############################################################################################################################################################################################
        #region CRUD Methods for Site Review Data Model
        public Task InsertReview(SiteReview sitereview)
        {
            try
            {
                string sql = @"Insert into dbo.tblSiteReview(UserID,Rating,ReviewText,ReviewDate)
                             values(@UserID,@Rating,@ReviewText,@ReviewDate)";

                return _db.SaveData(sql, sitereview);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task RemoveReview(SiteReview sitereview)
        {
            try
            {
                string sql = @"Delete from dbo.tblSiteReview Where ReviewID =" + sitereview.ReviewID + "";
                return _db.SaveData(sql, sitereview);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public Task UpdateReview(SiteReview sitereview)
        {
            try
            {
                string sql = @"Update dbo.tblSiteReview Set Rating = " + sitereview.Rating + ",ReviewText = '" + sitereview.ReviewText + "',ReviewDate = " + sitereview.ReviewDate +
                             "Where ReviewID = " + sitereview.ReviewID + "";

                return _db.SaveData(sql, sitereview);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }
        #endregion

        //###############################################################################################################################################################################################
        #region Other Methods for Site Review Data Model

        public Task<bool> Check_Reviews_UserID(int iUserID)
        {
            try
            {
                var TotalReviews = Task.FromResult(_db.Get<int>("Select count(*) from dbo.tblSiteReview Where UserID = " + iUserID + "", null, commandType: CommandType.Text));

                var bFirstReview = false;

                int iTotal = TotalReviews.Result;
                if (iTotal >= 1)
                {
                    bFirstReview = false;
                }
                else
                {
                    bFirstReview = true;
                }

                return Task.FromResult(bFirstReview);
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return Task.FromResult(false);
            }
        }

        #endregion
    }
}

