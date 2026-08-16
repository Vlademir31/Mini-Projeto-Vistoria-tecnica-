namespace AutoCheck.ConsoleApp.Models
{
    public class ItemVistoria
    {
        public string Nome { get; set; }
        public string Status { get; set; }

        public ItemVistoria( string nome, string status)
        {
            Nome = nome;
            Status = status;
        }
        public bool ValidarStatus()
        {
            if (Status == "Bom" ||
             Status == "Regular" ||
             Status == "Ruim")
            {
                return true;
            }
            return false;
        }
    }
}