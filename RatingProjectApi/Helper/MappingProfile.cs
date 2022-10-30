using AutoMapper;
using DAL.Entities;
using RatingProjectApi.Dto;

namespace RatingProjectApi.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RatingDto,Rating>();
        }
    }
}
