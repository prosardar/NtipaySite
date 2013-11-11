using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ntipay.Models {
    public class User {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? UserId { get; set; }

        public string Name { get; set; }
        
        [Key]
        [EmailAddress]
        [Editable(true)]
        [Required(ErrorMessage = "Введите адрес почты")]
        [Remote("IsEmail_Available", "Home", ErrorMessage = "Пользователь с таким email уже существует")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Пожалуйста проверьте адрес почты")]
        public string Email { get; set; }
    }
}