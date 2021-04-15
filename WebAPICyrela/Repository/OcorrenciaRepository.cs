using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICyrela.Models;
using WebAPICyrela.Repository.Context;

namespace WebAPICyrela.Repository
{
    public class OcorrenciaRepository
    {

        private readonly DataBaseContext context;

        public OcorrenciaRepository()
        {
            context = new DataBaseContext();
        }

        public IList<Ocorrencia> Listar()
        {
            return context.Ocorrencia.ToList();
        }

        public void Inserir(Ocorrencia ocorrencia)
        {
            context.Ocorrencia.Add(ocorrencia);
            context.SaveChanges();
        }

        public Ocorrencia Consultar (int id)
        {
            return context.Ocorrencia.Find(id);
        }

        public void Alterar (Ocorrencia ocorrencia)
        {
            context.Ocorrencia.Update(ocorrencia);
            context.SaveChanges();
        }

        public void Excluir (int id)
        {
            var ocorrencia = new Ocorrencia
            {
                IdOcorrencia = id
            };

            context.Ocorrencia.Remove(ocorrencia);
            context.SaveChanges();
        }

    }
}
