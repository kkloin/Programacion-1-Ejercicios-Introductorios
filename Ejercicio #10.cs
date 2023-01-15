class Ejercicio10
    {
        static void Main(string[] args)
        {
            int _num1;
            int _num2;
            int _numMenor;
            int _numMayor;

            Console.WriteLine("Ingrese el primer numero:");
            _num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            _num2 = Convert.ToInt32(Console.ReadLine());
            
            if (_num1 > _num2)
            {
                _numMayor = _num1;
                _numMenor = _num2;
            }
            else
            {
                _numMayor = _num2;
                _numMenor = _num1;
            }
            if ((_numMayor - _numMenor) <= 10)
            {
                Console.WriteLine("La secuencia de numeros es:");
                for (int i = _numMenor; i <= _numMayor; i++)
                {
                    Console.WriteLine(i);
                }
                
            } 
            else 
            {
                Console.WriteLine("La diferencia entre los numeros es mayor a 10.");
            }
            
            Console.WriteLine();
            Console.Write("Pulsa cualquier tecla para salir.");
            Console.ReadLine();
        }
    }

