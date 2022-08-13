using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Consult consult = new Consult();
            Manager man = new Manager();
            consult.ReadData();
            //foreach(var c in consult.clients)
            //{
            //    Console.WriteLine(c.Name + " "+c.PhoneNumber+" "+c.PassportData);
            //}
            while (!exit)
            {

                Console.WriteLine("Admin - [A] / Consult - [C] / Exite - [E]");
                
                string flag = Console.ReadLine();
                if (flag == "С".ToLower())
                {
                    consult.ViewClientData();
                }
                else
                {
                    Console.WriteLine("Check list - [1] / Edit List - [2]");
                    
                    if (Console.ReadLine() == "1")
                    {
                        man.ViewClientData();
                    }
                    else
                    {
                        man.ViewClientData();
                        Console.WriteLine("/-------------------/");
                        Console.WriteLine("Do you want to change data? \n[1]-Yes / [2]- No");
                        if(Console.ReadLine() == "1")
                        {
                            man.ChangeData();
                        }
                    }

                }
                if(flag == "E".ToLower()) exit = false;
                
            }
        }
    }
}
