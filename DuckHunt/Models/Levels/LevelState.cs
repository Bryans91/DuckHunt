using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt
{
    interface LevelState
    {

        // States expected: LevelOne, LevelTwo, LevelThree, BossLevel

        void changeBackground();
        void checkScore();

    }
}
