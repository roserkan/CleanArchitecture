﻿using Core.Persistence.Repositories;

namespace Devs.Domain.Entities;

public class ProgrammingLanguage : Entity
{
    public string Name { get; set; }
    public virtual ICollection<Technology> Technologies { get; set; }
}