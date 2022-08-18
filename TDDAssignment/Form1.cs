using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDAssignment
{
    public partial class Owoda : Form
    {
        public bool isMember { get; set; }
        public int vType { get; set; }
        public int noOftrip { get; set; }

        public Owoda()
        {
            InitializeComponent();
        }

        private void Owoda_Load(object sender, EventArgs e)
        {

        }

        private void car_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tripNum = 0;
            if (car.Checked) { vType = 1; } else { vType = 2; }
            if (yes.Checked) { isMember = true; } else { isMember = false; }
            if(Int32.TryParse(noOftrips.Text, out tripNum))
            {
                noOftrip = tripNum;
            }
            else { noOftrip = 0; }
            var toll = TollCalc(vType, isMember, noOftrip);
            tollDue.Text = toll.ToString();
                      
        }

        public double TollCalc(int vehicle, bool nurtw, int trips)
        {
            double baseAmount, toll;
            if (vehicle == 1) { baseAmount = 200; } else { baseAmount = 180; };
            if (nurtw) { toll = baseAmount * 0.7; } else { toll = baseAmount; };
            return Math.Round((toll * trips), 2);

        }
    }
}
