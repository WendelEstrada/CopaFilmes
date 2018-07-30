namespace Wes.CopaMundoFilmes.Domain.Entities
{
    public class Partida
    {
        public Partida(int id, Filme primeiroFilme, Filme segundoFilme)
        {
            Id = id;
            PrimeiroFilme = primeiroFilme;
            SegundoFilme = segundoFilme;
        }

        public int Id { get; private set; }
        public Filme PrimeiroFilme { get; private set; }
        public Filme SegundoFilme { get; private set; }
        public Filme Vencedor { get; private set; }
        public Filme Perdedor { get; private set; }

        public void Iniciar() => DefinirResultadoDaPartida();

        private void DefinirResultadoDaPartida()
        {
            if (NotaIgual())
            {
                Desempate();
                return;
            }

            if (PrimeiroFilme.AverageRating > SegundoFilme.AverageRating)
            {
                Vencedor = PrimeiroFilme;
                Perdedor = SegundoFilme;
            }
            else
            {
                Vencedor = SegundoFilme;
                Perdedor = PrimeiroFilme;
            }
        }

        private bool NotaIgual()
        {
            if (PrimeiroFilme.AverageRating == SegundoFilme.AverageRating)
                return true;

            return false;
        }

        private void Desempate()
        {
            if (PrimeiroFilme.PrimaryTitle.CompareTo(SegundoFilme.PrimaryTitle) <= 0)
            {
                Vencedor = PrimeiroFilme;
                Perdedor = SegundoFilme;
            }
            else
            {
                Vencedor = SegundoFilme;
                Perdedor = PrimeiroFilme;
            }
        }

    }
}
