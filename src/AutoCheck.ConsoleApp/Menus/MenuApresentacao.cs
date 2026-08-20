namespace AutoCheck.ConsoleApp.Menus
{
    public class MenuApresentacao
    {
        public void Exibir()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("================================================\n");
                Console.WriteLine("      Sistema de Gestão e Laudos Automotivos      ");
                Console.WriteLine("\t A certeza de um automovel seguro. \n");
                Console.WriteLine("================================================\n");
                Console.ResetColor();
                
              
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Iniciando o sistema ");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(300);
                    Console.Write(".");
                }
                Console.ResetColor();

                MenuPrincipal menuPrincipal = new MenuPrincipal();

                menuPrincipal.Exibir();

                continuar = false;
            }
        }
    }
}