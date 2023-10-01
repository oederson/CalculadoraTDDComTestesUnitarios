using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraTDD _calc;

    public CalculadoraTestes() 
    {
        string data = "01/10/2023";
        _calc = new CalculadoraTDD(data);
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        int resultadoCalculadora = _calc.Somar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
       int resultadoCalculadora = _calc.Multiplicar(val1, val2);
       Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData (2, 2, 0)]
    [InlineData (5, 5, 0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        int resultadoCalculadora = _calc.Subtrair(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
        
    [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (40, 5, 8)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        int resultadoCalculadora = _calc.Dividir(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }
    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1, 2);
        _calc.Somar(2, 2);
        _calc.Somar(3, 2);
        _calc.Somar(4, 2);

        var lista = _calc.Historico();

        Assert.NotEmpty(_calc.Historico());
        Assert.Equal(3, lista.Count);
    }
}