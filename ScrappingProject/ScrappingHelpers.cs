using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScrappingProject
{
    public static class ScrappingHelpers
    {
        public static bool ContainsTag(this IWebElement element, string tagName)
        {
            string elementText = element.GetAttribute("innerHTML");
            return CheckStringForTag(elementText, tagName);
        }

        public static bool ContainsClass(this IWebElement element, string className)
        {
            string elementText = element.GetAttribute("innerHTML");
            return CheckStringForClass(elementText, className);
        }

        public static bool ContainsTag(this IWebDriver driver, string tagName)
        {
            return CheckStringForTag(driver.PageSource, tagName);
        }

        public static bool ContainsClass(this IWebDriver driver, string className)
        {
            return CheckStringForClass(driver.PageSource, className);
        }

        private static bool CheckStringForTag(string text, string tagName)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                return text.Contains("<" + tagName + ">") || text.Contains("</" + tagName + ">") || text.Contains("<" + tagName + " ");
            }
            return false;
        }

        private static bool CheckStringForClass(string text, string className)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                string pattern = string.Format(".*class[\\s]?=[\\s]?.*[\\s'\"]{0}[\\s'\"].*.*", className);
                Match m = Regex.Match(text, className, RegexOptions.IgnoreCase);
                return m.Success;
            }
            return false;
        }

        public static string InnerHTML(this IWebElement element)
        {
            return element.GetAttribute("innerHTML");
        }
    }
}
