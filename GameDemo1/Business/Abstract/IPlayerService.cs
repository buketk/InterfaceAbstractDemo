using GameDemo1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Business.Abstract
{
    public interface IPlayerService
    {
        void Update(Player player);

        void Delete(Player player);
    }
}
