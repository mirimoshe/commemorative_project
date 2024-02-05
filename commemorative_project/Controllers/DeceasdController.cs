using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;


namespace commemorative_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeceasdController: ControllerBase
    {
        private readonly IService<DeceasdDetailesDto> service;
        public DeceasdController (IService<DeceasdDetailesDto> service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<List<DeceasdDetailesDto>> Get()
        {
            return await service.Get();
        }
        [HttpGet("{id}")]
        public async Task<DeceasdDetailesDto> Get(int id)
        {
            return await service.Get(id);
        }
        [HttpPost]
        public async Task Post([FromBody] DeceasdDetailesDto Deceasd)
        {
            await service.Post(Deceasd);
        }
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] DeceasdDetailesDto deceasd)
        {
            await service.updateAsync(id, deceasd);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.deleteAsync(id);
        }
    }
}
