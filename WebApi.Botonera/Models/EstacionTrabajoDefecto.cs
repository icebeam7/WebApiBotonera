using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Botonera.Models
{
    public class EstacionTrabajoDefecto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CantidadDefecto { get; set; }

        [Required, MaxLength(50)]
        public string EstacionTrabajo { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        [ForeignKey("FK_EstacionTrabajoDefecto")]
        public int IdDefecto { get; set; }
        public Defecto FK_EstacionTrabajoDefecto { get; set; }
    }
}
