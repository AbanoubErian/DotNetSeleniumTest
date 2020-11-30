using Logging.Utilities.Logging;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sample.Automation.Solution.Application.Pages;
using Sample.Automation.Solution.Tests.Utility_Functions;
using System.IO;
using AventStack.ExtentReports;
using System.Reflection;

namespace Sample.Automation.Solution.Tests.Scripts.UserTCs
{
    class NewUserTestSuite : TestMain
    {
        LoginPage loginPage;
        ManagerHomepage managerHomepage;
        SideMenuPage sideMenu;
        AddNewCustomer newCustomerPage;
        NewCustomerConfirmationPage newCustomerConfirmationPage;
        Customer customer;
        Manager manager;


        [SetUp]
        public void loginSetup()
        {
            AutomatedLogger.Log("Setting up test suite pages");
            loginPage = new LoginPage(ActiveBrowser.WebDriverInstance);
            managerHomepage = new ManagerHomepage(ActiveBrowser.WebDriverInstance);
            sideMenu = new SideMenuPage(ActiveBrowser.WebDriverInstance);
            newCustomerPage = new AddNewCustomer(ActiveBrowser.WebDriverInstance);
            newCustomerConfirmationPage = new NewCustomerConfirmationPage(ActiveBrowser.WebDriverInstance);
            AutomatedLogger.Log("Test suite setup is done");
        }



        [TestCase("CreateNewUser1", "Customer Data", TestName = "Success Test Case")]
        [TestCase("CreateNewUser2", "Customer Data", TestName = "Failure Test Case")]
        public void CreateNewUser(String testCaseName,String sheetName)
        {
            AutomatedLogger.Log("Manager is logging");

            String reportingPathDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Artifacts\\Reports\\";

            manager = new Manager("Manager Data", "ManagerLogin");
            loginPage.Login(manager.userName, manager.password);
            bool mgrLoginFlag = loginPage.AssertManagerLogin(ActiveBrowser);

            //Asserting Manager login
            if (mgrLoginFlag)
            {
                AutomationReport.AssertAndReportStatus(mgrLoginFlag,"Loggin Status", "Manager logged in successfully", "Manager Failed to login");
                AutomatedLogger.Log("Manager logged in successfully");
            }

            else
            {
                AutomationReport.Log("The Manager is not able to logging correctly", Status.Fail);
                AutomationReport.TakeScreenshot(ActiveBrowser.WebDriverInstance, reportingPathDir, testCaseName, "Failure Screenshot");
                AutomatedLogger.Log("Manager Failed to login");
                return;
            }


            //Clicking on Create new user from the side menu
            sideMenu.clickNewCustomer();

            Random random = new Random();
            int Rand = random.Next(0, 10000);

            AutomatedLogger.Log("Inserting form fields data");
            customer = new Customer(sheetName, testCaseName);
            newCustomerPage.fillFormWithValidData(customer.userName, customer.gender, customer.dateOfBirth, customer.address, customer.city, customer.state
                , customer.pin, customer.mobile, Rand + customer.email, customer.password);

            //Customer Submission Assertion
            bool isCustomerAdded = newCustomerPage.AssertCustomerAddition(ActiveBrowser);

            if (isCustomerAdded)
            {
                string csAssertionMessage = newCustomerConfirmationPage.getConfirmationMessage();
                AutomationReport.AssertAndReportStatus(csAssertionMessage.Contains("Customer Registered Successfully!!!"), "Logging customed addition status"
                    , "Customer added successfully", "Customer addition failed");

                AutomatedLogger.Log("Customer Added Successfully");

            }
            else
            {
                AutomationReport.Log("Customer is not Added Correctly", Status.Fail);
                AutomationReport.TakeScreenshot(ActiveBrowser.WebDriverInstance, reportingPathDir, testCaseName, "Failure Screenshot");
                AutomatedLogger.Log("Customer Addition failed");

            }

            AutomatedLogger.Log("Test case execution is finished");
        }
    }
}
