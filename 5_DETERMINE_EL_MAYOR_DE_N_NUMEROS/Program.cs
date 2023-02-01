//REALICE UN PROGRAMA C# QUE DETERMINE EL MAYOR DE N NUMEROS DIGITADOS POR EL TECLADO Y CALCULE LA MEDIA.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Programa identificar el valor mayor--\n");

        int cant = 0, num = 0, v = 0, Sum = 0;
        double media = 0;
        char c = '¿', c2 = '?';
        bool rem = true;
        Console.WriteLine(c + "Cuantos numeros desea digitar" + c2);
        cant = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[cant];
        do
        {
            try
            {
                rem = true;

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("ingrese el valor " + (i+1));
                    num = Convert.ToInt32(Console.ReadLine());
                    array[i] = num;
                    Sum += array[i];
                }
                Console.WriteLine("");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("El valor " + (i+1) + " es: " + array[i]);
                }

                v = array.Max();
                media = (double)Sum / (double)cant;

            }
            catch (Exception e)
            {
                rem = false;
                Console.WriteLine("Ocurrió un error " + e);
            }
        } while (rem == false);
        
            Console.WriteLine("\nEl valor mayor es: " + v);
        Console.WriteLine("\nLa media es: " + media);

            
        Console.ReadKey();
    }
}