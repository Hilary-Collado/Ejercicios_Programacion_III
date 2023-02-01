//REALICE UN PROGRAMA EN C# DADO DOS NUMEROS SIMULE O REALICE LAS OPERACIONES BASICAS. SUMA, RESTA, MULTIPLICACION Y DIVISION.

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("--Programa: Operaciones basicas");

        int num1 = 0, num2 = 0, suma = 0, resta = 0, multiplicacion = 0, division = 0;
        bool ren = true;
        do
        {
            try
            {
                ren = true;
                
                Console.WriteLine("Ingrece dos numeros");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                suma = num1 + num2;
                resta = num1 - num2;
                multiplicacion = num1 * num2;
                division = num1 / num2;

            }
            catch (Exception e)
            {
                ren = false;
                Console.WriteLine("\nOcurrió un error " + e);
            }

        } while (ren == false);

        Console.WriteLine("Los numeros son: " + num1 + " y " + num2);
        Console.WriteLine("\nEl resultado es:\nSuma: " + suma +
            "\nResta: " + resta +
            "\nMultiplicacion: " + multiplicacion +
            "\nDivision: " + division);


        Console.ReadKey();
    }
}