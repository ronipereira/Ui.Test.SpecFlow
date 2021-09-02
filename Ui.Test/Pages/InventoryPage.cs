
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

        public bool HasProductCurrentValue(string currentProduct, string currentValue)
        {
            int i = 1;
            var produto = "";
            var valor = "";
            while (i <= 6)
            {
                var divBase = $"//div[@class='inventory_item'][{i}]//div[@class='inventory_item_description']//div[@class='";
                try
                {
                   produto = driver.FindElement(By.XPath(divBase + $"inventory_item_label']//*[text()='{currentProduct}']")).Text;
                   valor = driver.FindElement(By.XPath(divBase + $"pricebar']//*[text()='{currentValue.Replace("$", "")}']")).Text;
                   return currentProduct.Equals(produto) && currentValue.Equals(valor);
                }
                catch(NoSuchElementException)
                {
                    i++;
                }
            }
            return currentProduct.Equals(produto) && currentValue.Equals(valor);    
        }
    }
}
