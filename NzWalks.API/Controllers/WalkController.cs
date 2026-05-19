using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NzWalks.API.Models.Domain;
using NzWalks.API.Models.DTOs;
using NzWalks.API.Repositries;

namespace NzWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalkController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWalkRepo _walkrepo;

        public WalkController(IMapper mapper, IWalkRepo walkRepo)
        {
            this._mapper = mapper;
            this._walkrepo = walkRepo;
        }

        [HttpPost]
       public async Task<IActionResult> Create([FromBody] AddWalkerDto addwalkerDto)
        {
            var walkDominModel = _mapper.Map<Walks>(addwalkerDto);
            await _walkrepo.CreateAsync(walkDominModel);
            return Ok(_mapper.Map<AddWalkerDto>(walkDominModel));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var walkDomianModel = await _walkrepo.GetAllWalkAsync();

            return Ok(_mapper.Map<List<AddWalkerDto>>(walkDomianModel));
        }
    }
}
