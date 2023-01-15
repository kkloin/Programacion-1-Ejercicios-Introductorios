class Ejercicio5 {
    public static void Main (string[] args) {
    
    int _num;
    int _primerDigito;
    int _segundoDigito;
    int _tercerDigito;

Console.WriteLine("Ingresa un numero entero de 3 digitos:");
_num = Convert.ToInt32(Console.ReadLine());

_tercerDigito = _num % 10;
_num = _num / 10;

_segundoDigito = _num % 10;
_num = _num / 10;

_primerDigito = _num % 10;

if (_primerDigito > _segundoDigito && _primerDigito > _tercerDigito)
{
    Console.WriteLine("El digito mayor está en la primera posición."); 
}
else if (_segundoDigito > _primerDigito && _segundoDigito > _tercerDigito)
{
    Console.WriteLine("El digito mayor está en la segunda posición."); 
}
else
{
    Console.WriteLine("El digito mayor está en la tercera posición."); 
}
    Console.WriteLine("Presiona cualquier tecla para continuar.");
    Console.ReadKey();
    }
}