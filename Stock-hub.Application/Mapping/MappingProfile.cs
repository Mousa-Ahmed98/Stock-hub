using AutoMapper;
using Stock_hub.Application.DTOS;
using Stock_hub.Core.Entities;
using Stock_hub.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //////////TSource              TDestination
            CreateMap<UserRegisterDTO, ApplicationUser>();
            CreateMap<StockUpdateReqDto, StockUpdate>();
            CreateMap<OrderDto, Order>();
            CreateMap<Order, OrderRespDTO>();
            CreateMap<StockUpdate, StockUpdateRespDTO>();
        }
    }
}
