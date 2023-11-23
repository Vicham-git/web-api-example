using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApi.Core;

namespace WebApi.Modules.Profiles;

public class ProfilesModel : Entity
{
    public Guid FirstName { get; set; }
    public Guid LastName { get; set; }
    public Guid  Email { get; set; }
}
