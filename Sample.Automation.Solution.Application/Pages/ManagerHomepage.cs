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
    public class ManagerHomepage
    {
        private readonly string _jsonPagePath = AppConfigs.ObjectRepository + @"Manager_homepage.json";
        private readonly AutomatedElement loggedUsernamelabel;
        readonly IWebDriver _driver;
        public ManagerHomepage(IWebDriver driver)
        {
            _driver = driver;
            var pageElement = ElementParser.Initialize_Page_Elements(_driver, _jsonPagePath);
            loggedUsernamelabel = pageElement["loggedUsername"];
        }

        public string getLoggedinUsername()
        {
            return AutomatedActions.TextActions.GetTextOfElement(_driver, loggedUsernamelabel);
        }
    }
}
