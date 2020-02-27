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
    [Table("Trains",Schema="dbo")]
    public partial class Train
    {
		#region TrainId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TrainId Annotations

        public int TrainId { get; set; }

		#region TrainName Annotations

        [Required]
        [MaxLength(50)]
		#endregion TrainName Annotations

        public string TrainName { get; set; }

		#region TrainDetails Annotations

        [InverseProperty("Train")]
		#endregion TrainDetails Annotations

        public virtual ICollection<TrainDetail> TrainDetails { get; set; }


        public Train()
        {
			TrainDetails = new HashSet<TrainDetail>();
        }
	}
}