namespace AutoCheck.ConsoleApp.Models
{
    public class Carro : Veiculo
    {
          public int QuantidadePortas { get; set; }
        public Carro (string marca, string modelo, int ano, int quilometragem, int quantidadePortas) : base(marca, modelo, ano,quilometragem)
        {
            this.QuantidadePortas = quantidadePortas;
        }
      public override List<string> ObterChecklistObrigatorio()
        {
            List<string> cheCklist = base.ObterChecklistObrigatorio();
            
            cheCklist.Add ("Triangulo de Sinalização");
            cheCklist.Add ("Ar Condicionado");
            cheCklist.Add ("Estepe e Macaco");
            cheCklist.Add ("Faróis e Lanternas");
            cheCklist.Add ("Retrovisores");
            cheCklist.Add ("Vidros e Para-brisa");

            return cheCklist;
        }

        
    }
}