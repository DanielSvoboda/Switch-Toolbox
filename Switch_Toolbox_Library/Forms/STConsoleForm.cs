﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Toolbox.Library.Forms
{
    public partial class STConsoleForm : STForm
    {
        public STConsoleForm()
        {
            InitializeComponent();
            stPanel1.Controls.Add(STConsole.Instance);

            Text = "Console";
        }
    }
}
