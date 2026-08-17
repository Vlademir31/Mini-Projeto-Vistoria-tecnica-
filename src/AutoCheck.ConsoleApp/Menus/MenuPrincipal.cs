namespace AutoCheck.ConsoleApp.Menus
{
    public class MenuPrincipal
    {
        public void Exibir()
        {
            bool continuar = true;

            MenuVistoria menuVistoria = new MenuVistoria();

            while (continuar)
            {
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("==========================");
                Console.WriteLine("     GESTÃO VEICULAR     ");
                Console.WriteLine("==========================");
                Console.WriteLine();

                Console.WriteLine("1 - Vistoria");
                Console.WriteLine("2 - Relatório");
                Console.WriteLine("3 - Laudo cautelar");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
       
                Console.Write("Escolha uma opção:  ");

                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        menuVistoria.Exibir();
                        break;

                    case "2":
                        Console.WriteLine("Relatórios");
                        break;

                        case "3":
                        Console.WriteLine("Laudo cautelar");
                        break;

                    case "0":
                    Console.ResetColor();
                        continuar = false;
                        
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.Write("\nEncerrando o sistema");
                        for (int i = 0; i <3; i++)
                        {
                            Thread.Sleep(3000);
                            Console.Write(".");
                        }

                        Console.ResetColor();
                        break;
                        
                        default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nOpção inválida.\n");
                        
                        break;
                 }
                 if (continuar)
                {
                    Console.WriteLine("Pressione ENTER para continuar.");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.ResetColor();
                }
            }

        }
    }
}