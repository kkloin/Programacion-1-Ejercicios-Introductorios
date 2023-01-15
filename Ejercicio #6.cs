class Ejercicio6
    {
        static void Main(string[] args)
        {
            int _num;
            int _primerDig;
            int _segundoDig;
            int _tercerDig;

            Console.WriteLine("Ingrese un numero de 3 digitos:");
            _num = Convert.ToInt32(Console.ReadLine());

             _primerDig = _num / 100;
             _segundoDig = (_num / 10) % 10;
             _tercerDig = _num % 10;

            if (_primerDig % _segundoDig == 0 || _segundoDig % _tercerDig == 0 || _primerDig % _tercerDig == 0 || _segundoDig % _primerDig == 0 || _tercerDig % _segundoDig == 0 || _tercerDig % _primerDig == 0)
            {
                Console.WriteLine("Uno de los digitos es multiplo de otros.");
            }
            else
            {
                Console.WriteLine("Ninguno de los digitos es multiplo de otros.");
            }
            Console.WriteLine();
            Console.Write("Pulsa cualquier tecla para salir.");
            Console.ReadLine();
        }
    }
        


