#region practica
/*Se requiere crear la pantalla en windows forms que permita capturar la siguiente informacióm:
Codigo.
Nombres
Apellidos.
Correo
Telefono
Direccion
Posicion
Departamento
Fecha Contractación
Se debe crear la clase de negocio y la clase de acceso a datos.*/
#endregion

namespace Capturaempleadowforms.Clases
{
    public class negocio
    {
        #region Atributos
        private string _codigo;
        private string _nombres;
        private string _apellidos;
        private string _correo;
        private string _telefono;
        private string _direccion;
        private string _posicion;
        private string _departamento;
        private DateTime _fechacontratacion;
        #endregion
        #region Propiedades
        /// <summary>
        /// propiedades de codigo
        /// </summary>
        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        /// <summary>
        /// propiedades de nombres
        /// </summary>
        public string nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        /// <summary>
        /// propiedades de apellidos
        /// </summary>
        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        /// <summary>
        /// propiedades de correo
        /// </summary>
        public string correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        /// <summary>
        /// propiedades de telefono
        /// </summary>
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        /// <summary>
        /// propiedades de direccion
        /// </summary>
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        /// <summary>
        /// propiedades de posicion
        /// </summary>
        public string posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }
        /// <summary>
        /// propiedades de departamento
        /// </summary>
        public string departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }
        /// <summary>
        /// Propiedades de fechacontratacion
        /// </summary>
        public DateTime fechacontratacion
        {
            get { return _fechacontratacion; }
            set { _fechacontratacion = value; }
        }
        /// <summary>
        /// Empresa a la que pertenece
        /// </summary>
        public string empresa
        { get; set; }

        public string nombrecompleto
        {
            get { return string.Concat(this._nombres, "", this.apellidos); }
        }
        #endregion
    }
}