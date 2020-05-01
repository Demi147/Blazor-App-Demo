using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISiteReviewData
    {
        Task<bool> Check_Reviews_UserID(int iUserID);
        Task<List<SiteReview>> Get_10LatestReveiws();
        Task<double> Get_AVG_UserReview();
        Task<List<SiteReview>> Get_SingleReview_UserID(int iUserID);
        Task InsertReview(SiteReview sitereview);
        Task RemoveReview(SiteReview sitereview);
        Task UpdateReview(SiteReview sitereview);
    }
}