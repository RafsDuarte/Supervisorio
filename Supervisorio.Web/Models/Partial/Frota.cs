using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Supervisorio.Web
{
    [MetadataType(typeof(MD_FROTA))]
    public partial class FROTA
    {
        internal class MD_FROTA
        {

            [DisplayName("Placa")]
            [DisplayFormat(DataFormatString = "AAAAAAA")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Placa { get; set; }

            [DisplayName("Marca")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Marca { get; set; }

            [DisplayName("Tara")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Tara { get; set; }

            [DisplayName("Peso Bruto")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public byte[] PesoBruto { get; set; }
        }
    }
}