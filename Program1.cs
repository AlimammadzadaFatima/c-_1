using System;

namespace EvTapsirigi
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Verilmis array - deki reqemlerinin cemi 10 - dan kicik olan ededlerin sayini tapan alqoritm
            //int[] numbers = { 12, 39, 47, 51, 6, 124, 99 };
            //var say = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    var num1 = numbers[i];
            //    var digit = 0;



            //    while (num1 > 0)
            //    {
            //        var digit1 = num1 % 10;
            //        digit += digit1;
            //        num1 = (num1 - digit1) / 10;
            //    }

            //    if (digit < 10)
            //    {
            //        say++;
            //    }
            //}
            //if (say > 0)
            //{
            //    Console.WriteLine(say);
            //}
            //else
            //{
            //    Console.WriteLine("siyahida bele eded yoxdur");
            //}

            //2. 1-den 8000-dek ededler icerisinde cut olanlarin sayini tapan proqram
            //var cut = 0;
            //for (int i = 1; i < 8000; i++)

            //{
            //    //var cut = 0;
            //    if (i % 2 == 0)
            //     cut++; 


            //  else
            //    { continue; }

            //}
            //{
            //    Console.WriteLine("1-den 8000-dek ededler icerisinde "+cut+" sayda cut eded var.");
            //}
            //3. Verilmis ededin en yaxin asagi kokalti deyerini tapan alqoritm
            //(kecen ders etdiyimize uygun, misalcun eded 20-dirse 4 qaytarmalidi, 25-dise 5 qaytarmalidi, 16-drisa 4 ve s.)
            int i =45;
            for (int n = 0; n < i; n++)
            {
                if (n * n <= i)
                { continue; }
                else
                    n = n - 1;
                { Console.WriteLine("verilmis edede en yaxin asagi kokalti deyeri "+n+"-dir.");  }
                break;
            }

        }












    }
    }
