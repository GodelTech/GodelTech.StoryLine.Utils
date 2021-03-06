using System;
using System.Threading;
using GodelTech.StoryLine.Contracts;

namespace GodelTech.StoryLine.Utils.Actions
{
    public class WaitAction : IAction
    {
        private readonly TimeSpan _timeout;

        public WaitAction(TimeSpan timeout)
        {
            _timeout = timeout;
        }

        public void Execute(IActor actor)
        {
            if (actor == null)
                throw new ArgumentNullException(nameof(actor));

            Thread.Sleep(_timeout);
        }
    }
}