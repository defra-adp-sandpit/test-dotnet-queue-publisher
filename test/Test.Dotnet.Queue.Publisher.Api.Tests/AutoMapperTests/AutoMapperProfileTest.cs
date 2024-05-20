using Test.Dotnet.Queue.Publisher.Api.AutoMapper;
using Test.Dotnet.Queue.Publisher.Api.Models;
using Test.Dotnet.Queue.Publisher.Core.Entities;

using AutoFixture;

using AutoMapper;

namespace Test.Dotnet.Queue.Publisher.Api.Tests.AutoMapperTests;

public class AutoMapperProfileTests
{
    [Fact]
    public void AutoMapperProfile_Should_Create_Valid_Mappings()
    {
        // Arrange
        var profile = new AutoMapperProfile();
        var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
        var mapper = new Mapper(configuration);
        var fixture = new Fixture();
        var itemRequest = fixture.Create<ItemRequest>();

        // Act
        var item = mapper.Map<ItemRequest, Item>(itemRequest);

        // Assert
        item.Should().NotBeNull();
        item.Name.Should().Be(itemRequest.Name);
    }
}