using System;
using System.Collections.Generic;
using DIO.Series.Interface;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;  
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(Serie entidade)
        {
           listaSerie.Add(entidade);
        }
        public List<Serie> Lista()
        {
            return listaSerie;
        }
        public int ProximoID()
        {
            return listaSerie.Count;
        }
        public Serie RetornaPorID(int id)
        {
           return listaSerie[id];
        }
    }
}