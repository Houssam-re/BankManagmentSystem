using BuissnessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (clsClient.Deposit(1, 1055))
            {
                clsClient client = clsClient.findByID(1);
                Console.WriteLine(client.AccountBalance);
            }
            else
            {
                Console.WriteLine("False");
                clsClient client = clsClient.findByID(1);
                Console.WriteLine(client.AccountBalance);
            }
        }
    }
}
