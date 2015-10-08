using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt
{
    interface DuckState
    {

        // States expected: AliveDuck, ShotDuck, DeadDuck

        void getShot();

    }
}
