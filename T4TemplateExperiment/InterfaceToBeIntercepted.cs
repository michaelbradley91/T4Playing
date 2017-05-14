using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4TemplateExperiment.Parameters;

namespace T4TemplateExperiment
{
    [WooMe]
    public interface InterfaceToBeIntercepted
    {
        void HelpMe(string woo, bool what);

        string Param { get; }

        string WhatHappened(NonTrivialParameter parameter);

        string WillIAppear(int x, int y, int z, int a, int b, int c, int d, int e);
    }
}
