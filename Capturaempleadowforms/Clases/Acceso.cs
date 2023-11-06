namespace Capturaempleadowforms.Clases
{
    public class AccesoDao
    {
        private List<negocio> negocios;
        public AccesoDao()
        {
            this.negocios = new List<negocio>();
        }
        /// <summary>
        /// Metodo para guardar un contacto
        /// </summary>
        /// <param name="contact">Contacto que desea guardar</param>
        public void Guadar(negocio negocio)
        {
            if (negocio == null)
                throw new ArgumentNullException("El contacto es requerido para ejecutar este metodo.");



            this.negocios.Add(negocio);
        }
        /// <summary>
        /// Metodo para obtener todos los contactos
        /// </summary>
        /// <returns>Retorna una lista de los contactos</returns>
        public List<negocio> ObtenerContactos()
        {
            return this.negocios;
        }

        /// <summary>
        /// Metodo para obtener los contactos por empresa.
        /// </summary>
        /// <param name="empresa">empresa que desea ver los contactos.</param>
        /// <returns>Retorna una lista de los contactos</returns>
        public List<negocio> ObtenerContactos(string empresa)
        {

            return this.negocios.Where(co => co.empresa == empresa).ToList();
        }

        /// <summary>
        /// Obtener el detalle del contacto por la fecha de contratacion
        /// </summary>
        /// <param name="fechacon">fecha de contratacion del contacto</param>
        /// <returns>Contacto encontrado a partir de la fecha de contratacion</returns>
        public negocio ObtenerContacto(DateTime fechacon)
        {
            negocio negocio = this.negocios.FirstOrDefault(co => co.fechacontratacion == fechacon);
            return negocio;
        }
        /// <summary>
        /// Metodo para obtener el detalle del contacto a partir del codigo.
        /// </summary>
        /// <param name="codigo">codigo del contacto que desea ver el detalle</param>
        /// <returns>Contacto encontrado a partir del codigo.</returns>
        public negocio ObtenerContacto(string codigo)
        {
            return this.negocios.FirstOrDefault(co => co.codigo == codigo);
        }

        protected negocio ObtenerDatos()
        {
            negocio negocio = this.negocios.First();
            return negocio;
        }
    }
}
