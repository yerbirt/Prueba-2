﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class InfoClienteVO
    {
        #region Atributos
        private string idCliente;
        private string nombreEmpresas;
        private string nombreContacto;
        private string categoriaContacto;
        private string direccion;
        private string ciudad;
        private string region;
        private string codigoPostal;
        private string pais;
        private string telefono;
        private string fax;

        #endregion

        #region Constructor
        public InfoClienteVO()
        {

        }

        #endregion

        #region Propiedades
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreEmpresas { get => nombreEmpresas; set => nombreEmpresas = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string CategoriaContacto { get => categoriaContacto; set => categoriaContacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }
        #endregion
    }
}
