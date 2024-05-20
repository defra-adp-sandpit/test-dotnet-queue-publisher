using Test.Dotnet.Queue.Publisher.Api.Models;
using Test.Dotnet.Queue.Publisher.Core.Entities;

using AutoMapper;

namespace Test.Dotnet.Queue.Publisher.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
