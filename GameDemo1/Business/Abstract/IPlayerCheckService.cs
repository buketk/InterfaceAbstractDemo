﻿using GameDemo1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Business.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
        
    }
}
