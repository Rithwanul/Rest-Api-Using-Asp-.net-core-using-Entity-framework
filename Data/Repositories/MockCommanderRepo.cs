using System;
using System.Collections.Generic;
using Commander.Models;
using Commander.Data.Interfaces;

namespace Commander.Data.Repositories
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 101,
                    HowTo = "Fuck YourSelf",
                    Line = "Put Lubricant On the cock",
                    Platform = "Tushy.com"
                },
                new Command
                {
                    Id = 102,
                    HowTo = "Fuck Leah Gotti",
                    Line = "Put Lubricant On the cock",
                    Platform = "Brazzers.com"
                },
                new Command
                {
                    Id = 103,
                    HowTo = "Fuck Leah Gotti",
                    Line = "Put Lubricant On the Ass",
                    Platform = "Blacked.com"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 101,
                HowTo = "Fuck YourSelf",
                Line = "Put Lubricant On the cock",
                Platform = "Tushy.com"
            };
        }

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}