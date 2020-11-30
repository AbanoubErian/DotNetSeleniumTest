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
    public class SideMenuPage
    {
        //private readonly string _jsonPagePath = "D:\\Training & Tutorials\\Automation Testing\\.Net Automation Matrials\\Sample.Automation.Solution\\Sample.Automation.Solution\\Sample.Automation.Solution.Application\\Domain\\ObjectRepository\\SideMenu.json";
        private readonly string _jsonPagePath = AppConfigs.ObjectRepository + @"SideMenu.json";
        private readonly AutomatedElement newCustomermenuItem;
        readonly IWebDriver _driver;

        public SideMenuPage(IWebDriver driver)
        {
            _driver = driver;
            var pageElement = ElementParser.Initialize_Page_Elements(_driver, _jsonPagePath);
            newCustomermenuItem = pageElement["NewCustomer"];
        }

        public void clickNewCustomer()
        {
            AutomatedActions.ClickActions.ClickOnElement(_driver, newCustomermenuItem);
        }
    }
}
