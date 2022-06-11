using apilocadora.Data.Models.InputModel;
using apilocadora.Data.Models.ViewModel;
using AutoMapper;

namespace apilocadora.Data.Models.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region DAO to DTO
                CreateMap<User, UserDTO>()
                    .ForMember(dst => dst.Token, map => map.MapFrom(src => src.JwtToken))
                    .ForMember(dst => dst.Id, map => map.MapFrom(src => src.IdUser));
            #endregion

            #region DTO to DAO
                CreateMap<Register, User>();
            #endregion
            
        }
    }
}