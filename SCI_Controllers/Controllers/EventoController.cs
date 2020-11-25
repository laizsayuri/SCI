using SCI_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCI_Controllers.Controllers
{
    public class EventoController
    {
        private readonly sciContext db;

        public EventoController()
        {
            db = new sciContext();
        }

        public void Save(Evento evento)
        {
            Evento entidadeSalva = db.Eventos.FirstOrDefault(e => e.Codevento == evento.Codevento);
            if (entidadeSalva != null)
            {
                entidadeSalva.Codcategoria = evento.Codcategoria;
                entidadeSalva.Codlocal = evento.Codlocal;
                entidadeSalva.Nome = evento.Nome;
                entidadeSalva.Artista = evento.Artista;
                entidadeSalva.Data = evento.Data;
                entidadeSalva.Valoringresso = evento.Valoringresso;
                entidadeSalva.Numeroingressos = evento.Numeroingressos;
                entidadeSalva.Descricao = evento.Descricao;

                db.SaveChanges();
            }
        }

        public Evento GetById(int CodEvento)
        {
            Evento entidade = db.Eventos.FirstOrDefault(e => e.Codevento == CodEvento);
            return entidade;
        }

        public List<Evento> GetAll()
        {
            return db.Eventos.ToList();
        }

        public void Remove(int CodEvento)
        {
            Evento entidadeSalva = db.Eventos.FirstOrDefault(e => e.Codevento == CodEvento);
            if(entidadeSalva != null)
            {
                db.Eventos.Remove(entidadeSalva);
                db.SaveChanges();
            }
        }
    }
}
