using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using GamerProfile.App;

namespace GamerProfile.Tests
{
    public class PerfilJogadorServiceTests
    {
        [Fact]
        public void GerarTagUsuario_DeveGerarFormatacaoCorreta()
        {
            // Arrange
            var service = new PerfilJogadorService();

            // Act
            string resultado = service.GerarTagUsuario("Nickname", "0000");

            // Assert
            Assert.Equal("Nickname#0000", resultado);
        }

        [Fact]
        public void CalcularXPTotal_DeveSomarXPComBonus()
        {
            // Arrange
            var service = new PerfilJogadorService();
            int valorEsperado = 600;

            // Act
            int resultado = service.CalcularXPTotal(200, 300);

            // Assert
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void EEligivelParaRanked_DeveValidarNivelDoJogador()
        {
            // Arrange
            var service = new PerfilJogadorService();

            // Act
            bool jogadorElegivel = service.EEligivelParaRanked(15);
            bool jogadorNaoElegivel = service.EEligivelParaRanked(14);

            // Assert
            Assert.True(jogadorElegivel);
            Assert.False(jogadorNaoElegivel);
        }
    }
}