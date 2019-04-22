using System;
using System.Collections.Generic;
using System.Web.Services;

namespace MyFirstServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public float ConvertDegrees(float degrees,char option)
        {
                switch (option)
                {
                    case 'F':
                        degrees = (degrees * 1.8F) + 32;
                        break;
                    case 'C':
                        degrees = (degrees - 32) * (0.555F);
                        break;
                    default:
                        break;
                }
            return degrees;
        }
        [WebMethod]
        public String CurrentDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        [WebMethod]
        public List<int> ReturnList()
        {
            var list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Add(11);
            return list;
        }
        [WebMethod]
        public float ConvertMoney(float sum, char option)
        {
            switch (option)
            {
                case 'R':
                    sum = (sum * 4.76F);
                    break;
                case 'E':
                    sum = (sum * 0.21F);
                    break;
                default:
                    break;
            }
            return sum;
        }
    }
}