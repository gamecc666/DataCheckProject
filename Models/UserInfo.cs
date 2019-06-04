using System.ComponentModel.DataAnnotations;
namespace DataCheckProject.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage ="用户名不能为空")]
        [StringLength(10,ErrorMessage ="用户名长度不能超过10")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        [StringLength(6,ErrorMessage ="密码长度不能超过6")]
        public string Passward { get; set; }
    }
}
