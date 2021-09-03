using System.Collections.Generic;
namespace DIO.Jogadores.Interface
{
    public interface IJogadores<T>
    {
         List<T> Lista();
         T RetornaPorId (int id);
         void Exclui (int id);
         void Atualiza (int id, T EntidadeBase);
         int ProximoId ();
    }
}