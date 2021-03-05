using System;
using System.Collections.Generic;
using Dio.Desafio01.interfaces;
namespace Dio.Desafio01
{
    public class FilmeRepositorio : IRepositorio<Filmes>
    {
        private List<Filmes> listaFilmes = new List<Filmes>();
        public void Atualiza(int id, Filmes objeto)
		{
			listaFilmes[id] = objeto;
		}
        public void Excluir(int id)
		{
			listaFilmes[id].Excluir();
		}

		public void Inserir(Filmes objeto)
		{
			listaFilmes.Add(objeto);
		}

		public List<Filmes> Lista()
		{
			return listaFilmes;
		}

		public int ProximoId()
		{
			return listaFilmes.Count;
		}

		public Filmes RetornaPorId(int id)
		{
			return listaFilmes[id];
		}

        
    }
}