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
    
    public partial class Emploe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emploe()
        {
            this.InstallationEquipment = new HashSet<InstallationEquipment>();
        }
    
        public int IDEmploys { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
        public string image { get; set; }
    
        public virtual Rols Rols { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstallationEquipment> InstallationEquipment { get; set; }
    }
}
