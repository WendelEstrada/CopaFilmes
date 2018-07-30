using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Domain.Entities
{
    public class Campeonato
    {
        public Campeonato()
        {
            Grupos = new List<Grupo>();
            Partidas = new List<Partida>();
        }

        private int numeroDaPartida;

        public Filme Campeao { get; private set; }
        public Filme Segundo { get; private set; }
        public Filme Terceiro { get; private set; }
        public List<Grupo> Grupos { get; set; }
        public List<Partida> Partidas { get; set; }

        public Partida ObterPartida(int numero) => Partidas.First(p => p.Id == numero);
        public Grupo ObterGrupo(string nome) => Grupos.First(g => g.Nome == nome);

        public void RealizarPartida(string nomeDoPrimeiroGrupo, string nomeDoSegundoGrupo)
        {
            SomarNumeroDaPartida();
            var partida = new Partida(numeroDaPartida,
                    ObterGrupo(nomeDoPrimeiroGrupo).Primeiro,
                    ObterGrupo(nomeDoSegundoGrupo).Segundo);

            ExecutarJogo(partida);
        }

        public void RealizarPartida(int primeiroNumeroDaPartida, int segundoNumeroDaPartida)
        {
            SomarNumeroDaPartida();
            var partida = new Partida(numeroDaPartida,
                ObterPartida(primeiroNumeroDaPartida).Vencedor,
                ObterPartida(segundoNumeroDaPartida).Vencedor);

            ExecutarJogo(partida);
        }

        private void ExecutarJogo(Partida partida)
        {
            partida.Iniciar();
            Partidas.Add(partida);
        }

        public void DefinirPrimeirosColocados()
        {
            var final = Partidas.Last();

            Campeao = final.Vencedor;
            Segundo = final.Perdedor;

            var partidasDoCampeao = Partidas.FindAll(p => p.Vencedor == final.Vencedor);
            Terceiro = partidasDoCampeao
                        .OrderByDescending(partida => partida.Id)
                        .Skip(1)
                        .First()
                        .Perdedor;
        }

        private void SomarNumeroDaPartida()
        {
            numeroDaPartida = numeroDaPartida + 1;
        }
    }
}
