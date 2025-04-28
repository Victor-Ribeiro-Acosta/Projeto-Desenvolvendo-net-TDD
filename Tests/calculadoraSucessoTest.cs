using ProjetoCalculadora.Models;


namespace Tests.CalculadoraSucessoTest;

// Engloba todos os testes com o sucesso esperado
public class CalculatoraSucessoTest
{
    [Theory]
    [InlineData(10,15)]
    [InlineData(20,0)]
    [InlineData(149,51)]
    [InlineData(-10, 27)]
    [InlineData(45,-15)]
    public void DeveSomardoisNumeroseRetornarResultadoEHistorico(int valor1, int valor2)
    {
        Calculadora calculadora = new Calculadora();
        int resultado = calculadora.Soma(valor1, valor2);
        bool test = calculadora.historico.Contains($"Calculo: soma    -   Valores: {valor1} + {valor2}  -   Resultado: {resultado}");

        Assert.Equal(valor1 + valor2, resultado);
        Assert.True(test);
        
    }


    [Theory]
    [InlineData(10,15)]
    [InlineData(20,0)]
    [InlineData(149,51)]
    [InlineData(-10, 27)]
    [InlineData(45,-15)]
    public void DeveSubtrairDoisNumeroseRetornarResultadoEHistorico(int valor1, int valor2)
    {
        Calculadora calculadora = new Calculadora();
        int resultado = calculadora.Subtracao(valor1, valor2);
        bool test = calculadora.historico.Contains($"Calculo: subtracao    -   Valores: {valor1} - {valor2}  -   Resultado: {resultado}");

        Assert.Equal(valor1-valor2, resultado);
        Assert.True(test);
    }


    [Fact]
    public void DeveMultiplicarDoisNumeroseRetornarResultadoEHistorico()
    {
        Calculadora calculadora = new Calculadora();
        int resultado = calculadora.Multiplicacao(5, 5);
        bool test = calculadora.historico.Contains("Calculo: multiplicação    -   Valores: 5 x 5  -   Resultado: 25");


        Assert.Equal(5*5, resultado);
        Assert.True(test); 
    }


    [Fact]
    public void DeveDividirDoisNumeroseRetornarResultadoEHistorico()
    {
        Calculadora calculadora = new Calculadora();
        int resultado = calculadora.Divisao(50, 5);
        bool test = calculadora.historico.Contains("Calculo: divisão    -   Valores: 50 / 5  -   Resultado: 10");

        Assert.Equal(50/5, resultado);
        Assert.True(test);   
    }
}
