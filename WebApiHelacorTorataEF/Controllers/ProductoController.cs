using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelacorTorataEF.Controllers
{
    public class ProductoController : ApiController
    {
        // GET: api/Producto
        public List<Producto> Get()
        {
            List<Producto> oList = new List<Producto>();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oList = db.Producto.ToList();
            }
            return oList;
        }

        //// GET: api/Producto/5
        public Producto Get(int id)
        {
            Producto oItem = new Producto();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oItem = db.Producto.Find(id);
            }
            return oItem;
        }

        // POST: api/Producto
        public void Post([FromBody]Producto value)
        {
            Producto oProducto = new Producto();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                db.Producto.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Producto/5
        public void Put(int id, [FromBody]Producto value)
        {

            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Producto.Find(id);
                oItem.Descripcion = value.Descripcion;
                oItem.Tipo = value.Tipo;
                oItem.Unidad = value.Unidad;
                oItem.Peso_Helado = value.Peso_Helado;
                oItem.Peso_Total = value.Peso_Total;

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Producto/5
        public void Delete(int id)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Producto.Find(id);

                db.Producto.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}
