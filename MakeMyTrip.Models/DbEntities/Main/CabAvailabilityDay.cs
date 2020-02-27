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
    [Table("CabAvailabilityDays",Schema="dbo")]
    public partial class CabAvailabilityDay
    {
		#region CabAvailableId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CabAvailableId Annotations

        public int CabAvailableId { get; set; }

		#region AvailableDay Annotations

        [Required]
        [MaxLength(50)]
		#endregion AvailableDay Annotations

        public string AvailableDay { get; set; }

		#region CabDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("CabDetails","dbo","","CabDetailId")]
		#endregion CabDetailId Annotations

        public int CabDetailId { get; set; }

		#region CabDetail Annotations

        [ForeignKey(nameof(CabDetailId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.CabDetail.CabAvailabilityDays))]
		#endregion CabDetail Annotations

        public virtual CabDetail CabDetail { get; set; }


        public CabAvailabilityDay()
        {
        }
	}
}