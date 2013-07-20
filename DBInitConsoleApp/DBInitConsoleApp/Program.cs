using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using MemberTracker.Data;
namespace DBInitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext context = new DataContext();
            context.Database.Initialize(true);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
