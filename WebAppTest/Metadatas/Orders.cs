using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    [MetadataType(typeof(OrderMetadata))]
    //partial擴充源自EF Orders Model 屬性
    public partial class Orders : IValidatableObject//利用IValidatableObject介面實作自訂驗証
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           if(RequiredDate > OrderDate.Value.AddMonths(1))
            {
               yield return new ValidationResult(
                   "訂購商品必須在1個月內取貨", new string[] { "RequiredDate", "OrderDate" });
            }
        }
    }
}