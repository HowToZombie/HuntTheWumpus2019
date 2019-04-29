using System;

namespace GameLocationHuntTheWumpus
{
    public class GameLocation
    {

       // •	Store and interact with the cave used for this game
//•	Keep track of where the hazards are
        public int HazardLocation { get; private set; }
//•	Keep track of where the Wumpus is. This includes controlling Wumpus behavior(that is, asleep, awake, moving).
        public int WumpusLocation { get; private set; }
//•	Keep track of where the player is
        public int PlayerLocation { get; private set; }
  
//•	Control arrow shooting.
//•	Give any necessary warnings
//•	Obtain hints to help the player


    }
}
