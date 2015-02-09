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
using System.Threading;
using NOTE_field;
using db_lb_kursova;

namespace cource_worck
{
    public partial class Form1 : Form


    {
        string conect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Діма\Desktop\універ\try\cource_worck\cource_worck\game.mdf;Integrated Security=True";
        string name_tab = "www";
        db DB;
        void con()
        {
            DB = new db(conect,name_tab);
            DB.dgv = dataGridView1;
        }
        void locSiz()
        {
            Point p = new Point(15, 30);
            Size s = new Size(251, 263);
            this.textBox2.Location = p;
            this.textBox2.Size = s; 
        }
        void unvisiable()
        { 
            button2.Visible = false; 
 

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                DB = new db(conect, name_tab);
                DB.id = Convert.ToInt16(dataGridView1.CurrentCell.Value);
                DB.dgv = dataGridView1;
                DB.delete();
                DB.output();
            }
            catch { MessageBox.Show("Please, select field 'id'"); }

        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            unvisiable();
            con();
            DB.output(); 
        }

        
        
 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
                unvisiable();
                locSiz();
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
               
                    con();
                    string way = openFileDialog1.FileName;
                    file fl = new file();
                    fl.way = way;
                    note n = new note();
                    List<note> ls = new List<note>();
                    fl.List_fields(ref ls);
                    DB.add_data(ls);
                    DB.output(); 
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = new Point(15, 110);
            Size s = new Size(251,183);
            this.textBox2.Location = p;
            this.textBox2.Size = s; 
            unvisiable(); 
            button2.Visible = true; 
            DB = new db(conect, name_tab);
            this.Height = 350;
            this.Width = 1045;
            DB.dgv = dataGridView1;
            DB.output();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locSiz();
            unvisiable(); 
            DB = new db(conect, name_tab);
            this.Height = 350;
            this.Width = 1045;
            con();
            DB.output();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        } 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = Convert.ToString(dataGridView1.CurrentCell.Value);
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con();
            locSiz();
            Form2 f = new Form2();
            f.ShowDialog();
            string a = f.a;
            if (a == null) return;
            DB.one_query(FieldsOfNote.qurey,a);
        }

        private void answerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con();
            locSiz();
            Form2 f = new Form2();
            f.ShowDialog();
            string a = f.a;
            if (a == null) return;
            DB.one_query(FieldsOfNote.answer, a);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con();
            locSiz();
            Form2 f = new Form2();
            f.ShowDialog();
            string a = f.a;
            if (a == null) return;
            DB.one_query(FieldsOfNote.place, a);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void zalickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con();
            locSiz();
            Form2 f = new Form2();
            f.ShowDialog();
            string a = f.a;
            if (a == null) return;
            DB.one_query(FieldsOfNote.zalick, a); 
        }

        private void comentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con();
            locSiz();
            Form2 f = new Form2();
            f.ShowDialog();
            string a = f.a;
            if (a == null) return;
            DB.one_query(FieldsOfNote.coment, a); 
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con();
            locSiz();
            Form2 f = new Form2();
            f.ShowDialog();
            string a = f.a;
            if (a == null) return;
            DB.one_query(FieldsOfNote.source, a); 
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con();
            locSiz();
            Form2 f = new Form2();
            f.ShowDialog();
            string a = f.a;
            if (a == null) return;
            DB.one_query(FieldsOfNote.author, a); 
        }

        private void manyFieldToolStripMenuItem_Click(object sender, EventArgs e)
        { 
                con();
                locSiz();
                Form3 f = new Form3();
                f.ShowDialog();
                if (f.n == null) return;
                DB.many_query(f.n);
            
        }

        private void asdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            locSiz();
            f.ShowDialog();
        }
    }
}
 