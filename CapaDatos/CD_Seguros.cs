using System.Collections.Generic;
using System.IO;

namespace CapaDatos
{
    public class CD_Seguros
    {
        private string codigo;
        private string tipoSeguro;
        private string incremento;
        private string valor;
        private string IdUsuario;
        private string NombreUsuario;
        private string ContactoUsuario;
        


        FileStream archivo = null;
        StreamWriter escritor = null;
        StreamReader lector = null;

        List<string> listaSeguros = new List<string>();
        List<string> listaUsuarios = new List<string>();
        private string mensaje = "";

        private string rutaSeguros = @"C:\Users\PC\Documents\Seguros.txt";
        private string rutaUsuariosVentas = @"C:\Users\PC\Documents\UsuariosVentas.txt";

        public string Codigo { get => codigo; set => codigo = value; }
        public string TipoSeguro { get => tipoSeguro; set => tipoSeguro = value; }
        public string Incremento { get => incremento; set => incremento = value; }
        public string Valor { get => valor; set => valor = value; }
        public string IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public string NombreUsuario1 { get => NombreUsuario; set => NombreUsuario = value; }
        public string ContactoUsuario1 { get => ContactoUsuario; set => ContactoUsuario = value; }
        public string getmensaje() {  return mensaje; }

        public void guardarSeguros(string cod, string tipo, string incremento, string valor)
        {

            try
            {
                archivo = new FileStream(rutaSeguros, FileMode.Append, FileAccess.Write);
                escritor = new StreamWriter(archivo);
                escritor.WriteLine(cod + "," + tipo + "," + incremento + ", " + valor);
                escritor.Close();
                mensaje = ("se ha registrado el seguro");

            }
            catch (IOException ex)
            {
                mensaje = ("ERROR: " + ex.Message);
            }
        }

        public void guardarUsuarios(string id, string nombre, string contacto)
        {

            try
            {
                archivo = new FileStream(rutaUsuariosVentas, FileMode.Append, FileAccess.Write);
                escritor = new StreamWriter(archivo);
                escritor.WriteLine(id + "," + nombre + "," + contacto);
                escritor.Close();
                //mensaje = ("se ha registrado el seguro");

            }
            catch (IOException ex)
            {
                mensaje = ("ERROR: " + ex.Message);
            }
        }

        public void BuscarSeguros(string id)
        {
            try
            {


                archivo = new FileStream(rutaSeguros, FileMode.Open, FileAccess.Read);
                lector = new StreamReader(archivo);
                string Linea;
                string[] cadena = new string[4];
                bool encontro = false;
                int pos = 0, i = 0;
                while ((Linea = lector.ReadLine()) != null)
                {
                    cadena = Linea.Split(new char[] { ',' });
                    if (cadena[0] == id)
                    {
                        codigo = cadena[0];
                        tipoSeguro = cadena[1];
                        incremento = cadena[2];
                        valor = cadena[3];
                        encontro = true;
                        pos = i;
                    }
                    i++;
                }
                lector.Close();
            }
            catch (IOException ex)
            {
                mensaje = ("ERROR: " + ex.Message);
            }

        }

        public void BuscarUsuarios(string id)
        {
            try
            {


                archivo = new FileStream(rutaUsuariosVentas, FileMode.Open, FileAccess.Read);
                lector = new StreamReader(archivo);
                string Linea;
                string[] cadena = new string[3];
                bool encontro = false;
                int pos = 0, i = 0;
                while ((Linea = lector.ReadLine()) != null)
                {
                    cadena = Linea.Split(new char[] { ',' });
                    if (cadena[0] == id)
                    {
                        IdUsuario = cadena[0];
                        NombreUsuario = cadena[1];
                        ContactoUsuario = cadena[2];
                        encontro = true;
                        pos = i;
                    }
                    i++;
                }
                lector.Close();
            }
            catch (IOException ex)
            {
                mensaje = ("ERROR: " + ex.Message);
            }

        }

        public List<string> ListadoSeguro()
        {
            try
            {
                archivo = new FileStream(rutaSeguros, FileMode.Open, FileAccess.Read);
                lector = new StreamReader(archivo);
                string linea;
                while ((linea = lector.ReadLine()) != null)
                { // Lee líneas mientras haya (mientras sean !=null)
                    listaSeguros.Add(linea);
                }
                lector.Close();
            }
            catch (IOException ex)
            {
                mensaje = ("ERROR: " + ex.Message);
            }
            return listaSeguros;
        }
        public List<string> ListadoUsuario()
        {
            try
            {
                archivo = new FileStream(rutaUsuariosVentas, FileMode.Open, FileAccess.Read);
                lector = new StreamReader(archivo);
                string linea;
                while ((linea = lector.ReadLine()) != null)
                { // Lee líneas mientras haya (mientras sean !=null)
                    listaUsuarios.Add(linea);
                }
                lector.Close();
            }
            catch (IOException ex)
            {
                mensaje = ("ERROR: " + ex.Message);
            }
            return listaUsuarios;

        }

    }
}
