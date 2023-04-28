namespace BehavioralPatterns
{
    file class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator();
            var game = new Caretaker();

            originator.MakeSomething();
            game.History.Push(originator.SaveState());

            originator.MakeSomething();
            originator.RestoreState(game.History.Pop());

            originator.MakeSomething();

            Console.Read();
        }
    }

    // Originator
    // певний об'єкт - знімок якого ми будемо робити
    class Originator
    {
        private object _params;
        public Memento SaveState()
        {
            return new Memento(_params);
        }

        public void RestoreState(Memento memento)
        {
            _params = memento.Params;
        }

        public void MakeSomething()
        {
            _params = Random.Shared.Next();
        }
    }

    // Memento
    // модель даних для обєкта
    class Memento
    {
        public object Params { get; set; }
        public Memento(object p)
        {
            Params = p;
        }
    }

    // Caretaker
    // Caretaker: виконує тільки функцію зберігання об'єкта Memento, 
    // в той же час він не має повного доступу до зберігача і ніяких інших операцій над зберігачем, 
    // крім власне збереження, він не робить

    // обєкт в якого ми кладемо знімки 
    // або витягуємо
    class Caretaker
    {
        public Stack<Memento> History { get; private set; }
        public Caretaker()
        {
            History = new Stack<Memento>();
        }
    }
}
