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
    public class AddNewCustomer
    {
        private string _jsonPagePath = AppConfigs.ObjectRepository + @"NewCustomerForm.json";
        private readonly Web.Automation.Web.Component.AutomatedElement username, maleGender, femaleGender, dateOfBirth, address, city, state, pin, mobNb, email, password, submitBTN;
        readonly IWebDriver _driver;
        public AddNewCustomer(IWebDriver driver)
        {
            _driver = driver;
            var pageElement = ElementParser.Initialize_Page_Elements(_driver, _jsonPagePath);
            username = pageElement["userName"];
            maleGender = pageElement["maleGender"];
            femaleGender = pageElement["femaleGender"];
            dateOfBirth = pageElement["dateOfBirth"];
            address = pageElement["Address"];
            city = pageElement["City"];
            state = pageElement["State"];
            pin = pageElement["pin"];
            mobNb = pageElement["MobileNb"];
            email = pageElement["Email"];
            password = pageElement["Password"];
            submitBTN = pageElement["submit"];
        }

        public void fillFormWithValidData(string nameValue, char genderValue, string dateOfBirthValue, string addressValue, string cityValue, string stateValue,
            string pinValue, string mobNbValue, string emailValue, string passwordValue)
        {
            Web.Automation.Web.Action.AutomatedActions.TextActions.EnterTextInField(_driver, username, nameValue);

            switch (genderValue)
            {
                case 'm':
                    AutomatedActions.ClickActions.ClickOnElement(_driver, maleGender);
                    break;
                case 'f':
                    AutomatedActions.ClickActions.ClickOnElement(_driver, femaleGender);
                    break;
                default:
                    break;
            }

            //Split the DateText
            String[] dateItems = dateOfBirthValue.Split('/');

            AutomatedActions.TextActions.EnterTextInField(_driver, dateOfBirth, dateOfBirthValue,false);
            AutomatedActions.TextActions.EnterTextInField(_driver, address, addressValue);
            AutomatedActions.TextActions.EnterTextInField(_driver, city, cityValue);
            AutomatedActions.TextActions.EnterTextInField(_driver, state, stateValue);
            AutomatedActions.TextActions.EnterTextInField(_driver, pin, pinValue);
            AutomatedActions.TextActions.EnterTextInField(_driver, mobNb, mobNbValue);
            AutomatedActions.TextActions.EnterTextInField(_driver, email, emailValue);
            AutomatedActions.TextActions.EnterTextInField(_driver, password, passwordValue);
            AutomatedActions.ClickActions.ClickOnElement(_driver, submitBTN);
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
