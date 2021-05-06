using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool check = true;
            string texto = "";
            string nome = "";
            string senha = "";
            while (check == true)
        {
              Console.WriteLine("Insira o seu nome" + texto);
              nome = Console.ReadLine();
              //Console.WriteLine(nome);
              Console.WriteLine("Insira o seu senha" + texto);
              senha = Console.ReadLine();
              //Console.WriteLine(senha);
            
            if (nome == senha)
              {
                  Console.WriteLine("Cadastro inválido: Nome igual a senha");
                texto = " novamente:";
              }
              else
              
              {
                   Console.WriteLine("Cadastro Efetuado !!!");
                    check = false;
                      texto = "novamente";
              }
        }

        }
    }
}
