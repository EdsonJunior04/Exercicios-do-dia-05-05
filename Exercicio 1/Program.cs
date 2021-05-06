using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
                float nota;
                bool check = true;
                string texto = "";
                while (check == true)
            {
                Console.WriteLine("Insira sua nota" + texto);
                nota = float.Parse(Console.ReadLine());

                 if (nota >= 0 && nota <=10)
                {
                Console.WriteLine("Nota valida");
                check = false;
                }
                else
                {
                    Console.WriteLine("Nota invalida");
                    texto = " novamente";
                }
            }               
        }
      
    }
}
