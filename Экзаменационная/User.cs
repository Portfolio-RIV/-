//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Экзаменационная
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int KeyUser { get; set; }
        public int KeyRole { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
    
        public virtual RoleUser RoleUser { get; set; }
    }
}
