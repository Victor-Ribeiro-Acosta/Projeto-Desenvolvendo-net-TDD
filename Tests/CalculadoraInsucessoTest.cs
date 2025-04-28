using System.Runtime.InteropServices;
using ProjetoCalculadora.Models;

namespace Tests.CalculadoraInsucessoTest;

public class CalculadoraInsucessoTest
{
    [Theory]
    [InlineData(-10, 20, 30)]
    [InlineData(30, -15, 45)]
    [InlineData(-10, 90, 100)]
    [InlineData(-30, 30, 60)]
    [InlineData(50, -20, 70)]
    public void DeveReceberValorNegativoeRetornarSubtracao(int valor1, int valor2, int resultadoEsperado)
    {
        Calculadora calculadora = new Calculadora();
        int resultadoSoma = calculadora.Soma(valor1, valor2);

        Assert.NotEqual(resultadoEsperado, resultadoSoma);
    }

    [Theory]
    [InlineData(20, -10, 10)]
    [InlineData(30, -15, 15)]
    [InlineData(-10, 90, 80)]
    [InlineData(-30, 30, 0)]
    [InlineData(50, -20, 30)]
    public void DeveReceberValorNegativoeRetornarSoma(int valor1, int valor2, int resultadoEsperado)
    {
        Calculadora calculadora = new Calculadora();
        int resultadoSoma = calculadora.Subtracao(valor1, valor2);

        Assert.NotEqual(resultadoEsperado, resultadoSoma);
    }

    [Theory]
    [InlineData(2, -10, 20)]
    [InlineData(3, -5, 15)]
    [InlineData(-10, 8, 80)]
    [InlineData(-3, 6, 18)]
    [InlineData(5, -10, 50)]
    public void DeveReceberValorNegativoRetornaNegativo(int valor1, int valor2, int resultadoEsperado)
    {
        Calculadora calculadora = new Calculadora();
        int resultadoSoma = calculadora.Multiplicacao(valor1, valor2);

        Assert.NotEqual(resultadoEsperado, resultadoSoma);
    }

    [Fact]
    public void TentarDividirPorZero()
    {
        Calculadora calculadora = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => calculadora.Divisao(10, 0));
    }
}
