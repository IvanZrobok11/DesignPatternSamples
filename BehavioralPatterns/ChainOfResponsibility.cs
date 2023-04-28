namespace BehavioralPatterns
{
    public abstract class HandlerBase
    {
        protected HandlerBase _nextHandler;
        public HandlerBase SetNext(HandlerBase next = null)
        {
            _nextHandler = next;
            return next;
        }
        public virtual void Handle(object args)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(args);
            }
            return;
        }
    }
    public class Handler1 : HandlerBase
    {
        public override void Handle(object args)
        {
            //
            //  ...
            //
            base.Handle(args);
        }
    }

    public class Handler2 : HandlerBase
    {
        public override void Handle(object args)
        {
            base.Handle(args);
        }
    }

    public class Handler3 : HandlerBase
    {
        public override void Handle(object args)
        {
            base.Handle(args);
        }
    }

    file class Program
    {
        public void Main()
        {
            var h1 = new Handler1();
            var h2 = new Handler2();
            var h3 = new Handler3();

            h1.SetNext(h2).SetNext(h3);

            h1.Handle(1);
        }
    }
}
