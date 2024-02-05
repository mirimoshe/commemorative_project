namespace commemorative_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController: ControllerBase
    {
        private readonly IService<ResponseDetailsDto> service;

        public ResponseController(IService<StoryDetailesDto> service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<List<ResponseDetailsDto>> Get()
        {
            return await service.getAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ResponseDetailsDto> Get(int id)
        {
            return await service.getAsync(id);
        }
        [HttpPost]
        public async Task Post([FromBody] ResponseDetailsDto response)
        {
            await service.AddAsync(response);
        }
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ResponseDetailsDto r)
        {
            await service.updateAsync(id, r);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.deleteAsync(id);
        }
    }
}
