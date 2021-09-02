# Ui.Test.SpecFlow
Treinamento Automação de Testes(Jornada FrontEnd): Selenium+Specflow+C#. 

Automation Frontend Tests - SpecFlow NUnit Selenium
O objetivo deste projeto é fornecer um bom ponto de partida para quem procura usar
SpecFlow, NUnit e Selenium com C# na plataforma .NET Core 3.1, no padrão de projeto
PageObject demonstrando os resultados com o framework Allure Report.
Referências - .NET - C# - Selenium - NUnit - SpecFlow - Allure - Webdriver Manager
Os testes deste projeto foram baseados no site https://www.saucedemo.com/.
Setup - Windows
Download e instale Visual Studio ou Visual Studio Code.
Visual Studio - Extension
Download e instale a extensão SpecFlow for Visual Studio 2019 na sua IDE.
Visual Studio Code - Extension
Download e instale a extensão .NET Core Test Explorer na sua IDE. Esta extensão permite
visualizar os testes, entretanto se os testes não forem exibidos no Test Explorer, execute os
seguintes passos:
• Crie o arquivo .vscode/settings.json, com o seguinte conteúdo.
{
"dotnet-test-explorer.testProjectPath": "**/*(caminhoDiretorio).csproj"
}
• De acordo com esta issue será necessário deletar o diretório correspondente à
linguagem padrão que está sendo usada pela SDK, localizado em
"dotnet-install-directory/sdk/sdk-version".
Webdriver Manager
Requerimentos - Node.js
Instale o Webdriver Manager para resolver possíveis incompatibilidades entre o webdriver
e a versão do browser.
$ npm install -g webdriver-manager
Instale Scoop (utilitário para instalar programas pela linha de comando)
Requerimentos - PowerShell 3
Para instalar o Scoop abra o PowerShell e execute os seguintes comandos.
$ set-executionpolicy unrestricted -s cu
$ iex (new-object net.webclient).downloadstring('https://get.scoop.sh')
Allure Report
Instale o Allure Report.
$ scoop install allure
$ scoop update allure
Executando Testes
Requerimentos - Inicie o Selenium Server.
$ webdriver-manager update
$ webdriver-manager start
Você pode executar no Test Explorer da sua IDE escolhida ou via command line.
Build.
$ dotnet build
Executar todos os testes.
$ dotnet test
Executar apenas um teste.
$ dotnet test --filter "FullyQualifiedName~(ParteUnicaDoNomeDoCenario)"
Então você pode gerar um html report via Allure.
$ allure generate "allure-results-directory" -c
E abrir o report.
$ allure open "allure-report-directory"
