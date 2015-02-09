using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOTE_field;

namespace cource_worck
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public note n;   

        private void button1_Click(object sender, EventArgs e)
        {
            n = new note();
            n.query = textBox1.Text;
            n.answer = textBox2.Text;
            n.zalick = textBox3.Text;
            n.coment = textBox4.Text;
            n.source = textBox5.Text;
            n.author = textBox6.Text;
            n.place = textBox7.Text;
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
