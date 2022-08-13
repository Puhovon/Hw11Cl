using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Consult : IClientDataMonitor
    {

        public ObservableCollection<Employee> clients
        {
            get; set;
        }
        public Consult()
        {
            this.clients = new ObservableCollection<Employee>(); 
            ReadData();
        }
       

        /// <summary>
        /// Read data into file
        /// </summary>
        public void ReadData(string path = "db.txt")
        {
            string AllData = "";

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    AllData += sr.ReadLine();
                    string[] Split = AllData.Split(' ');
                    if (Split.Length == 3)
                    {
                        Employee emp = new Employee(Split[0], Split[1], Split[2]);
                        clients.Add(emp);

                        Array.Clear(Split, 0, Split.Length);
                        AllData = "";

                    }
                }
            }
        }
        public void ViewClientData()
        {
            int id = 1;

            foreach (Employee emp in clients)
            {
                Console.WriteLine(id + " " + emp.Name + " " + emp.PhoneNumber + " " + "***");
                id++;
            }
        }

        public void ChangeData()
        {
            
        }
    }
}