namespace AutoCheck.ConsoleApp.Models
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto (string marca, string modelo, int ano, int quilometragem, int cilindradas) : base (marca, modelo, ano, quilometragem )
        {
            Cilindradas = cilindradas;
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = base.ObterChecklistObrigatorio();

            checklist.Add ("Kit Trnansmissão");
            checklist.Add ("Guidão e Manoplas");
            checklist.Add ("Retrovisores");
            checklist.Add ("Kit Relação");
            checklist.Add ("Faróis e Lanternas");

            return checklist;
        }
    }
}