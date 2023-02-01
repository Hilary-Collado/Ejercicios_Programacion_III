//REALICE UN PROGRAMA EN C# PARA INVERTIR NÚMERO DE TRES CIFRAS DIGITADOS POR TECLADO.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Programa que invierte el orden de un valor");

        int n1 = 0, unidad, decena, centena;
        bool ress = true;

        do
        {
            try
            {
                ress = true;

                Console.WriteLine("\nIngresa un digito de tres cifras");
                n1 = Convert.ToInt32(Console.ReadLine());

                if (n1 < 100 || n1 > 999)
                {
                    Console.WriteLine("\nEl numero no coincide | intentalo otra vez");
                }
                else
                {
                    unidad = n1 % 10;
                    decena = (n1 % 100 - unidad) / 10;
                    centena = (n1 % 1000 - n1 % 100) / 100;
                    Console.WriteLine("\nel numero es: " + n1 + "\nel numero invertido es: " + unidad + decena + centena);
                }
            }
            catch (Exception e)
            {
                ress = false;
                Console.WriteLine("Hubo un error " + e);
            }
        } while (n1 < 100 || n1 > 999);

        Console.ReadKey();
    }
}