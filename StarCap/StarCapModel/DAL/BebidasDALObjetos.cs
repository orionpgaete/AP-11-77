using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class BebidasDALObjetos : IBebidasDAL
    {
        public List<Bebida> ObtenerBebidas()
        {
            return new List<Bebida>()
            {
                new Bebida()
                {
                    Nombre="Frapuccino",
                    Codigo="FP-01"
                },
                new Bebida()
                {
                    Nombre="Cafe del dia",
                    Codigo= "CAF-01"
                },
                new Bebida()
                {
                    Nombre="Té Chai",
                    Codigo= "TE-01"
                },
                new Bebida()
                {
                    Nombre="Te del dia",
                    Codigo="TE-02"
                }
            };
        }
    }
}
