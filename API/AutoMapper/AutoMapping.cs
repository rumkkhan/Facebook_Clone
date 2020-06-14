using Application.Activities;
using AutoMapper;
using Domain;

namespace API.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
          CreateMap<Activity, Create.Command>(); // means you want to map from User to UserDTO
        // CreateMap<Create.Command, Activity>();
          CreateMap<Activity, Edit.EditCommand>();
          CreateMap<Edit.EditCommand,Activity>();
        }
    }
}