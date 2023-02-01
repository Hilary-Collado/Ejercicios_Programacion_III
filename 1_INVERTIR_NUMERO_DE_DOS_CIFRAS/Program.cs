//REALICE UN PROGRAMA EN C# PARA INVERTIR NÚMERO DE DOS CIFRAS DIGITADOS POR TECLADO.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Programa que invirte el orden de un valor--");

        int n1 = 0, unidad, decena;
        bool res = true;
        do
        {
            try
            {
                res = true;
                Console.WriteLine("Ingresa un digito de dos cifras");
                n1 = Convert.ToInt32(Console.ReadLine());

                if (n1 < 10 || n1 > 99)
                {
                    Console.WriteLine("el numero no coincide | intentalo otra vez");
                }
                else
                {
                    unidad = n1 % 10;
                    decena = (n1 % 100 - unidad) / 10;
                    Console.WriteLine("\nel numero es: " + n1 + "\nel numero invertido es: " + unidad + decena);
                }
            }
            catch (Exception e)
            {
                res = false;
                Console.WriteLine("Ocurrió un error " + e);
            }
        } while (n1 < 10 || n1 > 99);

        Console.ReadKey();
    }
}
