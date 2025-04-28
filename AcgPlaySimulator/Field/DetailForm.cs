using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcgPlaySimulator.Field
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        public Image Image { get; set; }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Image;
        }
    }
}
