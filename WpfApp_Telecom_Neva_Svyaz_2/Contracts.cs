//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp_Telecom_Neva_Svyaz_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contracts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contracts()
        {
            this.ConnectingTheService = new HashSet<ConnectingTheService>();
        }
    
        public int SubscribersID { get; set; }
        public string ContractNumber { get; set; }
        public System.DateTime DateOfCinclusion { get; set; }
        public int TypeContractID { get; set; }
        public int PersonalAccount { get; set; }
        public Nullable<int> ReasonForTerminationID { get; set; }
        public Nullable<System.DateTime> TermibationDate { get; set; }
    
        public virtual Clients Clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectingTheService> ConnectingTheService { get; set; }
        public virtual Reasons Reasons { get; set; }
        public virtual TypesOfContracts TypesOfContracts { get; set; }
    }
}