using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS_POS.Model;


namespace PMS_POS.Controller
{
    class ControllerHabitacion
    {
        public void Insertar(int NumHab, string TipoHab, int CantCamas, int MaxPersonas, int Piso, string Plan, string Detalles, float PrecioPorNoche)
        {
       
            Habitacion h = new Habitacion();
            h.NumHab = NumHab;
            h.TipoHab = TipoHab;
            h.CantCamas = CantCamas;
            h.MaxPersonas = MaxPersonas;
            h.Piso = Piso;
            h.Plan = Plan;
            h.Detalles = Detalles;
            h.PrecioPorNoche = PrecioPorNoche;
           //return h.Insert(h);
        }
    }




}
