using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vBusDetails",Schema="dbo")]
    public partial class vBusDetail
    {

        public string AvailableDay { get; set; }


        public string BusDetails { get; set; }


        public string Origin { get; set; }


        public string Destination { get; set; }

		#region LeftSeats Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LeftSeats Annotations

        public int LeftSeats { get; set; }


        public decimal Amount { get; set; }


        public string BusName { get; set; }


        public string BusType { get; set; }


        public string Transport { get; set; }


        public int BusId { get; set; }


        public vBusDetail()
        {
        }
	}
}