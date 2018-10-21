using FluentAssertions;
using IRRF.Domain.Entities;
using Xunit;

namespace IRRF.Domain.Test.Entidades
{
    public class IncomeTaxTest
    {
        [Fact]
        public void IsentoSemDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 0, 1683.56m);

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(0);
        }

        [Fact]
        public void IsentoComDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 1, 1928.47m);

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(0);
        }

        [Fact]
        public void PrimeiraAliquotaSemDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 0, 1958.47m);
            var valorImpostoEsperado = 146.88525M;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }

        [Fact]
        public void PrimeiraAliquotaComDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 2, 3850);
            var valorImpostoEsperado = 281.595M;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }

        [Fact]
        public void SegundaAliquotaSemDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 0, 4293);
            var valorImpostoEsperado = 643.95m;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }

        [Fact]
        public void SegundaAliquotaComDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 1, 4800);
            var valorImpostoEsperado = 712.845m;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }

        [Fact]
        public void TerceiraAliquotaSemDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 0, 5724);
            var valorImpostoEsperado = 1287.9m;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }

        [Fact]
        public void TerceiraAliquotaComDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 4, 6700);
            var valorImpostoEsperado = 1464.57m;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }

        [Fact]
        public void QuartaAliquotaSemDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 0, 8765);
            var valorImpostoEsperado = 2410.375m;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }

        [Fact]
        public void QuartaAliquotaComDependentes()
        {
            //Arrange
            var salarioMinimo = 954;
            var impostoRenda = new IncomeTax(salarioMinimo);
            var contribuinte = new Contributor("643.574.755-54", "Alexandre Dórea", 3, 9352);
            var valorImpostoEsperado = 2532.4475m;

            //Act
            impostoRenda.CalculateIncomeTax(contribuinte);

            //Assert
            contribuinte.IncomeTax.Should().Be(valorImpostoEsperado);
        }
    }
}
