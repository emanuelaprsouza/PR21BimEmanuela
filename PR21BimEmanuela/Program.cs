using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR21BimEmanuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine(" ==========MENU============ ");
            Console.WriteLine(" 1- EXERCÍCIO 1 ");
            Console.WriteLine(" 2- EXERCÍCIO 2 ");
            Console.WriteLine(" 3- EXERCÍCIO 3 ");
            Console.WriteLine(" 4- EXERCÍCIO 4 ");
            Console.WriteLine(" 5- EXERCÍCIO 5 ");
            Console.WriteLine(" 6- EXERCÍCIO 6 ");
            Console.WriteLine(" 7- EXERCÍCIO 7 ");
            Console.WriteLine(" ========================= ");

            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: int num;

                    Console.WriteLine("Digite um número: ");
                    num = int.Parse(Console.ReadLine());

                    if(num < 0)
                    {
                        num = -num;
                    }

                    Console.WriteLine("O valor absoluto do número é: " + num);

                    break;

                case 2:
                    int numd;

                    Console.WriteLine("digite um número inteiro ");

                    numd = int.Parse(Console.ReadLine());


                    if (((numd % 3) == 0) && ((numd % 5) == 0))
                    {
                        Console.WriteLine("seu número é multiplo por 3,5");

                    }
                    else if (((numd % 4) == 0) && ((numd % 7) == 0))
                    {
                        Console.WriteLine("seu número é multiplo por 4,7");

                    }
                    else if ((numd % 3) == 0)
                    {
                        Console.WriteLine("seu número é divisel por 3");

                    }
                    else if ((numd % 4) == 0)
                    {
                        Console.WriteLine("seu número é divisel por 4");
                    }
                    else if ((numd % 5) == 0)
                    {
                        Console.WriteLine("seu número é divisel por 5");
                    }
                    else if ((numd % 7) == 0)
                    {
                        Console.WriteLine("seu número é divisel por 7");
                    }
                    else
                        Console.WriteLine("não é divisivel ");

                    break;

                case 3:
                    int n1, n2, n3;

                    Console.WriteLine("Digite o primeiro número: ");
                    n1 = int.Parse(Console.ReadLine()); 
                   
                    Console.WriteLine("Digite o segundo número: ");
                    n2 = int.Parse(Console.ReadLine()); 
                   
                    Console.WriteLine("Digite o terceiro número: ");
                    n3 = int.Parse(Console.ReadLine());

                    if ((n1 > n2) && (n1 > n3))
                    {
                        Console.WriteLine("O primeiro número digitado é o maior: " + n1);

                    }
                    else if ((n2 > n1) && (n2 > n3))
                    {
                        Console.WriteLine("O segundo número digitado é o maior: " + n2);

                    }
                    else if ((n3 > n1) && (n3 > n2))
                    {
                        Console.WriteLine("O terceiro número digitado é o maior: " + n3);

                    }
                    else Console.WriteLine("Os números tem o mesmo valor: " + n1 + n2 + n3 );  

                    break; 
               
                case 4:
                    int ds;

                    Console.WriteLine(" ==========MENU============ ");
                    Console.WriteLine(" 1 - domingo ");
                    Console.WriteLine(" 2 - segunda ");
                    Console.WriteLine(" 3 - terça ");
                    Console.WriteLine(" 4 - quarta ");
                    Console.WriteLine(" 5 - quinta");
                    Console.WriteLine(" 6 - sexta ");
                    Console.WriteLine(" 7 - sábado ");
                    Console.WriteLine(" ========================= ");


                    Console.WriteLine("Escolha um número entre 1 e 7 para saber as disciplinas do dia escolhido: ");
                    ds = int.Parse(Console.ReadLine());

                    switch (ds)
                    {
                        case 1:Console.WriteLine("domingo,eu durmo o dia inteiro ");
                            break;

                        case 2:Console.WriteLine("segunda:Filosofia,Portugês,Matemática");
                            break;  
                       
                        case 3:Console.WriteLine("terça:Quimica,Historia,Inglês para o mundo da Informática");
                            break;

                        case 4: Console.WriteLine("Quarta:Biologia,Português,Programação");
                            break;

                        case 5: Console.WriteLine("Quinta:Fisica,Redes,Sociologia");
                            break;

                        case 6: Console.WriteLine("Sexta:Geografia,Matemática,Banco de dados");
                            break;

                        case 7: Console.WriteLine("Sabado,Feira");
                            break;

                        default:Console.WriteLine("Mensagem Inválida");
                            break;
                          
                    }

                    break; 
              
                case 5:
                    int  parada = 2, menorvalor, maiorvalor, nm;
                   

                    menorvalor = int.MaxValue;
                    maiorvalor = int.MinValue;

                    for ( ; parada != 0; )
                    {
                        Console.WriteLine(" Digite um número: ");
                        nm = int.Parse(Console.ReadLine());
                     

                        if (nm > maiorvalor)
                        {
                            maiorvalor = nm;
                           
                        }

                        if (nm < menorvalor)
                        {
                            menorvalor = nm;
                           
                        }

                        Console.WriteLine(" Digite 0 para SAIR ou 1 para CONTINUAR ");
                        parada = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("maior número da sequência: "  + maiorvalor);
                    Console.WriteLine("menor número da sequência: " + menorvalor);

                    break; 
               
                case 6:
                    int nu, soma = 0;

                    Console.WriteLine("Digite um número inteiro: ");
                    nu = int.Parse(Console.ReadLine()); 

                     for(int i = 1; i < nu; i++)
                     {
                        if((nu % i )== 0)
                        {
                            soma = soma + i;
                        }
                     }
                     if(soma == nu)
                     {
                        Console.WriteLine("O número é perfeito");
                     }
                     else
                     {
                        Console.WriteLine("O número não é perfeito");
                     }

                    break; 
               
                case 7: Console.WriteLine("Indisponivel no seu país  :) ");
                    break;

                default:Console.WriteLine("Mensagem Inválida");
                    break;

            }
            
            Console.ReadKey();
        }
    }
}
