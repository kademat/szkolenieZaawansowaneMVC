using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperTest
{
    class Order
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public decimal Cost { get; set; }

        public OrderStatus Status { get; set; }
    }


    enum OrderStatus
    {
        [Display(ResourceType = typeof(OrderStatusResources), Name = "Created")]
        Created,
        [Display(ResourceType = typeof(OrderStatusResources), Name = "Processed")]
        Processed
    }
}
