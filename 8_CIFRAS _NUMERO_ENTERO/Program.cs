//CREAR UN PROGRAMA CALCULE CUANTAS CIFRAS TIENE UN NÚMERO ENTERO POSITIVO

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Programa que cuenta las cifras de un valor-- ");

        bool ter = true;
        int numero, con = 0;
        do
        {
            try
            {
                do
                {
                    ter = true;
                    Console.WriteLine("\nIntroduce un número entero positivo: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < 0)
                    {
                        Console.WriteLine("el valor no es entero positivo\n");
                    }
                    else
                    {
                        while (numero > 0)
                        {
                           numero /= 10;
                            con++;
                        }
                    }


                } while (numero < 0);
            }catch(Exception e)
            {
                ter = false;
                Console.WriteLine("\nHubo un error " + e);
            }

        } while (ter == false);

        Console.WriteLine("\nEl número de digitos es " + con);

        Console.ReadKey();
    }
}
