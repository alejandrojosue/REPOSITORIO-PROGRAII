namespace patronesDiseno.Mediator
{
    internal class Mediator : IMediator
    {
        private List<IColleague> colleagues;
    
        public Mediator(){colleagues = new List<IColleague>();}
        public void add(IColleague colleague){this.colleagues.Add(colleague);}

        public void send(string message, IColleague colleague)
        {
            foreach(var c in this.colleagues)
            {
                if (colleague != c)
                {
                    colleague.receive(message);
                }
            }
        }
    }
}
