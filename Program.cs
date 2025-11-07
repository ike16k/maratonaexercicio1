/*
1. Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
Descrição: Crie um script que declare uma variável para o nome de 
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá, 
João! Bem-vindo ao nosso site!".
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de 
uma string com aspas duplas.
*/

/*2.Conversão de Temperatura(Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
Descrição: Crie um script que converta uma temperatura em Celsius 
para Fahrenheit. A fórmula para conversão é: 
Dica: Declare uma constante para armazenar o valor 9/5 e faça o 
cálculo com a variável fornecida.*/

const double valorF = 9 / 5.0F;
double F;

Console.WriteLine("Digite uma temperatura em celsius para converter para Fahrenheit");
double C = Convert.ToDouble(Console.ReadLine());

F = (C * valorF) + 32;

Console.WriteLine($"A temperatura {C}C° em Fahrenheit equivale à: {Math.Round(F, 2)}F°");


/*3. Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
Descrição: Crie um script que solicite ao usuário seu nome, idade e 
cidade e depois mostre uma mensagem com essas informações. 
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.*/

Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Quantos anos tem?");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Onde você mora?");
string local = Console.ReadLine();

Console.WriteLine($"Meu nome é {nome}, tenho "+ idade + $" anos e moro em {local}");


/*4. Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis.
Descrição: Crie um script que calcule o valor de uma parcela de um 
empréstimo, dado o valor total do empréstimo, a taxa de juros e o 
número de parcelas. Exemplo de fórmula: 
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o 
número de parcelas.*/

Console.WriteLine("Qual o valor total do empréstimo?");
double emprestimo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual é a taxa de juros?");
double taxaJuros = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual é o numero total de parcelas? ");
int numParcelas = Convert.ToInt32(Console.ReadLine());

double valorParcela = (emprestimo * (1 + taxaJuros)) / numParcelas;

Console.WriteLine("Valor do empréstimo: R$ " + emprestimo);
Console.WriteLine("Taxa de juros: " + (taxaJuros * 100) + "% ao mês");
Console.WriteLine("Número de parcelas: " + numParcelas);
Console.WriteLine("Valor da parcela: R$ " + valorParcela);

/*5. Conversor de Moeda
Objetivo: Trabalhar com variáveis, operadores e arredondamento.
Descrição: Crie um script que converta uma quantia em reais para 
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor 
convertido com 2 casas decimais.
Dica: Use round() para arredondar o valor para 2 casas decimais.*/

/*6 . Calculadora de Desconto
Objetivo: Cálculos matemáticos e uso de variáveis.
Descrição: Crie um script que calcule o valor do desconto de um 
produto, dado o preço original e a porcentagem de desconto. Exemplo 
de fórmula: 
Dica: Use variáveis para armazenar o preço e a porcentagem do 
desconto e calcule o valor final*/