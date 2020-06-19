using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoraBlazor.Models
{
    public class MoraDetalles
    {
        [Key]
        [Required(ErrorMessage = "El campo ID no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo ID no puede ser menor que cero o mayor a 1000000.")]
        public int MoradetalleId { get; set; }

        [Required(ErrorMessage = "El campo Mora no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo no puede ser menor que cero o mayor a 1000000.")]
        public int MoraId { get; set; }

        [Required(ErrorMessage = "El campo Mora no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo no puede ser menor que cero o mayor a 1000000.")]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "El campo Valor no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo Valor no puede ser menor que cero o mayor a 1000000.")]
        public decimal Valor { get; set; }

        public MoraDetalles()
        {
            MoradetalleId = 0;
            MoraId = 0;
            PrestamoId = 0;
            Valor = 0;
        }

        public MoraDetalles(int moradetalleId, int moraId, int prestamoId, decimal valor)
        {
            MoradetalleId = moradetalleId;
            MoraId = moraId;
            PrestamoId = prestamoId;
            Valor = valor;
        }
    }
}
