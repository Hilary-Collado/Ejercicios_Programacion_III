//REALICE UN PROGRAMA EN C# QUE  UTILIZANDO LA CLASE MATCH CON CUALESQUIERA DE SUS METODOS, YA SEA VALOR ABSOLUTO.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Programa que calcula la raiz cubica de un numero--\n");
        int valor = 0;
        bool re = true;
        do
        {
            do
            {
                try
                {
                    re = true;
                    Console.WriteLine("Ingresa un valor");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor < 0)
                    {
                        Console.WriteLine("\nNo se admiten numeros negativos\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nOcurrió un error " + e);
                    re = false;
                }

            } while (valor < 0);
        } while (re == false);
        
        //calculando la raiz cubica
        double raiz = Math.Cbrt(valor);

        Console.WriteLine("\nLa raiz cubica de " + valor + " es: " + raiz);

    }
}