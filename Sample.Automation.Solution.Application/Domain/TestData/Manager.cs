using Parsing.Utilities.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Automation.Solution.Application.TestData
{
    public class Manager
    {
        private string _username;
        private string _Password;

        public Manager(String SheetName,String testCaseName)
        {
            _username = ExcelDataParser.GetValueOf(SheetName, testCaseName, "Username");
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
