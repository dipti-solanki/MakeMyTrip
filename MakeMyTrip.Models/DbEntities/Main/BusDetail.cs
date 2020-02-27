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
    [Table("BusDetails",Schema="dbo")]
    public partial class BusDetail
    {
		#region BusDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BusDetailId Annotations

        public int BusDetailId { get; set; }

		#region BusId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Buses","dbo","","BusId")]
		#endregion BusId Annotations

        public int BusId { get; set; }

		#region BusDetails Annotations

        [Required]
        [MaxLength(50)]
		#endregion BusDetails Annotations

        public string BusDetails { get; set; }

		#region Origin Annotations

        [Required]
        [MaxLength(50)]
		#endregion Origin Annotations

        public string Origin { get; set; }

		#region Destination Annotations

        [Required]
        [MaxLength(50)]
		#endregion Destination Annotations

        public string Destination { get; set; }

		#region Date Annotations

        [Required]
		#endregion Date Annotations

        public System.DateTimeOffset Date { get; set; }

		#region LeftSeats Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion LeftSeats Annotations

        public int LeftSeats { get; set; }

		#region Amount Annotations

        [Required]
		#endregion Amount Annotations

        public decimal Amount { get; set; }

		#region ReviewId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Reviews","dbo","","ReviewId")]
		#endregion ReviewId Annotations

        public int ReviewId { get; set; }

		#region BusType Annotations

        [MaxLength(50)]
		#endregion BusType Annotations

        public string BusType { get; set; }

		#region Transport Annotations

        [MaxLength(50)]
		#endregion Transport Annotations

        public string Transport { get; set; }

		#region Bus Annotations

        [ForeignKey(nameof(BusId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Bus.BusDetails))]
		#endregion Bus Annotations

        public virtual Bus Bus { get; set; }

		#region Review Annotations

        [ForeignKey(nameof(ReviewId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Review.BusDetails))]
		#endregion Review Annotations

        public virtual Review Review { get; set; }

		#region BusAvailabilityDays Annotations

        [InverseProperty("BusDetail")]
		#endregion BusAvailabilityDays Annotations

        public virtual ICollection<BusAvailabilityDay> BusAvailabilityDays { get; set; }


        public BusDetail()
        {
			BusAvailabilityDays = new HashSet<BusAvailabilityDay>();
        }
	}
}