using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cource_worck
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Size = this.Size;
            StreamReader sr = new StreamReader("ReadMe.txt",Encoding.GetEncoding(1251)); 
            label1.Text =  sr.ReadToEnd();
        }
    }
}
