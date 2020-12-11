using Parsing.Utilities.Parsers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Automation.Solution.Application.TestData
{
    public class Customer
    {
        private string _username;
        private char _Gender;
        private string _date_of_Birth;
        private string _Address;
        private string _City;
        private string _State;
        private string _PIN;
        private string _Mobile;
        private string _Email;
        private string _Password;

        public Customer(String SheetName, String testCaseName)
        {
            _username = ExcelDataParser.GetValueOf(SheetName, testCaseName, "Username");
            _date_of_Birth = ExcelDataParser.GetValueOf(SheetName, testCaseName, "Date of Birth");
            _Gender = Char.Parse(ExcelDataParser.GetValueOf(SheetName, testCaseName, "Gender"));
            _Address = ExcelDataParser.GetValueOf(SheetName, testCaseName, "Address");
            _City = ExcelDataParser.GetValueOf(SheetName, testCaseName, "City");
            _State = ExcelDataParser.GetValueOf(SheetName, testCaseName, "State");
            _PIN = ExcelDataParser.GetValueOf(SheetName, testCaseName, "PIN");
            _Mobile = ExcelDataParser.GetValueOf(SheetName, testCaseName, "Mobile");
            _Email = ExcelDataParser.GetValueOf(SheetName, testCaseName, "Email");      
            _Password = ExcelDataParser.GetValueOf(SheetName, testCaseName, "Password");
        }

        public string userName
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }

        }

        public char gender
        {
            get
            {
                return _Gender;
            }

            set
            {
                _Gender = value;
            }
        }

        public string dateOfBirth
        {
            get
            {
                return _date_of_Birth;
            }

            set
            {
                _date_of_Birth = value;
            }
        }

        public string address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        public string city
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }

        public string state
        {
            get
            {
                return _State;
            }

            set
            {
                _State = value;
            }
        }

        public string pin
        {
            get
            {
                return _PIN;
            }

            set
            {
                _PIN = value;
            }
        }

        public string mobile
        {
            get
            {
                return _Mobile;
            }

            set
            {
                _Mobile = value;
            }
        }

        public string email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }
    }
}
