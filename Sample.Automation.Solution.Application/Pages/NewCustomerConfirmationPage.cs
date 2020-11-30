using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Automation.Web.Action;
using Web.Automation.Web.Component;

namespace Sample.Automation.Solution.Application.Pages
{
    public class NewCustomerConfirmationPage
    {
        private readonly string _jsonPagePath = AppConfigs.ObjectRepository + @"NewUserConfirmation.json";
        private readonly AutomatedElement registrationConfirmationMessage;
        readonly IWebDriver _driver;

        public NewCustomerConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
            var pageElement = ElementParser.Initialize_Page_Elements(_driver, _jsonPagePath);
            registrationConfirmationMessage = pageElement["ConfirmationMessage"];
        }

        public string getConfirmationMessage()
        {
            try
            {
                return AutomatedActions.TextActions.GetTextOfElement(_driver, registrationConfirmationMessage);
            }
            catch (Exception e)
            {
                return "Confirmation element not found with the following excepetion";
            }
        }
    }
}
