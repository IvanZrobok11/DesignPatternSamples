namespace BehavioralPatterns
{
    interface IObserver
    {
        void Update(Subject subject);
    }
    class Observer1 : IObserver
    {
        public void Update(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
    class Observer2 : IObserver
    {
        public void Update(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
    class Subject
    {
        public List<IObserver> Observers { get; private set; }
        public int SomeParametr { get; private set; }
        public Subject()
        {
            Observers = new List<IObserver>();
        }
        public void AttachObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void DetachObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void MakeSomething()
        {
            SomeParametr += Random.Shared.Next(0, 5);
            Notify();
        }
        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }
    }

    file class P
    {
        public void Main()
        {
            var o1 = new Observer1();
            var o2 = new Observer2();

            var subject = new Subject();
            subject.AttachObserver(o1);
            subject.AttachObserver(o2);

            subject.MakeSomething();
        }
    }
}
