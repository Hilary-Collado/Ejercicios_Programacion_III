//DADO UN NUMERO ENTERO POSITIVO CONVERTIRLO A LETRAS.

class Program
{
    static void Main(string[] args)
    {
        string[] num1 = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        string[] num2 = { "diez", "once", "doce", "trece", "catorce", "quince" };
        string[] num3 = { "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        string[] num4 = { "cien", "ciento", "cientos" };
        string[] num5 = { "quinientos", "sete", "nove" };

        Console.WriteLine("--Programa que da el equivalente en letras de un numero entero");

        int unidad, decena, centena, a = 0;
        string num_unidad = " ", num_decena = "", num_centena = "";
        bool cont = false;
        do
        {
            do
            {
                Console.WriteLine("\ningrese un valor");
                try
                {
                    cont = false;
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < 0 || a > 999)
                    {
                        Console.WriteLine("\nel valor excede el limite | prueba otra vez");
                    }
                    else
                    {
                        unidad = a % 10;
                        decena = (a % 100 - a % 10) / 10;
                        centena = (a % 1000 - a % 100) / 100;

                        //unidad
                        for (int i = 0; i <= unidad; i++)
                        {
                            if (i == unidad) num_unidad = num1[i];
                        }

                        //decena
                        for (int i = 0; i <= decena; i++)
                        {
                            if (i == decena)
                            {   //diez
                                if (decena == 1 && unidad == 0) num_decena = num2[0];

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                    || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 1)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                    || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 2)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                    || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 3)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                     || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 4)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                    || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 5)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                     || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 6)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                    || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 7)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                 || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 8)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                                else if ((decena == 1 || decena == 2 || decena == 3 || decena == 4 || decena == 5
                                    || decena == 6 || decena == 7 || decena == 8 || decena == 9) && unidad == 9)
                                {
                                    if (decena == 1) num_decena = num2[0];
                                    else if (decena == 2) num_decena = num3[0];
                                    else if (decena == 3) num_decena = num3[1];
                                    else if (decena == 4) num_decena = num3[2];
                                    else if (decena == 5) num_decena = num3[3];
                                    else if (decena == 6) num_decena = num3[4];
                                    else if (decena == 7) num_decena = num3[5];
                                    else if (decena == 8) num_decena = num3[6];
                                    else if (decena == 9) num_decena = num3[7];
                                }

                            } //fin if decena

                        }

                        //centena
                        for (int e = 0; e <= centena; e++)
                        {
                            if (e == centena)
                            {
                                if (centena == 1 && unidad == 0) num_centena = num4[0];
                                else if (centena == 1 && unidad != 0) num_centena = num4[1];
                                else if ((centena == 2 || centena == 3 || centena == 4
                                        || centena == 6 || centena == 8) && unidad != 0) num_centena = num1[e] + num4[2];
                                else
                                {
                                    if (centena == 5 && unidad != 0) num_centena = num5[0];
                                    else if (centena == 7 && unidad != 0) num_centena = num5[1] + num4[2];
                                    else if (centena == 9 && unidad != 0) num_centena = num5[2] + num4[2];
                                }

                            }
                        }//fin del for
                        if (unidad != 0 && decena != 0)
                        {
                            Console.WriteLine(num_centena + " " + num_decena + " y " + num_unidad);
                        }
                        else if (unidad == 0)
                        {
                            Console.WriteLine(num_centena + " " + num_decena);
                        }
                        else
                        {
                            Console.WriteLine(num_centena + " " + num_decena + " " + num_unidad);
                        }

                    }//fin del else

                }
                catch (Exception e)
                {
                    cont = true;
                    Console.WriteLine("\nhubo un error " + e);
                }
            } while (a < 0 || a > 999);
        } while (cont == true);
    }//fin del main

}//fin de la clase