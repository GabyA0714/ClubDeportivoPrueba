﻿

namespace ClubDeportivo
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(150, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(241, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Club Deportivo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Cyan;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.Blue;
            btnIngresar.Location = new Point(292, 194);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(99, 38);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(235, 106);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(195, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(235, 148);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(195, 23);
            txtContrasenia.TabIndex = 6;
            txtContrasenia.Text = "CONTRASEÑA";
            txtContrasenia.Enter += txtContrasenia_Enter;
            txtContrasenia.Leave += txtContrasenia_Leave;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(472, 293);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Name = "FormLogin";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion


        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
    }
}
