namespace Calculadora.Tests;

[TestFixture]
public class CalculadoraTests
{
    private Calculadora Calculadora;

    [SetUp]
    public void Setup()
    {
        Calculadora = new Calculadora();
    }

    [Test]
    public void testSomarNumerosSimples()
    {
        var num1 = 3;
        var num2 = 5;
        var resultadoEsperado = 8;

        var resultadoObtido = Calculadora.somarDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoObtido));

    }

    [TestCase(1, 1, 2)]
    [TestCase(5, 7, 12)]
    [TestCase(50, 5, 55)]
    public void testSomarTag(int num1, int num2, int resultadoEsperado)
    {
        var resultadoObtido = Calculadora.somarDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoObtido));
    }

    public static IEnumerable<TestCaseData> getTestData(String operacao)
    {
        String caminhoMassa = @"C:\Iterasys\ProjetoCalculadora\Calculadora139.Tests\Fixture\";

        switch (operacao)
        {
            case "+":
                caminhoMassa += @"massaSomar.csv";
                break;
            case "-":
                caminhoMassa += @"massaSubtrair.csv";
                break;
            case "*":
                caminhoMassa += @"massaMultiplicar.csv";
                break;
            case "/":
                caminhoMassa += @"massaDividir.csv";
                break;
            
        }

        using var reader = new StreamReader(caminhoMassa);

        // Pula a primeira linha com os cabeçahos
        reader.ReadLine();

        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(",");

            yield return new TestCaseData(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]));
        }


    }

    [Test, TestCaseSource("getTestData", new object[] { "+" })]
    public void testSomarMassa(int num1, int num2, int resultadoEsperado)
    {
        int resultadoObtido = Calculadora.somarDoisNumeros(num1, num2);
        Assert.That(resultadoObtido, Is.EqualTo(resultadoEsperado));
    }

    [Test, TestCaseSource("getTestData", new object[] { "-" })]
    public void testSubtrairMassa(int num1, int num2, int resultadoEsperado)
    {
        int resultadoObtido = Calculadora.subtrairDoisNumeros(num1, num2);
        Assert.That(resultadoObtido, Is.EqualTo(resultadoEsperado));
    }

    [Test, TestCaseSource("getTestData", new object[] { "*" })]
    public void testMultiplicarMassa(int num1, int num2, int resultadoEsperado)
    {
        int resultadoObtido = Calculadora.multiplicarDoisNumeros(num1, num2);
        Assert.That(resultadoObtido, Is.EqualTo(resultadoEsperado));
    }

    [Test, TestCaseSource("getTestData", new object[] { "/" })]
    public void testDividirMassa(int num1, int num2, int resultadoEsperado)
    {

        int resultadoObtido = Calculadora.dividirDoisNumeros(num1, num2);
        Assert.That(resultadoObtido, Is.EqualTo(resultadoEsperado));

    }

}