using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICyrela.Models;
using WebAPICyrela.Repository.Context;

namespace WebAPICyrela.Repository
{
    public class AssistenciaRepository
    {
        private readonly DataBaseContext context;

        public AssistenciaRepository()
        {
            context = new DataBaseContext();
        }


        public IList<Assistencia> Listar()
        {
            return context.Assistencia.ToList();
        }

        public void Inserir(Assistencia assistencia)
        {
            context.Assistencia.Add(assistencia);
            context.SaveChanges();
        }

        public Assistencia Consultar(int id)
        {
            return context.Assistencia.Find(id);
        }

        public void Alterar(Assistencia assistencia)
        {
            context.Assistencia.Update(assistencia);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {

            var assistencia = new Assistencia()
            {
                IdAssistencia = id
            };

            context.Assistencia.Remove(assistencia);
            context.SaveChanges();
        }

    }
}
