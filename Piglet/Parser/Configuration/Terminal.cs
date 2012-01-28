using System;

namespace Piglet.Parser.Configuration
{
    public class Terminal<T> : Symbol<T>, ITerminal<T>
    {
        public string RegExp { get; private set; }
        public Func<string, T> OnParse { get; private set; }

        public Terminal(string regExp, Func<string, T> onParse)
        {
            if (onParse == null) 
            {
                onParse = f => default(T);
            }

            OnParse = onParse;
            RegExp = regExp;
            DebugName = RegExp;
        }

        public override string ToString()
        {
            return string.Format("{0}{{{1}}} - {2}", DebugName, RegExp, OnParse);
        }
    }
}