namespace BehavioralPatterns
{
    public abstract class StateBase
    {
        protected Context _context;

        public void SetContext(Context context) { _context = context; }

        public abstract void SomeHandle();
    }

    public class StateA : StateBase
    {
        public override void SomeHandle()
        {
            /*
             * some logic
             */
            _context.TransitionTo(new StateB());
            Console.WriteLine("handler for state A");
        }
    }

    public class StateB : StateBase
    {
        public override void SomeHandle()
        {
            /*
             * some logic
             */
            _context.TransitionTo(new StateA());
            Console.WriteLine("handler for state B");
        }
    }

    public class Context
    {
        private StateBase _state;
        public Context(StateBase state)
        {
            _state = state;
        }

        public void TransitionTo(StateBase state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public void Request1()
        {
            //_state.SomeHandle();
            Console.WriteLine("Invoking request 1");
        }

        public void Request2()
        {
            _state.SomeHandle();
            Console.WriteLine("Invoking request 1");
        }
    }

    file class P
    {
        static void Main()
        {
            var context = new Context(new StateA());
            context.Request1();
            context.Request2();

            context.Request1();
            context.Request2();
        }
    }
}
