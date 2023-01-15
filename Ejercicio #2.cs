class Ejercicio2 {
  public static void Main (string[] args) {
    int _num;

    Console.WriteLine("Ingresa un número entero de dos dígitos:");
    _num = Convert.ToInt32(Console.ReadLine());

    if (_num < 0) {
        Console.WriteLine("El número ingresado es negativo");
    } else {
        if (numPrimo(_num)) {
            Console.WriteLine("El número ingresado es primo");
        } else {
            Console.WriteLine("El número ingresado no es primo");
        }
    }

    Console.WriteLine("Presiona cualquier tecla para continuar.");
    Console.ReadKey();
  }

  public static bool numPrimo(int _num) {
      if (_num < 2) return false;
      for (int i = 2; i <= _num / 2; i++) {
          if (_num % i == 0) return false;
      }
      return true;
  }
}