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
    [Table("Travellers",Schema="dbo")]
    public partial class Traveller
    {
		#region TravellerId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TravellerId Annotations

        public int TravellerId { get; set; }

		#region AppUserId Annotations

        [RelationshipTableAttribue("AppUsers","dbo","","AppUserId")]
		#endregion AppUserId Annotations

        public Nullable<int> AppUserId { get; set; }

		#region FirstName Annotations

        [Required]
        [MaxLength(50)]
		#endregion FirstName Annotations

        public string FirstName { get; set; }

		#region LastName Annotations

        [Required]
        [MaxLength(50)]
		#endregion LastName Annotations

        public string LastName { get; set; }

		#region EmailId Annotations

        [Required]
        [MaxLength(50)]
		#endregion EmailId Annotations

        public string EmailId { get; set; }

		#region MobileNumber Annotations

        [Required]
		#endregion MobileNumber Annotations

        public decimal MobileNumber { get; set; }

		#region AppUser Annotations

        [ForeignKey(nameof(AppUserId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.AppUser.Travellers))]
		#endregion AppUser Annotations

        public virtual AppUser AppUser { get; set; }


        public Traveller()
        {
        }
	}
}