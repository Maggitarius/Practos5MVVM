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
    
    public partial class Account_Game
    {
        public int ID_Account_Game { get; set; }
        public int Account_ID { get; set; }
        public int Game_ID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Games Games { get; set; }
    }
}
