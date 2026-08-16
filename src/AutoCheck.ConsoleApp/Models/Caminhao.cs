namespace AutoCheck.ConsoleApp.Models
{
    public class Caminhao : Veiculo
    {
        public int QuantidadeEixos { get; set; }
        public double CapacidadeCargaToneladas { get; set; }

        public Caminhao (string marca, string modelo, int ano, int quilometragem, int quantidadeEixos, double capacidadeCargaToneladas) : base (marca, modelo, ano, quilometragem)
        {
            QuantidadeEixos = quantidadeEixos;
            CapacidadeCargaToneladas = capacidadeCargaToneladas;
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = base.ObterChecklistObrigatorio();

            checklist.Add ("Disco Tacógrafo");
            checklist.Add ("Sistema de Freios");
            checklist.Add ("Faróis e Lanternas");
            checklist.Add ("Carroceria e estrutura");
            checklist.Add ("Mangueiras e conexões");

            return checklist;
        }
    }
}