[Test, TestCaseSource("LerDadosDeTeste", new object[] { "+" })]
  public void TestSomarDoisNumerosDD(int num1, int num2, int resultadoEsperado)
{   
    // Executa
    int resultadoAtual = Calculadora.SomarDoisNumeros(num1, num2);

    // Valida
    Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
}

