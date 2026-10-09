using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_8
{
    public class Producto
    {
        private int idProducto;
        private string nombreProducto;
        private string cantidadPorUnidad;
        private decimal precioUnitario;

        public Producto()
        {
        }
        public int IdProducto
        {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }
            set
            {
                nombreProducto = value;
            }
        }

        public string CantidadPorUnidad
        {
            get
            {
                return cantidadPorUnidad;
            }
            set
            {
                cantidadPorUnidad = value;
            }
        }

        public decimal PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }
            set
            {
                precioUnitario = value;
            }
        }
    }
}