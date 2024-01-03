using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using estacionamento_2.models;

decimal precoInicial=0;
decimal precoPorHora=0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento ! \n"+"Digite o preço incial:");
precoInicial=Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento e1= new Estacionamento(precoInicial,precoPorHora);

string opcao= string.Empty;
bool exibirMenu =true;

while(exibirMenu){

Console.Clear();
Console.WriteLine("1-Cadastrar veículo \n 2-Remover veículo \n 3-Listar veículos \n 4-Encerrar");
    switch( Console.ReadLine()){

        case "1":
            e1.AdicionarVeiculo();
            
            break;
        case "2":
        
            e1.RemoverVeiculos();
            
            break;

        case "3":
            e1.ListarVeiculos();
            break;
        
        case"4":
            exibirMenu=false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
            
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");