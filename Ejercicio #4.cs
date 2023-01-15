class Ejercicio4 {
  public static void Main (string[] args) {
    int _num1;
    int _num2;
    int _suma;

    Console.WriteLine("Ingresa el primer numero entero de dos digitos: ");
     _num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el segundo numero entero de dos digitos: ");
     _num2 = Convert.ToInt32(Console.ReadLine());

    _suma = _num1 + _num2;

    if (_suma % 2 == 0) {
        Console.WriteLine(string.Format("La suma es de los dos numeros es: {0}", _suma + ", y es un numero par."));
    } else {
        Console.WriteLine(string.Format("La suma es de los dos numeros es: {0}", _suma + ", y no es un numero par."));
    }

    Console.WriteLine("Presiona cualquier tecla para continuar.");
    Console.ReadKey();
  }
}
