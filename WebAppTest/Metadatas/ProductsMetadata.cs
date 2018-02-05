using System.ComponentModel.DataAnnotations;

namespace WebAppTest.Models
{
    public class ProductsMetadata
    {
        [StringLength(40,ErrorMessage = "{0}最長{1}")]
        public string ProductName { get; set; }
    }
}