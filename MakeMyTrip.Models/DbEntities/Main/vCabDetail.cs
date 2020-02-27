using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vCabDetails",Schema="dbo")]
    public partial class vCabDetail
    {

        public string CabName { get; set; }


        public string CabDetails { get; set; }


        public string Facilities { get; set; }

		#region CabId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CabId Annotations

        public int CabId { get; set; }


        public int CabDetailId { get; set; }


        public decimal Amount { get; set; }


        public int ReviewId { get; set; }


        public int Expr1 { get; set; }


        public int Cabs { get; set; }


        public string Origin { get; set; }


        public string Destination { get; set; }


        public string AvailableDay { get; set; }


        public vCabDetail()
        {
        }
	}
}