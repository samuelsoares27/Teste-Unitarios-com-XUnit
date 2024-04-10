using System.Net.NetworkInformation;
using TesteUnitario;

namespace XUnitTeste
{
    public class UnitTest1
    {

        private readonly Class2 _class2;


        public UnitTest1()
        {
            _class2 = new Class2();
        }

        [Fact(DisplayName = "Informe valores, quando somar ent�o tenha sucesso.")]
        //GIVEN_WHEN_THEN
        public void GivenValideNumeros_WhenSomar_ThenSucesso()
        {
            //Arrange (Vari�veis)
            const int resultadoExperado = 5;
            const int PrimeiroNumero = 2;
            const int SegundoNumero = 3;

            //Act (A��o)

            var resultadoAtual = Class1.Soma(PrimeiroNumero, SegundoNumero);

            //Asserts (Resultado)
            Assert.Equal(resultadoExperado, resultadoAtual);

        }

        [Theory(DisplayName = "Informe valores por Par�metro, quando somar ent�o tenha sucesso.")]
        [InlineData(5, 2, 3)]
        [InlineData(10, 4, 6)]
        //GIVEN_WHEN_THEN
        public void GivenValideNumerosPorParametro_WhenSomar_ThenSucesso(int resultadoExperado, int PrimeiroNumero, int SegundoNumero)
        {

            //Act (A��o)

            var result = Class1.Soma(PrimeiroNumero, SegundoNumero);

            //Asserts (Resultado)

            result.Should().Be(resultadoExperado); // Igual ao resultado experado
            result.Should().BeGreaterThanOrEqualTo(5); // Maior que ou igual a 5
            result.Should().NotBeInRange(-1000, 0); // n�o ser entre -1000 e 0

        }


        [Fact(DisplayName = "Retornar data.")]
        
        public void Classe2_RetornarData()
        {
            //Act (A��o)

            var result = _class2.DataHora();

            //Asserts (Resultado)

            result.Should().NotBe(DateTime.MinValue); // N�o pode ser nulo

        }

        [Fact(DisplayName = "GetPingOptions")]

        public void NetWorkServices_GetPingOptions_ReturnsObjects()
        {

            //Arrange (Vari�veis)
            var expectedPingOptions = new PingOptions
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act (A��o)

            var result = _class2.PingOptions();

            //Asserts (Resultado)

            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expectedPingOptions);
            result.Ttl.Should().Be(1);

        } //

        [Fact(DisplayName = "ListPingOptions")]

        public void NetWorkServices_ListtPingOptions_ReturnsListOfObjects()
        {

            //Arrange (Vari�veis)
            var expectedPingOptions = new PingOptions
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act (A��o)

            var result = _class2.ListPingOptions();

            //Asserts (Resultado)

            //result.Should().BeOfType<IEnumerable<PingOptions>>();
            result.Should().ContainEquivalentOf(expectedPingOptions);
            result.Should().Contain(p => p.DontFragment);

        }
    }
}