using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.Models;


namespace BlazorDemoUI.Services
{
    public class Generate_SiteReport : IGenerate_SiteReport
    {
        private string[] arrReviewText = new string[10];
        private double[] arrUserRatings = new double[10];
        private string[] arrUserName = new string[10];
        private string[] arrUserEmail = new string[10];
        private double dRating;

        public Generate_SiteReport()
        {

        }

        public byte[] Completed_PDF()
        {
            return DataAccessLibrary.Utilities.CreatePDF(CompilePDF_Body());
        }

        public int[] Get_UserID(List<SiteReview> _review, double rating)
        {
            dRating = rating * 20;
            int iCount = 0;
            int[] arrUserID = new int[10];

            foreach (var review in _review)
            {
                arrUserID[iCount] = review.UserID;
                arrReviewText[iCount] = review.ReviewText;
                arrUserRatings[iCount] = review.Rating;
                iCount++;
            }

            return arrUserID;
        }

        public void Get_ReviewerDetails(List<Users> _user)
        {
            int iCount = 0;
            foreach (var user in _user)
            {
                arrUserName[iCount] = user.UserName;
                arrUserEmail[iCount] = user.UserEmail;
                iCount++;
            }
        }

        private string Get_RatingComment()
        {
            if (dRating <= 20.00)
            {
                return "Bad";
            }
            else if ((dRating < 20.00) && (dRating >= 40.00))
            {
                return "less bad";
            }
            else if ((dRating < 40.00) && (dRating >= 60.00))
            {
                return "ok";
            }
            else if ((dRating < 60.00) && (dRating >= 80.00))
            {
                return "more ok";
            }
            else
            {
                return "good";
            }
        }

        private string CompilePDF_Body()
        {
            string sPDF_body = "User rating " + Environment.NewLine + "============================================" + Environment.NewLine + Environment.NewLine + "Overall recommendation factor: " +
                                Get_RatingComment() + Environment.NewLine + Environment.NewLine + "User satifdaction rating : " + dRating.ToString("F2") + "%" + Environment.NewLine + Environment.NewLine
                                + "Summerized user recommendation: Yes" + Environment.NewLine + Environment.NewLine + "============================================" + Environment.NewLine +
                                Environment.NewLine + "Top 10 latest user reviews" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < 10; i++)
            {
                string sReviewDetails = (i + 1).ToString() + ": " + arrUserName[i].ToString() + " (" + arrUserEmail[i].ToString() + ") - Site rating:" + arrUserRatings[i].ToString() + Environment.NewLine
                    + Environment.NewLine + "     " + arrReviewText[i].ToString() + Environment.NewLine + Environment.NewLine;

                sPDF_body = sPDF_body + sReviewDetails;
            }

            return sPDF_body;
        }
    }
}
