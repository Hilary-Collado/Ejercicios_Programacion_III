//PROGRAMA EN C# QUE DADO UN NUMERO DEL 1-7 NOS DIGA QUE DIA DE LA SEMANA CORRESPNDE. USAR SWITCH-CASE.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Dias de la semana--");
        int num = 0;
        bool tre = true;

        do
        {
            do
            {

                try
                {
                    tre = true;
                    Console.WriteLine("\nIngresa un numero entre 1 y 7");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num <= 0 || num >= 8)
                    {
                        Console.WriteLine("el numero ingresado debe estar entre 1 y 7");
                    }
                    else
                    {
                        Console.WriteLine("\nEl Dia es: ");
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("\nDomingo");
                                break;
                            case 2:
                                Console.WriteLine("\nLunes");
                                break;
                            case 3:
                                Console.WriteLine("\nMartes");
                                break;
                            case 4:
                                Console.WriteLine("\nMiercoles");
                                break;
                            case 5:
                                Console.WriteLine("\nJueves");
                                break;
                            case 6:
                                Console.WriteLine("\nViernes");
                                break;
                            case 7:
                                Console.WriteLine("\nSabado");
                                break;
                        } //fin switch
                    } //fin else
                }
                catch (Exception e)
                {
                    tre = false;
                    Console.WriteLine("\nel valor ingresado no coincide\n" + e);
                }

            } while (num <= 0 || num >= 8);
            
        } while (tre == false);

        Console.ReadKey();
    }
}