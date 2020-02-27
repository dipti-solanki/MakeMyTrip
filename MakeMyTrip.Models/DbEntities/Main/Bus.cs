using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.Models.Enums.Main;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("Buses",Schema="dbo")]
    public partial class Bus
    {
		#region BusId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BusId Annotations

        public int BusId { get; set; }

		#region BusName Annotations

        [Required]
        [MaxLength(50)]
		#endregion BusName Annotations

        public string BusName { get; set; }

		#region BusDetails Annotations

        [InverseProperty("Bus")]
		#endregion BusDetails Annotations

        public virtual ICollection<BusDetail> BusDetails { get; set; }


        public Bus()
        {
			BusDetails = new HashSet<BusDetail>();
        }
	}
}