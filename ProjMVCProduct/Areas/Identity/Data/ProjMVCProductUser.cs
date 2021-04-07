using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjMVCProduct.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ProjMVCProductUser class
    public class ProjMVCProductUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public string Document { get; set; }
        [PersonalData]
        public TypePerson TypePerson { get; set; }

    }
}
