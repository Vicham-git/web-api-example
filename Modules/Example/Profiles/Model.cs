using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApi.Modules.Profiles;

public class ProfilesModel : Model
{
    public Guid FirstName { get; set; }
    public Guid LastName { get; set; }
    public Guid  Email { get; set; }
}
