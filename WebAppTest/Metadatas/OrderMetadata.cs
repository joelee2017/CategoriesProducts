using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppTest.Models
{
    public class OrderMetadata
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]

        public Nullable<System.DateTime> OrderDate { get; set; }
    }
}