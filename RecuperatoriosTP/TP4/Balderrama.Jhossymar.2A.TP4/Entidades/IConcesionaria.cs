using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IConcesionaria
    {
        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve una lista de Vehiculos, solo lectura
        /// </summary>
        List<Vehiculo> Vehiculos { get; }


        /// <summary>
        /// Propiedad PrecioTotal, solo lectura
        /// </summary>
        double PrecioTotal { get; }
        #endregion

    }
}
