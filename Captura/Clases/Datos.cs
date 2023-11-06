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
namespace Captura.Clases
{
    /// <summary>
    /// Clases para manejar los datos
    /// </summary>
    public class Datos
    {
        #region atributos
        private string _codigo;
        private string _nombres;
        private string _apellidos;
        private string _correo;
        private string _telefono;
        private string _direccion;
        private string _posicion;
        private string _departamento;
        private DateTime _fechacontractacion;
        #endregion

        #region Propiedades
        /// <summary>
        /// Esta propiedad es para almacenar el codigo
        /// </summary>
        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar el nombre
        /// </summary>
        public string nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar el apellido
        /// </summary>
        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar la correo
        /// </summary>
        public string correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar el telefono
        /// </summary>
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar la direccion
        /// </summary>
        public string dirrecion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar la posicion
        /// </summary>
        public string posicion
        {
            get { return _posicion; }
            set { _posicion = value; }

        }
        /// <summary>
        /// Esta propiedad es para almacenar el departamento
        /// </summary>
        public string departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar la fecha de contractacion
        /// </summary>
        public DateTime fechacontractacion
        {
            get { return _fechacontractacion; }
            set { _fechacontractacion = value; }
        }

        /// <summary>
        /// Raiz a la que pertenece la persona
        /// </summary>
        public string empresa
        { get; set; }

        /// <summary>
        /// Nombre completo
        /// </summary>
        public string nombrecompleto
        {
            get { return string.Concat(this.nombres, "", this.apellidos, ""); }
        }

        #endregion


    }
}
