using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoraBlazor.Models
{
    public class Moras
    {
        [Key]
        [Required(ErrorMessage = "El campo ID no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo ID no puede ser menor que cero o mayor a 1000000.")]
        public int MoraId { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo Fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo Monto no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo Monto no puede ser menor que cero o mayor a 1000000.")]
        public decimal Total { get; set; }

        [ForeignKey("MoraId")]
        public virtual List<MoraDetalles> MoraDetalles { get; set; }

        public Moras()
        {
            MoraId = 0;
            Fecha = DateTime.Now;
            Total = 0;
            MoraDetalles = new List<MoraDetalles>();
        }

        public Moras(int moraId, DateTime fecha, decimal total, List<MoraDetalles> moraDetalles)
        {
            MoraId = moraId;
            Fecha = fecha;
            Total = total;
            MoraDetalles = moraDetalles ?? throw new ArgumentNullException(nameof(moraDetalles));
        }
    }
}
