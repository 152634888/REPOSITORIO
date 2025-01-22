namespace Situação_de_Aprendizagem
{
    partial class btnCarregar
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
            button1 = new Button();
            label1 = new Label();
            textID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textName = new TextBox();
            textTipo = new TextBox();
            textValor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textTipop = new TextBox();
            textNamep = new TextBox();
            textValatualp = new TextBox();
            textIDp = new TextBox();
            textTipo1 = new Label();
            textName1 = new Label();
            textValor1 = new Label();
            textID1 = new Label();
            panel3 = new Panel();
            textTipou = new TextBox();
            textNameu = new TextBox();
            textValatualu = new TextBox();
            textIDu = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            labe1 = new Label();
            label11 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            texttime = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 720);
            button1.Name = "button1";
            button1.Size = new Size(278, 47);
            button1.TabIndex = 0;
            button1.Text = "Carregar valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(195, 23);
            label1.TabIndex = 1;
            label1.Text = "Sensor de Temperatura";
            // 
            // textID
            // 
            textID.Location = new Point(160, 61);
            textID.Name = "textID";
            textID.Size = new Size(125, 27);
            textID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(21, 61);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 3;
            label2.Text = "ID do Sensor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(19, 130);
            label3.Name = "label3";
            label3.Size = new Size(142, 23);
            label3.TabIndex = 4;
            label3.Text = "Nome do Sensor:";
            // 
            // textName
            // 
            textName.Location = new Point(160, 130);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 5;
            // 
            // textTipo
            // 
            textTipo.Location = new Point(160, 163);
            textTipo.Name = "textTipo";
            textTipo.Size = new Size(125, 27);
            textTipo.TabIndex = 6;
            // 
            // textValor
            // 
            textValor.Location = new Point(160, 94);
            textValor.Name = "textValor";
            textValor.Size = new Size(125, 27);
            textValor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(21, 163);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 8;
            label4.Text = "Tipo do Sensor:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(21, 94);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 9;
            label5.Text = "Valor Atual:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 29);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 10;
            label6.Text = "Sensor de Pressao";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textValor);
            panel1.Controls.Add(textName);
            panel1.Controls.Add(textTipo);
            panel1.Location = new Point(7, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 218);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(textTipop);
            panel2.Controls.Add(textNamep);
            panel2.Controls.Add(textValatualp);
            panel2.Controls.Add(textIDp);
            panel2.Controls.Add(textTipo1);
            panel2.Controls.Add(textName1);
            panel2.Controls.Add(textValor1);
            panel2.Controls.Add(textID1);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(7, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 218);
            panel2.TabIndex = 12;
            // 
            // textTipop
            // 
            textTipop.Location = new Point(160, 164);
            textTipop.Name = "textTipop";
            textTipop.Size = new Size(125, 27);
            textTipop.TabIndex = 18;
            // 
            // textNamep
            // 
            textNamep.Location = new Point(160, 130);
            textNamep.Name = "textNamep";
            textNamep.Size = new Size(125, 27);
            textNamep.TabIndex = 17;
            // 
            // textValatualp
            // 
            textValatualp.Location = new Point(160, 96);
            textValatualp.Name = "textValatualp";
            textValatualp.Size = new Size(125, 27);
            textValatualp.TabIndex = 16;
            // 
            // textIDp
            // 
            textIDp.Location = new Point(160, 63);
            textIDp.Name = "textIDp";
            textIDp.Size = new Size(125, 27);
            textIDp.TabIndex = 15;
            // 
            // textTipo1
            // 
            textTipo1.AutoSize = true;
            textTipo1.Font = new Font("Segoe UI", 10F);
            textTipo1.Location = new Point(21, 164);
            textTipo1.Name = "textTipo1";
            textTipo1.Size = new Size(128, 23);
            textTipo1.TabIndex = 14;
            textTipo1.Text = "Tipo do Sensor:";
            // 
            // textName1
            // 
            textName1.AutoSize = true;
            textName1.Font = new Font("Segoe UI", 10F);
            textName1.Location = new Point(21, 130);
            textName1.Name = "textName1";
            textName1.Size = new Size(142, 23);
            textName1.TabIndex = 13;
            textName1.Text = "Nome do Sensor:";
            // 
            // textValor1
            // 
            textValor1.AutoSize = true;
            textValor1.Font = new Font("Segoe UI", 10F);
            textValor1.Location = new Point(21, 97);
            textValor1.Name = "textValor1";
            textValor1.Size = new Size(134, 23);
            textValor1.TabIndex = 12;
            textValor1.Text = "Valor do Sensor:";
            textValor1.Click += textValor1_Click;
            // 
            // textID1
            // 
            textID1.AutoSize = true;
            textID1.Font = new Font("Segoe UI", 10F);
            textID1.Location = new Point(21, 63);
            textID1.Name = "textID1";
            textID1.Size = new Size(112, 23);
            textID1.TabIndex = 11;
            textID1.Text = "ID do Sensor:";
            // 
            // panel3
            // 
            panel3.Controls.Add(textTipou);
            panel3.Controls.Add(textNameu);
            panel3.Controls.Add(textValatualu);
            panel3.Controls.Add(textIDu);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(labe1);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(6, 490);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 218);
            panel3.TabIndex = 13;
            // 
            // textTipou
            // 
            textTipou.Location = new Point(160, 164);
            textTipou.Name = "textTipou";
            textTipou.Size = new Size(125, 27);
            textTipou.TabIndex = 18;
            // 
            // textNameu
            // 
            textNameu.Location = new Point(160, 130);
            textNameu.Name = "textNameu";
            textNameu.Size = new Size(125, 27);
            textNameu.TabIndex = 17;
            // 
            // textValatualu
            // 
            textValatualu.Location = new Point(160, 96);
            textValatualu.Name = "textValatualu";
            textValatualu.Size = new Size(125, 27);
            textValatualu.TabIndex = 16;
            // 
            // textIDu
            // 
            textIDu.Location = new Point(160, 63);
            textIDu.Name = "textIDu";
            textIDu.Size = new Size(125, 27);
            textIDu.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(21, 164);
            label7.Name = "label7";
            label7.Size = new Size(128, 23);
            label7.TabIndex = 14;
            label7.Text = "Tipo do Sensor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(21, 130);
            label8.Name = "label8";
            label8.Size = new Size(142, 23);
            label8.TabIndex = 13;
            label8.Text = "Nome do Sensor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(21, 97);
            label9.Name = "label9";
            label9.Size = new Size(134, 23);
            label9.TabIndex = 12;
            label9.Text = "Valor do Sensor:";
            // 
            // labe1
            // 
            labe1.AutoSize = true;
            labe1.Font = new Font("Segoe UI", 10F);
            labe1.Location = new Point(21, 63);
            labe1.Name = "labe1";
            labe1.Size = new Size(112, 23);
            labe1.TabIndex = 11;
            labe1.Text = "ID do Sensor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(19, 29);
            label11.Name = "label11";
            label11.Size = new Size(166, 23);
            label11.TabIndex = 10;
            label11.Text = "Sensor de Umidade";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // texttime
            // 
            texttime.AutoSize = true;
            texttime.Font = new Font("Segoe UI", 10F);
            texttime.Location = new Point(427, 731);
            texttime.Name = "texttime";
            texttime.Size = new Size(50, 23);
            texttime.TabIndex = 14;
            texttime.Text = "00:00";
            // 
            // btnCarregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 779);
            Controls.Add(texttime);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "btnCarregar";
            Text = "Form1";
            Load += btnCarregar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textID;
        private Label label2;
        private Label label3;
        private TextBox textName;
        private TextBox textTipo;
        private TextBox textValor;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Label textValor1;
        private Label textID1;
        private Label textTipo1;
        private Label textName1;
        private TextBox textTipop;
        private TextBox textNamep;
        private TextBox textValatualp;
        private TextBox textIDp;
        private Panel panel3;
        private TextBox textTipou;
        private TextBox textNameu;
        private TextBox textValatualu;
        private TextBox textIDu;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label labe1;
        private Label label11;
        private System.Windows.Forms.Timer timer1;
        private Label texttime;
    }
}
