using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTiko
{
    public class ServiseRelasietion : IContract
    {
        public string gettikotime(string text)
        {

            Console.WriteLine("{1}  Tiko  sent  text {0}",text, DateTime.Now.ToString());
           return  DateTime.Now.ToString() + " " +text;
        }
    }
}
