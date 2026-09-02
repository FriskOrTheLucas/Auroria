using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auroria.NT.Resources
{
    public static class PathHelper
    {
        public static AurNTBase MainForm;

        public static string Client
        {
            get
            {
                return MainForm?.SelectedClient ?? "";
            }
        }
    }
}