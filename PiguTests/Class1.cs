using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PiguTests;

public class Class1
{
    [Category("Functioanl")]
    [Test]
    public void Test1()
    {
        var list = new List<Human>
        {
            new Human() { Name = "Name1"}
        };
        var r = list.FirstOrDefault(x => x.Name == "Name");
        //Console.WriteLine(r!.Name);

        var driver = new ChromeDriver();
        driver.Url = "https://onliner.by";
        //var waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        //waiter.IgnoreExceptionTypes(typeof(CustomException));
        //waiter.Until(_ =>
        //{
        //    var input = driver.FindElement(By.Id("searchInput"));
        //    input.SendKeys("iphone");
        //    input.SendKeys(Keys.Enter);
        //    //CheckWithException();

        //    return true;
        //});
        //var res = driver.FindElement(By.XPath("//*[@class='c-search-summary ']/span[1]"));
        //var resText = res.Text;
        //StringAssert.AreEqualIgnoringCase("Искали: iphone", resText);
        //var items = driver.FindElements(By.XPath("//*[contains(@class, 'product-list-item')]"));
        //Assert.AreEqual(60, items.Count);

        //var logo = driver.FindElement(By.XPath("//*[@class='c-header-logo-group']"));
        //logo.Click();

        //var isResultNotPresent = waiter.Until(_ =>
        //    driver.FindElements(By.XPath("/*[@class='c-search-summary']")).Count == 0);
        //Assert.That(isResultNotPresent);

        driver.Quit();
    }

    [Smoke]
    [Test]
    public void Test2()
    {
        Console.WriteLine("Always passed");
        Assert.That(true);
    }

    private void CheckWithException()
    {
        throw new CustomException();
    }

    public class CustomException : Exception
    {
    }

    public class Human
    {
        public string Name { get; set; }
    }
}
