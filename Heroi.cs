using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo
{
    public class Heroi
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Tipo { get; set; } 

        public void Atacar()
        {
            if (Tipo == null)
            {
                Console.WriteLine("Tipo não definido.");
                return; 
            }

            string ataque;

         
            switch (Tipo.ToLower()) 
            {
                case "mago":
                    ataque = "magia";
                    break;
                case "guerreiro":
                    ataque = "espada";
                    break;
                case "monge":
                    ataque = "artes marciais";
                    break;
                case "ninja":
                    ataque = "shuriken";
                    break;
                default:
                    ataque = "ataque desconhecido";
                    break;
            }

            Console.WriteLine($"O {Tipo} atacou usando {ataque}.");
        }
    }
}