using AutoMapper;
using RestService.Dto;
using RestService.Models;

namespace RestService.MapperProfile
{
    public class RequestModelProfile : Profile
    {
        public RequestModelProfile()
        {
            RequestModelMapper(CreateMap<RequestModel, RequestDto>());
        }

        void RequestModelMapper(IMappingExpression<RequestModel, RequestDto> mappingExpression)
        {
            mappingExpression.ForMember(dest => dest.numbers, opt => opt.MapFrom(src => src.Data)).ReverseMap();
        }
    }
}
