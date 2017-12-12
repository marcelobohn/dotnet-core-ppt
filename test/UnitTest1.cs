using System;
using Xunit;
using lib;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void VerificaVendedorPedra()
        {
            PPT ppt = new PPT("João", "Marcos");
            ppt.jogador1_material = "Pedra";
            ppt.jogador2_material = "Tesoura";            
            Assert.Equal("João", ppt.vencedor());
        }

        [Fact]
        public void VerificaPerdedorPedra()
        {
            PPT ppt = new PPT("João", "Marcos");
            ppt.jogador1_material = "Pedra";
            ppt.jogador2_material = "Papel";            
            Assert.Equal("Marcos", ppt.vencedor());
        }

        [Fact]
        public void VerificaEmpatePedra()
        {
            PPT ppt = new PPT("João", "Marcos");
            ppt.jogador1_material = "Pedra";
            ppt.jogador2_material = "Pedra";            
            Assert.Equal("Empate", ppt.vencedor());
        }        
        
        [Fact]
        public void VerificaVendedorPapel()
        {
            PPT ppt = new PPT("João", "Marcos");
            ppt.jogador1_material = "Papel";
            ppt.jogador2_material = "Pedra";            
            Assert.Equal("João", ppt.vencedor());
        }        

        [Fact]
        public void VerificaVendedorTesoura()
        {
            PPT ppt = new PPT("João", "Marcos");
            ppt.jogador1_material = "Tesoura";
            ppt.jogador2_material = "Papel";            
            Assert.Equal("João", ppt.vencedor());
        }                
    }
}
