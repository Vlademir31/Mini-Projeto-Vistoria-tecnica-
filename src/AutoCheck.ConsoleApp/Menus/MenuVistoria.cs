namespace AutoCheck.ConsoleApp.Menus
{
    public class MenuVistoria
    {
        private MenuCarro menuCarro;
        public MenuVistoria()
        {
            menuCarro = new MenuCarro();
        }
        public void Exibir()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            Console.WriteLine("===================================");
            Console.WriteLine("      GESTÃO DE CONSULTA     ");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Caminhão");
            Console.WriteLine("3 - Moto");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine();

            Console.Write("Escolha o tipo de veículo: ");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                menuCarro.Exibir();
                break;

                case "2":
                Console.WriteLine("Vistoria de Caminhão.");
                break;

                case "3":
                Console.WriteLine("Vistoria de Moto.");
                break;

                case "0":
                return;

                default:
                Console.WriteLine("Opção invalidade.");
                Console.ReadLine();
                break;
            }
        }
    }
}