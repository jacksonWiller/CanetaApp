using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanetaApp
{
    public class Caneta
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Modelo{get; set;}

        public string Cor{get; set;}

        public int Carga{get; set;}

        public bool Tampada{get; set;}

        public Caneta(){}
        public Caneta(int carga )
        {
            Carga = carga;
            destampar();
        }

        public void status()
        {
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Uma caneta: " + Cor);
            Console.WriteLine("Carga: " + Carga);
            Console.WriteLine("Tampada: " + Tampada);
            Console.WriteLine("//////////////////////////////////////////////");

        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public void setModelo(string modelo)
        {
            Modelo = modelo;
        }

        public string getNome()
        {
            return Nome;
        }

       
       public void tampar()
        {
            Tampada = true;
        }

       public void destampar ()
        {
            Tampada = false;
        }

        public void setColor(int cor)
        {
            if(cor == 1)
                Cor= "Rosa";

            else if (cor == 2){
                Cor = "Azul";
            }
            else
            {
                Console.WriteLine("Erro ao adicionar a cor");
                Console.Error.Close();
            }

        }

       public void Rabiscar(string palavra)
        {
            if (Carga > 0)
            {
                Carga--;
                if (Cor == "Rosa")
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(palavra);
                    Console.ResetColor();
                }
                else if (Cor == "Azul")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(palavra);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(palavra);
                }
            }
            else
            {
                Console.WriteLine("Caneta sem carga"); 
            }
           
            
        }
    }
}
