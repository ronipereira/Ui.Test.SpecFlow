using OpenQA.Selenium;
using Ui.Test.Drivers;

namespace Ui.Test.Pages
{
    public class LoginPage : Browser
    {
        private IWebElement BotImg => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div[1]/div[2]"));
        public bool IsBotImgExist() => BotImg.Displayed;
        private IWebElement UsernameTxt => driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordTxt => driver.FindElement(By.Id("password"));
        private IWebElement LoginBlockedMsg => driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]/h3"));
        public bool IsLoginBlockedMsgExist() => LoginBlockedMsg.Displayed;
        public string GetLoginBlockedMsg() => LoginBlockedMsg.Text;
        private IWebElement LoginBtn => driver.FindElement(By.Id("login-button"));
        public void LoginSendKeys(string username, string password)
        {
            UsernameTxt.SendKeys(username);
            PasswordTxt.SendKeys(password);
        }
        public void LoginClick() => LoginBtn.Click();
    }
}
