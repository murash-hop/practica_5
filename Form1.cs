using practica_5.FolderforModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void userControl32_Load(object sender, EventArgs e)
        {

        }
        public static Model1 DB = new Model1();

        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControl31.Fill(Motorbikes[AccNumber]);
            userControl32.Fill(Motorbikes[AccNumber + 1]);
        }
        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)
                AccNumber--;
            else
                return;
            Loading();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }
    }
}
