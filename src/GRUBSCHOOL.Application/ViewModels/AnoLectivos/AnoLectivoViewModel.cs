using System;
using System.ComponentModel.DataAnnotations;

namespace GRUBSCHOOL.Application.ViewModels
{
    public class AnoLectivoViewModel
    {
        [Display(Name = "Ano Lectivo")]
        public int Ano { get; set; }
        [Display(Name = "Data de Ínicio")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de Término")]
        public DateTime DataTermino { get; set; }
    }
}
