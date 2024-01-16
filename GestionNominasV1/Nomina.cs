using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV1
{
    public class Nomina
    {
        // Miembros privados de la clase

        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salrioHora;

        // Propiedades dar acceso a la interdaz, para dar protección

        /// <summary>
        /// Nombre del Empleado
        /// </summary>
        public string NombreEmpleado
        {
            get
            {
                // Control de Contenido
                if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre del trabajador no establecido");

                // Devolución del Valor
                return _nombre;
            }
            set
            {
                // Validación de los Datos a Establecer
                if (string.IsNullOrEmpty(value)) throw new Exception("El nombre del trabajador no puede ser null o cadena vacía");
                
                // Establecimiento del valor al miembro privadoo
                _nombre = value;

            }
            
        }


    }
}
