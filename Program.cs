/*1. Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
Descrição: Crie um script que declare uma variável para o nome de
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá,
João! Bem-vindo ao nosso site!".
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de
uma string com aspas duplas.*/
string nome = "Kaique";
Console.WriteLine($"Olá, {nome}! Bem-vindo ao nosso site!");
Console.WriteLine("Olá " + nome + "! Bem-vindo ao nosso site!");
/*2. Conversão de Temperatura (Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
Descrição: Crie um script que converta uma temperatura em Celsius
para Fahrenheit. A fórmula para conversão é:
Dica: Declare uma constante para armazenar o valor 9/5 e faça o
cálculo com a variável fornecida. */
const double divisao = 9.0 / 5.0;
double c = 32;
double resultado = (c * divisao) + 32;
Console.WriteLine($"{c} graus Celsius, é igual a {resultado} Fahrenheit  ");

/*3. Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
Descrição: Crie um script que solicite ao usuário seu nome, idade e
cidade e depois mostre uma mensagem com essas informações.
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.*/
string nomeUsuario = "Kaique";
int idade = 23;
string cidade = "São Paulo";
Console.WriteLine($"Meu nome é {nomeUsuario}, tenho {idade} anos e moro em {cidade}");
Console.WriteLine("Meu nome é " + nome + " , tenho " + idade + " anos e moro em " + cidade);

Console.WriteLine("4. Empréstimo Bancário\n");
/*Objetivo: Cálculos financeiros e declaração de variáveis.
Descrição: Crie um script que calcule o valor de uma parcela de um 
empréstimo, dado o valor total do empréstimo, a taxa de juros e o 
número de parcelas. Exemplo de fórmula: 
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o 
número de parcelas.*/

Console.WriteLine("Qual o valor total do empréstimo?");
double emprestimo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual é a taxa de juros? (Somente número, ex: 10 para 10%)");
double taxaJuros = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual é o numero total de parcelas? ");
int numParcelas = Convert.ToInt32(Console.ReadLine());

double valorParcela = (emprestimo * (1 + (taxaJuros / 100)) / numParcelas);

Console.WriteLine("\nValor do empréstimo: R$ " + emprestimo);
Console.WriteLine("Taxa de juros: " + (taxaJuros) + "% ao mês");
Console.WriteLine("Número de parcelas: " + numParcelas);
Console.WriteLine("Valor da parcela: R$ " + valorParcela + "\n");


Console.WriteLine("5. Conversor de Moeda\n");
/*Objetivo: Trabalhar com variáveis, operadores e arredondamento.
Descrição: Crie um script que converta uma quantia em reais para 
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor 
convertido com 2 casas decimais.
Dica: Use round() para arredondar o valor para 2 casas decimais.*/

double taxaCambio, valorReais, totalConversao;

Console.WriteLine("Quantos reais deseja converter?");
valorReais = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual é a taxa de câmbio atual entre real-dólar?");
taxaCambio = Convert.ToDouble(Console.ReadLine());

totalConversao = valorReais / taxaCambio;

Console.WriteLine($"\nO valor {valorReais}R$ convertido em dólares é: {Math.Round(totalConversao)} $.\n");


Console.WriteLine("6 . Calculadora de Desconto\n");
/*Objetivo: Cálculos matemáticos e uso de variáveis.
Descrição: Crie um script que calcule o valor do desconto de um 
produto, dado o preço original e a porcentagem de desconto. Exemplo 
de fórmula: 
Dica: Use variáveis para armazenar o preço e a porcentagem do 
desconto e calcule o valor final*/

Console.WriteLine("Digite o preço original do produto");
double precoProduto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a porcentagem do desconto que será aplicada");
double porcentoDesconto = Convert.ToDouble(Console.ReadLine());

double valorFinal = precoProduto - (precoProduto * (porcentoDesconto / 100));
Console.WriteLine($"\nO valor de {precoProduto}R$ com o desconto de {porcentoDesconto}% é : {valorFinal}R$");