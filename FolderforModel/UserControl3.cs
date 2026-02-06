using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica_5.FolderforModel;

namespace practica_5.FolderforModel
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
        public void Fill (Table_Motorbike Motorbike)
        {
            label1.Text = Motorbike.ID.ToString();
            label2.Text = Motorbike.Model;
            label3.Text = Motorbike.Brand;
            label4.Text = Motorbike.Price.ToString();
            label5.Text = Motorbike.Horsepower.ToString();
            label6.Text = Motorbike.Mileage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{Motorbike.Image}");
        }
    }
}
