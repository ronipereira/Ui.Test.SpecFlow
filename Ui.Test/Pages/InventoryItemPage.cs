using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Ui.Test.Drivers;

namespace Ui.Test.Pages
{
    public class InventoryItemPage : Browser
    {
        public void AddToCartClick(string produto) => driver.FindElement(By.Id($"add-to-cart-{produto.Replace(" ", "-").ToLower()}")).Click();
    }
}
