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
    
    public partial class Equipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipment()
        {
            this.InstallationEquipment = new HashSet<InstallationEquipment>();
        }
    
        public int IDEquipment { get; set; }
        public string NameOfEquipment { get; set; }
        public int IDType { get; set; }
        public Nullable<int> IDMac { get; set; }
        public int IDSerial { get; set; }
        public string Specifications { get; set; }
    
        public virtual SerialNumbers SerialNumbers { get; set; }
        public virtual TypeEquipments TypeEquipments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstallationEquipment> InstallationEquipment { get; set; }
    }
}
