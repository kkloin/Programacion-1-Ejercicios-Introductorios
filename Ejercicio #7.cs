class Ejercicio7
    {
        static void Main(string[] args)
        {
            int _primerNum, _segundoNum;

            Console.WriteLine("Ingrese el primer digito:");
            _primerNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo digito:");
            _segundoNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer digito:");
            int _tercerNum = Convert.ToInt32(Console.ReadLine());

            int _numeroMax = Math.Max(_primerNum, _segundoNum);
            _numeroMax = Math.Max(_numeroMax, _tercerNum);

            Console.WriteLine("El número mayor es: " + _numeroMax);
            Console.WriteLine();

            Console.Write("Presiona cualquier tecla para salir.");
            Console.ReadLine();
        }
        
    }


