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
    public class SideMenuPage : SideMenuElements
    {
        readonly IWebDriver _driver;

        public SideMenuPage(IWebDriver driver) : base (driver)
        {
            _driver = driver;
        }

        public void clickNewCustomer()
        {
            AutomatedActions.ClickActions.ClickOnElement(_driver, _NewCustomer);
        }
    }
}
