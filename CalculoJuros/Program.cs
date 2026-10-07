using CalculoJuros.Services;

var service = new JurosService();

string continuar;

do
{
    Console.Clear();

    Console.WriteLine("=== CÁLCULO DE JUROS ===");
    Console.WriteLine();

    Console.Write("Digite o valor da conta: ");
    decimal valor = decimal.Parse(Console.ReadLine()!);

    Console.Write("Digite a data de vencimento (dd/MM/yyyy): ");
    DateTime dataVencimento = DateTime.Parse(Console.ReadLine()!);

    decimal juros = service.CalcularJuros(valor, dataVencimento);

    decimal valorAtualizado = service.CalcularValorAtualizado(
        valor,
        dataVencimento);

    Console.WriteLine();
    Console.WriteLine($"Valor original: R$ {valor:F2}");
    Console.WriteLine($"Juros: R$ {juros:F2}");
    Console.WriteLine($"Valor atualizado: R$ {valorAtualizado:F2}");

    Console.WriteLine();
    Console.Write("Deseja informar outro valor? (S/N): ");
    continuar = Console.ReadLine()!.Trim().ToUpper();

} while (continuar == "S");

Console.WriteLine();
Console.WriteLine("Programa encerrado.");