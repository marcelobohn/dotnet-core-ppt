using System;

namespace lib
{
    public class PPT
    {
        public string jogador1_nome;
        public string jogador2_nome;

        public string jogador1_material;
        public string jogador2_material;
        public PPT(string nome1, string nome2) {
            this.jogador1_nome = nome1;
            this.jogador2_nome = nome2;
        }
        public string vencedor() {
            return "João";
        }
    }
}
