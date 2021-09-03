
using OpenQA.Selenium;
using Ui.Test.Drivers;

namespace Ui.Test.Pages
{
    public class InventoryPage : Browser
    {
        private IWebElement MenuBtn => driver.FindElement(By.Id("react-burger-menu-btn"));
        private IWebElement MenuWindow => driver.FindElement(By.Id("menu_button_container"));
        private IWebElement LogoutLnk => driver.FindElement(By.Id("logout_sidebar_link"));
        public void MenuClick() => MenuBtn.Click();
        public bool IsMenuWindowVisible() => MenuWindow.Displayed;
        public bool IsLogoutExist() => LogoutLnk.Displayed;
        public void GetProduto(string produto) => driver.FindElement(By.XPath($"//*[text()='{produto}']")).Click();
        private IWebElement PrecoProdutoTxt(string produto) => driver.FindElement(By.XPath($"//*[text()='{produto}']/parent::a/../../div[@class='pricebar']/div[@class='inventory_item_price']"));
        private bool IsPrecoProdutoTxtExist(string produto) => PrecoProdutoTxt(produto).Displayed;
        public string GetPrecoProdutoTxt(string produto)
        {
            if (IsPrecoProdutoTxtExist(produto))
                return PrecoProdutoTxt(produto).Text;
            return "";
        }
    }
}
