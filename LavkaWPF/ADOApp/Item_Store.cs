//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LavkaWPF.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item_Store
    {
        public int Item_Store_ID { get; set; }
        public int Item_ID { get; set; }
        public int Store_ID { get; set; }
        public int Count { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Store Store { get; set; }
    }
}
