//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projecto_Desenvolvimento_Aplicaçoes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Casa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Casa()
        {
            this.Limpezas = new HashSet<Limpeza>();
        }
    
        public int IdCasa { get; set; }
        public string Localidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int Andar { get; set; }
        public decimal Area { get; set; }
        public int NumeroAssoalhadas { get; set; }
        public int NumeroWC { get; set; }
        public int NumeroPisos { get; set; }
        public string Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Limpeza> Limpezas { get; set; }
        public virtual Cliente Proprietario { get; set; }
    }
}
