using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baseball
{    
    class Ball
    {
        /* Ball class raises/fires/invokes an event named 'BallInPlay'. BallInPlay references a new object, 'BallEventArgs'. 
         * BallEventArgs is a class that defines fields for Velocity and Trajectory.
         *  
         * The event keyword informs other objects about the event, so they can subscribe to it.
         *  
         * The word EventHandler is not a C# keyword. It informs other objects (that would subscribe to BallInPlay event) 
         * about how their event handler methods should look like. For example, the EventHandler tells other objects that 
         * their event handlers need to take two parameters an object named sender and an EventArgs reference named e. sender
         * is a reference to the object that raised the event and e is a reference to an EventArgs objects */
        public event EventHandler<BallEventArgs> BallInPlay;

        /* The method that invokes an event a standard naming convention. For example,
         * OnDoubleClick(EventArgs e) method invokes the event DoubleClick
         * The method passed the parameter on to the event when they raise it */
        public void OnBallInPlay(BallEventArgs e)
        {
            /* BallInPlay is copied to a variable, ballInPlay, which is null-checked and used to raise the event */
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            if (ballInPlay != null)
                ballInPlay(this, e);
            /* 'this' is a reference to the object that raised the event (Baseball.Ball) and e is a new BallEventArgs object             
             * 
             * 'BallInPlay?.Invoke(this, e);' can be used instead of the if statement */            
        }
    }
}
