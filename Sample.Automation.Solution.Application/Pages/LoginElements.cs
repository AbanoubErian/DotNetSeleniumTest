

/// <summary>
/// This is Auto Generated Class By Template file AutoGeneratePagesElementsClasses.tt
/// Please Don't Edit this Class if you need to add new Elements, add them in related JSON File then from Build Menu -> click Transform All T4 Templates
/// </summary>
using OpenQA.Selenium;
using Web.Automation.Web.Component;


namespace Sample.Automation.Solution.Application.Pages
{
public class LoginElements {
      private readonly IWebDriver _driver;
	 
	 	  
      private readonly string _jsonFilePath = AppConfigs.ObjectRepository + @"Login.json";
      protected readonly AutomatedElement _username;
     protected readonly AutomatedElement _password;
     protected readonly AutomatedElement _login;
  
 public LoginElements (IWebDriver driver)
        {
            _driver = driver;
              ElementParser.Initialize_Page_Elements(this, _driver, _jsonFilePath);
        }
}

}
