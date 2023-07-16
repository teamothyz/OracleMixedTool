﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumUndetectedChromeDriver;

namespace ChromeDriverLibrary
{
    public static class ChromeDriverExtension
    {
        public static IWebElement FindInnerElement(this UndetectedChromeDriver driver, IWebElement element, string selector, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            var innerElement = waiter.Until(webdriver => element.FindElement(By.CssSelector(selector)), token);
            return innerElement;
        }

        public static IWebElement FindElement(this UndetectedChromeDriver driver, string selector, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            var element = waiter.Until(webdriver => webdriver.FindElement(By.CssSelector(selector)), token);
            return element;
        }

        public static void Sendkeys(this UndetectedChromeDriver driver, IWebElement element, string content, bool needCompare, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            waiter.Until(webdriver =>
            {
                try
                {
                    element.Click();
                    Thread.Sleep(500);
                    element.Clear();
                    Thread.Sleep(500);
                }
                catch { }

                element.SendKeys(content);
                Thread.Sleep(500);
                if (!needCompare) return true;
                return CompareContent(driver, element, content);
            }, token);
        }

        public static void ScrollTo(this UndetectedChromeDriver driver, string selector, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            waiter.Until(webdriver =>
            {
                driver.ExecuteScript($"document.querySelector('{selector}').scrollIntoView()");
                return true;
            }, token);
        }

        public static void Sendkeys(this UndetectedChromeDriver driver, string selector, string content, bool needCompare, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            waiter.Until(webdriver =>
            {
                var element = driver.FindElement(By.CssSelector(selector));
                try
                {
                    element.Click();
                    Thread.Sleep(500);
                    element.Clear();
                    Thread.Sleep(500);
                }
                catch { }

                element.SendKeys(content);
                Thread.Sleep(500);
                if (!needCompare) return true;
                return CompareContent(driver, element, content);
            }, token);
        }

        public static void Click(this UndetectedChromeDriver driver, string selector, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            waiter.Until(webdriver =>
            {
                driver.FindElement(By.CssSelector(selector)).Click();
                return true;
            }, token);
        }

        public static void Click(this IWebElement element, UndetectedChromeDriver driver, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            waiter.Until(webdriver =>
            {
                element.Click();
                return true;
            }, token);
        }

        public static void ClickByJS(this UndetectedChromeDriver driver, string selector, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            waiter.Until(webdriver =>
            {
                driver.ExecuteScript("arguments[0].click();", driver.FindElement(By.CssSelector(selector)));
                return true;
            }, token);
        }

        public static IAlert SwitchToAlert(this UndetectedChromeDriver driver, int timeout, CancellationToken token)
        {
            var waiter = GetWaiter(driver, timeout);
            return waiter.Until(webdriver =>
            {
                return driver.SwitchTo().Alert();
            }, token);
        }

        public static void ClearContentManually(this IWebElement element, int timeout, CancellationToken token)
        {
            var endTime = DateTime.Now.AddSeconds(timeout);
            while (element.GetAttribute("value") != "")
            {
                element.SendKeys(Keys.Backspace);
                if (DateTime.Now >= endTime) break;
                Thread.Sleep(200);
            }
        }

        public static bool CompareContent(UndetectedChromeDriver driver, IWebElement element, string content)
        {
            try
            {
                var value = element.GetAttribute("value");
                if (value == content) return true;
                if (driver.GetInnerHTML(element) == content) return true;
                if (driver.GetInnerText(element) == content) return true;

                throw new InvalidElementStateException("content does not match");
            }
            catch (Exception ex)
            {
                throw new InvalidElementStateException(ex.Message);
            }
        }

        public static string GetInnerHTML(this UndetectedChromeDriver driver, IWebElement element)
        {
            return (string)driver.ExecuteScript("return arguments[0].innerHTML;", element);
        }

        public static string GetInnerText(this UndetectedChromeDriver driver, IWebElement element)
        {
            return (string)driver.ExecuteScript("return arguments[0].innerText;", element);
        }

        public static WebDriverWait GetWaiter(UndetectedChromeDriver driver, int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException),
                typeof(ElementNotVisibleException),
                typeof(ElementNotInteractableException),
                typeof(StaleElementReferenceException),
                typeof(NoAlertPresentException),
                typeof(InvalidElementStateException),
                typeof(WebDriverTimeoutException));

            return wait;
        }
    }
}
