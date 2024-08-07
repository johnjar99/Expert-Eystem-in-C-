// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    private int n_lados; // Variable miembro de la clase
    private int n_lados_paralelos; // Variable miembro de la clase

    static void Main(string[] args)
    {
        Program myObject = new Program();
        Console.WriteLine("Este es un ejemplo de sistema experto que " +
        "nos permitirá adivinar un polígono que piense el usuario");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("¿Cuántos lados tiene el polígono?");
        String entrada = Console.ReadLine();

        if (entrada != null)
        {
            int lados = myObject.lados(entrada);

            switch (lados)
            {
                case 3:
                    Console.WriteLine("¿Tiene un ángulo rectángulo?");
                    entrada = Console.ReadLine();

                    if (entrada != null && entrada.ToLower() == "si")
                    {
                        Console.WriteLine("El polígono que ha pensado es un triángulo rectángulo.");
                    }
                    else
                    {
                        Console.WriteLine("¿Tiene dos lados iguales?");
                        entrada = Console.ReadLine();

                        if (entrada != null && entrada.ToLower() == "si")
                        {
                            Console.WriteLine("El polígono pensado es un triángulo isósceles.");
                        }
                        else
                        {
                            Console.WriteLine("El polígono pensado es un triángulo irregular.");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("¿Cuántos lados paralelos tiene?");
                    entrada = Console.ReadLine();

                    if (entrada != null)
                    {
                        int lados_para = myObject.lados_paralelos(entrada);

                        switch (lados_para)
                        {
                            case 2:
                                Console.WriteLine("El polígono pensado es un trapecio.");
                                break;
                            case 4:
                                Console.WriteLine("¿Son todos los lados iguales?");
                                entrada = Console.ReadLine();

                                if (entrada != null && entrada.ToLower() == "si")
                                {
                                    Console.WriteLine("¿Son todos los ángulos de 90?");
                                    entrada = Console.ReadLine();

                                    if (entrada != null && entrada.ToLower() == "si")
                                    {
                                        Console.WriteLine("El polígono pensado es un cuadrado.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El polígono pensado es un rombo.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El polígono pensado es un rectángulo.");
                                }
                                break;
                            default:
                                Console.WriteLine("No se puede determinar el polígono con el número de lados paralelos proporcionado.");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("No se puede determinar el polígono con el número de lados proporcionado.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
    }

    public int lados(String lados)
    {
        switch (lados)
        {
            case "3":
                n_lados = 3;
                break;
            case "4":
                n_lados = 4;
                break;
            default:
                n_lados = 0;
                break;
        }
        return n_lados;
    }

    public int lados_paralelos(String lados)
    {
        switch (lados)
        {
            case "2":
                n_lados_paralelos = 2;
                break;
            case "4":
                n_lados_paralelos = 4;
                break;
            default:
                n_lados_paralelos = 0;
                break;
        }
        return n_lados_paralelos;
    }
}

