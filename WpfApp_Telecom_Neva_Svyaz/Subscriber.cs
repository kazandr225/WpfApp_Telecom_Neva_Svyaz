//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp_Telecom_Neva_Svyaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscriber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscriber()
        {
            this.Subscriber_Service = new HashSet<Subscriber_Service>();
        }
    
        public int idSubscriber { get; set; }
        public string NumberSubscriber { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public Nullable<int> idGender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<int> idAdressSubscriber { get; set; }
        public string Number { get; set; }
        public string Passport { get; set; }
        public Nullable<int> idDivisionCode { get; set; }
        public Nullable<int> idIssued { get; set; }
        public Nullable<System.DateTime> IssuedDate { get; set; }
        public string ContractNumber { get; set; }
        public Nullable<System.DateTime> ConclusionDate { get; set; }
        public Nullable<int> idContractType { get; set; }
        public Nullable<int> idReasonTerminate { get; set; }
        public Nullable<System.DateTime> TerminateDate { get; set; }
        public string PersonalAccaunt { get; set; }
        public Nullable<System.DateTime> RentDate { get; set; }
        public Nullable<int> idSerialNumber { get; set; }
    
        public virtual AdressSubscriber AdressSubscriber { get; set; }
        public virtual Contract_Type Contract_Type { get; set; }
        public virtual DivisionCode DivisionCode { get; set; }
        public virtual FMS FMS { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ReasonTerminate ReasonTerminate { get; set; }
        public virtual SerialNumber SerialNumber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriber_Service> Subscriber_Service { get; set; }
    }
}
