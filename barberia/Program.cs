class barberia
{
    static void Main(string[] args)
    {
        var Usuario = "";

        var uñas = "";


        var opcion = "";


        Console.WriteLine("Bienvenido al salon 10-10 \nColegio Albertazzi");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Puedes proporcionarme tu nombre.");
        Usuario = Console.ReadLine();
        Console.Clear();
        do {
            Console.WriteLine("{0}, Dime cual servicio nesecitas\nOpciones: \n A- barberia\n B- Estilismo\n C- Manicura \n F- Salir", Usuario);
            opcion = Console.ReadLine();
            Console.Clear();


            if (opcion.ToLower() == "a")
            {
                var pelo = "";
                var barba = "";

                Console.WriteLine("{0}, aca te dejo las opciones de la barberia\n A- Corte de pelo: ¢3500 \n B- Corte de pelo y barba: ¢5000\n C- Corte de barba y Limpiza facial: ¢3000", Usuario);
                opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "a":
                        Barberia(ref pelo, ref barba, "corte");
                        Console.WriteLine("{0}, ahora tu pelo esta {1}", Usuario, pelo);
                        break;
                    case "b":
                        Barberia(ref pelo, ref barba, "corte/barba");
                        Console.WriteLine("{0}, ahora esta tu con {1} y {2}", Usuario, barba, pelo);
                        break;
                    case "c":
                        Barberia(ref pelo, ref barba, "barba/limp");
                        Console.WriteLine("{0}, Ahora tu barba esta {1}", Usuario, barba);
                        break;
                };
            }
            else if (opcion.ToLower() == "b")
            {
                var pelo = "";
                var rostro = "";

                Console.WriteLine("{0}, Aca te dejo las opciones de servicio de Estilismo\n A- Teñido de pelo: ¢2500 \n B- Lavado de pelo: ¢1500 \n C- Limpiza facial: ¢1200", Usuario);
                opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "a":
                        Estilista("teñido", ref pelo);
                        Console.WriteLine("{0}, Ahora tienes el pelo teñido de color {1}.", Usuario, pelo);
                        break;
                    case "b":
                        Estilista("lavado", ref pelo);
                        Console.WriteLine("{0}, Ahora tienes el pelo {1}.", Usuario, pelo);
                        break;
                    case "c":
                        Estilista("Limpieza", ref rostro);
                        Console.WriteLine("{0}, Ahora tienes el rostro {1}.", Usuario, rostro);
                        break;
                };

            }
            else if (opcion.ToLower() == "c")
            {
                Console.WriteLine("{0}, aca te dejo las opciones de Manicura\n A- Pedicura: ¢6000 \n B- poner uñas: ¢4000 \n C- pintar uñas: ¢1500  ", Usuario);
                //pedicure
            }
        } while (opcion.ToLower() != "f");
    }

    public static void Barberia(ref string pelo, ref string barba, string option)
    {
        switch(option)
        {
            case "corte":
                pelo = "corto";
            break;
            case "corte/barba":
                barba = "Barba corta";
                pelo = "Pelo corto";
            break;
            case "barba/limp":
                barba = "corta y limpia";
            break;
        }
    }

    public static void Estilista(string option, ref string variable)
    {
        Console.Clear();
        switch(option)
        {
            case "teñido":
                Console.WriteLine("De que color quieres el pelo?");
                variable = Console.ReadLine();
                break;
            case "lavado":
                variable = "Lavado";
                break;
            case "Limpieza":
                variable = "Limpia la cara";
                break;
            default:
                variable = string.Empty;
                break;
        }
    }

}