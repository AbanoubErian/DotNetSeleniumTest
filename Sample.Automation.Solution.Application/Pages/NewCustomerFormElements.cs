/// <summary>
/// This is Auto Generated Class By Template file AutoGeneratePagesElementsClasses.tt
/// Please Don't Edit this Class if you need to add new Elements, add them in related JSON File then from Build Menu -> click Transform All T4 Templates
/// </summary>
using OpenQA.Selenium;
using Web.Automation.Web.Component;


namespace Sample.Automation.Solution.Application.Pages
{
public class NewCustomerFormElements {
      private readonly IWebDriver _driver;
	 
	 	  
      private readonly string _jsonFilePath = AppConfigs.ObjectRepository + @"NewCustomerForm.json";
      protected readonly AutomatedElement _userName;
     protected readonly AutomatedElement _maleGender;
     protected readonly AutomatedElement _femaleGender;
     protected readonly AutomatedElement _dateOfBirth;
     protected readonly AutomatedElement _Address;
     protected readonly AutomatedElement _City;
     protected readonly AutomatedElement _State;
     protected readonly AutomatedElement _pin;
     protected readonly AutomatedElement _MobileNb;
     protected readonly AutomatedElement _Email;
     protected readonly AutomatedElement _Password;
     protected readonly AutomatedElement _submit;
  
 public NewCustomerFormElements (IWebDriver driver)
        {
            _driver = driver;
              ElementParser.Initialize_Page_Elements(this, _driver, _jsonFilePath);
        }
}

}
