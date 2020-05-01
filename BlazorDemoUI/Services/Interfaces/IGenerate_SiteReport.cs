using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace BlazorDemoUI.Services
{
    public interface IGenerate_SiteReport
    {
        byte[] Completed_PDF();
        void Get_ReviewerDetails(List<Users> _user);
        int[] Get_UserID(List<SiteReview> _review, double rating);
    }
}