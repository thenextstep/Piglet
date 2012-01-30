﻿using System.Collections.Generic;
using Piglet.Parser.Configuration;

namespace Piglet.Parser.Construction
{
    internal interface IGrammar<T>
    {
        IProductionRule<T> Start { get; }
        IEnumerable<IProductionRule<T>> ProductionRules { get; }
        IEnumerable<ISymbol<T>> AllSymbols { get; }
        NonTerminal<T> AcceptSymbol { get; }
        Terminal<T> EndOfInputTerminal { get; }
    }
}
