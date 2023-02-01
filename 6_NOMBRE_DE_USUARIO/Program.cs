//CREAR UN PROGRAMA QUE PIDA AL USUARIO SU NOMBRE, Y LE DIGA "HOLA" SI SE LLAMA "DAVID", O BIEN LE DIGA "NO TE CONOZCO" SI TECLEA OTRO NOMBRE.
class Program
{
    static void Main(string[] args)
    {
        bool ter = true;
        do
        {   
            try
            {
                Console.WriteLine("ingresa tu nombre");
                string user = Console.ReadLine();

                string D1 = "DAVID", D2 = "david", D3 = "David";


                if (user != D1 && user != D2 && user != D3)
                {
                    Console.WriteLine("\nNo te conosco");
                }
                else
                {
                    Console.WriteLine("\nHola");
                }
            }
            catch (IOException e)
            {
                ter = false;
                Console.WriteLine("Ocurrió un error " + e);
            }

        } while (ter == false);
        
        Console.ReadKey();
        
    }
}