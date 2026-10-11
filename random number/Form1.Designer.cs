namespace random_number
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
            groupBox1 = new GroupBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Lavender;
            groupBox1.Location = new Point(25, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 542);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ədəd axtarışı";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(15, 168);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(454, 63);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            button1.ForeColor = Color.Indigo;
            button1.Location = new Point(78, 329);
            button1.Name = "button1";
            button1.Size = new Size(276, 106);
            button1.TabIndex = 2;
            button1.Text = "yoxla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(15, 102);
            label1.Name = "label1";
            label1.Size = new Size(261, 50);
            label1.TabIndex = 0;
            label1.Text = "axtarılan ədəd";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            button2.ForeColor = Color.Indigo;
            button2.Location = new Point(571, 467);
            button2.Name = "button2";
            button2.Size = new Size(459, 106);
            button2.TabIndex = 3;
            button2.Text = "yeni oyun";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(571, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(459, 380);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1069, 617);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "random number";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private ErrorProvider errorProvider1;
        private RichTextBox richTextBox2;
    }
}
