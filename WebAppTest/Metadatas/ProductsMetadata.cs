using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppTest.Models
{
    public class ProductsMetadata
    {
        [Required(ErrorMessage ="產品名稱未填寫!")]
        [Display(Name ="產品名稱")]
        [StringLength(40,ErrorMessage = "{0}最長{1}")]
        public string ProductName { get; set; }

        [DisplayFormat(DataFormatString ="{0:c}")]
        [Display(Name ="產品單價")]
        public Nullable<decimal> UnitPrice { get; set; }

        [Display(Name ="訂購單位")]
        [Range(1,100,ErrorMessage ="{0}訂購單位必須介於{1}~{2}")]
        public Nullable<short> UnitsOnOrder { get; set; }
    }
}