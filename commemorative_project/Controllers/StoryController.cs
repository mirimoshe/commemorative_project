namespace commemorative_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController: ControllerBase
    {
        private readonly IService<StoryDetailesDto> service;

        public StoryController(IService<StoryDetailesDto> service)
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<List<StoryDetailesDto>> Get()
        {
            return await service.getAllAsync();
        }


        [HttpGet("{id}")]
        public async Task<StoryDetailesDto> Get(int id)
        {
            return await service.getAsync(id);
        }


        [HttpPost]
        public async Task Post([FromBody] StoryDetailesDto story)
        {
            await service.AddAsync(story);
        }


        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] StoryDetailesDto s)
        {
            await service.updateAsync(id, s);
        }


        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.deleteAsync(id);
        }
    }
}
