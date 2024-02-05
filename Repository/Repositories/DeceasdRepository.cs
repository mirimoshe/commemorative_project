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
    public class DeceasdRepository : IRepository<DeceasdDetails>
    {
        private readonly IContext _context;

        public DeceasdRepository(IContext context) { 
            _context = context; 
        }
        public async Task addItemAsync(DeceasdDetails item)
        {
            await _context.DeceasdsDetails.AddAsync(item);
            await _context.save();
        }

        public async Task deleteAsync(int id)
        {
            _context.DeceasdsDetails.Remove(await getAsync(id));
            await _context.save();
        }

        public async Task<List<DeceasdDetails>> getAllAsync()
        {
            return await _context.DeceasdsDetails.ToListAsync();
        }

        public async Task<DeceasdDetails> getAsync(int id)
        {
            return await _context.DeceasdsDetails.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task updateAsync(int id, DeceasdDetails entity)
        {
            _context.DeceasdsDetails.Update(entity);
            await _context.save();
        }
    }
}
