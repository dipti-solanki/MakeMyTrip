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
    [Table("BusAvailabilityDays",Schema="dbo")]
    public partial class BusAvailabilityDay
    {
		#region BusAvailableId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BusAvailableId Annotations

        public int BusAvailableId { get; set; }

		#region AvailableDay Annotations

        [Required]
        [MaxLength(50)]
		#endregion AvailableDay Annotations

        public string AvailableDay { get; set; }

		#region BusDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("BusDetails","dbo","","BusDetailId")]
		#endregion BusDetailId Annotations

        public int BusDetailId { get; set; }

		#region BusDetail Annotations

        [ForeignKey(nameof(BusDetailId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.BusDetail.BusAvailabilityDays))]
		#endregion BusDetail Annotations

        public virtual BusDetail BusDetail { get; set; }


        public BusAvailabilityDay()
        {
        }
	}
}