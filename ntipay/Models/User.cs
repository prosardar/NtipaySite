using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ntipay.Models {
    public class User {
        public int UserId { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "Введите адрес почты")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Пожалуйста проверьте адрес почты")]
        public string Email { get; set; }
    }
}