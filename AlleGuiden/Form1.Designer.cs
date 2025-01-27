namespace AlleGuiden
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            BtnDelete = new Button();
            BtnF = new Button();
            listBoxBetyg = new ListBox();
            BtnE = new Button();
            button2 = new Button();
            button1 = new Button();
            BtnA = new Button();
            BtnD = new Button();
            BtnB = new Button();
            BtnC = new Button();
            groupBox2 = new GroupBox();
            listBoxF = new ListBox();
            label7 = new Label();
            tbxMerit = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            listboxProgram = new ListBox();
            groupBox4 = new GroupBox();
            listboxProgram2 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnF);
            groupBox1.Controls.Add(listBoxBetyg);
            groupBox1.Controls.Add(BtnE);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnA);
            groupBox1.Controls.Add(BtnD);
            groupBox1.Controls.Add(BtnB);
            groupBox1.Controls.Add(BtnC);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 599);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Betyg";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 404);
            label8.Name = "label8";
            label8.Size = new Size(259, 15);
            label8.TabIndex = 11;
            label8.Text = "Har du inte gått en kurs ska du skriva den som F";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(326, 378);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 10;
            BtnDelete.Text = "Radera";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnF
            // 
            BtnF.Location = new Point(326, 244);
            BtnF.Name = "BtnF";
            BtnF.Size = new Size(75, 23);
            BtnF.TabIndex = 9;
            BtnF.Text = "F";
            BtnF.UseVisualStyleBackColor = true;
            BtnF.Click += Betygs_Click;
            // 
            // listBoxBetyg
            // 
            listBoxBetyg.FormattingEnabled = true;
            listBoxBetyg.ItemHeight = 15;
            listBoxBetyg.Location = new Point(6, 22);
            listBoxBetyg.Name = "listBoxBetyg";
            listBoxBetyg.Size = new Size(252, 379);
            listBoxBetyg.TabIndex = 0;
            listBoxBetyg.SelectedIndexChanged += listBoxBetyg_SelectedIndexChanged;
            // 
            // BtnE
            // 
            BtnE.Location = new Point(326, 199);
            BtnE.Name = "BtnE";
            BtnE.Size = new Size(75, 23);
            BtnE.TabIndex = 8;
            BtnE.Text = "E";
            BtnE.UseVisualStyleBackColor = true;
            BtnE.Click += Betygs_Click;
            // 
            // button2
            // 
            button2.Location = new Point(326, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "A";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Betygs_Click;
            // 
            // button1
            // 
            button1.Location = new Point(326, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnA_Click;
            // 
            // BtnA
            // 
            BtnA.Location = new Point(326, 22);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(75, 23);
            BtnA.TabIndex = 4;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(326, 150);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(75, 23);
            BtnD.TabIndex = 7;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += Betygs_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(326, 61);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(75, 23);
            BtnB.TabIndex = 5;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += Betygs_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(326, 104);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(75, 23);
            BtnC.TabIndex = 6;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += Betygs_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxF);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbxMerit);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(550, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 599);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Merit";
            // 
            // listBoxF
            // 
            listBoxF.FormattingEnabled = true;
            listBoxF.ItemHeight = 15;
            listBoxF.Location = new Point(0, 403);
            listBoxF.Name = "listBoxF";
            listBoxF.Size = new Size(265, 154);
            listBoxF.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(187, 45);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 7;
            label7.Text = "MeritVärde:";
            // 
            // tbxMerit
            // 
            tbxMerit.Location = new Point(260, 42);
            tbxMerit.Name = "tbxMerit";
            tbxMerit.ReadOnly = true;
            tbxMerit.Size = new Size(100, 23);
            tbxMerit.TabIndex = 6;
            tbxMerit.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 112);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 5;
            label6.Text = "F=0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 95);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "E=10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 80);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "D=12.5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 65);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "C=15";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 50);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "B=17.5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "A=20";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listboxProgram);
            groupBox3.Location = new Point(1085, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(507, 290);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Möjliga Program som matchar dina intressen";
            // 
            // listboxProgram
            // 
            listboxProgram.FormattingEnabled = true;
            listboxProgram.ItemHeight = 15;
            listboxProgram.Location = new Point(6, 22);
            listboxProgram.Name = "listboxProgram";
            listboxProgram.Size = new Size(426, 259);
            listboxProgram.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listboxProgram2);
            groupBox4.Location = new Point(1085, 334);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(507, 195);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Program du inte har bästa matchen med";
            // 
            // listboxProgram2
            // 
            listboxProgram2.FormattingEnabled = true;
            listboxProgram2.ItemHeight = 15;
            listboxProgram2.Location = new Point(14, 34);
            listboxProgram2.Name = "listboxProgram2";
            listboxProgram2.Size = new Size(332, 139);
            listboxProgram2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 612);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnF;
        private ListBox listBoxBetyg;
        private Button BtnE;
        private Button BtnA;
        private Button BtnD;
        private Button BtnB;
        private Button BtnC;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button BtnDelete;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxMerit;
        private ListBox listBoxF;
        private Label label7;
        private Label label8;
		private ListBox listboxProgram;
		private ListBox listboxProgram2;
	}
}
