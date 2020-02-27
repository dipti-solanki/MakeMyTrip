using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vTrainDetails",Schema="dbo")]
    public partial class vTrainDetail
    {

        public string AvailableDay { get; set; }


        public string TrainDetails { get; set; }


        public string Class { get; set; }


        public string Origin { get; set; }


        public string Destination { get; set; }


        public decimal Amount { get; set; }


        public string TrainName { get; set; }

		#region TrainId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TrainId Annotations

        public int TrainId { get; set; }


        public vTrainDetail()
        {
        }
	}
}