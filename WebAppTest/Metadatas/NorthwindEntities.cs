using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public partial class NorthwindEntities : DbContext
    {
        protected override DbEntityValidationResult ValidateEntity(
                        DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            var result = base.ValidateEntity(entityEntry, items);
            if (entityEntry.Entity is Order_Details)
            {
                Order_Details od = (Order_Details)entityEntry.Entity;
                decimal Subtotal = od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount);

                if (Subtotal > 1000)
                {
                    result.ValidationErrors.Add(
                        new DbValidationError("Quantity", "小計超過上限!"));
                }
            }
            else if(entityEntry.Entity is Orders)
            {
                Orders o = (Orders)entityEntry.Entity;
                var query = from od in Order_Details
                            where od.OrderID == o.OrderID
                            select od;
                if(query.Count()> 3)
                {
                    result.ValidationErrors.Add(new DbValidationError("CustomerID", "訂購項目超過3項!"));
                }
            }

            return result;

        }
    }
}