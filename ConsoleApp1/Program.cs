using BuissnessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsClient client = clsClient.findByID(1);
            if (client == null) 
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.Write(client.PersonID);
            }
            Console.ReadKey();
        }
    }
}
