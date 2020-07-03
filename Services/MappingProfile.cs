using AmazingChessAPI.Models;
using AmazingChessAPI.Models.ViewModels;
using AutoMapper;

namespace AmazingChessAPI.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<UserScore, LeaderBoardViewModel>().ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.UserName))
            //                                             .ForMember()
        }
    }
}