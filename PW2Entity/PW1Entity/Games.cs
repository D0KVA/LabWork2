//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PW1Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Games
    {
        public int ID_Game { get; set; }
        public string NameGame { get; set; }
        public int Zhanre_ID { get; set; }
    
        public virtual Zhanres Zhanres { private get; set; }
    }
}
