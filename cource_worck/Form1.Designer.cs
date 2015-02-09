namespace cource_worck
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sdadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adsadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.answerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manyFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 302);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdadsToolStripMenuItem,
            this.adsadsToolStripMenuItem,
            this.asdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sdadsToolStripMenuItem
            // 
            this.sdadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.showToolStripMenuItem});
            this.sdadsToolStripMenuItem.Name = "sdadsToolStripMenuItem";
            this.sdadsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.sdadsToolStripMenuItem.Text = "Data base";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // adsadsToolStripMenuItem
            // 
            this.adsadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneFieldToolStripMenuItem,
            this.manyFieldToolStripMenuItem});
            this.adsadsToolStripMenuItem.Name = "adsadsToolStripMenuItem";
            this.adsadsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.adsadsToolStripMenuItem.Text = "Query";
            // 
            // oneFieldToolStripMenuItem
            // 
            this.oneFieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qToolStripMenuItem,
            this.answerToolStripMenuItem,
            this.zalickToolStripMenuItem,
            this.comentToolStripMenuItem,
            this.sourceToolStripMenuItem,
            this.authorToolStripMenuItem,
            this.placeToolStripMenuItem});
            this.oneFieldToolStripMenuItem.Name = "oneFieldToolStripMenuItem";
            this.oneFieldToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.oneFieldToolStripMenuItem.Text = "One Field";
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.ShowShortcutKeys = false;
            this.qToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.qToolStripMenuItem.Text = "Question";
            this.qToolStripMenuItem.Click += new System.EventHandler(this.qToolStripMenuItem_Click);
            // 
            // answerToolStripMenuItem
            // 
            this.answerToolStripMenuItem.Name = "answerToolStripMenuItem";
            this.answerToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.answerToolStripMenuItem.Text = "Answer";
            this.answerToolStripMenuItem.Click += new System.EventHandler(this.answerToolStripMenuItem_Click);
            // 
            // zalickToolStripMenuItem
            // 
            this.zalickToolStripMenuItem.Name = "zalickToolStripMenuItem";
            this.zalickToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zalickToolStripMenuItem.Text = "Zalick";
            this.zalickToolStripMenuItem.Click += new System.EventHandler(this.zalickToolStripMenuItem_Click);
            // 
            // comentToolStripMenuItem
            // 
            this.comentToolStripMenuItem.Name = "comentToolStripMenuItem";
            this.comentToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.comentToolStripMenuItem.Text = "Coment";
            this.comentToolStripMenuItem.Click += new System.EventHandler(this.comentToolStripMenuItem_Click);
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sourceToolStripMenuItem.Text = "Source";
            this.sourceToolStripMenuItem.Click += new System.EventHandler(this.sourceToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // placeToolStripMenuItem
            // 
            this.placeToolStripMenuItem.Name = "placeToolStripMenuItem";
            this.placeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.placeToolStripMenuItem.Text = "Place";
            this.placeToolStripMenuItem.Click += new System.EventHandler(this.placeToolStripMenuItem_Click);
            // 
            // manyFieldToolStripMenuItem
            // 
            this.manyFieldToolStripMenuItem.Name = "manyFieldToolStripMenuItem";
            this.manyFieldToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.manyFieldToolStripMenuItem.Text = "Many Field";
            this.manyFieldToolStripMenuItem.Click += new System.EventHandler(this.manyFieldToolStripMenuItem_Click);
            // 
            // asdaToolStripMenuItem
            // 
            this.asdaToolStripMenuItem.Name = "asdaToolStripMenuItem";
            this.asdaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.asdaToolStripMenuItem.Text = "About Program";
            this.asdaToolStripMenuItem.Click += new System.EventHandler(this.asdaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(15, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(251, 266);
            this.textBox2.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1113, 305);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "cource worck DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adsadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manyFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem answerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

