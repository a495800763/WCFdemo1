using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;
using static System.Console;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Client";
            int intParam;
            do
            {
                WriteLine("Enter an integer and press enter to call the WCF service.");
            } while (!int.TryParse(ReadLine(), out intParam));
            Service1Client client = new Service1Client();
            WriteLine(client.GetData(intParam));
            WriteLine("Press an key to exit.");
            ReadKey();
        }
    }
}
