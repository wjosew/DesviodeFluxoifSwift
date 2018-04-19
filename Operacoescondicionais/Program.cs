using System;

namespace Operacoescondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário in-line(em linha)
            /*
            Comentário in-block(em bloco)
            */
            //Declaração da variável operação. Ela será do tipo inteiro
            int operacao;

            //Declaração das variáveis n1 e n2. elas serão double 
            double n1,n2;

            /* Para limpar a tela de comandos a cada execução
            utilizaremos o comando Console.clear();
            obs .: Clear -> limpar
               */
               Console.Clear();
               Console.WriteLine ("Escolha uma da operções abaixo");
               /* Para a exibição da opções de operação , vamos usar 
               ocomando de Console.Writeline e, nele usaremos um 
               comando de quebra de linha \n (contra barra n(new line)).
               Assim , as opções ficarão uma abaixo da outra
               */
               Console.WriteLine ("1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
               operacao = int.Parse(Console.ReadLine());

               Console.WriteLine ("Digite um número:");
               n1 = double.Parse(Console.ReadLine());

               Console.WriteLine("Digite outro número:");
               n2 = double.Parse(Console.ReadLine());
               
               if(operacao==1)
               {
                   Console.WriteLine("O resultado da soma é: "+(n1+n2));
               }
               else if(operacao==2)
               {
                   Console.WriteLine("O resultado da subtração é " +(n1-n2));
               } 
               else if (operacao==3)
               {
                   Console.WriteLine("O resultado da Multiplicação é " + (n1*n2));
               }
               else if (operacao==4)
               {
                   Console.WriteLine("O resultado da divisão é " +(n1/n2));
               }
               else
               {
                   Console.WriteLine("Operação invalida");
               }


        }
    }
}
