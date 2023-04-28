namespace BehavioralPatterns
{
    file interface IComponent
    {
        void Accept(IVisitor visitor);
        void SomeOperation();
    }
    file class ComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitComponentA(this);
        }
        public void SomeOperation() { }
    }
    file class ComponentB : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitComponentB(this);
        }
        public void SomeOperation() { }

    }


    file interface IVisitor
    {
        void VisitComponentA(ComponentA element);

        void VisitComponentB(ComponentB element);
    }
    file class Visitor : IVisitor
    {
        public void VisitComponentA(ComponentA element)
        {
            element.SomeOperation();
        }

        public void VisitComponentB(ComponentB element)
        {
            element.SomeOperation();
        }
    }

    file class P
    {
        public void Main()
        {
            var cA = new ComponentA();
            var cB = new ComponentB();

            cA.Accept(new Visitor());
        }
    }
}
