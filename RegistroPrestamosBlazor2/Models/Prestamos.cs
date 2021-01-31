using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamosBlazor2.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        //[Required(ErrorMessage = "Es obligatorio introducir la fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        //[Required(ErrorMessage = "Es obligatorio introducir una PersonaId")]
        public int PersonaId { get; set; }
        //[Required(ErrorMessage = "Es obligatorio introducir un Concepto")]
        public string Concepto { get; set; }
        //[Required(ErrorMessage = "Es obligatorio introducir un Monto")]
        public float Monto { get; set; }
        public float Balance { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Persona { get; set; }
    }
}
