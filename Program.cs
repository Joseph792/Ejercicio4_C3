// See https://aka.ms/new-console-template for more information
            int n;
            Console.Write("Ingrese un numero del 1 al 7: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("El dia es lunes.");
            }

            if (n == 2)
            {
                Console.WriteLine("El dia es martes.");
            }
            
            if (n == 3)
            {
                Console.WriteLine("El dia es miercoles.");
            }

            if (n == 4)
            {
                Console.WriteLine("El dia es jueves.");
            }

            if (n == 5)
            {
                Console.WriteLine("El dia es viernes.");
            }

            if (n == 6)
            {
                Console.WriteLine("El dia es sabado.");
            }

            if (n == 7)
            {
                Console.WriteLine("El dia es domingo.");
            }

            Console.ReadKey();
