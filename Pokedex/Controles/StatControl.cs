using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex.Controles
{
    public partial class StatControl : UserControl
    {
        public StatControl()
        {
            InitializeComponent();
        }

        public string StatName
        {
            set => label1.Text = value;
        }

        public int StatValue
        {
            set => myProgressbAr1.Value = value;
        }
    }
}
