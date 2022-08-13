using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Manager : Consult, IClientDataMonitor
    {
        Consult cons = new Consult();

        public new void ChangeData()
        {
            
            Console.WriteLine("Id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var empl in cons.clients)
            {
                if(clients[id] != null)
                {
                    Console.WriteLine("Change PhoneNumber: \t");
                    string newPhoneNumber = Console.ReadLine();
                    if(newPhoneNumber != null)
                    {
                        Employee temp = new Employee(empl.Name, newPhoneNumber, empl.PassportData);
                        clients[id] = temp;
                        SaveNewData();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("you don't written PhoneNumber");
                    }
                }
            }
        }

        private void SaveNewData(string path = "db.txt")
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                foreach (Employee emp in cons.clients)
                {
                    sw.WriteLine(emp.Name + " " + emp.PhoneNumber + " "+emp.PassportData);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Well done!");
            }
            
        }

        public new void ViewClientData()
        {
            
            int id = 1;

            foreach (var emp in cons.clients)
            {
                Console.WriteLine(id + " " + emp.Name + " " + emp.PhoneNumber + " " + emp.PassportData);
                id++;
            }
        }
    }
}
