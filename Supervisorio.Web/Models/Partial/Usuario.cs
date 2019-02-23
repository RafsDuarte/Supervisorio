using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supervisorio.Web
{
    [MetadataType(typeof(MD_USUARIO))]
    public partial class USUARIO
    {
        internal class MD_USUARIO
        {

            [DisplayName("ID")]
            public object ID { get; set; }

            [DisplayName("Funcão")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Funcao { get; set; }

            [DisplayName("Data Cadastro")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public DateTime DataCadastro { get; set; }

            [DisplayName("Imagem")]
            [DataType(DataType.ImageUrl)]
            public byte[] Imagem { get; set; }

            [DisplayName("Data Nascimento")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public DateTime DataNascimento { get; set; }

            [DisplayName("Documento")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Documento { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Nome { get; set; }

            [DisplayName("Email")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [DataType(DataType.EmailAddress)]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Email { get; set; }

            [DisplayName("Logradouro")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Logradouro { get; set; }

            [DisplayName("Nome do Logradouro ")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object NomeLogradouro { get; set; }

            [DisplayName("Número")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Numero { get; set; }

            [DisplayName("Bairro")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Bairro { get; set; }

            [DisplayName("Estado")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Estado { get; set; }

            [DisplayName("Cidade")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            public object Cidade { get; set; }

            [DisplayName("Telefone")]
            [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
            [StringLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} e no minimo {2} caracteres")]
            public object Telefone { get; set; }

            [DisplayName("Celular")]
            public object Celular { get; set; }
        }
    }
}