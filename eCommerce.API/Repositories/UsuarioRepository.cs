﻿using eCommerce.API.DataBase;
using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly eCommerceContext _db;
        public UsuarioRepository(eCommerceContext db)
        {
            _db = db;
        }
        
        public List<Usuario> Get()
        {
            return _db.Usuarios.OrderBy(x => x.Id).ToList();
        }
        public Usuario Get(int id)
        {
            return _db.Usuarios.Find(id)!;
        }
        public void Add(Usuario usuario)
        {
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }        
        public void Update(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }
    }
}
