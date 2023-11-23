using WebApi.Core;

namespace WebApi.Modules.Profiles;

public interface IProfilesRepository : IRepository<Profiles>
{

}

public class ProfilesRepository : Repository<Profiles>, IProfilesRepository
{
	public ProfilesRepository(MyDbContext context) : base(context)
	{
	}

    internal void CreateProfile(Profiles profiles)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Profiles> GetAllProfile()
    {
        throw new NotImplementedException();
    }
}
