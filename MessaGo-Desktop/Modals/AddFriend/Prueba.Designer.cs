namespace MessaGo_Desktop.Modals.AddFriend
{
    partial class Prueba
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.modalAddFriend1 = new MessaGo_Desktop.Modals.AddFriend.ModalAddFriend();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.BtnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnClose.ImageRotate = 0F;
            this.BtnClose.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnClose.Location = new System.Drawing.Point(29, 25);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.TabIndex = 36;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // modalAddFriend1
            // 
            this.modalAddFriend1.BackColor = System.Drawing.Color.White;
            this.modalAddFriend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modalAddFriend1.Location = new System.Drawing.Point(0, 0);
            this.modalAddFriend1.Name = "modalAddFriend1";
            this.modalAddFriend1.Size = new System.Drawing.Size(679, 379);
            this.modalAddFriend1.TabIndex = 0;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 379);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.modalAddFriend1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prueba";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton BtnClose;
        private ModalAddFriend modalAddFriend1;
    }
}