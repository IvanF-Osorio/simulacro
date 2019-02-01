using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Escrba su contrato (1 si es dependiente y 2 si es independiente)");
            double contrato = double.Parse(Console.ReadLine());

            if (contrato == 1)
            {
                Console.WriteLine("Escrba su salario");
                double salario = double.Parse(Console.ReadLine());
                double Deduccion = (salario * 40) / 100;
                if (Deduccion < 828116)
                {
                    double Pencion = (828116 * 4.0) / 100;
                    double EPS = (828116 * 4) / 100;
                    double prima = salario;
                    double salariototal = salario - Pencion - EPS;
                    double salarioanual = (salariototal * 12) + prima;
                    Console.WriteLine("Su salario anual es");
                    Console.WriteLine(salarioanual);
                }
                else
                {
                    double Pencion = (Deduccion * 4) / 100;
                    double EPS = (Deduccion * 4) / 100;
                    double prima = salario;
                    double salariototal = salario - Pencion - EPS;
                    double salarioanual = (salariototal * 12) + prima;
                    Console.WriteLine("Su salario anual es");
                    Console.WriteLine(salarioanual);
                }
            }
            else if (contrato == 2)
            {
                Console.WriteLine("Escrba su salario");
                double salario = double.Parse(Console.ReadLine());
                double Deduccion = (salario * 40) / 100;
                if (Deduccion < 828116)
                {
                    Console.WriteLine("escriba el tipo de riesgo");
                    double tipoderiesgo = double.Parse(Console.ReadLine());
                    if (tipoderiesgo == 1) {
                        double Pencion = (828116 * 16) / 100;
                        double EPS = (828116 * 12.5) / 100;
                    
                        double riesgo = (828116 *0.522) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if (tipoderiesgo == 2)
                    {
                        double Pencion = (828116 * 16) / 100;
                        double EPS = (828116 * 12.5) / 100;
          
                        double riesgo = (828116 * 1.044) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if (tipoderiesgo == 3)
                    {
                        double Pencion = (828116 * 16) / 100;
                        double EPS = (828116 * 12.5) / 100;
                     
                        double riesgo = (828116 * 2.436) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if (tipoderiesgo == 4)
                    {
                        double Pencion = (828116 * 16) / 100;
                        double EPS = (828116 * 12.5) / 100;
                    
                        double riesgo = (828116 * 4.35) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if(tipoderiesgo == 5)
                    {
                        double Pencion = (828116 * 16) / 100;
                        double EPS = (828116 * 12.5) / 100;
                       
                        double riesgo = (828116 * 6.96) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else {
                        Console.WriteLine("reinicie y escriba de 1 a 5");
                    }
                }
                else
                {
                    Console.WriteLine("escriba el tipo de riesgo");
                    double tipoderiesgo = double.Parse(Console.ReadLine());
                    if (tipoderiesgo == 1)
                    {
                        double Pencion = (Deduccion * 16) / 100;
                        double EPS = (Deduccion * 12.5) / 100;
                        double riesgo = (Deduccion * 0.522) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if (tipoderiesgo == 2)
                    {
                        double Pencion = (Deduccion * 16) / 100;
                        double EPS = (Deduccion * 12.5) / 100;
                        double riesgo = (Deduccion * 1.044) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if (tipoderiesgo == 3)
                    {
                        double Pencion = (Deduccion * 16) / 100;
                        double EPS = (Deduccion * 12.5) / 100;
                        double riesgo = (Deduccion * 2.436) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if (tipoderiesgo == 4)
                    {
                        double Pencion = (Deduccion * 16) / 100;
                        double EPS = (Deduccion * 12.5) / 100;
                        double riesgo = (Deduccion * 4.35) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else if (tipoderiesgo == 5)
                    {
                        double Pencion = (Deduccion * 16) / 100;
                        double EPS = (Deduccion * 12.5) / 100;
                        double riesgo = (Deduccion * 6.96) / 100;
                        double salariototal = salario - Pencion - EPS - riesgo;
                        double salarioanual = (salariototal * 12);
                        Console.WriteLine("Su salario anual es");
                        Console.WriteLine(salarioanual);
                    }
                    else
                    {
                        Console.WriteLine("reinicie y escriba de 1 a 5");
                    }

                }
            }
            else
            {
                Console.WriteLine("Reinicie y escriba 1 o 2 segun su contrato");
            }

        }
    }
}
