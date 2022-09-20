using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2.Lobby
{
    public partial class LoadBox : UserControl
    {
        public LoadBox(int IndexPeta)
        {
            InitializeComponent();
            FrontFood.Size = new Size(Math.Max(0, Convert.ToInt32(Math.Round(Convert.ToDouble(Hra.pets[IndexPeta].Hunger) * 0.4))), FrontFood.Size.Height);
            Hunger.Text = Math.Round((Convert.ToDouble(Hra.pets[IndexPeta].Hunger) * 2) / 10).ToString();
        }
    }
}
