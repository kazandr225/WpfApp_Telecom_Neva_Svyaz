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
    
    public partial class Users
    {
        public int idUser { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int idGender { get; set; }
        public string image { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int idRole { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
