namespace patronesDiseno.Mediator
{
    public abstract class IColleague
    {
        private IMediator mediator;

        public IColleague(IMediator mediator)
        {
            this.mediator = mediator;
        }
               

        public void communicate(string message)
        {
            this.mediator.send(message, this);
        }

        public abstract void receive(string message);
    }
}
