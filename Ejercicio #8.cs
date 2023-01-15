class Ejercicio8
    {
        static void Main(string[] args)
        {
            int _num;
            int _primerDig;
            int _segundoDig;
            int _tercerDig;
            int _cuartoDig;
            int _quintoDig;

            Console.WriteLine("Ingrese un numero de 5 digitos:");
            _num = Convert.ToInt32(Console.ReadLine());

             _primerDig = _num / 10000;
             _segundoDig = (_num / 1000) % 10;
             _tercerDig = (_num / 100) % 10;
             _cuartoDig = (_num / 10) % 10;
             _quintoDig = _num % 10;

            if (_primerDig == _quintoDig && _segundoDig == _cuartoDig)
            {
                Console.WriteLine("El numero ingresado es una capicua.");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es una capicua.");
            }
            Console.WriteLine();
            Console.Write("Presiona cualquier teecla para continuar.");
            Console.ReadKey();
        }
    }

