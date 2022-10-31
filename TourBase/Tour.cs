//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tour
    {
        public Tour()
        {
            this.Hotels = new HashSet<Hotel>();
            this.Types = new HashSet<Type>();
        }
    
        public int id { get; set; }
        public int TickerCount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImagePreview { get; set; }
        public decimal Price { get; set; }
        public bool IsActual { get; set; }
    
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<Type> Types { get; set; }
    }
}
