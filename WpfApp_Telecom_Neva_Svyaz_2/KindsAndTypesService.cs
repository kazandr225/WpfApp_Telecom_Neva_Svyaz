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
    
    public partial class KindsAndTypesService
    {
        public int KindsAndTypesServiceID { get; set; }
        public int TypeOfServiceID { get; set; }
        public int ServiceType { get; set; }
    
        public virtual TypeOfService TypeOfService { get; set; }
        public virtual TypesServices TypesServices { get; set; }
    }
}