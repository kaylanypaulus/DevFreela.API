using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descricao de projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descricao de projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descricao de projeto 3", 1, 1, 13000)
            };

            Users = new List<User>
            {
                new User("Kaylany Paulus", "kaylanypaulus@gmail.com", new DateTime(2003, 1, 1)),
                new User("Bruno Almeida", "brunoalmeida@gmail.com", new DateTime(2002, 1, 1)),
                new User("JungKook", "jungkook@gmail.com", new DateTime(1995, 1, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("Flutter"),
                new Skill("React")
            };

        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get;set; }
    }
}
