using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISiteReviewData
    {
        Task<List<SiteReview>> Get_10LatestReveiws();
        Task<double> Get_AVG_UserReview();
    }
}