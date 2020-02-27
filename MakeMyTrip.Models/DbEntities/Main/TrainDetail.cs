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
    [Table("TrainDetails",Schema="dbo")]
    public partial class TrainDetail
    {
		#region TrainDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TrainDetailId Annotations

        public int TrainDetailId { get; set; }

		#region TrainId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Trains","dbo","","TrainId")]
		#endregion TrainId Annotations

        public int TrainId { get; set; }

		#region TrainDetails Annotations

        [Required]
        [MaxLength(50)]
		#endregion TrainDetails Annotations

        public string TrainDetails { get; set; }

		#region Class Annotations

        [Required]
        [MaxLength(50)]
		#endregion Class Annotations

        public string Class { get; set; }

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

		#region Amount Annotations

        [Required]
		#endregion Amount Annotations

        public decimal Amount { get; set; }

		#region Train Annotations

        [ForeignKey(nameof(TrainId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Train.TrainDetails))]
		#endregion Train Annotations

        public virtual Train Train { get; set; }

		#region TrainAvailabilityDays Annotations

        [InverseProperty("TrainDetail")]
		#endregion TrainAvailabilityDays Annotations

        public virtual ICollection<TrainAvailabilityDay> TrainAvailabilityDays { get; set; }


        public TrainDetail()
        {
			TrainAvailabilityDays = new HashSet<TrainAvailabilityDay>();
        }
	}
}