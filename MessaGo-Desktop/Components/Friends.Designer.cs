namespace MessaGo_Desktop.Components
{
    partial class Friends
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Friends));
            this.b1 = new Guna.UI2.WinForms.Guna2Button();
            this.PtbFoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblUltimoMsg = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b1.BorderRadius = 5;
            this.b1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.b1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.b1.Location = new System.Drawing.Point(10, 10);
            this.b1.Name = "b1";
            this.b1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.b1.Size = new System.Drawing.Size(263, 53);
            this.b1.TabIndex = 3;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // PtbFoto
            // 
            this.PtbFoto.BackColor = System.Drawing.Color.Transparent;
            this.PtbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbFoto.Image = ((System.Drawing.Image)(resources.GetObject("PtbFoto.Image")));
            this.PtbFoto.ImageRotate = 0F;
            this.PtbFoto.Location = new System.Drawing.Point(3, 3);
            this.PtbFoto.Name = "PtbFoto";
            this.PtbFoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PtbFoto.Size = new System.Drawing.Size(42, 42);
            this.PtbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbFoto.TabIndex = 4;
            this.PtbFoto.TabStop = false;
            this.PtbFoto.UseTransparentBackground = true;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(71, 18);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(114, 20);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Miladis Nivar ";
            // 
            // LblUltimoMsg
            // 
            this.LblUltimoMsg.AutoSize = true;
            this.LblUltimoMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.LblUltimoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUltimoMsg.ForeColor = System.Drawing.Color.Gray;
            this.LblUltimoMsg.Location = new System.Drawing.Point(72, 42);
            this.LblUltimoMsg.Name = "LblUltimoMsg";
            this.LblUltimoMsg.Size = new System.Drawing.Size(61, 16);
            this.LblUltimoMsg.TabIndex = 6;
            this.LblUltimoMsg.Text = "Tu: Hola!";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 23;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.PtbFoto);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.guna2Panel4.Location = new System.Drawing.Point(17, 13);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(3);
            this.guna2Panel4.Size = new System.Drawing.Size(48, 48);
            this.guna2Panel4.TabIndex = 34;
            // 
            // timer1
            // 
            this.timer1.Interval = 180;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.LblUltimoMsg);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.b1);
            this.Name = "Friends";
            this.Size = new System.Drawing.Size(283, 73);
            ((System.ComponentModel.ISupportInitialize)(this.PtbFoto)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button b1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PtbFoto;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblUltimoMsg;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Timer timer1;
    }
}
