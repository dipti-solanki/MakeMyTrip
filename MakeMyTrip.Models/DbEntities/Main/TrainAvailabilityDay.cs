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
    [Table("TrainAvailabilityDays",Schema="dbo")]
    public partial class TrainAvailabilityDay
    {
		#region TrainAvailableId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TrainAvailableId Annotations

        public int TrainAvailableId { get; set; }

		#region AvailableDay Annotations

        [Required]
        [MaxLength(50)]
		#endregion AvailableDay Annotations

        public string AvailableDay { get; set; }

		#region TrainDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("TrainDetails","dbo","","TrainDetailId")]
		#endregion TrainDetailId Annotations

        public int TrainDetailId { get; set; }

		#region TrainDetail Annotations

        [ForeignKey(nameof(TrainDetailId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.TrainDetail.TrainAvailabilityDays))]
		#endregion TrainDetail Annotations

        public virtual TrainDetail TrainDetail { get; set; }


        public TrainAvailabilityDay()
        {
        }
	}
}