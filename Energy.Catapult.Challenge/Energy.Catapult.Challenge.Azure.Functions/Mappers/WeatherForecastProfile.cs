using AutoMapper;
using Energy.Captapult.Challenge.DataAccess;
using Energy.Catapult.Challenge.Azure.Functions.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Energy.Catapult.Challenge.Azure.Functions.Mappers
{
    class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile()
        {
            CreateMap<_10forecastinputsByTask, ForecastRequestItem>();
        }
    }
}
