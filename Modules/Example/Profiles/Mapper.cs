using AutoMapper;

namespace WebApi.Modules.Profiles;

public class ProfilesMapper : Profile
{

    public static ProfilesModel MapEntityToModel(Profiles profiles)
    {
        var profilesModel = new ProfilesModel
        {
            FirstName = profiles.FirstName,
            LastName = profiles.LastName,
            Email = profiles.Email
        };
        return profilesModel;
        	
    }
    public static Profiles MapModelToEntity(ProfilesModel profilesModel)
    {
        var profiles = new Profiles
        {
            FirstName = profilesModel.FirstName,
            LastName = profilesModel.LastName,
            Email = profilesModel.Email
        };
        
        return profiles;
    }
}