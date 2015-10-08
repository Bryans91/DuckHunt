using System;

namespace DuckHunt
{
    internal class DeadDuck : DuckState
    {
        private Duck duck;

        public DeadDuck(Duck duck)
        {
            this.duck = duck;
        }

        public void getShot()
        {
            // Killing dead ducks is overkill ;)
        }
    }
}