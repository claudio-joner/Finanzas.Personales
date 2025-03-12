using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Personales.Consola.Dominio
{
    public class Usuarios
    {
        public string NombreUsuario { get; set; }
        public double Objetivo { get; set; }
        public List<Movimiento> listMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Ahorro { get; set; }
        public Usuarios()
        {
            
        }
        public Usuarios(string nom, double obj) //Despues se ira agregando cada vez mas prop
        {
            NombreUsuario = nom;
            Objetivo = obj;
            listMovimiento = new List<Movimiento>();
            IdUsuario = 0;
            Fecha = DateTime.Now;
            Ahorro = 0;
        }

        public void ListarMovimientos()
        {
            foreach (var item in listMovimiento)
            {
                if (item.Estado)
                {
                    item.ToString();
                }
            }
        }

        public bool CargarMov(Usuarios usuario, Movimiento mov)
        {
            usuario.listMovimiento.Add(mov);

            return true;
        }

        public bool ActualizarMov(Usuarios usuario,Movimiento mov)
        {
            foreach(Movimiento m in usuario.listMovimiento)
            {
                if(mov.IdMovimiento == m.IdMovimiento)
                {
                    m.TipoMovimiento = mov.TipoMovimiento;
                    m.Motivo = mov.Motivo;
                    m.Monto = mov.Monto;
                    m.Descripcion = m.Descripcion;
                    m.FechaCharga = DateTime.Now;

                    return true;
                }
            }
            return false;
        }

        public bool BorrarMov(Usuarios usuario, Movimiento mov)
        {
            foreach (Movimiento m in usuario.listMovimiento)
            {
                if (m.IdMovimiento == mov.IdMovimiento)
                {
                    usuario.listMovimiento.Remove(m);
                    return true;
                }
            }   

            return false;
        }

        public void BorradoLogico(Usuarios usuario, Movimiento mov)
        {
            foreach(Movimiento m in usuario.listMovimiento)
            {
                if(mov.IdMovimiento == m.IdMovimiento)
                {
                    m.Estado = false;
                }
            }
        }

        public bool AnularMovimiento(Usuarios usuario, int idMov)
        {
            foreach (Movimiento movimiento in usuario.listMovimiento)
            {
                if(idMov == movimiento.IdMovimiento)
                {
                    movimiento.Estado = false;
                    Movimiento movimientoBaja = new Movimiento();


                }
            }
        }
    }
}
