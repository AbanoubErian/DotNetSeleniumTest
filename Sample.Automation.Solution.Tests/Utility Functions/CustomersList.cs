using Parsing.Utilities.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Automation.Solution.Tests.Utility_Functions
{
    class CustomersList
    {
        private List<string> _username_list;
        private List<string> _Gender_list;
        private List<string> _date_of_Birth_list;
        private List<string> _Address_list;
        private List<string> _City_list;
        private List<string> _State_list;
        private List<string> _PIN_list;
        private List<string> _Mobile_list;
        private List<string> _Email_list;
        private List<string> _Password_list;

        public CustomersList(String SheetName,String testCaseName)
        {
            _username_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "Username");
            _Gender_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "Gender");
            _date_of_Birth_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "Date of Birth");
            _Address_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "Address");
            _City_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "City");
            _State_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "State");
            _PIN_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "PIN");
            _Mobile_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "Mobile");
            _Email_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "Email");
            _Password_list = ExcelDataParser.GetAllStringValuesOf(SheetName, testCaseName, "Password");
        }

        public int list_Size
        {
            get
            {
                return _username_list.Count;
            }

        }

        public List<string> userName_list
        {
            get
            {
                return _username_list;
            }

            set
            {
                _username_list = value;
            }

        }

        public List<string> gender_list
        {
            get
            {
                return _Gender_list;
            }

            set
            {
                _Gender_list = value;
            }
        }

        public List<string> dateOfBirth_list
        {
            get
            {
                return _date_of_Birth_list;
            }

            set
            {
                _date_of_Birth_list = value;
            }
        }

        public List<string> address_list
        {
            get
            {
                return _Address_list;
            }

            set
            {
                _Address_list = value;
            }
        }

        public List<string> city_list
        {
            get
            {
                return _City_list;
            }

            set
            {
                _City_list = value;
            }
        }

        public List<string> state_list
        {
            get
            {
                return _State_list;
            }

            set
            {
                _State_list = value;
            }
        }

        public List<string> pin_list
        {
            get
            {
                return _PIN_list;
            }

            set
            {
                _PIN_list = value;
            }
        }

        public List<string> mobile_list
        {
            get
            {
                return _Mobile_list;
            }

            set
            {
                _Mobile_list = value;
            }
        }

        public List<string> email_list
        {
            get
            {
                return _Email_list;
            }

            set
            {
                _Email_list = value;
            }
        }

        public List<string> password_list
        {
            get
            {
                return _Password_list;
            }

            set
            {
                _Password_list = value;
            }
        }
    }

    
}
