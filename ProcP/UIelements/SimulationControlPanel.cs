using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP.UIelements
{
    public partial class SimulationControlPanel : UserControl
    {
        
        public event EventHandler OnStopSim;

        public SimulationControlPanel()
        {
            InitializeComponent();
            btnStopSimulation.Click += (s, e) => this.OnStopSim?.Invoke(this, e);
            
        }
        
    }
}
