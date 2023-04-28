namespace BehavioralPatterns
{
    file interface IInterpretable
    {
        object Interpret();
    }

    file class TerminalExpression : IInterpretable
    {
        public object Interpret()
        {
            throw new NotImplementedException();
        }
    }
    file class NonterminalExpression : IInterpretable
    {
        public object Interpret()
        {
            throw new NotImplementedException();
        }
    }

    file class Context
    {

    }

}
