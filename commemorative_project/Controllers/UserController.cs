namespace commemorative_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IService<UserDetailesDto> service;

        public UserController(IService<UserDetailesDto> service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<UserDetailesDto>> Get()
        {
            return await service.getAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDetailesDto> Get(int id)
        {
            return await service.getAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] UserDetailesDto user)
        {
            await service.AddAsync(user);
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] UserDetailesDto u)
        {
            await service.updateAsync(id, u);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.deleteAsync(id);
        }
    }
}
