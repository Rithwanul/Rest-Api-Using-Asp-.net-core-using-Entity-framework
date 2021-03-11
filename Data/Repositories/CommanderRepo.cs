using System;
using Commander.ApplicationDbContext;
using System.Collections.Generic;
using Commander.Models;
using Commander.Data.Interfaces;
using System.Linq;

namespace Commander.Data.Repositories
{
    public class CommanderRepo : ICommanderRepo
    {
        private readonly AppDbContext _context;

        public CommanderRepo(AppDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException();
            }

            _context.Commands.Add(cmd);
        }

        public void UpdateCommand(Command cmd)
        {

        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Remove(cmd);
        }
    }
}