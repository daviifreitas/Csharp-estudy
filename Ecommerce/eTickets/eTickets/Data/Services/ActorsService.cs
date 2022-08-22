using eTickets.Data.Services.I;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async void Add(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(m => m.Id == id);
             _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> Get(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> Update(int id, Actor newActorData)
        {
            _context.Update(newActorData);
            await _context.SaveChangesAsync();
            return newActorData;
        }
    }
}
