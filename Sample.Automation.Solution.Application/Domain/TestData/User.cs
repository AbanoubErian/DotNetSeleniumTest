using Parsing.Utilities.Parsers;

namespace Sample.Automation.Solution.Application.Domain.Models.TestData
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string message { get; set; }

        //Method for reading data from Excel into user object Properties
        public void FillData(string sheetToGetDataFrom, string getDataFromRow)
        {
            username = ExcelDataParser.GetValueOf(sheetToGetDataFrom, getDataFromRow, "Username");
            password = ExcelDataParser.GetValueOf(sheetToGetDataFrom, getDataFromRow, "Password");
            message = ExcelDataParser.GetValueOf(sheetToGetDataFrom, getDataFromRow, "Message");
        }
    }
}


