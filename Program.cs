
using CanetaApp;
using ConsoleDataBase;
using System.Collections.Generic;


var  listaDeCanetas = new List<Caneta>();
var database = new DataContext();

string opt = "";

do
{
    Console.WriteLine("Escolha um das opções");
    Console.WriteLine("0:Fechar");
    Console.WriteLine("1: adicionar caneta");
    Console.WriteLine("2: Mostrar lista");
    Console.WriteLine("3: Excluir  lista");
    opt = Console.ReadLine();

    if (opt == "1")
    {
        var caneta = new Caneta(2);
        Console.WriteLine("Digite o nome caneta");
        caneta.setNome(Console.ReadLine());
        Console.WriteLine("Digite o modelo da caneta");
        caneta.setModelo(Console.ReadLine());
        Console.WriteLine("Digite a cor da caneta- Rosa= 1 e Azul= 2");
        caneta.setColor(Convert.ToInt32(Console.ReadLine()));

        database.Canetas.Add(caneta);
        database.SaveChanges();


    }
    if (opt == "2")
    {
        var lista = database.Canetas.ToList();
        foreach (Caneta caneta in lista)
        {
            caneta.status();
        }
    }

    if (opt == "3")
    {
        Console.WriteLine("Digite o nome do item que deseja excluir");
        var item = Console.ReadLine();
        Console.ReadKey();
        var name = Console.ReadLine();
        Caneta caneta  = listaDeCanetas.Find(x => x.getNome() == name);
        listaDeCanetas.Remove(caneta);
        
    }

    if (opt == "4")
    {
        Console.WriteLine("Digite o nome da caneta que você deseja usar ");
        var name = Console.ReadLine();
        Caneta caneta = listaDeCanetas.Find(x => x.getNome() == name);
        Console.WriteLine("Digite a palavra que deseja escrever");
        var palavra = Console.ReadLine();
        caneta.Rabiscar(palavra);


    }




} while (opt != "0");

Console.WriteLine("Programa finalizado");