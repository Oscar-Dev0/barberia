using System;

class Barberia
{
    static void Main(string[] args)
    {
        var Usuario = ""; // Variable para almacenar el nombre del usuario
        var opcion = ""; // Variable para almacenar la opción seleccionada

        Console.WriteLine("Bienvenido al salón 10-10 \nColegio Albertazzi");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Puedes proporcionarme tu nombre.");
        Usuario = Console.ReadLine(); // Se solicita al usuario que ingrese su nombre
        Console.Clear();

        do
        {
            Console.Clear();
            Console.WriteLine("{0}, Dime cuál servicio necesitas\nOpciones: \n A- barbería\n B- estilismo\n C- manicura \n F- salir", Usuario);
            opcion = Console.ReadLine(); // Se solicita al usuario que seleccione una opción
            Console.Clear();

            if (opcion.ToLower() == "a")
            {
                var pelo = ""; // Variable para almacenar el estado del pelo
                var barba = ""; // Variable para almacenar el estado de la barba

                Console.WriteLine("{0}, aquí te dejo las opciones de la barbería\n A- Corte de pelo: ¢3500 \n B- Corte de pelo y barba: ¢5000\n C- Corte de barba y limpieza facial: ¢3000", Usuario);
                opcion = Console.ReadLine(); // Se solicita al usuario que seleccione una opción

                switch (opcion.ToLower())
                {
                    case "a":
                        barberia(ref pelo, ref barba, "corte"); // Se llama a la función Barberia para realizar un corte de pelo
                        Console.WriteLine("{0}, ahora tu pelo está {1}", Usuario, pelo);
                        break;
                    case "b":
                        barberia(ref pelo, ref barba, "corte/barba"); // Se llama a la función Barberia para realizar un corte de pelo y barba
                        Console.WriteLine("{0}, ahora tienes {1} y {2}", Usuario, barba, pelo);
                        break;
                    case "c":
                        barberia(ref pelo, ref barba, "barba/limp"); // Se llama a la función Barberia para realizar un corte de barba y limpieza facial
                        Console.WriteLine("{0}, ahora tu barba está {1}", Usuario, barba);
                        break;
                }
            }
            else if (opcion.ToLower() == "b")
            {
                var pelo = ""; // Variable para almacenar el estado del pelo
                var rostro = ""; // Variable para almacenar el estado del rostro

                Console.WriteLine("{0}, aquí te dejo las opciones de servicio de estilismo\n A- Teñido de pelo: ¢2500 \n B- Lavado de pelo: ¢1500 \n C- Limpieza facial: ¢1200", Usuario);
                opcion = Console.ReadLine(); // Se solicita al usuario que seleccione una opción

                switch (opcion.ToLower())
                {
                    case "a":
                        Estilista("teñido", ref pelo); // Se llama a la función Estilista para realizar un teñido de pelo
                        Console.WriteLine("{0}, ahora tienes el pelo teñido de color {1}.", Usuario, pelo);
                        break;
                    case "b":
                        Estilista("lavado", ref pelo); // Se llama a la función Estilista para realizar un lavado de pelo
                        Console.WriteLine("{0}, ahora tienes el pelo {1}.", Usuario, pelo);
                        break;
                    case "c":
                        Estilista("limpieza", ref rostro); // Se llama a la función Estilista para realizar una limpieza facial
                        Console.WriteLine("{0}, ahora tienes el rostro {1}.", Usuario, rostro);
                        break;
                }
            }
            else if (opcion.ToLower() == "c")
            {
                var uñas = ""; // Variable para almacenar el estado de las uñas

                Console.WriteLine("{0}, aquí te dejo las opciones de manicura\n A- Pedicura: ¢6000 \n B- Poner uñas: ¢4000 \n C- Pintar uñas: ¢1500", Usuario);
                opcion = Console.ReadLine(); // Se solicita al usuario que seleccione una opción

                switch (opcion.ToLower())
                {
                    case "a":
                        Manicura("pedicura", ref uñas); // Se llama a la función Manicura para realizar una pedicura
                        Console.WriteLine("{0}, ahora tienes las uñas {1}.", Usuario, uñas);
                        break;
                    case "b":
                        Manicura("poner uñas", ref uñas); // Se llama a la función Manicura para poner uñas
                        Console.WriteLine("{0}, ahora tienes las uñas puestas.", Usuario);
                        break;
                    case "c":
                        Manicura("pintar uñas", ref uñas); // Se llama a la función Manicura para pintar las uñas
                        Console.WriteLine("{0}, ahora tienes las uñas pintadas de color {1}.", Usuario, uñas);
                        break;
                }
            }
        } while (opcion.ToLower() != "f");
    }

    // Función para realizar diferentes cortes de pelo y barba
    public static void barberia(ref string pelo, ref string barba, string option)
    {
        switch (option)
        {
            case "corte":
                pelo = "corto";
                break;
            case "corte/barba":
                barba = "barba corta";
                pelo = "pelo corto";
                break;
            case "barba/limp":
                barba = "corta y limpia";
                break;
        }
    }

    // Función para realizar diferentes servicios de estilismo
    public static void Estilista(string option, ref string variable)
    {
        Console.Clear();
        switch (option)
        {
            case "teñido":
                Console.WriteLine("De qué color quieres el pelo?");
                variable = Console.ReadLine();
                break;
            case "lavado":
                variable = "lavado";
                break;
            case "limpieza":
                variable = "limpia la cara";
                break;
            default:
                variable = string.Empty;
                break;
        }
    }

    // Función para realizar diferentes servicios de manicura
    public static void Manicura(string option, ref string variable)
    {
        switch (option)
        {
            case "pedicura":
                variable = "limpias";
                break;
            case "poner uñas":
                variable = "uñas postizas";
                break;
            case "pintar uñas":
                Console.WriteLine("De qué color quieres las uñas?");
                variable = Console.ReadLine();
                break;
        }
    }
}
