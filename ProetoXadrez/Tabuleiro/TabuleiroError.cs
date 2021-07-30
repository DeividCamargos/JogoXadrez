using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class TabuleiroError : Exception
    {
        public TabuleiroError (string msg) : base (msg)
        {

        }
    }
}
