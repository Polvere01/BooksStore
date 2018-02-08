using BooksStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BooksStore.Models;
using System.Data.Entity;

namespace BooksStore.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private BooksStoresDataContext _db = new BooksStoresDataContext();

        public bool Create(Autor autor)
        {
            try
            {
                _db.Autor.Add(autor);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            var autor = _db.Autor.Find(id);
            _db.Autor.Remove(autor);
            _db.SaveChanges();
        }

        public List<Autor> Get()
        {
            return _db.Autor.ToList();
        }

        public Autor Get(int id)
        {
            return _db.Autor.Find(id);
        }

        public List<Autor> GetByName(string name)
        {
            return _db.Autor
                .Where(x => x.Nome.Contains(name))
                .ToList();
        }

        public bool Update(Autor autor)
        {
            try
            {
                //entra e verifica o que foi alterado no autor
                _db.Entry<Autor>(autor).State = EntityState.Modified;
                _db.SaveChanges();
                 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}