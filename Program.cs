﻿using System;

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

        Console.WriteLine("Projeto 6 - Atribuições de Variáveis");

        int idades = 20;
        int idadeRicardo = idades;
        Console.WriteLine(idadeRicardo);


        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //-----------------------------------------------------------------

        Console.WriteLine("Projeto 7 - Condionais");

        int idadeJoao = 16;
        int quantidadeDePessoas = 3;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar na Festa!");
        }
        else
        {
            if (quantidadeDePessoas >0)
            {
                Console.WriteLine("Pode entrar na Festa!");    
            }
            else
            {
                Console.WriteLine("Não pode entrar na Festa!");
            }
        }


        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //--------------------------------------------------------

        Console.WriteLine("Projeto 8 - Variáveis Booleanas");

        int idadeMarco = 16;
        int quantidadeDePessoa = 3;

        bool acompanhado = quantidadeDePessoa > 1;
        bool grupo = true;

        if (idadeMarco >= 18 || grupo && acompanhado )
        {
            Console.WriteLine("Marco Pode entrar na Festa!");
        }
        else
        {
            Console.WriteLine("Marco Não pode entrar na Festa!");
        }
        
        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //---------------------------------------------------

        Console.WriteLine("Projeto 9 - Escopo");

        int idadeMatheus = 16;
        int quantidadeDePeople = 3;

        bool acompanhados = quantidadeDePeople > 1;
        string textoAdicional;

        if(acompanhados == true)
        {
            textoAdicional = "matheus está acompanhado";
        }
        else
        {
            textoAdicional = "Matheus não está acompanhado";
        }

        if (idadeMatheus >= 18 ||  acompanhados )
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Marco Pode entrar na Festa!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Marco Não pode entrar na Festa!");
        }
        
        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //--------------------------------------------------------

        Console.WriteLine("Projeto 10 - While");

        double investimento = 1000;
        // rendimento de 0.5% ao mẽs

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            mes += 1;
            Console.WriteLine("No mês: " + mes + " você tem: " + investimento);

        }

        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //------------------------------------------------------

        Console.WriteLine("Projeto 11 - For");

        double investimentos = 1000;
        // rendimento de 0.5% ao mẽs

        for(int month = 1; month<=12; month++)
        {
            investimentos *= 1.005;
            Console.WriteLine("No mês: " + month + " você tem: " + investimentos);

        }

        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();

        //--------------------------------------------------------

        Console.WriteLine("Projeto 12 - Encadeando laços For");
        double totalInvestido = 1000;

        double fatorRendimento = 1.005;

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mess = 1; mess<= 12; mess++)
            {
                totalInvestido += fatorRendimento;
            }
            fatorRendimento += 0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá: " + totalInvestido);

        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();
        
        //----------------------------------------------------------

        Console.WriteLine("Projeto 13 - Breack - laços For");

        for (int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
        {
            for(int contadorDeColunas = 0; contadorDeColunas < 10; contadorDeColunas++)
            {
                Console.Write("*");
                if (contadorDeColunas >= contadorDeLinhas)
                    break;
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Pressione Enter para avançar...");
        Console.ReadLine();
        

    }
}

//Para executar o código basta digitar dotnet run no terminal.
//dotnet new console ... Cria um novo console com as pastas para um novo projeto.