using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapInvoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> hello");

            ServiceReference1.Person personDetails = new ServiceReference1.Person();
            personDetails.Name = "Rishab";
            personDetails.Age = 30;
            ServiceReference1.WebServiceCalculatorSoapClient scr = new ServiceReference1.WebServiceCalculatorSoapClient();
            string str = scr.SavePersonDetails(personDetails);
            Console.WriteLine(">>> result " + str);
            Console.ReadKey();
        }
    }
}
