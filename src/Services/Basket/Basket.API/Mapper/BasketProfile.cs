﻿using AutoMapper;
using EventBus.Messages.Events;

namespace Basket.API.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketProfile,BasketCheckoutEvent>().ReverseMap();
        }
    }
}
