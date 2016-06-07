using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baseball
{
    /* Pitcher class subcribes to the Ball class's BallInPlay event */
    class Pitcher
    {
        /* Write a constructor for Pitcher with a parameter type Ball */
        public Pitcher(Ball ball)
        {
            /* The left handside of the expression tells C# to hook the event handler up to the BallInPlay event of whatever object
             * (Ball) the ball reference is pointing to
             * 
             * The += operator tells C# to subscribe an event handler to an event
             * It allows to add a new event handler without replacing existing handlers
             * It becomes one in a very long chain of other event handlers, all of which are listening to the same event
             * 
             * The right handside of the expression specifies which event handler method (ball_BallInPlay) to subscribe to the event
             * 
             * 'ball.BallInPlay += new EventHandler(ball_BallInPlay);' format is used when the method that will handle an event has
             * no event data */
            ball.BallInPlay += (ball_BallInPlay);
        }

        /* ball_BallInPlay() is the event handler method
         * There is no specific C# naming convention for event handlers
         * The standard practice is: the name of object reference, followed by underscore (_), followed by the name of the event
         * 
         * The class (Pitcher) that has this particular event handler method has a Ball reference variable called ball, so its 
         * BallInPlay event handler starts with 'ball_' followed by the name of the event being handled, "BallInPlay"
         * 
         * The BallInPlay event declaration listed its event type as EventHandler (Ball.cs, line 19), which means that it needs 
         * to take two parameters: an object called sender, an EventArgs called e and have no return value */
        void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CatchBall()
        {
            Console.WriteLine("Pitcher: I caught the ball");
        }

        private void CoverFirstBase()
        {
            Console.WriteLine("Pitcher: I covered first base");
        }
    }

}