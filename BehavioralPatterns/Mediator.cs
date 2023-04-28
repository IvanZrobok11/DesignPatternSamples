namespace BehavioralPatterns
{
    class Mediator
    {
        private Component1 _component1;

        private Component2 _component2;

        public Mediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }
        public void Notify(BaseComponent sender, string message)
        {
            if (sender is Component1)
            {
                if (message == "A")
                {

                }
            }
            else if (sender is Component2)
            {

            }
        }
    }

    class BaseComponent
    {
        protected Mediator _mediator;

        public BaseComponent(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }
    }

    class Component1 : BaseComponent
    {
        public Component1(Mediator mediator) : base(mediator)
        {
        }

        public void MakeA()
        {
            Console.WriteLine("Component 1 makes A.");

            _mediator.Notify(this, "A");
        }

        public void MakeB()
        {
            Console.WriteLine("Component 1 makes B.");

            _mediator.Notify(this, "B");
        }
    }

    class Component2 : BaseComponent
    {
        public Component2(Mediator mediator) : base(mediator)
        {
        }

        public void MakeC()
        {
            Console.WriteLine("Component 2 makes C.");

            _mediator.Notify(this, "C");
        }
    }

}
