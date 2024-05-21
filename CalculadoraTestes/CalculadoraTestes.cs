using Calculadora.Services;

namespace CalculadoraTestes
{
public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    } 

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange escenario
        int num1 = 5;
        int num2 = 10;

        //Act acao
        int resultados = _calc.Somar(num1,num2);
        //Assert validacion

        Assert.Equal(15, resultados);

    }

    [Fact]
    public void verificarSeEhParEretornarVerdadeiro()
    {
        //Arrange escenario
        int num = 8;
          //Act acao
        bool resultado = _calc.EhPar(num);
         //Assert validacion
        Assert.True(resultado);
    }

    //Para evaluar multiples escenarios debe ser de la siguiente manera:
    /*[Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(12)]
    public void verificarSeEhParEretornarVerdadeiroMultiple(int num)
    {
          //Act acao
        bool resultado = _calc.EhPar(num);
         //Assert validacion
        Assert.True(resultado);
    }
    // o tambien*/
    [Theory]
    [InlineData(new int [] {2,4,6,8,10})]
    public void verificarSeEhParEretornarVerdadeiroMultiple(int[] numeros)
    {
       //para automatizar que haga la validacion para todos los elementos se hace de la siguiente manera:
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));

        //tambien se podria hacer con foreach
    }
}
}
