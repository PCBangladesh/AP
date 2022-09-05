using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Common.Models
{
    public class Product
    {
        [Key]
        public int ProyectId { get; set; }

        [Required]
        //[StringLength(20)]
        public string Nombre { get; set; }
        
        [Display(Name = "Razon Social")]
        //[StringLength(20)]
        public string RazonSocial { get; set; }

        //[Display(Name = "Tipo de Proyecto")]
        public string TipoProyecto { get; set; }
        public string Inmueble { get; set; }

        [Required]
        //[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]   
        public Decimal Presupuesto { get; set; }

        //[Display(Name = "Fecha de Inicio")]
        //[DataType(DataType.Date)]
        public DateTime PublishOn { get; set; }

        //[Display(Name = "Image")]
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
