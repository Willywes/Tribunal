using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tribunal.Negocio
{
    public class Comuna
    {


        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public decimal ProvinciaId { get; set; }

        public Comuna()
        {
        }

        public Comuna(decimal id, string nombre, decimal provinciaId)
        {
            Id = id;
            Nombre = nombre;
            ProvinciaId = provinciaId;
        }


        public List<Comuna> All() {

            var comunas =  CommonBC.LexEntities.COMUNA.ToList();

            List<Comuna> lista = new List<Comuna>();

            foreach (var comuna in comunas){

                Comuna c = new Comuna(comuna.ID_COMUNA, comuna.NOMBRE, comuna.ID_PROVINCIA);
                lista.Add(c);

            }

            return lista;

        }
       
    }
}
