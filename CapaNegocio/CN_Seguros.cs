using CapaDatos;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Seguros
    {
        private CD_Seguros objetoCD = new CD_Seguros();
        private string mensaje = "";
        private string codigo;
        private string tipoSeguro;
        private string incremento;
        private string valor;
        private string IdUsuario;
        private string NombreUsuario;
        private string ContactoUsuario;

        public string Codigo { get => codigo; set => codigo = value; }
        public string TipoSeguro { get => tipoSeguro; set => tipoSeguro = value; }
        public string Incremento { get => incremento; set => incremento = value; }
        public string Valor { get => valor; set => valor = value; }
        public string IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public string NombreUsuario1 { get => NombreUsuario; set => NombreUsuario = value; }
        public string ContactoUsuario1 { get => ContactoUsuario; set => ContactoUsuario = value; }
        public string getmensaje() { return mensaje; }

        public List<string> ListaSeguros()
        {
            List<string> lista = new List<string>();
            lista = objetoCD.ListadoSeguro();
            return lista;
        }

        public List<string> ListaUsuarios()
        {
            List<string> lista = new List<string>();
            lista = objetoCD.ListadoUsuario();
            return lista;
        }

        public void insertarSeguro(string cod, string tipo, string incremento, string valor)
        {
            objetoCD.guardarSeguros(cod, tipo, incremento, valor);
            mensaje = objetoCD.getmensaje();
        }

        public void insertarUsuario(string id, string nombre, string contacto)
        {
            objetoCD.guardarUsuarios(id, nombre, contacto);
            mensaje = objetoCD.getmensaje();
        }

        public void buscarSeguro(string cod)
        {
            objetoCD.BuscarSeguros(cod);
            codigo = Codigo;
            tipoSeguro = TipoSeguro;
            incremento = Incremento;
            valor = Valor;
        }
        public void buscarUsuario(string id)
        {
            objetoCD.BuscarUsuarios(id);
            id = IdUsuario1;
            NombreUsuario = NombreUsuario1;
            ContactoUsuario = ContactoUsuario1;
        }
    }
}
