using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Withus.Utilitys
{
    class Crawler
    {
        private readonly string poster = "<p style=\"text-align: center;\">&nbsp;</p>" +
            "<p style=\"box-sizing: border-box; padding: 0px; word-break: break-all; font-family: &quot;Malgun Gothic&quot;, dotum, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255); text-align: center;\">" +
            "<strong style=\"box-sizing: border-box;\">9월 22일 시즌4 오픈!! 와우디아블로!!</strong></p>" +
            "<p style=\"box-sizing: border-box; padding: 0px; word-break: break-all; font-family: &quot;Malgun Gothic&quot;, dotum, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255); text-align: center;\">&nbsp;</p>" +
            "<p style=\"box-sizing: border-box; padding: 0px; word-break: break-all; font-family: &quot;Malgun Gothic&quot;, dotum, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255); text-align: center;\">" +
            "<a style=\"box-sizing: border-box; text-decoration-line: underline;\">" +
            "<strong style=\"box-sizing: border-box;\">https://wowdia.com/</strong></a></p>" +
            "<p style=\"box-sizing: border-box; padding: 0px; word-break: break-all; font-family: &quot;Malgun Gothic&quot;, dotum, sans-serif; fontsize: 12px; background-color: rgb(255, 255, 255); text-align: center;\">" +
            "<a style=\"box-sizing: border-box; text-decoration-line: underline;\">" +
            "<strong style=\"box-sizing: border-box;\">https://wowdia.com/</strong></a></p>" +
            "<p style=\"box-sizing: border-box; padding: 0px; word-break: break-all; font-family: &quot;Malgun Gothic&quot;, dotum, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255); text-align: center;\">&nbsp;</p>" +
            "<p style=\"box-sizing: border-box; padding: 0px; word-break: break-all; font-family: &quot;Malgun Gothic&quot;, dotum, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255); text-align: center;\">" +
            "<a href=\"https://wowdia.com/\" target=\"_blank\">" +
            "<img alt=\"\" src=\"https://wowdia.com/data/editor/2009/20200922101511_d806e27d367b21554dd8591d2017013c_uw8e.jpg\" style=\"margin-left: 5px; margin-right: 5px; width: 600px; height: 4537px;\" /></a></p>";

        public string gamezoneResult = string.Empty;
        public string GamezoneHeler(string account, string password, bool needView)
        {
            string gamezoneURL = $"http://gamezone.live/index.php?mid=board_JYXw39&act=dispMemberLoginForm";
            string targetURL = $"http://gamezone.live/board_JYXw39";

            IWebDriver driver;
            ChromeOptions option;
            ChromeDriverService driverService;

            if (needView)
            {
                driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(driverService);                
            }
            else
            {
                option = new ChromeOptions();
                driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                option.AddArgument("--headless");

                driver = new ChromeDriver(driverService, option);                
            }        

            driver.Navigate().GoToUrl(gamezoneURL);
            Thread.Sleep(7000);
            Gamezone_Login(account, new AES256().AESDecrypt256(password), driver);
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl(targetURL);
            Thread.Sleep(5000);
            Gamezone_Writing(driver);            
            return gamezoneResult;
        }

        private void Gamezone_Login(string account, string password, IWebDriver driver)
        {            
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/div[5]/div/section/div/div[2]/form/fieldset/div[1]/input[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/div[5]/div/section/div/div[2]/form/fieldset/div[1]/input[1]")).SendKeys(account);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/div[5]/div/section/div/div[2]/form/fieldset/div[1]/input[2]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/div[5]/div/section/div/div[2]/form/fieldset/div[1]/input[2]")).SendKeys(password);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/div[5]/div/section/div/div[2]/form/fieldset/div[2]/input")).Click();
        }
        private void Gamezone_Writing(IWebDriver driver)
        {
            string writingURL = $"http://gamezone.live/index.php?mid=board_JYXw39&act=dispBoardWrite";
            driver.Navigate().GoToUrl(writingURL);
            Thread.Sleep(5000);
            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[5]/div/div/form/div[1]/input")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[5]/div/div/form/div[1]/input")).SendKeys(">> 디아블로2 본섭지향 : 와우디아서버 <<");
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[5]/div/div/form/div[2]/div[1]/div/div/span[1]/span[2]/span/span[6]/span[3]/a")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[5]/div/div/form/div[2]/div[1]/div/div/div/textarea")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[5]/div/div/form/div[2]/div[1]/div/div/div/textarea")).SendKeys(poster);
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[5]/div/div/form/div[3]/div[3]/input")).Click();
                gamezoneResult = driver.Url; 
                driver.Quit();
            } catch
            {
                gamezoneResult = "포인트 부족 또는 기타오류";
                driver.Quit();
            }            
        }
        public string TodayHeler()
        {
            //TODO: 투데이서버 크롤러 동작 코드
            string postURL = "TodayHeler 테스트";
            return postURL;
        }
        public string NaverHeler()
        {
            //TODO: 네이버 블로그 + 카페2곳 크롤러 동작 코드
            string postURL = "NaverHeler 테스트";
            return postURL;
        }


    }
}
