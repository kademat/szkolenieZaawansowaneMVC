using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.Cost,
                opt => opt.MapFrom(src => string.Format("{0} zl", src.Cost)))
                .ForMember(dest => dest.Status,
                    opt => opt.MapFrom(src =>


                      src.Status.ToDisplayString()));
                //.IgnoreAllNonExisting();

            Mapper.AssertConfigurationIsValid();

            var order = new Order()
            {
                Id = 10,
                Cost = 15.3M,
                Number = "Jakiś tam numer",
                Status = OrderStatus.Created
            };

            var orderDTO = Mapper.Map<OrderDTO>(order);

        }
    }
}
