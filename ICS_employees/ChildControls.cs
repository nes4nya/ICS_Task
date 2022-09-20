﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_employees
{
    public static class ChildControls
    {
        public static IEnumerable<TControl> GetChildControls<TControl>(this Control control) where TControl : Control
        {
            var children = (control.Controls != null) ? control.Controls.OfType<TControl>() : Enumerable.Empty<TControl>();
            return children.SelectMany(c => GetChildControls<TControl>(c)).Concat(children);
        }
    }
}
