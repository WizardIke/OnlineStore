using System.ComponentModel.DataAnnotations;

namespace _16125296_OnlineStore.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Role Name")]
        public string Name { get; set; }

    }
}
