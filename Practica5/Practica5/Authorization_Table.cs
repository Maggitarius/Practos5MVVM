//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authorization_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Authorization_Table()
        {
            this.Account = new HashSet<Account>();
        }
    
        public int ID_Authorization { get; set; }
        public string Login_Authorization { get; set; }
        public string Password_Authorization { get; set; }
        public int Role_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Account { get; set; }
        public virtual Roles Roles { get; set; }
    }
}