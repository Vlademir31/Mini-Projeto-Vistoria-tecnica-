using AutoCheck.ConsoleApp.Models;

namespace AutoCheck.ConsoleApp.Services
{
    public class MotorVistoria
    {
        public int CalculadoraPontuacaoItem(ItemVistoria item)
        {
            if (item.Status == "Bom")
            {
                return 10;
            }
            else if (item.Status == "Regular")
            {
                return 5;
            }
            else if (item.Status == "Ruim")
            {
                return 0;
            }
            return 0;
        }

        public int CalcularPontuacaoTotal(Veiculo veiculo)
        {
            int pontuacaoTotal = 0;

            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                pontuacaoTotal += CalculadoraPontuacaoItem(item);
            }
            return pontuacaoTotal;
        }

        public int CalcularPontuacaoMaxima(Veiculo veiculo)
        {
            int quantidade = 0;

            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                quantidade++;
            }
            return quantidade * 10;
        }
        public double CalcularPercentual(Veiculo veiculo)
        {
            int pontuacaoObtida = CalcularPontuacaoTotal(veiculo);
            int pontuacaoMaxima = CalcularPontuacaoMaxima(veiculo);

            if (pontuacaoMaxima == 0)
            {
                return 0;
            }

            double percentual = ((double)pontuacaoObtida / pontuacaoMaxima) * 100;

            return percentual;
        }
        public string ClassificarVeiculo(double percentual)
        {
            if (percentual >= 90)
            {
                return "Aprovado com Excelência";
            }
            else if (percentual >= 60)
            {
                return "Aprovado com Apontamento";
            }
            else
            {
                return "Reprovado na Vistoria";
            }
        }
    }
}
