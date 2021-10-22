using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_final
{
    class Entrada
    {
        public void Start()
        {
            string Prompt = "Bienvenido a nuestro colmado, Como podemos ayudarle?";
            string[] Options = { "Comprar", "Ver precios", "Salir" };

            Menu MainMenu = new Menu(Prompt, Options);
           int SelectedIndex = MainMenu.Run();

            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey(true);

        }

    }
}
