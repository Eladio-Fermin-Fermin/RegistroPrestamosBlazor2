using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamosBlazor2.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        //[Required(ErrorMessage = "Es obligatorio introducir la fecha")]
        public DateTime Fecha { get; set; }
        //[Required(ErrorMessage = "Es obligatorio introducir una PersonaId")]
        public int PersonaId { get; set; }
        //[Required(ErrorMessage = "Es obligatorio introducir un Concepto")]
        public float Concepto { get; set; }
        //[Required(ErrorMessage = "Es obligatorio introducir un Monto")]
        public float Monto { get; set; }
        public float Balance { get; set; }
    }
}
