﻿//string mensagem = "Boas vindas";

//void ExibirMensagem()
//{
//    Console.WriteLine(mensagem);
//}

//void ExibirMenu()
//{
//    Console.WriteLine("\nDigite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para exibir a média de uma banda");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("Digite a sua opção: "); // Usando apenas o "Write" não pula a linha
//    string opcaoEscolhida = Console.ReadLine()!; // Lê o que o usuario digito
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); // Transformando para string para int

//    switch (opcaoEscolhidaNumerica)
//    {
//        case 1: Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
//            break;
//        case 2:
//            Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
//            break;
//    }

//}

//ExibirMensagem();
//ExibirMenu();

using System.Collections.Generic;

void ExibirMenu()
{
    Console.WriteLine("Digite um número de 1 a 100");
    string escolhaJogador = Console.ReadLine()!;
    int escolhaJogadorNumerica = int.Parse(escolhaJogador);
}
static int CriaLista()
{
    List<int> lista = new List<int>();
    for (int i = 1; i <= 100; i++)
    {
        lista.Add(i);
    }

    Random rnd = new Random();
    int index = rnd.Next(lista.Count);

    Console.WriteLine(lista[index]);

    //lista.ForEach(Console.WriteLine); //Maneira mais simples de mostrar a lista
    return lista[index]; // retorna o número aleatório
}


CriaLista();