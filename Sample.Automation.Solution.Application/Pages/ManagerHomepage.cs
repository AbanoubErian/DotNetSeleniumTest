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
    public class ManagerHomepage : Manager_homepageElements
    {
        readonly IWebDriver _driver;

        public ManagerHomepage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public string getLoggedinUsername()
        {
            return AutomatedActions.TextActions.GetTextOfElement(_driver, _loggedUsername);
        }
    }
}
