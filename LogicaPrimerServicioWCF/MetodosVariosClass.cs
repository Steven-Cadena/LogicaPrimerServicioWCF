using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrimerServicioWCF
{
    //importante poner la clase publica 
    public class MetodosVariosClass : IMetodosVariosContract
    {
        public int GetNumeroDoble(int numero)
        {
            return numero * 2;
        }

        public string GetSaludo(string nombre)
        {
            return "Mi primer WCF de martes, " + nombre;
        }

        public string MetodoVisible()
        {
            return "no valgo para el servicio";
        }
    }
}
