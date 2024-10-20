Console.WriteLine("Aviso: números decimais devem ser informados com virgula!");

Console.WriteLine("Informe um número:");
double primeiroNumero = 0;
primeiroNumero = double.Parse(Console.ReadLine());

Console.WriteLine("Informe outro número:");
double segundoNumero = 0;
segundoNumero = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a operação desejada:\n" +
    "1. Adição\n" +
    "2. Subtração\n" +
    "3. Multiplicação\n" +
    "4. Divisão");

int operacao = int.Parse(Console.ReadLine());

if(operacao == 1)
{
    double adicao = primeiroNumero + segundoNumero;
    adicao = Math.Round(adicao, 2);
    Console.WriteLine("O resultado da adição de: " + primeiroNumero + " + " + segundoNumero + " é igual a: " + adicao);
}
else if (operacao == 2)
{
    double subtracao = primeiroNumero - segundoNumero;
    subtracao = Math.Round(subtracao, 2);
    Console.WriteLine("O resultado da subtração de: " + primeiroNumero + " - " + segundoNumero + " é igual a: " + subtracao);
}
else if (operacao == 3)
{
    double multiplicacao = primeiroNumero * segundoNumero;
    multiplicacao = Math.Round(multiplicacao, 2);
    Console.WriteLine("O resultado da multiplicação de: " + primeiroNumero + " x " + segundoNumero + " é igual a: " + multiplicacao);
}
else if (operacao == 4)
{
    double divisao = primeiroNumero / segundoNumero;
    divisao = Math.Round(divisao, 2);
    Console.WriteLine("O resultado da divisão de: " + primeiroNumero + " por " + segundoNumero + " é igual a: " + divisao);
}
else
{
    Console.WriteLine("Opção inválida. Informe apenas o número referente a operação desejada!");
}
