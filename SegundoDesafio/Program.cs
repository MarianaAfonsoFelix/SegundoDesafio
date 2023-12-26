// See https://aka.ms/new-console-template for more information

var fluxoSistema = 0;

Console.WriteLine("Seja bem vindo, ao projeto de Calculadora!");

while(fluxoSistema == 0)
{
    Console.WriteLine("Digite a operação que deseja realiazar?");
    Console.WriteLine("Digite 1 para soma?");
    Console.WriteLine("Digite 2 para divisão?");
    Console.WriteLine("Digite 3 para subtração?");
    Console.WriteLine("Digite 4 para multiplicação?");

    var acaoDesejada = Convert.ToInt32(Console.ReadLine());

    if(acaoDesejada == 1)
    {
        Console.WriteLine("Digite o primeiro número a ser somado!");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser somado!");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        var resultado = SomandoNumeros(numero1, numero2);
        Console.WriteLine("A soma deu:");
        Console.WriteLine(resultado);
    }

    else if(acaoDesejada == 2)
    {
        Console.WriteLine("Digite o primeiro número a ser dividido!");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser dividido!");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        var resultado = DivisaoNumeros(numero1, numero2);
        Console.WriteLine("A divisão deu:");
        Console.WriteLine(resultado);
    }

    else if(acaoDesejada == 3)
    {
        Console.WriteLine("Digite o primeiro número a ser subtraído!");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser subtraído!");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        var resultado = SubtracaoNumeros(numero1, numero2);
        Console.WriteLine("A subtração deu:");
        Console.WriteLine(resultado);
    }

    else if(acaoDesejada == 4)
    {
        Console.WriteLine("Digite o primeiro número a ser multiplicado!");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser multiplicado!");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        var resultado = MultiplicacaoNumeros(numero1, numero2);
        Console.WriteLine("A multiplicaçaõ deu:");
        Console.WriteLine(resultado);
    }

    else
    {
        Console.WriteLine("Ação inválida!");
    }

    Console.WriteLine("Digite S se deseja realizar outra operação ou N para encerrar!");
    var continuar = Console.ReadLine();
    if(continuar == "N")
    {
        fluxoSistema = 1;
    }
}

int MultiplicacaoNumeros(int num1, int num2)
{
    var multiplicacao = num1 * num2;
    return multiplicacao;
}
int SubtracaoNumeros(int num1, int num2)
{
    var subtracao = num1 - num2;
    return subtracao;
}
int DivisaoNumeros(int num1, int num2)
{
    var divisao = num1 / num2;
    return divisao;
}
int SomandoNumeros(int num1, int num2)
{
    var soma = num1 + num2;
    return soma;
}
