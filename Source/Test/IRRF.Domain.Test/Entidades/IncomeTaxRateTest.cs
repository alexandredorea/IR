using FluentAssertions;
using IRRF.Domain.Entities;
using Xunit;

namespace IRRF.Domain.Test.Entidades
{
    public class IncomeTaxRateTest
    {
        [Fact]
        public void AliquotaErradaSemProxima()
        {
            //Arrange
            var aliquota = new IncomeTaxRate(15, 5);
            var salarioMinimo = 1000;
            var rendaLiquida = 6000;

            //Act
            var valor = aliquota.GetIncomeTax(salarioMinimo, rendaLiquida);

            //Assert
            valor.Should().Be(0);
        }

        [Fact]
        public void AliquotaErradaComProxima()
        {
            //Arrange
            var aliquota = new IncomeTaxRate(15, 5)
                .NextRange(new IncomeTaxRate(22.5m, 7));
            var salarioMinimo = 1000;
            var rendaLiquida = 6000;

            //Act
            var valor = aliquota.GetIncomeTax(salarioMinimo, rendaLiquida);
            var valorEsperado = ((rendaLiquida * 22.5m) / 100);

            //Assert
            valor.Should().Be(valorEsperado);
        }

        [Fact]
        public void AliquotaCorretaSemProxima()
        {
            //Arrange
            var aliquota = new IncomeTaxRate(15, 5);
            var salarioMinimo = 1000;
            var rendaLiquida = 4000;

            //Act
            var valor = aliquota.GetIncomeTax(salarioMinimo, rendaLiquida);
            var valorEsperado = ((rendaLiquida * 15) / 100);

            //Assert
            valor.Should().Be(valorEsperado);
        }

        [Fact]
        public void AliquotaMaxima()
        {
            //Arrange
            var aliquota = new IncomeTaxRate(27.5m);
            var salarioMinimo = 1000;
            var rendaLiquida = 40000;

            //Act
            var valor = aliquota.GetIncomeTax(salarioMinimo, rendaLiquida);
            var valorEsperado = ((rendaLiquida * 27.5m) / 100);

            //Assert
            valor.Should().Be(valorEsperado);
        }

        [Fact]
        public void AliquotaCorretaComProxima()
        {
            //Arrange
            var aliquota = new IncomeTaxRate(15, 5)
                .NextRange(new IncomeTaxRate(22.5m, 7));
            var salarioMinimo = 1000;
            var rendaLiquida = 4000;

            //Act
            var valor = aliquota.GetIncomeTax(salarioMinimo, rendaLiquida);
            var valorEsperado = ((rendaLiquida * 15) / 100);

            //Assert
            valor.Should().Be(valorEsperado);
        }
    }
}