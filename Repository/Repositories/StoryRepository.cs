using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StoryRepository : IRepository<StoryDetailes>
    {
        private readonly IContext _context;

        public StoryRepository(IContext context) {
            _context = context; 
        }
        public async Task addItemAsync(StoryDetailes item)
        {
            await _context.Stories.AddAsync(item);
            await _context.save();
        }

        public async Task deleteAsync(int id)
        {
            _context.Stories.Remove(await getAsync(id));
            await _context.save();
        }

        public async Task<List<StoryDetailes>> getAllAsync()
        {
            return await _context.Stories.ToListAsync();
        }

        public async Task<StoryDetailes> getAsync(int id)
        {
            return await _context.Stories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task updateAsync(int id, StoryDetailes entity)
        {
            _context.Stories.Update(entity);
            await _context.save();
        }
    }
}
