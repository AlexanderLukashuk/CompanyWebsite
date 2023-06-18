using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyWebsiteLibrary.Entities
{
	public class ServiceItem : EntityBase
	{
		[Required(ErrorMessage = "Fill in the name of the service")]
		[Display(Name = "Service name")]
		public override string? Title { get; set; } = "Information page";

        [Display(Name = "Full description")]
        public override string? Text { get; set; }
    }
}

