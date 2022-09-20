using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
       private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Adiciona um veículo na lista
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("O veículo foi cadastado");
        }

        public void RemoverVeiculo()
        {
            // Remove o veículo da lista
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                Console.WriteLine("Quantas horas o veículo ficou estacionado?");
                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0;

                valorTotal = Convert.ToDecimal(precoInicial + (horas * precoPorHora)); 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            // Caso o veículo não exista
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Listagem de Veículos
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
    
                int contador = 0;
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"Veículo Nº {contador} - Placa Nº {item}");
                    contador++;
                }
            }
            else
            // Caso não tenha veículos estacionados
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}