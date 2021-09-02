#language: pt-br

Funcionalidade: Checkout

Esquema do Cenário: Realizar uma compra com sucesso
	Dado que acesso o site
	Quando informo as seguintes credenciais
		| Username      | Password     |
		| standard_user | secret_sauce |
	E me autentico no sitema
	E adiciono o produto '<Produto>'
	E visualizo o carrinho
	E sigo para as informações do Checkout
	E insiro as seguintes informações pessoais
		| FirstName | LastName | PostalCode |
		| Teste     | CWI      | "91910400" |
	E sigo para o Overview do Checkout
	E Finalizo a compra
	Entao a página do pedido completo é exibida contendo a mensagem 'THANK YOU FOR YOUR ORDER'

	Exemplos: 
		| Produto             |
		| Sauce Labs Backpack |
		| Sauce Labs Onesie   |