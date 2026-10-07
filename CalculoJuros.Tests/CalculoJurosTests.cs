using CalculoJuros.Services;

namespace CalculoJuros.Tests;

public class JurosServiceTests
{
    [Fact]
    public void DeveRetornarZeroQuandoVencimentoForHoje()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today;

        // Act
        var resultado = service.CalcularJuros(1000m, dataVencimento);

        // Assert
        Assert.Equal(0m, resultado);
    }

    [Fact]
    public void DeveRetornarZeroQuandoVencimentoForNoFuturo()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today.AddDays(5);

        // Act
        var resultado = service.CalcularJuros(1000m, dataVencimento);

        // Assert
        Assert.Equal(0m, resultado);
    }

    [Fact]
    public void DeveCalcularJurosDeUmDiaDeAtraso()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today.AddDays(-1);

        // Act
        var resultado = service.CalcularJuros(1000m, dataVencimento);

        // Assert
        Assert.Equal(25m, resultado);
    }

    [Fact]
    public void DeveCalcularJurosDeTresDiasDeAtraso()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today.AddDays(-3);

        // Act
        var resultado = service.CalcularJuros(1000m, dataVencimento);

        // Assert
        Assert.Equal(75m, resultado);
    }

    [Fact]
    public void DeveCalcularJurosDeDezDiasDeAtraso()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today.AddDays(-10);

        // Act
        var resultado = service.CalcularJuros(1000m, dataVencimento);

        // Assert
        Assert.Equal(250m, resultado);
    }

    [Fact]
    public void DeveCalcularJurosComValorDecimal()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today.AddDays(-2);

        // Act
        var resultado = service.CalcularJuros(500.50m, dataVencimento);

        // Assert
        Assert.Equal(25.025m, resultado);
    }

    [Fact]
    public void DeveCalcularValorAtualizadoComUmDiaDeAtraso()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today.AddDays(-1);

        // Act
        var resultado = service.CalcularValorAtualizado(
            1000m,
            dataVencimento);

        // Assert
        Assert.Equal(1025m, resultado);
    }

    [Fact]
    public void DeveRetornarValorOriginalQuandoVencimentoForHoje()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today;

        // Act
        var resultado = service.CalcularValorAtualizado(
            1000m,
            dataVencimento);

        // Assert
        Assert.Equal(1000m, resultado);
    }

    [Fact]
    public void DeveCalcularValorAtualizadoComDezDiasDeAtraso()
    {
        // Arrange
        var service = new JurosService();
        var dataVencimento = DateTime.Today.AddDays(-10);

        // Act
        var resultado = service.CalcularValorAtualizado(
            1000m,
            dataVencimento);

        // Assert
        Assert.Equal(1250m, resultado);
    }
}