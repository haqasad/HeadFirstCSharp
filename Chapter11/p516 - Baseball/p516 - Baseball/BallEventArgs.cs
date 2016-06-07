using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baseball
{
    /* In real life, when a ball is hit it is in motion and has properties like trajectory, distance, velocity etc. Similarly,   
     * Class Ball invokes an event BallInPlay. BallInPlay has arguments: Trajectory, Distance. In real life, pitchers, umpire 
     * and even the fans has to anticipate those properties (trajectory, distance). These arguments need to be passed on (to  
     * event handlers). .NET has a standard class for it called EventArgs. It is an empty class with no members. Its sole purpose  
     * is to allow event arguments object to be passed to the event handlers that use it. It is a good practice to inherit event
     * argument objects from EventArgs. */
    class BallEventArgs : EventArgs
    {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }
        public BallEventArgs(int trajectory, int distance)
        {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }
}
