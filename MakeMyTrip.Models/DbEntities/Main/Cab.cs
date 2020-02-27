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
    [Table("Cabs",Schema="dbo")]
    public partial class Cab
    {
		#region CabId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CabId Annotations

        public int CabId { get; set; }

		#region CabName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CabName Annotations

        public string CabName { get; set; }

		#region Cabs Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion Cabs Annotations

        public int Cabs { get; set; }

		#region CabDetails Annotations

        [InverseProperty("Cab")]
		#endregion CabDetails Annotations

        public virtual ICollection<CabDetail> CabDetails { get; set; }


        public Cab()
        {
			CabDetails = new HashSet<CabDetail>();
        }
	}
}