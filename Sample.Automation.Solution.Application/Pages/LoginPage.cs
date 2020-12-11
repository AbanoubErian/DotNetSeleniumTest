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
    public class LoginPage : LoginElements
    {

        readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver) : base (driver)
        {
            _driver = driver;
        }

        public void Login(Manager manger)
        {
            AutomatedActions.TextActions.EnterTextInField(_driver, _username, manger.userName);
            AutomatedActions.TextActions.EnterTextInField(_driver, _password, manger.password);
            AutomatedActions.ClickActions.ClickOnElement(_driver, _login);
        }

        public bool AssertManagerLogin(AutomatedBrowser Browser)
        {
            try
            {
                if (Browser.WebDriverInstance.Url.Contains("Managerhomepage.php"))
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
