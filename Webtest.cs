using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System.Threading;
using System;
using TestProject.SDK;
using TestProject.SDK.Tests.Helpers;
using TestProject.SDK.Tests;
using TestProject.Common.Attributes;
using TestProject.Common.Enums;

namespace TestProject.Generated.Tests.MyFirstProject
{
	/// <summary>
	/// This class was automatically generated by TestProject
	/// Project: My first Project
	/// Test: webTest
	/// Generated by: Jd Manuel (ijdm43@gmail.com)
	/// Generated on: 12/20/2021 11:48:27
	/// </summary>
	public class Webtest : IWebTest
	{
		[ParameterAttribute(Description = "Auto generated application URL parameter", DefaultValue = "https://example.testproject.io/web/", Direction = ParameterDirection.Input)]
		public string ApplicationURL;
		public ExecutionResult Execute(WebTestHelper helper)
		{
			var driver = helper.Driver;
			var report = helper.Reporter;
			bool boolResult;
			By by;
			
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 15000;
			
			 // 1. Navigate to '{{ApplicationURL}}'
			// Navigates the specified URL (Auto-generated)
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().NavigateToURL(ApplicationURL);
			report.Step(string.Format("Navigate to '{0}'", ApplicationURL), boolResult, TakeScreenshotConditionType.Failure);
			
			 // 2. Click 'Enter your full name'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#name");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Enter your full name'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 3. Type '{Name}' in 'Enter your full name'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#name");
			boolResult = driver.TestProject().TypeText(by, "{Name}");
			report.Step("Type '{Name}' in 'Enter your full name'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 4. Click 'Enter your password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Enter your password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 5. Type '12345' in 'Enter your password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TestProject().TypeText(by, "12345");
			report.Step("Type '12345' in 'Enter your password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 6. Click 'Login1'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#login");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Login1'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 7. Click 'country'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#country");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'country'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 8. Select the 'AU' option in 'country'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#country");
			boolResult = driver.TestProject().SelectAnOptionByValue(by, "AU");
			report.Step("Select the 'AU' option in 'country'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 9. Click 'country'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#country");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'country'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 10. Click 'Enter your address'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#address");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Enter your address'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 11. Type 'Linkpark drive' in 'Enter your address'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#address");
			boolResult = driver.TestProject().TypeText(by, "Linkpark drive");
			report.Step("Type 'Linkpark drive' in 'Enter your address'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 12. Click 'Enter your email'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#email");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Enter your email'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 13. Scroll window by ('0','156')
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().ScrollWindow(0, 156);
			report.Step("Scroll window by ('0','156')", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 14. Scroll window by ('0','76')
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().ScrollWindow(0, 76);
			report.Step("Scroll window by ('0','76')", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 15. Type 'labalaba@email.com' in 'Enter your email'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#email");
			boolResult = driver.TestProject().TypeText(by, "labalaba@email.com");
			report.Step("Type 'labalaba@email.com' in 'Enter your email'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 16. Click 'Enter your phone number'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#phone");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Enter your phone number'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 17. Type '95648212' in 'Enter your phone number'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#phone");
			boolResult = driver.TestProject().TypeText(by, "95648212");
			report.Step("Type '95648212' in 'Enter your phone number'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 18. Click 'Save1'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#save");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Save1'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 19. Click 'Logout1'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#logout");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Logout1'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 20. Scroll window by ('0','158')
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().ScrollWindow(0, 158);
			report.Step("Scroll window by ('0','158')", boolResult, TakeScreenshotConditionType.Failure);
			
			return ExecutionResult.Passed;
		}
	}
}