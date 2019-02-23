//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supervisorio.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.CICLOUSINA = new HashSet<CICLOUSINA>();
            this.DESTINO = new HashSet<DESTINO>();
            this.ENTRADA = new HashSet<ENTRADA>();
            this.RECEITA = new HashSet<RECEITA>();
        }
    
        public int ID { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public byte[] Imagem { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string NomeLogradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Funcao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CICLOUSINA> CICLOUSINA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DESTINO> DESTINO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA> ENTRADA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEITA> RECEITA { get; set; }
    }
}