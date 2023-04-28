namespace BehavioralPatterns
{
    public interface IStrategy
    {
        void Algorithm();
    }

    public class Strategy1 : IStrategy
    {
        public void Algorithm()
        { }
    }

    public class Strategy2 : IStrategy
    {
        public void Algorithm()
        { }
    }

    file class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy _strategy)
        {
            ContextStrategy = _strategy;
        }

        public void ExecuteAlgorithm()
        {
            // make something 
            //
            ContextStrategy.Algorithm();
            //
            // make something 
        }
    }
}
