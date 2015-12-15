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
            Mapper.CreateMap<Enum, string>()
                .ConvertUsing<EnumToStringConverter>();

            Mapper.CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.Cost,
                opt => opt.MapFrom(src => string.Format("{0} zl", src.Cost)))
                .ForMember(dest => dest.Status,
                    opt => opt.ResolveUsing<EnumToStringResolver>()
                    .FromMember(src => src.Status))
                //.ForMember(dest => dest.Status,
                //    opt => opt.MapFrom(src =>
                //      src.Status.ToDisplayString()))
                .IgnoreAllNonExisting();


            Mapper.CreateMap<MyOrder, MyOrderDTO>()
                .IgnoreAllNonExisting();

            Mapper.AssertConfigurationIsValid();

            var order = new Order()
            {
                Id = 10,
                Cost = 15.3M,
                Number = "Jakiś tam numer",
                Status = OrderStatus.Processed
            };

            var orderDTO = Mapper.Map<OrderDTO>(order);

        }
    }

    public class EnumToStringConverter : ITypeConverter<Enum, string>
    {
        public string Convert(ResolutionContext context)
        {
            var value = (Enum)context.SourceValue;

            return value.ToDisplayString();
        }
    }

    public class EnumToStringResolver : ValueResolver<Enum, string>
    {
        protected override string ResolveCore(Enum source)
        {
            return source.ToDisplayString();
        }
    }
}
