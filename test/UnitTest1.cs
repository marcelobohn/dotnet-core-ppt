using System;
using Xunit;

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
            Assert.Equal(ppt.vencedor, "João");
        }
    }
}
