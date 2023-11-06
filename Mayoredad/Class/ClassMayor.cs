/*Confeccionar una clase que permita carga el nombre y la edad de una persona. 
 * Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18).*/
namespace Mayoredad.Class
{
    /// <summary>
    /// Clases para manejar los datos
    /// </summary>
    public class ClassMayor
    {
        #region atributos
        private string _nombres;
        private string _apellidos;
        private int _edad;
        #endregion

        #region Propiedades
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
        public string apellido
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        /// <summary>
        /// Esta propiedad es para almacenar la edad
        /// </summary>
        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        /// <summary>
        /// Raiz a la que pertenece la persona
        /// </summary>
        public string raiz
        { get; set; }

        /// <summary>
        /// Nombre completo
        /// </summary>
        public  string nombrecompleto
        {
            get { return string.Concat(this.nombres, "", this.apellido, "");  }
        }

        #endregion

            
    }
}
