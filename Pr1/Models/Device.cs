//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pr1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            this.Verification1 = new HashSet<Verification>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> IdMode { get; set; }
        public Nullable<int> IdCondition { get; set; }
        public Nullable<int> IdDepartment { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Unit { get; set; }
        public Nullable<int> IdVerification { get; set; }
        public Nullable<int> IdRepairOfTheDevice { get; set; }
    
        public virtual Condition Condition { get; set; }
        public virtual Department Department { get; set; }
        public virtual Mode Mode { get; set; }
        public virtual RepairOfTheDevice RepairOfTheDevice { get; set; }
        public virtual Verification Verification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Verification> Verification1 { get; set; }
    }
}
