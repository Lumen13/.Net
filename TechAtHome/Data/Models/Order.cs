using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechAtHome.Data.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "Поле должно содержать не менее 2х и не более 20 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "Поле должно содержать не менее 2х и не более 20 символов")]
        public string SurName { get; set; }

        [Display(Name = "Введите Ваш адрес прописки")]
        [StringLength(20, MinimumLength = 12)]
        [Required(ErrorMessage = "Поле должно содержать не менее 12 и не более 20 символов")]
        public string Adress { get; set; }

        [Display(Name = "Введите Ваш номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, MinimumLength = 7)]
        [Required(ErrorMessage = "Поле должно содержать не менее 7 и не более 10 символов")]
        public string Phone { get; set; }

        [Display(Name = "Введите Ваш адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20, MinimumLength = 2)]
        [Required(ErrorMessage = "Поле должно содержать не менее 2 и не более 20 символов")]
        public string Email { get; set; }

        // ERROR Required. При заполнии малого кол-ва символов
        //
        // The field Введите имя must be a string with a minimum length of 2 and a maximum length of 20.

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
