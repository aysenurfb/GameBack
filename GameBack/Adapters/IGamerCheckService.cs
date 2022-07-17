using GameBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBack.Adapters
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
