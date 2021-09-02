using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Ui.Test.Drivers;
using Ui.Test.Pages;

namespace Ui.Test.Steps
{
    [Binding]
    public class InventorySteps : Browser
    {
        private readonly InventoryPage inventoryPage = new InventoryPage();
        private readonly InventoryItemPage inventoryItemPage = new InventoryItemPage();

        [When(@"adiciono o produto '(.*)'")]
        public void QuandoAdicionoOProduto(string produto)
        {
            inventoryPage.GetProduto(produto);
            inventoryItemPage.AddToCartClick(produto);
        }

        [Then(@"o menu do usuário está visível")]
        public void EntaoOMenuDoUsuarioEstaVisivel()
        {
            inventoryPage.MenuClick();
            Assert.That(inventoryPage.IsMenuWindowVisible, Is.True);
        }

        [Then(@"o usuário aparece logado")]
        public void EntaoOUsuarioApareceLogado()
        {
            Assert.That(inventoryPage.IsLogoutExist, Is.True);
        }

        [Then(@"o produto terá o seguinte valor")]
        public void EntaoOProdutoTeraOSeguinteValor(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Assert.That(inventoryPage.HasProductCurrentValue((string)data.Produto, (string)data.ValorUnitario), Is.True);
            
        }

        [Then(@"os produtos terão os seguintes valores")]
        public void EntaoOsProdutosTeraoOsSeguintesValores(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                Assert.That(inventoryPage.HasProductCurrentValue(row["Produto"], row["ValorUnitario"]), Is.True);
            }
        }
    }
}
