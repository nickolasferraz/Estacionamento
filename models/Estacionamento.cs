using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento_2.models
{
    public class Estacionamento
    {
        // Atributos
        private decimal precoInicial=0;
        private decimal precoPorHora=0;

        public decimal horas;
        private List <string> Veiculos=new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){

            this.precoInicial=precoInicial;
            this.precoPorHora=precoPorHora;

        }

        public void AdicionarVeiculo(){
            Console.WriteLine("digite a placa");
            string? placaQueSeraAdicionada =Console.ReadLine();
            Veiculos.Add(placaQueSeraAdicionada);
            Console.WriteLine($"o veiculo com a placa {placaQueSeraAdicionada} estacionado");

        }

        public void RemoverVeiculos(){

                ListarVeiculos();
             Console.WriteLine("Digite a placa do carro ");
             string placaQueSeraRemovida =Console.ReadLine();
             

                if(Veiculos.Any(x => x.ToUpper() == placaQueSeraRemovida.ToUpper())){

                    int horas =0;
                    decimal valorTotal=0;

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    horas=Convert.ToInt32(Console.ReadLine());
                    valorTotal= precoInicial+precoPorHora*horas;
                    Veiculos.Remove(placaQueSeraRemovida);
                    
                    Console.WriteLine($"O veículo {placaQueSeraRemovida} foi removido e o preço total foi de: R$ {valorTotal}");
                } 
                else{
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }           
        }

        public void ListarVeiculos(){
            
                if(Veiculos.Any())
                {

                    Console.WriteLine("Os veículos estacionados são:");

                    foreach( string v in Veiculos)
                    {

                        
                        Console.WriteLine(v);
                    

                    }
                }
                else
                {
                 Console.WriteLine("Não há veículos estacionados.");
                }

        }
                
    }
        




}