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
    public class UserRepository : IRepository<UserDetailes>
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task addItemAsync(UserDetailes item)
        {
            await _context.Users.AddAsync(item);
            await _context.save();
        }

        public async Task deleteAsync(int id)
        {
            _context.Users.Remove(await getAsync(id));
            await _context.save();
        }

        public async Task<List<UserDetailes>> getAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserDetailes> getAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task updateAsync(int id, UserDetailes entity)
        {
           _context.Users.Update(entity);
            await _context.save();
        }
    }
}
