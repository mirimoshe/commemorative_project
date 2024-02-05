using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ResponseRepository : IRepository<ResponseDetails>
    {
        private readonly IContext _context;
        public ResponseRepository(IContext context) {
            _context = context; 
        }
        public async Task addItemAsync(ResponseDetails item)
        {
            await _context.Responses.AddAsync(item);
            await _context.save();
        }

        public async Task deleteAsync(int id)
        {
            _context.Responses.Remove(await getAsync(id));
            await _context.save();
        }

        public async Task<List<ResponseDetails>> getAllAsync()
        {
            return await _context.Responses.ToListAsync();
        }

        public async Task<ResponseDetails> getAsync(int id)
        {
            return await _context.Responses.FirstOrDefault(r => r.Id == id);
        }

        public async Task updateAsync(int id, ResponseDetails entity)
        {
            _context.Responses.Update(entity);
            await _context.save();
        }
    }
}
