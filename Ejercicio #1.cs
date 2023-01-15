class Ejercicio1 {
  public static void Main (string[] args) {
    int _dig;
    int _suma;
    int _dig1;
    int _dig2;

    Console.WriteLine("Ingresa un número entero de dos dígitos:");
    _dig = Convert.ToInt32(Console.ReadLine());

    _dig1 = _dig / 10;
    _dig2 = _dig % 10;
    _suma = _dig1 + _dig2;

    Console.WriteLine("La suma de los dígitos del número ingresado es: " + _suma);

    Console.WriteLine("Presiona cualquier tecla para continuar.");

    Console.ReadKey();
  }
}



