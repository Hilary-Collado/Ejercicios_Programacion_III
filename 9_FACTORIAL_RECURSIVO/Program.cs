//CALCULAR EL FACTORIAL  DE UN NUMERO DE MANERA RECURSIVA.
/*para sacar el factorial resursivo:
se multiplica el numero x el factorial del numero  - 1
ejemplo: 2! = 2* (2-1)! = 2*1!
1! = 1 * (1-1)! = 1*0! 
 0! = 1;
entonces tendriamos = 1 * 1 = 1; 2*1 = 2;*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Programa que calcula el factorial de numeros enteros positivos---\n");
        int num = 0;
        bool b = false;
        do
        {
            do
            {
                try
                {
                    b = false;
                    Console.WriteLine("Ingrese un numero entero positivo");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.WriteLine("\nNo existe factorial para numeros negativos | intentalo otra vez\n");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nHubo un error\n");
                    b = true;
                }
            } while (num < 0);
            
        } while (b == true);

        Console.WriteLine("\nEl factorial recursivo de " + num + " es: " + factorialRecursivo(num));

        Console.ReadKey();

    }

    static int factorialRecursivo(int num2)
    {
        if (num2 == 0)
        {
            num2 = 1;
        }
        else
        {
            num2 *= factorialRecursivo(num2 - 1);
        }
        return num2;
    }

}