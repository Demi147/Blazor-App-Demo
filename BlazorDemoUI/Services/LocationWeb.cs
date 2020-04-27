using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace BlazorDemoUI.Services
{
    public class LocationWeb : ILocationWeb
    {
        public LocationWeb()
        {

        }

        public double[] Get_lat_Long(string Country, string Province, string City, string Street)
        {
            double[] arrLocals = new double[2];
            string sUrl = "http://dev.virtualearth.net/REST/v1/Locations/" + Country + "/" + Province + "/" + City + "/" + Street +
                          "/1%20Mircosoft%20Way?o=xml&key=%20AqDcSaScIrV4hlXytWo9qijSha2Ga2yRWVJ-Ajwv1h9ysY_kLvk7GJzMmJDkoTPm";
            WebRequest request = HttpWebRequest.Create(sUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

            int itest = json.IndexOf("<Latitude>");
            int itest2 = json.IndexOf("<Longitude>");

            string stest = json.Substring((itest + 10), 10);
            string stest2 = json.Substring((itest2 + 11), 10);

            double dtest = Check_Valid(stest);
            arrLocals[0] = dtest;

            dtest = Check_Valid(stest2);
            arrLocals[1] = dtest;
            return arrLocals;
        }

        public double Check_Valid(string Value)//Checks that long and lat are valid double values
        {
            string sValidValue = "";
            for (int i = 0; i < Value.Length; i++)
            {
                if (char.IsDigit(Value[i]) == true || Value[i] == '.' || Value[i] == '-')
                {
                    sValidValue = sValidValue + Value[i].ToString();
                }
            }
            return double.Parse(sValidValue);
        }
    }
}
