using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Repositories
{
    public class SqlCommanderRepository : ICommanderRepository
    {
        private readonly Context _context;

        public SqlCommanderRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(c => c.Id == id);
        }
    }
}