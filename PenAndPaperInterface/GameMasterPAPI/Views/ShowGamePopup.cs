﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
{
    public partial class ShowGamePopup : PAPIPopup, ITranslatableView
    {
        public ShowGamePopup()
        {
            InitializeComponent();
        }

        public override void SetTextToActiveLanguage()
        {
            // TODO
        }

        
    }
}