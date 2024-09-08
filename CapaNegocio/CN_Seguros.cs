using CapaDatos;
using System;
using System.Collections.Generic;
using static CapaDatos.CD_Seguros;

namespace CapaNegocio
{
    public class CN_Seguros
    {
        private CD_Seguros cdSeguros = new CD_Seguros();

        public Seguro BuscarSeguro(string id)
        {
            return cdSeguros.BuscarSeguro(id);
        }

        public void GuardarSeguro(Seguro seguro)
        {
            cdSeguros.GuardarSeguro(seguro);
        }

        public List<Seguro> ListadoSeguros()
        {
            return cdSeguros.ListadoSeguros();
        }


        public Usuario BuscarUsuario(string id)
        {
            return cdSeguros.BuscarUsuario(id);
        }

        public void GuardarUsuario(Usuario usuario)
        {
            cdSeguros.GuardarUsuario(usuario);
        }

        public List<Usuario> ListadoUsuarios()
        {
            return cdSeguros.ListadoUsuarios();
        }

        public void GuardarVenta(Venta venta)
        {
            cdSeguros.GuardarVenta(venta);
        }

        public List<Venta> ListadoVentas()
        {
            return cdSeguros.ListadoVentas();
        }
        public Venta CalcularDetallesVenta(Seguro seguro, Usuario cliente, int cantidadBeneficiarios)
        {
            decimal valorBase = seguro.Valor;
            decimal porcentajeIncremento = seguro.PorcentajeIncremento;
            decimal incrementoPorTipo = valorBase * porcentajeIncremento / 100;
            decimal incrementoPorBeneficiario = valorBase * 0.10m * cantidadBeneficiarios;
            decimal valorTotal = valorBase + incrementoPorTipo + incrementoPorBeneficiario;

            return new Venta
            {
                CodigoSeguro = seguro.Codigo,
                Cliente = cliente,
                CantidadBeneficiarios = cantidadBeneficiarios,
                ValorBase = valorBase,
                IncrementoPorTipo = incrementoPorTipo,
                IncrementoPorBeneficiario = incrementoPorBeneficiario,
                ValorTotal = valorTotal
            };
        }



    }
}
