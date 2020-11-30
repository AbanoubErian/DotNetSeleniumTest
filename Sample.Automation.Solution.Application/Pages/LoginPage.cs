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
    public class LoginPage
    {
        private readonly string _jsonPagePath = AppConfigs.ObjectRepository + @"Login.json";
        private AutomatedElement userNameField, passwordField, loginBTN;
        readonly IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            var _pageElement = ElementParser.Initialize_Page_Elements(_driver, _jsonPagePath);
            userNameField = _pageElement["username"];
            passwordField = _pageElement["password"];
            loginBTN = _pageElement["login"];
        }


        public void Login(string username, string password)
        {
            AutomatedActions.TextActions.EnterTextInField(_driver, userNameField, username);
            AutomatedActions.TextActions.EnterTextInField(_driver, passwordField, password);
            AutomatedActions.ClickActions.ClickOnElement(_driver, loginBTN);
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
