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
    
    public partial class Store_Warehouse
    {
        public int Store_Warehouse_ID { get; set; }
        public int Store_ID { get; set; }
        public int Warehouse_ID { get; set; }
    
        public virtual Store Store { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
