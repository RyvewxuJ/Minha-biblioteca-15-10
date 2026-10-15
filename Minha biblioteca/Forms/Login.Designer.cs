namespace Minha_biblioteca.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            Usuario2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Usuario = new Label();
            Usuario1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Usuario2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Usuario);
            panel1.Controls.Add(Usuario1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 342);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Usuario2
            // 
            Usuario2.AutoSize = true;
            Usuario2.Location = new Point(62, 231);
            Usuario2.Name = "Usuario2";
            Usuario2.Size = new Size(39, 15);
            Usuario2.TabIndex = 7;
            Usuario2.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(123, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(62, 231);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(0, 15);
            Usuario.TabIndex = 3;
            // 
            // Usuario1
            // 
            Usuario1.AutoSize = true;
            Usuario1.Location = new Point(62, 176);
            Usuario1.Name = "Usuario1";
            Usuario1.Size = new Size(47, 15);
            Usuario1.TabIndex = 2;
            Usuario1.Text = "Usuario";
            Usuario1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(62, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(229, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 366);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label Usuario1;
        private Label Usuario;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label Usuario2;
    }
}