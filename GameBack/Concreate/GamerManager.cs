using GameBack.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBack.Adapters;

namespace GameBack.Concreate
{
    public class GamerManager : IGamersService
    {
        //servise baglanma 
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        /***********************************/

        public void Add(Gamer gamer) 
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.Name + "(" + gamer.UserName + ")" + " added");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        public void Update(Gamer gamer) 
        { 
            Console.WriteLine(gamer.Name + "(" + gamer.UserName + ")" + " updated"); 
        }

        public void Delete(Gamer gamer) 
        {
            Console.WriteLine(gamer.Name + "(" + gamer.UserName + ")" + " deleted");
        }



    }
}
