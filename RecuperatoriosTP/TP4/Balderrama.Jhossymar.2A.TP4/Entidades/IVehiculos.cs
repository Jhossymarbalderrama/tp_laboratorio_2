using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    public interface IVehiculos
    {
        #region "Propiedades"
        /// <summary>
        /// Propiedad Marca, solo lectura
        /// </summary>
        string Marca { get; }


        /// <summary>
        /// Propiedad Precio, Solo lectura
        /// </summary>
        double Precio { get; }
        #endregion

        #region "Metodo"
        /// <summary>
        /// Metodo, retornara la marca y el precio del vehiculo
        /// </summary>
        /// <returns></returns>
        string VehiculosToString();

        #endregion

    }
}
