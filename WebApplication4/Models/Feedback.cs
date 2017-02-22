using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Feedback
    {

        public int Id { get; set; }

        [Required(ErrorMessageResourceType = (typeof(Resources.GiftGalleryResources)), ErrorMessageResourceName = "errNameField")]
        [Display(Name = "lblNameFld", ResourceType = typeof(Resources.GiftGalleryResources))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = (typeof(Resources.GiftGalleryResources)), ErrorMessageResourceName = "errEmailField")]
        [Display(Name = "lblEmailID", ResourceType = typeof(Resources.GiftGalleryResources))]
        public string EmaiID { get; set; }

        [Required(ErrorMessageResourceType = (typeof(Resources.GiftGalleryResources)), ErrorMessageResourceName = "errFeedbackField")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "lblFeedback", ResourceType = typeof(Resources.GiftGalleryResources))]
        public string UserFeedback { get; set; }

    }

}