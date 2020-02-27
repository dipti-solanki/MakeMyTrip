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
    [Table("AppUsers",Schema="dbo")]
    public partial class AppUser
    {
		#region AppUserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion AppUserId Annotations

        public int AppUserId { get; set; }

		#region MobileNumber Annotations

        [Required]
		#endregion MobileNumber Annotations

        public decimal MobileNumber { get; set; }

		#region EmailId Annotations

        [Required]
        [MaxLength(50)]
		#endregion EmailId Annotations

        public string EmailId { get; set; }

		#region AppPassword Annotations

        [Required]
        [MaxLength(50)]
		#endregion AppPassword Annotations

        public string AppPassword { get; set; }

		#region Reviews Annotations

        [InverseProperty("AppUser")]
		#endregion Reviews Annotations

        public virtual ICollection<Review> Reviews { get; set; }

		#region Travellers Annotations

        [InverseProperty("AppUser")]
		#endregion Travellers Annotations

        public virtual ICollection<Traveller> Travellers { get; set; }


        public AppUser()
        {
			Reviews = new HashSet<Review>();
			Travellers = new HashSet<Traveller>();
        }
	}
}