using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Ui.Test.Drivers;
using Ui.Test.Pages;

namespace Ui.Test.Steps
{
    [Binding]
    public class CheckoutSteps : Browser
    {
        CartPage cartPage = new CartPage();
        CheckoutStepOnePage checkoutStepOnePage = new CheckoutStepOnePage();
        CheckoutStepTwoPage checkoutStepTwoPage = new CheckoutStepTwoPage();
        CheckoutComplete checkoutComplete = new CheckoutComplete();

        [When(@"visualizo o carrinho")]
        public void QuandoVisualizoOCarrinho()
        {
            cartPage.CartClick();
        }

        [When(@"sigo para as informações do Checkout")]
        public void QuandoSigoParaAsInformacoesDoCheckout()
        {
            cartPage.CheckoutCartClick();
        }

        [When(@"insiro as seguintes informações pessoais")]
        public void QuandoInsiroAsSeguintesInformacoesPessoais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            checkoutStepOnePage.YourInformationSendKeys((string)data.FirstName, (string)data.LastName, (string)data.PostalCode);
        }

        [When(@"sigo para o Overview do Checkout")]
        public void QuandoSigoParaOOverviewDoCheckout()
        {
            checkoutStepOnePage.ContinueBtnClick();
        }

        [When(@"Finalizo a compra")]
        public void QuandoFinalizoACompra()
        {
            checkoutStepTwoPage.FinishBtnClick();
        }

        [Then(@"a página do pedido completo é exibida contendo a mensagem '(.*)'")]
        public void EntaoAPaginaDoPedidoCompletoEExibidaContendoAMensagem(string msgPedidoEnviado)
        {
            if(checkoutComplete.IsOrderSentMsgExist())
            {
                Assert.That(checkoutComplete.GetOrderSentMsg(), Is.EqualTo(msgPedidoEnviado));
            } 
        }
    }
}
