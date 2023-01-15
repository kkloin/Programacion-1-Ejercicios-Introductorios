class Ejercicio3 {

    public static void Main (string[] args) {
    int _numEntero;
    int _primerDig;
    int _segundoDig;

    Console.WriteLine("Ingrese un numero entero de dos digitos: ");
    _numEntero = Convert.ToInt32(Console.ReadLine());

    _primerDig = _numEntero / 10;
    _segundoDig = _numEntero % 10;

    if (numPrimo(_primerDig) && numPrimo(_segundoDig)) {
      Console.WriteLine("Los dos digitos son primos.");
    } else {
      Console.WriteLine("Uno o ambos digitos del numero enetero no son primos.");
    }

    Console.WriteLine("Presiona cualquier tecla para continuar.");
    Console.ReadKey();
  }
  public static bool numPrimo(int number) {
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;
    for (int i = 3; i <= Math.Sqrt(number); i += 2) {
      if (number % i == 0) return false;
    }
    return true;
  }
}
