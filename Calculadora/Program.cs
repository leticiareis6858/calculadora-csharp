class Calculadora
{
    static double Adicao(double primeiroNumero, double segundoNumero)
    {
        return Math.Round(primeiroNumero + segundoNumero, 2);
    }

    static double Subtracao(double primeiroNumero, double segundoNumero)
    {
        return Math.Round(primeiroNumero - segundoNumero, 2);
    }

    static double Divisao(double primeiroNumero, double segundoNumero)
    {
        if (segundoNumero == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        return Math.Round(primeiroNumero / segundoNumero, 2);
    }

    static double Multiplicacao(double primeiroNumero, double segundoNumero)
    {
        return Math.Round(primeiroNumero * segundoNumero, 2);
    }

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Aviso: números decimais devem ser informados com virgula!");

            Console.WriteLine("Informe um número:");
            double primeiroNumero = 0;
            primeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro número:");
            double segundoNumero = 0;
            segundoNumero = double.Parse(Console.ReadLine());

            bool opcao = true;

            while (opcao)
            {
                Console.WriteLine("Informe a operação desejada:\n" +
                "1. Adição\n" +
                "2. Subtração\n" +
                "3. Multiplicação\n" +
                "4. Divisão\n"+
                "0. Sair");

                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 0)
                {
                    opcao = false;
                    continuar = false;
                    Console.WriteLine("Encerrando...");
                    break;
                }

                double resultado;

                switch (operacao)
                {
                    case 1:
                        resultado = Adicao(primeiroNumero, segundoNumero);
                        Console.WriteLine("O resultado da adição de: " + primeiroNumero + " + " + segundoNumero + " é igual a: " + resultado);
                        break;
                    case 2:
                        resultado = Subtracao(primeiroNumero, segundoNumero);
                        Console.WriteLine("O resultado da subtração de: " + primeiroNumero + " - " + segundoNumero + " é igual a: " + resultado);
                        break;
                    case 3:
                        resultado = Multiplicacao(primeiroNumero, segundoNumero);
                        Console.WriteLine("O resultado da multiplicação de: " + primeiroNumero + " x " + segundoNumero + " é igual a: " + resultado);
                        break;
                    case 4:
                        try
                        {
                            resultado = Divisao(primeiroNumero, segundoNumero);
                            Console.WriteLine("O resultado da divisão de: " + primeiroNumero + " por " + segundoNumero + " é igual a: " + resultado);
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        continue;
                }

                Console.WriteLine("O que deseja fazer agora?\n" +
                  "1. Fazer outra operação com os mesmos números\n" +
                  "2. Informar novos números\n" +
                  "3. Encerrar");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        continue;
                    case 2:
                        opcao = false;
                        break;
                    case 3:
                        opcao = false;
                        continuar = false;
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        continue;
                }
            }
        }
    }
}