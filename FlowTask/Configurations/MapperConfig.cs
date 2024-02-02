using AutoMapper;
using FlowTask.DTOs;
using FlowTask.Models;

namespace FlowTask.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<UpdateBoardDTO, Board>();
            CreateMap<CreateBoardDTO, Board>();
            CreateMap<UpdateCardDTO, Card>();
            CreateMap<CreateCardDTO, Card>();
            CreateMap<UpdateSectionDTO, Section>();
            CreateMap<CreateCardDTO, Section>();
        }
    }
}
