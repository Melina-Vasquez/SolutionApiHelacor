using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelacorTorataEF.Controllers
{
    public class PuestoController : ApiController
    {
        // GET: api/Puesto
        public List<Puesto> Get()
        {
            List<Puesto> oList = new List<Puesto>();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oList = db.Puesto.ToList();
            }
            return oList;
        }

        //// GET: api/Puesto/5
        public Puesto Get(int id)
        {
            Puesto oItem = new Puesto();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oItem = db.Puesto.Find(id);  
            }
            return oItem;
        }

        // POST: api/Puesto
        public void Post([FromBody]Puesto value)
        {
            Puesto oPuesto = new Puesto();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                db.Puesto.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Puesto/5
        public void Put(int id, [FromBody]Puesto value)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Puesto.Find(id);
                oItem.Tipo_puesto = value.Tipo_puesto;
                oItem.Descripcion = value.Descripcion;
                

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Puesto/5
        public void Delete(int id)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Puesto.Find(id);

                db.Puesto.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}
