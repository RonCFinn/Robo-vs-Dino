using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSdinos
{
    class Arena
    {
        Fleet fleet = new Fleet();

        public Arena()
        {
            BuildTheForces();
        }

        public void BuildTheForces()
        {
            for (int i = 0; i < 3; i++)
            {
                fleet.CharacterSelection();
            }
        }
    }
}
