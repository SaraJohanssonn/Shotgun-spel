using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public enum playerChoice 
    {
        Shoot,
        Load,
        Block,
        Shotgun

    }
    class Player
    {
       
        public int ShotCount { get; set; }
        public playerChoice Choice { get; set;  }
        
        
        public bool Shoot()
        {
            if (ShotCount == 0)
                return false;

            ShotCount--;
            Choice = playerChoice.Shoot;
            return true;


        }
      
        public void Load()
        {
            ShotCount++;
            Choice = playerChoice.Load;
        }

        public void Block()
        {
            Choice = playerChoice.Block;
        }

        public bool Shotgun()
        {
            if (ShotCount < 3)
                return false;

            ShotCount = 0;
            Choice = playerChoice.Shotgun;
            return true;
        }
    }
}
