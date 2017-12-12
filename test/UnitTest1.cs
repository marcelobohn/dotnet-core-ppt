using System;
using Xunit;
using lib;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void VerificaVendedor()
        {
            PPT ppt = new PPT("João", "Marcos");
            ppt.jogador1_material = "Papel";
            ppt.jogador2_material = "Pedra";            
            Assert.Equal("João", ppt.vencedor());
        }
    }
}
