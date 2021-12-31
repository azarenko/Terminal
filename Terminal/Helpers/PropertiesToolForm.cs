using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Terminal.Helpers
{
    public partial class PropertiesToolForm : Form
    {
        public PropertiesToolForm(object component)
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = component;
        }
    }

    
}
