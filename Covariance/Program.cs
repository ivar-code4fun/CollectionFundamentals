using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!!";
            object obj = str;

            //List<string> doe snot display covariance
            //var strList = new List<string> { "Monday", "Tuesday" };
            //List<object> objList = strList;

            //demo array covariance - really bad !!
            var strList = new string[] { "Monday", "Tuesday" };
            object[] objList = strList;
            objList[0] = 5;
        }
    }
}
