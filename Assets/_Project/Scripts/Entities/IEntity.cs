﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;

namespace Assets.Scripts.Entidades
{
    public interface IEntity
    {
        Entity CreateEntity(EntityManager manager, Entity? parent = null, Entity? root = null);
    }
}
