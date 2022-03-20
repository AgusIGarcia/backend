using backend.Data;
using backend.Domain;
using Microsoft.AspNetCore.Mvc;

namespace backend.Services
{
    public class PersonaService
    {
        private readonly PersonaDbContext _db;
        public PersonaService(PersonaDbContext db)
        {
            this._db = db;
            _db.Database.EnsureCreated();
        }

        public Persona GetPersona(int id)
        {
            var persona = this._db.Persona.SingleOrDefault(p => p.Id == id);
            return persona;
        }

        public List<Persona> GetAllPersonas()
        {
            return this._db.Persona.ToList();
        }

        public void CreatePersona(Persona p){
            this._db.Persona.Add(p);
            this._db.SaveChanges();
        }
    }
}