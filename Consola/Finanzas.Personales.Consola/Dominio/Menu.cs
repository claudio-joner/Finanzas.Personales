using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Personales.Consola.Dominio
{
    public class Menu
    {
        public int MostrarMenu(string mensaje,int cantidadOpc)
        {
            Console.WriteLine(mensaje);
            return MenuOpciones(cantidadOpc);
        }

        public int MenuOpciones(int cantidadOpc)
        {
            try
            {
                bool estado;
                do
                {
                    estado = false;
                    Console.WriteLine($"Ingrese la opción correspondiente.Válido de 1 a {cantidadOpc}.");
                    int respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta > 0 && respuesta <= cantidadOpc)
                    {
                        estado = false;
                        return respuesta;
                    }
                } while (estado);
                return -1;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }



        public void Salir()
        {
            string mensaje = "¿Desea salir de la app ? 1-Si 2-No.\n";
            if(MostrarMenu(mensaje,2) == 1)
            {
                Environment.Exit(0);
            }
        }

        public bool MenuCrearUsuario()
        {
            try
            {
                bool estado;
                Console.WriteLine("Ingresar Nombre y Apellido: \n");
                string nombreUsu = Console.ReadLine();
                Console.WriteLine("Ingresar el objetivo de ahorro(Monto que desea ahorrar):\n");
                double obj = Convert.ToDouble(Console.ReadLine()); 

                if( MenuBuscarUsuario(nombreUsu) != null)
                {
                    Usuarios nuevoUsu = new Usuarios(nombreUsu, obj);
                    estado = true;
                }
                else
                {
                    estado =  false;
                }
                return estado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }

        /*
         El método MenuBuscarUsuario(string nombreUsu) buscara en el origen, ya sea .csv .xml bd, al usuario
         */

        public Usuarios MenuBuscarUsuario(string nombreUsu)
        {
            try
            {
                Usuarios usuario = new Usuarios();
                return usuario;
            }
            catch(Exception ex)
            {
                throw;
            }

        }

        public bool MenuModificarUsuario(string nombre)
        {
            try
            {
                Usuarios usuario = MenuBuscarUsuario(nombre);
                if (usuario is not null)
                {
                    Usuarios nuevoUsuario = new Usuarios();
                    nuevoUsuario.IdUsuario = usuario.IdUsuario;
                    nuevoUsuario.listMovimiento = usuario.listMovimiento;
                    Console.WriteLine("Ingrese el nuevo nombre de Usuario");
                    nuevoUsuario.NombreUsuario = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo objetivo del usuario");
                    nuevoUsuario.Objetivo = Convert.ToDouble(Console.ReadLine());
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        public void MenuVolver()
        {
            
        }
    }
}
