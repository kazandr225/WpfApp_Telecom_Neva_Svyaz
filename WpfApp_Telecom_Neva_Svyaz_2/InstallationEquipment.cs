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
    
    public partial class InstallationEquipment
    {
        public int InstallationEquipmentID { get; set; }
        public Nullable<System.DateTime> InstallationDate { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public int EquipmentID { get; set; }
        public int SubscriberID { get; set; }
        public string Notes { get; set; }
        public bool Rental { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Emploe Emploe { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
