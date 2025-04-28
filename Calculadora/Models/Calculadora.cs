

using System.Diagnostics.Metrics;

namespace ProjetoCalculadora.Models
{
    public class Calculadora
    {
        public List<string> historico = new List<string>();

        public int Soma(int numero1, int numero2)
        {
            int soma = numero1 + numero2;
            historico.Add($"Calculo: soma    -   Valores: {numero1} + {numero2}  -   Resultado: {soma}");
            return soma;
        }

    public int Subtracao(int numero1, int numero2)
        {
            int subtracao = numero1 - numero2;
            historico.Add($"Calculo: subtracao    -   Valores: {numero1} - {numero2}  -   Resultado: {subtracao}");
            return subtracao;
        }

        public int Multiplicacao(int numero1, int numero2)
        {
            int multiplicacao = numero1 * numero2;
            historico.Add($"Calculo: multiplicação    -   Valores: {numero1} x {numero2}  -   Resultado: {multiplicacao}");
            return multiplicacao;
        }

        public int Divisao(int numero1, int numero2)
        {
            int div = numero1 / numero2;
            historico.Add($"Calculo: divisão    -   Valores: {numero1} / {numero2}  -   Resultado: {div}");
            return div;
        }
    
    }
}