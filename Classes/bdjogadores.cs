using System;
using System.Collections.Generic;
using Jogadores;
namespace DIO.Jogadores
{
    public class bdjogadores: IJogadores <Jogadores>
    {
        private List <Jogadores> listaJogadores = new List <Jogadores>();
        public void Atualiza (int id, Jogadores objeto)
        {
            listaJogadores[id] = objeto;
        } 
        public void Exclui (int id)
        {
            listaJogadores[id].Exclui();
        }
        public void Insere (Jogadores objeto)
        {
            listaJogadores.Add(objeto);
        }
        public List<Jogadores> Lista()
        {
            return listaJogadores;
        }
        public int ProximoId()
        {
            return listaJogadores.Count;
        }
        public Jogadores RetornaPorId (int id)
        {
            return listaJogadores[id];
        }
    }
}