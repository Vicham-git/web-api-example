using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Core;
using WebApi.Services;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Modules.Profiles;

public class ProfilesController : MyController
{
	// private readonly ICloudStorageSingletonService _service;
	private readonly IMapper _mapper;
	private readonly ProfilesRepository _repository;

	public ProfilesController(
		ProfilesRepository repository,
		ICloudStorageSingletonService service, 
        IMapper mapper
        )
	{
		_repository = repository;
		// _service = service;
		_mapper = mapper;
	}

    [HttpGet]
    public IActionResult GetAllProfile()
    {
        var profiles = _repository.GetAllProfile();
        var profileModels = profiles.Select(p => ProfilesMapper.MapEntityToModel(p));
        
        return Ok(profiles);
    }
     [HttpPost]
    public IActionResult CreateProfile(ProfilesModel profilesModel)
    {
        var profiles = ProfilesMapper.MapModelToEntity(profilesModel);
        _repository.CreateProfile(profiles);
        
        return CreatedAtAction(nameof(CreateProfile), new { id = profiles.Id }, profilesModel);
    }
}