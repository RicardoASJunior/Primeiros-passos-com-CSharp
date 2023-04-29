using System;

class Programa{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Word!!!");

        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //------------------------------------------

        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade;
        idade = 22;
        Console.WriteLine("Minha idade é: " + idade);
        idade = 27 -5;
        Console.WriteLine(idade);
        idade = 5 * 2 -6;

        Console.WriteLine(idade);
        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //---------------------------------------------

        Console.WriteLine("Projeto 3 - Variáveis de ponto Flutuante");

        double salario;
        salario = 2200.50;

        Console.WriteLine(salario);

        double divisao;
        divisao = 7.0 / 5;

        Console.WriteLine("O resultado é: " + divisao);
        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //-----------------------------------------------

        Console.WriteLine("Projeto 4 - Outras variáveis numéricas");

        long x = 200000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.78f;
        Console.WriteLine(altura);

        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //----------------------------------------------

        Console.WriteLine("Projeto 5 - Caracteres e Textos.");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65; // Transformando numero em letra.. consultar tabela char
        Console.WriteLine(letra);


        letra = (char)(65+1); // Transformando numero em letra.. consultar tabela char
        Console.WriteLine(letra);

        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        string frase = "Encapsulando uma frase";
        Console.WriteLine(frase);

        string linguagensDeProgramacao = @"Minhas Linguagens favoritas:
- Python
- JavaScript
- HTML
- CSS
- C#"; // Não pode identar, pq ele considera o espaço da identação;
        Console.WriteLine(linguagensDeProgramacao);


    Console.WriteLine("Pressione Enter para avançar...");
    Console.ReadLine();

    //-----------------------------------------------------------------

    

    }
}