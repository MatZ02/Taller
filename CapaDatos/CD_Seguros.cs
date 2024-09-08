using System.Collections.Generic;
using System.IO;

namespace CapaDatos
{
    public class CD_Seguros
    {
        public class Seguro
        {
            public string Codigo { get; set; }
            public string Tipo { get; set; }
            public decimal PorcentajeIncremento { get; set; }
            public decimal Valor { get; set; }
        }
        public class Usuario
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string Contacto { get; set; }
        }


        public class Venta
        {
            public string CodigoSeguro { get; set; }
            public Usuario Cliente { get; set; }
            public int CantidadBeneficiarios { get; set; }
            public decimal ValorTotal { get; set; }
        }
        public string getmensaje() { return mensaje; }

        List<string> listaSeguros = new List<string>();
        List<string> listaUsuarios = new List<string>();

        private string mensaje = "";

        private string rutaSeguros = @"C:\Users\PC\Documents\Seguros.txt";
        private string rutaUsuariosVentas = @"C:\Users\PC\Documents\UsuariosVentas.txt";

        public void GuardarSeguro(Seguro seguro)
        {
            try
            {
                using (var archivo = new FileStream(rutaSeguros, FileMode.Append, FileAccess.Write))
                using (var escritor = new StreamWriter(archivo))
                {
                    escritor.WriteLine($"{seguro.Codigo},{seguro.Tipo},{seguro.PorcentajeIncremento},{seguro.Valor}");
                }
                mensaje = "Se ha registrado el seguro";
            }
            catch (IOException ex)
            {
                mensaje = "ERROR: " + ex.Message;
            }
        }


        public void GuardarUsuario(Usuario usuario)
        {
            try
            {
                using (var archivo = new FileStream(rutaUsuariosVentas, FileMode.Append, FileAccess.Write))
                using (var escritor = new StreamWriter(archivo))
                {
                    escritor.WriteLine($"{usuario.Id},{usuario.Nombre},{usuario.Contacto}");
                }
                mensaje = "Se ha registrado el usuario";
            }
            catch (IOException ex)
            {
                mensaje = "ERROR: " + ex.Message;
            }
        }


        public Seguro BuscarSeguro(string id)
        {
            Seguro seguroEncontrado = null;
            try
            {
                using (var archivo = new FileStream(rutaSeguros, FileMode.Open, FileAccess.Read))
                using (var lector = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        var cadena = linea.Split(',');
                        if (cadena[0] == id)
                        {
                            seguroEncontrado = new Seguro
                            {
                                Codigo = cadena[0],
                                Tipo = cadena[1],
                                PorcentajeIncremento = decimal.Parse(cadena[2]),
                                Valor = decimal.Parse(cadena[3])
                            };
                            break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                mensaje = "ERROR: " + ex.Message;
            }
            return seguroEncontrado;
        }



        public Usuario BuscarUsuario(string id)
        {
            Usuario usuarioEncontrado = null;
            try
            {
                using (var archivo = new FileStream(rutaUsuariosVentas, FileMode.Open, FileAccess.Read))
                using (var lector = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        var cadena = linea.Split(',');
                        if (cadena[0] == id)
                        {
                            usuarioEncontrado = new Usuario
                            {
                                Id = cadena[0],
                                Nombre = cadena[1],
                                Contacto = cadena[2]
                            };
                            break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                mensaje = "ERROR: " + ex.Message;
            }
            return usuarioEncontrado;
        }


        public List<string> ListadoSeguro()
        {
            try
            {
                using (var archivo = new FileStream(rutaSeguros, FileMode.Open, FileAccess.Read))
                using (var lector = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        listaSeguros.Add(linea);
                    }
                }
            }
            catch (IOException ex)
            {
                mensaje = "ERROR: " + ex.Message;
            }
            return listaSeguros;
        }

        public List<string> ListadoUsuario()
        {
            try
            {
                using (var archivo = new FileStream(rutaUsuariosVentas, FileMode.Open, FileAccess.Read))
                using (var lector = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        listaUsuarios.Add(linea);
                    }
                }
            }
            catch (IOException ex)
            {
                mensaje = "ERROR: " + ex.Message;
            }
            return listaUsuarios;
        }


    }
}
