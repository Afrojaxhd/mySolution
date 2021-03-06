﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace mySolution.Templates.Overlay
{
    public class ItemControl<T> : OverlayHelper<T> where T : UserControl
    {
        public ItemControl()
        {
            mySControls = new ObservableCollection<mySControl>();

            D3RenderControl = Activator.CreateInstance<T>();
            D3RenderControl.DataContext = this;
        }
    }
}
