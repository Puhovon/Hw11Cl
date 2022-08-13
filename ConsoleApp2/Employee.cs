using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        private string _name;
        private string _phoneNumber;
        private string _passportData;

        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string PassportData
        {
            get { return _passportData; }
            set { _passportData = value; }
        }
        public Employee(string name, string phoneNumber, string passporData)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            PassportData = passporData;
        }
        public string HeroInformation()
        {
            return String.Format("Name:{0,10} |  PhoneNumber:{1,4} |  PassporData:{2,6}",
              this.Name,
              this.PhoneNumber,
              this.PassportData
              );
        }
    }
}
