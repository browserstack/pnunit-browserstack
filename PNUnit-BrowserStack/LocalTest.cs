using NUnit.Framework;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace BrowserStack
{
  public class LocalTest : BrowserStackPNUnitTest
  {
    [Test]
    public void HealthCheck()
    {
      driver.Navigate().GoToUrl("http://bs-local.com:45691/check");
      Assert.IsTrue(Regex.IsMatch(driver.PageSource, "Up and running", RegexOptions.IgnoreCase));
    }
  }
}
