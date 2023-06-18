using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyWebsiteLibrary.Entities
{
	public class TextField : EntityBase
	{
		[Required]
		public string? CodeWord { get; set; }

		[Display(Name = "Page Name")]
		public override string? Title { get; set; } = "Information page";

        [Display(Name = "Page content")]
        public override string? Text { get; set; } = "Content is filled by the administrator";
    }
}

