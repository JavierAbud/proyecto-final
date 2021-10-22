using System;


namespace proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrada mientrada = new Entrada();
            mientrada.Start();

        backorder:
            Int32 platanos = 25, yuca = 30, guineo = 5, papa = 25, cebolla = 5;
            Int32 jugo = 25, soda = 15;
            Int32 total = 0;
            

            //login




            //punto de venta
            Console.WriteLine("");
            Console.WriteLine("Seleccione el tipo de producto que desa adquirir");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("1-   Platanos   " + platanos.ToString("0"));
            Console.WriteLine("2-   Yuca   " + yuca.ToString("0"));
            Console.WriteLine("3-   guineo   " + papa);
            Console.WriteLine("4-   cebolla   " + cebolla);
            Console.WriteLine("5-   jugo   " + jugo);
            Console.WriteLine("6-   soda   " + soda);


            byte x = Convert.ToByte(Console.ReadLine());
            if (x == 1)
            {
                total = total + platanos;
                Console.WriteLine("   platanos   " + total.ToString("0"));
                Console.WriteLine("\n\n");
                goto backorder;
            }
            else if(x == 2)
            {
                total = total + yuca;
                Console.WriteLine("   Yuca   " + total.ToString("0"));
                goto backorder;
            }
            else if (x == 3)
            {
                total = total + guineo;
                Console.WriteLine("   guineo   " + total.ToString("0"));
                goto backorder;
            }

            else if (x == 4)
            {
                total = total + cebolla;
                Console.WriteLine("   cebolla   " + total.ToString("0"));
                goto backorder;
            }

            else if (x == 5)
            {
                total = total + jugo;
                Console.WriteLine("   jugo   " + total.ToString("0"));
                goto backorder;
            }

            else if (x == 6)
            {
                total = total + soda;
                Console.WriteLine("   soda   " + total.ToString("0"));
                goto backorder;
            }


            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
