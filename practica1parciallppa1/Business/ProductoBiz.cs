using practica1parciallppa1.Data;
using practica1parciallppa1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica1parciallppa1.Business
{
    public class ProductoBiz
    {
        BaseDataService<Producto> db;
        public ProductoBiz()
        {
            db = new BaseDataService<Producto>();
        }

       public Producto Agregar(Producto model)
        {
           return db.Create(model);
        }

        public List<Producto> Listar()
        {
           
            var lista = db.Get();
            return lista;
        }

        public Producto Get(int id)
        {
            return db.GetById(id);
        }

        public void Eliminar(Producto model)
        {
            db.Delete(model);
        }

        public void Update(Producto model)
        {
            db.Update(model);
        }
    }
}