using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tribunal.Negocio
{
    public class Causas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Rol { get; set; }
        public string Caratula { get; set; }
        public string Tribunal { get; set; }
        public string Comuna { get; set; }


        public Causas()
        {

        }

        public Causas(int id, DateTime fecha, string rol, string caratula, string tribunal, string comuna)
        {
            Id = id;
            Fecha = fecha;
            Rol = rol;
            Caratula = caratula;
            Tribunal = tribunal;
            Comuna = comuna;
        }

        public List<Causas> All()
        {

            var causas = CommonBC.LexEntities.CAUSAS.ToList();
            List<Causas> lista = new List<Causas>();

            foreach (var causa in causas)
            {

                lista.Add(new Causas((int)causa.ID_CAUSA, causa.FECHA, causa.ROL, causa.CARATULA, causa.TRIBUNAL.NOMBRE, causa.TRIBUNAL.COMUNA.NOMBRE));

            }


            return lista;


        }

        public List<Causas> Get(string rol, DateTime? fecha)
        {


            var causas = CommonBC.LexEntities.CAUSAS.ToList();

            if (rol != null && rol.Length > 0)
            {
                causas = CommonBC.LexEntities.CAUSAS.Where(c => c.ROL.Contains(rol.ToUpper())).ToList();
            }

            List<Causas> lista = new List<Causas>();

            foreach (var causa in causas)
            {
                if (fecha != null)
                {
                    if (DateTime.Compare(causa.FECHA.Date, fecha.Value.Date) <= 0)
                    {
                        lista.Add(new Causas((int)causa.ID_CAUSA, causa.FECHA, causa.ROL, causa.CARATULA, causa.TRIBUNAL.NOMBRE, causa.TRIBUNAL.COMUNA.NOMBRE));
                    }
                }
                else
                {
                    lista.Add(new Causas((int)causa.ID_CAUSA, causa.FECHA, causa.ROL, causa.CARATULA, causa.TRIBUNAL.NOMBRE, causa.TRIBUNAL.COMUNA.NOMBRE));
                }
            }

            return lista;

        }

    }
}
