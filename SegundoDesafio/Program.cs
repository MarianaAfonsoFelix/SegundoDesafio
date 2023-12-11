// See https://aka.ms/new-console-template for more information
Console.WriteLine("Seja bem vindo. ao projeto de SOMA!");

Console.WriteLine("Digite o primeiro número a ser somado!");
var numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número a ser somado!");
var numero2 = Convert.ToInt32(Console.ReadLine());

var resultado = SomandoNumeros();

Console.WriteLine("A soma deu:");
Console.WriteLine(resultado);

int SomandoNumeros()
{
    var soma = numero1 + numero2;
    return soma;
}