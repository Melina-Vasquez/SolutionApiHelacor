using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelacorTorataEF.Controllers
{
    public class TurnoController : ApiController
    {
        // GET: api/Turno
        public List<Turno> Get()
        {
            List<Turno> oList = new List<Turno>();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oList = db.Turno.ToList();
            }
            return oList;
        }

        // GET: api/Turno/5
        public Turno Get(int id)
        {
            Turno oItem = new Turno();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oItem = db.Turno.Find(id);
            }
            return oItem;
        }

        // POST: api/Turno
        public void Post([FromBody]Turno value)
        {
            Turno oTurno = new Turno();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                db.Turno.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Turno/5
        public void Put(int id, [FromBody]Turno value)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Turno.Find(id);
                oItem.Descripcion = value.Descripcion;
                oItem.Horario_Inicio = value.Horario_Inicio;
                oItem.Horario_Fin = value.Horario_Fin;

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Turno/5
        public void Delete(int id)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Turno.Find(id);

                db.Turno.Remove(oItem);
                db.SaveChanges();
            }
        }
    }
}
