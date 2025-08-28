using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Expresion Lambda en funcion ");
        //Func<int, int> b = (a) => a * 2;

        // int resultado = b(4);

        //Console.WriteLine("El resuotado es: " + resultado);

        //Func<int, int, int > suma (a, b) => a + b;
        //int resultado = suma(4, 6);
        //Console.WriteLine("el resultado es:" + resultado);

        //Func<int, int, int> mayor (a, b) =>
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else
        //    {

        //        return b;
        //    }



        //};

        //int resultado = suma(4, 6);
        //Console.WriteLine("el resultado es:" + resultado);


        //Console.WriteLine("Funcones Lambda");
        //Persona pers = new Persona();
        //int edad = 18;
        //edad++;
        //edad++;

        //Console.WriteLine("El  valor de la variable edad es: " + edad);
        //Console.WriteLine("La direccion de memmoria es: " +);
        //unsafe
        //{

        //    int* puntero = &edad;
        //    Console.WriteLine((IntPtr)puntero);
        //}

        var numeros = new List<int> { 8, 5, 9, 6, 4, 7, 4, 7 };
        Func<int, bool> ObtenerPares = (num) => num % 2 == 0;
        var pares = numeros.Where(ObtenerPares);
        Console.WriteLine("Hola");








        Console.ReadKey();
    }
}