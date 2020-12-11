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
    public class NewCustomerConfirmationPage : NewUserConfirmationElements
    {
        readonly IWebDriver _driver;

        public NewCustomerConfirmationPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public string getConfirmationMessage()
        {
            try
            {
                return AutomatedActions.TextActions.GetTextOfElement(_driver, _ConfirmationMessage);
            }
            catch (Exception e)
            {
                return "Confirmation element not found with the following excepetion";
            }
        }
    }
}
