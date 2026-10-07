namespace CalculoJuros.Services;

public class JurosService
{
    private const decimal PercentualMultaDiaria = 0.025m;

    public decimal CalcularJuros(decimal valor, DateTime dataVencimento)
    {
        DateTime hoje = DateTime.Today;

        if (dataVencimento >= hoje)
        {
            return 0m;
        }

        int diasAtraso = (hoje - dataVencimento.Date).Days;

        decimal jurosPorDia = valor * PercentualMultaDiaria;

        return jurosPorDia * diasAtraso;
    }

    public decimal CalcularValorAtualizado(
        decimal valor,
        DateTime dataVencimento)
    {
        decimal juros = CalcularJuros(valor, dataVencimento);

        return valor + juros;
    }
}