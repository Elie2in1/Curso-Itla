
namespace Captura.Clases
{
    /// <summary>
    /// Objeto creado para el acceso a los datos del formulario de contactos.
    /// </summary>
    public class negocio
    {
        private List<negocio> datos;

        public negocio()
        {
            this.datos = new List<negocio>();
        }

        /// <summary>
        /// Metodo para guardar un contacto
        /// </summary>
        /// <param name="contact">Contacto que desea guardar</param>
        public void Guadar(Datos Datos)
        {
            if (Datos == null)
                throw new ArgumentNullException("El contacto es requerido para ejecutar este metodo.");



            this.datos.Add(datos);
        }

        /// <summary>
        /// Metodo para obtener todos los contactos
        /// </summary>
        /// <returns>Retorna una lista de los contactos</returns>
        public List<Datos> ObtenerContactos()
        {
            return this.datos;
        }

        /// <summary>
        /// Metodo para obtener los contactos por pais.
        /// </summary>
        /// <param name="pais">Pais que desea ver los contactos.</param>
        /// <returns>Retorna una lista de los contactos</returns>
        public List<Datos> ObtenerContactos(string empresa)
        {

            return this.Datos.Where(co => co.empresa == empresa).ToList();
        }

        /// <summary>
        /// Obtener el detalle del contacto por la fecha de nacimiento
        /// </summary>
        /// <param name="fechaNac">fecha de nacimiento del contacto</param>
        /// <returns>Contacto encontrado a partir de la fecha de nacimiento</returns>
        public Datos ObtenerContacto(DateTime fechaNac)
        {
            datos datos = this.datos.FirstOrDefault(co => co.Fechacontractacion == fechaNac);
            return datos;
        }

        /// <summary>
        /// Metodo para obtener el detalle del contacto a partir del codigo.
        /// </summary>
        /// <param name="codigo">codigo del contacto que desea ver el detalle</param>
        /// <returns>Contacto encontrado a partir del codigo.</returns>
        public Datos ObtenerContacto(string codigo)
        {
            return this.datos.FirstOrDefault(co => co.Codigo == codigo);
        }

        protected Datos ObtenerDatos()
        {
            datos contact = this.datos.First();
            return contact;
        }
    }
}