using Xunit;
using calculadoraApp; 

namespace calculadoraApp.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Sumar_DosNumeros_VerificaSumaCorrecta()
        {
            var calc = new Calculadora();

            var resultado = calc.Sumar(2, 3);

            Assert.Equal(5, resultado);
        }
    }
}