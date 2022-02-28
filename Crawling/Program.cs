using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = GetTitle();

            Console.WriteLine(title);
            Console.ReadLine();
        }

        private static string GetTitle()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://sports.news.naver.com/index";

            var element = driver.FindElement(By.ClassName("today_item")).FindElement(By.TagName("a"));
            var title = element.GetAttribute("title");

            return title;
        }

    }
}
