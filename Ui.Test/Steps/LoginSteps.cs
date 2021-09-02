using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Ui.Test.Drivers;
using Ui.Test.Pages;

namespace Ui.Test.Steps
{
    [Binding]
    public sealed class LoginSteps : Browser
    {
        private readonly LoginPage loginPage = new LoginPage();

        [Given(@"que acesso o site")]
        public void DadoQueAcessoOSite()
        {
            Browser.LoadPage("https://www.saucedemo.com/");
        }

        [Then(@"vejo que estou na loginpage")]
        public void EntaoVejoQueEstouNaLoginpage()
        {
            Assert.That(loginPage.IsBotImgExist(), Is.True);
        }

        [When(@"informo as seguintes credenciais")]
        public void QuandoInformoAsSeguintesCredenciais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.LoginSendKeys((string)data.Username, (string)data.Password);
        }

        [When(@"me autentico no sitema")]
        public void QuandoMeAutenticoNoSitema()
        {
            loginPage.LoginClick();
        }

        [Then(@"um erro aparece informando que o usuário está bloqueado")]
        public void EntaoUmErroApareceInformandoQueOUsuarioEstaBloqueado()
        {
            if (loginPage.IsLoginBlockedMsgExist())
            {
                Assert.That(loginPage.GetLoginBlockedMsg(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
            }
        }
    }
}
