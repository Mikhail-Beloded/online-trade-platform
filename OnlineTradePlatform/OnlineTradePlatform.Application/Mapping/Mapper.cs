using AutoMapper;
using OnlineTradePlatform.Core.Entities;
using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.Paging;

namespace OnlineTradePlatform.Application.Mapping
{
    public class Mapper
    {
        private readonly IMapper _mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<UserDto, User>();
            cfg.CreateMap<User, UserDto>();

            cfg.CreateMap<Ad, AdDto>();
            cfg.CreateMap<AdDto, Ad>();

        }).CreateMapper();

        public UserDto MapUserToDto(User user)
        {
            var dto = this._mapper.Map<UserDto>(user);
            return dto;
        }

        public User MapUserFromDto(UserDto userDto)
        {
            var user = this._mapper.Map<User>(userDto);
            return user;
        }

        public AdDto MapAdToDto(Ad ad)
        {
            var dto = this._mapper.Map<AdDto>(ad);
            return dto;
        }

        public Ad MapAdFromDto(AdDto adDto)
        {
            var ad = this._mapper.Map<Ad>(adDto);
            return ad;
        }

        public PagedList<AdDto> MapAdListToDto(PagedList<Ad> ads)
        {
            var dtos = this._mapper.Map<PagedList<AdDto>>(ads);
            return dtos;
        }

        public PagedList<UserDto> MapUserListToDto(PagedList<User> users)
        {
            var dtos = this._mapper.Map<PagedList<UserDto>>(users);
            return dtos;
        }
    }
}
