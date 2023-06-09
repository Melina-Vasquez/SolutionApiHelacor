using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelacorTorataEF.Controllers
{
    public class PaisController : ApiController
    {
        // GET: api/Pais
        public List<Pais> Get()
        {
            List<Pais> oList = new List<Pais>();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oList = db.Pais.ToList();
            }
            return oList;
        }

        // GET: api/Pais/5
        public Pais Get(int id)
        {
            Pais oItem = new Pais();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oItem = db.Pais.Find(id);
            }
            return oItem;
        }

        // POST: api/Pais
        public void Post([FromBody]Pais value)
        {
            Pais oPais = new Pais();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                db.Pais.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Pais/5
        public void Put(int id, [FromBody] Pais value)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Pais.Find(id);
                oItem.C_Postal = value.C_Postal;
                oItem.NombrePais = value.NombrePais;

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        // DELETE: api/Pais/5
        public void Delete(int id)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Pais.Find(id);

                db.Pais.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}
