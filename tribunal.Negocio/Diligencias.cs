using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tribunal.Negocio
{
    public class Diligencias
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdCausa { get; set; }

        public Diligencias() { }

        public Diligencias(int id, DateTime fecha, string descripcion, int idCausa)
        {
            Id = id;
            Fecha = fecha;
            Descripcion = descripcion;
            IdCausa = idCausa;
        }

        public Diligencias(int id, DateTime fecha, string descripcion)
        {
            Id = id;
            Fecha = fecha;
            Descripcion = descripcion;
        }


        public List<Diligencias> GetByCausa(int id_causa)
        {

            var diligencias = CommonBC.LexEntities.DILIGENCIAS.Where(d => d.ID_CAUSA == id_causa).OrderBy(o => o.ID_DILIGENCIA).ToList();
            List<Diligencias> lista = new List<Diligencias>();

            foreach (var diligencia in diligencias)
            {

                lista.Add(new Diligencias((int)diligencia.ID_DILIGENCIA, diligencia.FECHA_HORA, diligencia.DESCRIPCION));

            }


            return lista;


        }

        public bool Store(Diligencias diligencia) {


            try
            {
                var context = CommonBC.LexEntities;

                var di = new DALC.DILIGENCIAS();
                 
                di.FECHA_HORA = DateTime.Now;
                di.DESCRIPCION = diligencia.Descripcion;
                di.ID_CAUSA = diligencia.IdCausa;

                context.DILIGENCIAS.Add(di);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }
    }
}
