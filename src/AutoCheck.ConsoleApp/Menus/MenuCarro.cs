using System.Net;
using AutoCheck.ConsoleApp.Models;

namespace AutoCheck.ConsoleApp.Menus
{

    public class MenuCarro
    {
        public Carro CriarCarro()
        {
            Console.Clear();

            Console.WriteLine("===========================");
            Console.WriteLine("     CADASTRO DO CARRO     ");
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.Write("Marca:  ");
            string marca = Console.ReadLine() ?? "";

            Console.Write("Modelo:  ");
            string modelo = Console.ReadLine() ?? "";

            Console.Write("Ano:  ");
            int ano = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Quilometragem:  ");
            int quilometragem = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Quantidade de portas: ");
            int quantidadePortas = int.Parse(Console.ReadLine() ?? "0");

            Carro carro = new Carro(marca, modelo, ano, quilometragem, quantidadePortas);

            return carro;
        }
        public void RealizarChecklist(Carro carro)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("===============================");
            Console.WriteLine("     CHECKLIST DE VISTORIA     ");
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine();

            List<string> checklist = carro.ObterChecklistObrigatorio();

            foreach (string Item in checklist)
            {
                string status = "";

                do
                {
                    Console.WriteLine();
                    Console.WriteLine($"Item: {Item}");
                    Console.WriteLine();
                    Console.WriteLine("1 - Bom");
                    Console.WriteLine("2 - Regular");
                    Console.WriteLine("3 - Ruim");

                    Console.Write("Escolha o Status:  ");

                    string? opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            status = "Bom";
                            break;

                        case "2":
                            status = "Regular";
                            break;

                        case "3":
                            status = "Ruim";
                            break;

                        default:

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine("Opção inválida.");
                            Console.WriteLine("Escolha entre 1, 2 ou 3.");
                            Console.ResetColor();
                            break;
                    }
                }
                while (status == "");
                {
                    carro.AdicionarItemVistoriado(Item, status);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Checklist concluido com sucesso.");
                Console.ResetColor();
            }
        }
        public void Exibir()
        {
            Carro carro = CriarCarro();

            Console.WriteLine();
            Console.WriteLine($"Marca......................: {carro.Marca}");
            Console.WriteLine($"Modelo.....................: {carro.Modelo}");
            Console.WriteLine($"Ano........................: {carro.Ano}");
            Console.WriteLine($"Quilometragem..............: {carro.Quilometragem}");
            Console.WriteLine($"Quantidade de Portas.......: {carro.QuantidadePortas}");

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para iniciar a vistoria.");
            Console.ReadLine();

            RealizarChecklist(carro);

        }

    }
}