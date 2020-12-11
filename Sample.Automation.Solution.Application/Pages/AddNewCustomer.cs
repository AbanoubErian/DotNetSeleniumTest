using OpenQA.Selenium;
using Sample.Automation.Solution.Application.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Automation.Web.Action;
using Web.Automation.Web.Component;

namespace Sample.Automation.Solution.Application.Pages
{
    public class AddNewCustomer : NewCustomerFormElements
    {
        readonly IWebDriver _driver;
        public AddNewCustomer(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void fillFormWithValidData(Customer customer)
        {
            Random random = new Random();
            int Rand = random.Next(0, 10000);

            AutomatedActions.TextActions.EnterTextInField(_driver, _userName, customer.userName);
            switch (customer.gender)
            {
                case 'm':
                    AutomatedActions.ClickActions.ClickOnElement(_driver, _maleGender);
                    break;
                case 'f':
                    AutomatedActions.ClickActions.ClickOnElement(_driver, _femaleGender);
                    break;
                default:
                    break;
            }

            AutomatedActions.TextActions.EnterTextInField(_driver, _dateOfBirth, customer.dateOfBirth,false);
            AutomatedActions.TextActions.EnterTextInField(_driver, _Address, customer.address);
            AutomatedActions.TextActions.EnterTextInField(_driver, _City, customer.city);
            AutomatedActions.TextActions.EnterTextInField(_driver, _State, customer.state);
            AutomatedActions.TextActions.EnterTextInField(_driver, _pin, customer.pin);
            AutomatedActions.TextActions.EnterTextInField(_driver, _MobileNb, customer.mobile);
            AutomatedActions.TextActions.EnterTextInField(_driver, _Email, Rand + customer.email);
            AutomatedActions.TextActions.EnterTextInField(_driver, _Password, customer.password);
            AutomatedActions.ClickActions.ClickOnElement(_driver, _submit);
        }

        public bool AssertCustomerAddition(AutomatedBrowser Browser)
        {
            try
            {
                if (Browser.WebDriverInstance.Url.Contains("CustomerRegMsg.php"))
                    return true;

                else
                    return false;
            }
            catch (UnhandledAlertException alertException)
            {
                AutomatedActions.AuthenticationActions.AcceptAlert(Browser.WebDriverInstance);
                return false;
            }
        }
    }
}
