class Ejercicio9
    {
        static void Main(string[] args)
        {
            int _num;
            int _penDig;
            int _segundoDig;

            Console.WriteLine("Ingrese un numero de 4 digitos:");
            _num = Convert.ToInt32(Console.ReadLine());

            _segundoDig = (_num / 100) % 10;
            _penDig = (_num / 10) % 10;

            if (_segundoDig == _penDig)
            {
                Console.WriteLine("El segundo digito es igual al penultimo digito.");
            }
            else
            {
                Console.WriteLine("El segundo digito no es igual al penultimo digito.");
            }
            Console.WriteLine();
            Console.Write("Pulsa cualquier tecla para salir.");
            Console.ReadLine();
        }
    }