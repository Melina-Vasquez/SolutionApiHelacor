using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelacorTorataEF.Controllers
{
    public class MarcaController : ApiController
    {
        // GET: api/Marca
        public List<Marca> Get()
        {
            List<Marca> oList = new List<Marca>();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oList = db.Marca.ToList();
            }
            return oList;
        }

        // GET: api/Marca/5
        public Marca Get(int id)
        {
            Marca oItem = new Marca();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oItem = db.Marca.Find(id);
            }
            return oItem;
        }

        // POST: api/Marca
        public void Post([FromBody]Marca value)
        {
            Marca oMarca = new Marca();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                db.Marca.Add(value);
                db.SaveChanges();           
            }
       }

        // PUT: api/Marca/5
        public void Put(int id, [FromBody]Marca value)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Marca.Find(id);
                oItem.nombremarca = value.nombremarca;

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Marca/5
        public void Delete(int id)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Marca.Find(id);

                db.Marca.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}
