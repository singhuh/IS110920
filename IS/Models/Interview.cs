//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Interview
    {
        public int InterviewId { get; set; }
        [Display(Name = "M#")]
        [RegularExpression(@"^M{1}\d{8}$", ErrorMessage = "Must be valid a M#")]
        [Required(ErrorMessage = "Please provide M#")]
        [StringLength(9, ErrorMessage = "9 characters only")]
        public string MNumber { get; set; }
        [Display(Name = "Interviewing Company")]
        [Required(ErrorMessage = "Please provide Interview company")]
        [StringLength(50, ErrorMessage = "50 characters only")]
        public string InterviewCompany { get; set; }
        [Display(Name = "Interview Date")]
        [Required(ErrorMessage = "Please provide Interview date")]
        public System.DateTime InterviewDate { get; set; }
        public Nullable<bool> Offer { get; set; }

        public virtual StudentAlum StudentAlum { get; set; }
    }
}
