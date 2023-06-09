using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelacorTorataEF.Controllers
{
    public class EmpleadoController : ApiController
    {
        // GET: api/Empleado
        public List<Empleado> Get()
        {
            List<Empleado> oList = new List<Empleado>();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oList = db.Empleado.ToList();
            }
            return oList;
        }

        // GET: api/Empleado/5
        public Empleado Get(int id)
        {
            Empleado oItem = new Empleado();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                oItem = db.Empleado.Find(id);
            }
            return oItem;
        }

        // POST: api/Empleado
        public void Post([FromBody]Empleado value)
        {
            Empleado oTurno = new Empleado();
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                db.Empleado.Add(value);
                db.SaveChanges();
            }
        }

        // PUT: api/Empleado/5
        public void Put(int id, [FromBody] Empleado value)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Empleado.Find(id);
                oItem.Apellido = value.Apellido;
                oItem.Nombre = value.Nombre;
                oItem.I_Identidad = value.I_Identidad;
                oItem.Tipo_I_Identidad = value.Tipo_I_Identidad;
                oItem.Telefono = value.Telefono;
                oItem.Domiclio = value.Domiclio;
                oItem.Idpuesto = value.Idpuesto;

                db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Empleado/5
        public void Delete(int id)
        {
            using (Helacor_Linea_de_TortaEntities db = new Helacor_Linea_de_TortaEntities())
            {
                var oItem = db.Empleado.Find(id);

                db.Empleado.Remove(oItem);
                db.SaveChanges();
            }
        }
    
    }
}
