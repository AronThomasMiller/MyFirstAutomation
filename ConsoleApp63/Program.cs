using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to Google");
            var word = Console.ReadLine();
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");
            driver.FindElement(By.XPath("//input[@name= 'q']")).SendKeys(word);
            driver.FindElement(By.XPath("//input[@name= 'q']")).SendKeys(Keys.Enter);        }
    }
}
