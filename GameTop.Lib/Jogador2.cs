using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona Está Chutando";
        }

        public string Corre()
        {
            return "Maradona Está Correndo";
        }

        public string Passe()
        {
            return "Maradona Está Passando";
        }
    }
}
