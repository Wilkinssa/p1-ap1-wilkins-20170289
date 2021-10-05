using System;
using System.Collections.Generic;
using System.Text;
//Using agregados
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p1_ap1_wilkins_20170289.Entidades
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public String Persona { get; set; }
        public String Concepto { get; set; }
        public double Monto { get; set; }
    }
}