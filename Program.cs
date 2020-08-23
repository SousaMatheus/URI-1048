    using System;
    using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, ganho;
            int percentual;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            
            if (salario ==0 || salario < 400.00){
                novoSalario = salario * 1.15;
                ganho = novoSalario - salario;
                percentual = 15;
                
            } else if (salario >= 400.01 && salario <= 800.00){
                novoSalario = salario * 1.12;
                ganho = novoSalario - salario;
                percentual = 12;
            } else if (salario >= 800.01 && salario <= 1200.00){
                novoSalario = salario * 1.10;
                ganho = novoSalario - salario;
                percentual = 10;
            } else  {
                novoSalario = salario * 1.07;
                ganho = novoSalario - salario;
                percentual = 7;
            }   

            Console.WriteLine("Novo salario: "+ novoSalario.Tostring("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: "+ ganho.Tostring("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
