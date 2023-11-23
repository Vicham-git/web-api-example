using WebApi.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApi.Modules.Profiles;

public class Profiles : Entity
{
    public Guid FirstName {get; set;}
    public Guid LastName {get; set;}
    public Guid Email {get; set;}

}

public class ProfilesConfig : IEntityTypeConfiguration<Profiles>
{
	public void Configure(EntityTypeBuilder<Profiles> builder)
	{

	}
}