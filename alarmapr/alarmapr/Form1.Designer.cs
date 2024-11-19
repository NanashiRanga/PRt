namespace alarmapr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            tbhr = new TextBox();
            tbmin = new TextBox();
            label2 = new Label();
            cbst = new CheckBox();
            cblunes = new CheckBox();
            cbmartes = new CheckBox();
            cbmiercoles = new CheckBox();
            cbjueves = new CheckBox();
            cbviernes = new CheckBox();
            cbsabado = new CheckBox();
            cbdomingo = new CheckBox();
            btstop = new Button();
            btselcan = new Button();
            lbnomcan = new Label();
            axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Despertador";
            label1.Click += label1_Click;
            // 
            // tbhr
            // 
            tbhr.Location = new Point(82, 96);
            tbhr.Name = "tbhr";
            tbhr.Size = new Size(55, 23);
            tbhr.TabIndex = 1;
            tbhr.TextChanged += textBox1_TextChanged;
            // 
            // tbmin
            // 
            tbmin.Location = new Point(143, 96);
            tbmin.Name = "tbmin";
            tbmin.Size = new Size(55, 23);
            tbmin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 104);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Hora";
            label2.Click += label2_Click;
            // 
            // cbst
            // 
            cbst.AutoSize = true;
            cbst.Location = new Point(43, 142);
            cbst.Name = "cbst";
            cbst.Size = new Size(119, 19);
            cbst.TabIndex = 4;
            cbst.Text = "Seleccionar todos";
            cbst.UseVisualStyleBackColor = true;
            cbst.CheckedChanged += cbst_CheckedChanged;
            // 
            // cblunes
            // 
            cblunes.AutoSize = true;
            cblunes.Location = new Point(43, 167);
            cblunes.Name = "cblunes";
            cblunes.Size = new Size(57, 19);
            cblunes.TabIndex = 5;
            cblunes.Text = "Lunes";
            cblunes.UseVisualStyleBackColor = true;
            // 
            // cbmartes
            // 
            cbmartes.AutoSize = true;
            cbmartes.Location = new Point(43, 192);
            cbmartes.Name = "cbmartes";
            cbmartes.Size = new Size(62, 19);
            cbmartes.TabIndex = 6;
            cbmartes.Text = "Martes";
            cbmartes.UseVisualStyleBackColor = true;
            // 
            // cbmiercoles
            // 
            cbmiercoles.AutoSize = true;
            cbmiercoles.Location = new Point(43, 217);
            cbmiercoles.Name = "cbmiercoles";
            cbmiercoles.Size = new Size(77, 19);
            cbmiercoles.TabIndex = 7;
            cbmiercoles.Text = "Miercoles";
            cbmiercoles.UseVisualStyleBackColor = true;
            cbmiercoles.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // cbjueves
            // 
            cbjueves.AutoSize = true;
            cbjueves.Location = new Point(43, 242);
            cbjueves.Name = "cbjueves";
            cbjueves.Size = new Size(60, 19);
            cbjueves.TabIndex = 8;
            cbjueves.Text = "Jueves";
            cbjueves.UseVisualStyleBackColor = true;
            cbjueves.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // cbviernes
            // 
            cbviernes.AutoSize = true;
            cbviernes.Location = new Point(43, 267);
            cbviernes.Name = "cbviernes";
            cbviernes.Size = new Size(64, 19);
            cbviernes.TabIndex = 9;
            cbviernes.Text = "Viernes";
            cbviernes.UseVisualStyleBackColor = true;
            cbviernes.CheckedChanged += cbviernes_CheckedChanged;
            // 
            // cbsabado
            // 
            cbsabado.AutoSize = true;
            cbsabado.Location = new Point(43, 292);
            cbsabado.Name = "cbsabado";
            cbsabado.Size = new Size(65, 19);
            cbsabado.TabIndex = 10;
            cbsabado.Text = "Sabado";
            cbsabado.UseVisualStyleBackColor = true;
            cbsabado.CheckedChanged += cbsabado_CheckedChanged;
            // 
            // cbdomingo
            // 
            cbdomingo.AutoSize = true;
            cbdomingo.Location = new Point(43, 317);
            cbdomingo.Name = "cbdomingo";
            cbdomingo.Size = new Size(76, 19);
            cbdomingo.TabIndex = 11;
            cbdomingo.Text = "Domingo";
            cbdomingo.UseVisualStyleBackColor = true;
            cbdomingo.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // btstop
            // 
            btstop.Location = new Point(284, 91);
            btstop.Name = "btstop";
            btstop.Size = new Size(138, 29);
            btstop.TabIndex = 13;
            btstop.Text = "STOP";
            btstop.UseVisualStyleBackColor = true;
            // 
            // btselcan
            // 
            btselcan.Location = new Point(284, 56);
            btselcan.Name = "btselcan";
            btselcan.Size = new Size(138, 29);
            btselcan.TabIndex = 14;
            btselcan.Text = "Select song";
            btselcan.UseVisualStyleBackColor = true;
            btselcan.Click += btselcan_Click;
            // 
            // lbnomcan
            // 
            lbnomcan.AutoSize = true;
            lbnomcan.Location = new Point(292, 292);
            lbnomcan.Name = "lbnomcan";
            lbnomcan.Size = new Size(49, 15);
            lbnomcan.TabIndex = 15;
            lbnomcan.Text = "cancion";
            lbnomcan.Click += lbnomcan_Click;
            // 
            // axWindowsMediaPlayer2
            // 
            axWindowsMediaPlayer2.Enabled = true;
            axWindowsMediaPlayer2.Location = new Point(383, 288);
            axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            axWindowsMediaPlayer2.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer2.OcxState");
            axWindowsMediaPlayer2.Size = new Size(75, 23);
            axWindowsMediaPlayer2.TabIndex = 17;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(axWindowsMediaPlayer2);
            Controls.Add(lbnomcan);
            Controls.Add(btselcan);
            Controls.Add(btstop);
            Controls.Add(cbdomingo);
            Controls.Add(cbsabado);
            Controls.Add(cbviernes);
            Controls.Add(cbjueves);
            Controls.Add(cbmiercoles);
            Controls.Add(cbmartes);
            Controls.Add(cblunes);
            Controls.Add(cbst);
            Controls.Add(label2);
            Controls.Add(tbmin);
            Controls.Add(tbhr);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Alarma";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbhr;
        private TextBox tbmin;
        private Label label2;
        private CheckBox cbst;
        private CheckBox cblunes;
        private CheckBox cbmartes;
        private CheckBox cbmiercoles;
        private CheckBox cbjueves;
        private CheckBox cbviernes;
        private CheckBox cbsabado;
        private CheckBox cbdomingo;
        private Button btstop;
        private Button btselcan;
        private Label lbnomcan;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Timer timer1;
    }
}
