namespace NG_Injector
{
    partial class Injector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Injector));
            this.AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Borderless = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.Discord = new Guna.UI2.WinForms.Guna2Button();
            this.Website = new Guna.UI2.WinForms.Guna2Button();
            this.NG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Inject = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.NG)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimateWindow
            // 
            this.AnimateWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            // 
            // Borderless
            // 
            this.Borderless.AnimateWindow = true;
            this.Borderless.AnimationInterval = 300;
            this.Borderless.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.Borderless.ContainerControl = this;
            this.Borderless.DockIndicatorTransparencyValue = 0.6D;
            this.Borderless.ResizeForm = false;
            this.Borderless.TransparentWhileDrag = true;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.UseTransparentDrag = true;
            // 
            // Exit
            // 
            this.Exit.Animated = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderColor = System.Drawing.Color.Transparent;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Exit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(447, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 0;
            this.Exit.UseTransparentBackground = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.Animated = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BorderColor = System.Drawing.Color.Transparent;
            this.Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Minimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(416, -1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(25, 25);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseTransparentBackground = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Discord
            // 
            this.Discord.Animated = true;
            this.Discord.BackColor = System.Drawing.Color.Transparent;
            this.Discord.BorderColor = System.Drawing.Color.Transparent;
            this.Discord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Discord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Discord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Discord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Discord.FillColor = System.Drawing.Color.Transparent;
            this.Discord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Discord.ForeColor = System.Drawing.Color.White;
            this.Discord.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Discord.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Discord.Image = ((System.Drawing.Image)(resources.GetObject("Discord.Image")));
            this.Discord.ImageSize = new System.Drawing.Size(25, 25);
            this.Discord.Location = new System.Drawing.Point(-1, 0);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(28, 24);
            this.Discord.TabIndex = 2;
            this.Discord.UseTransparentBackground = true;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // Website
            // 
            this.Website.Animated = true;
            this.Website.BackColor = System.Drawing.Color.Transparent;
            this.Website.BorderColor = System.Drawing.Color.Transparent;
            this.Website.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Website.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Website.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Website.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Website.FillColor = System.Drawing.Color.Transparent;
            this.Website.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Website.ForeColor = System.Drawing.Color.White;
            this.Website.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Website.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Website.Image = ((System.Drawing.Image)(resources.GetObject("Website.Image")));
            this.Website.Location = new System.Drawing.Point(33, 0);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(28, 24);
            this.Website.TabIndex = 3;
            this.Website.UseTransparentBackground = true;
            this.Website.Click += new System.EventHandler(this.Website_Click);
            // 
            // NG
            // 
            this.NG.BackColor = System.Drawing.Color.Transparent;
            this.NG.Image = ((System.Drawing.Image)(resources.GetObject("NG.Image")));
            this.NG.ImageRotate = 0F;
            this.NG.Location = new System.Drawing.Point(157, 32);
            this.NG.Name = "NG";
            this.NG.Size = new System.Drawing.Size(161, 118);
            this.NG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NG.TabIndex = 4;
            this.NG.TabStop = false;
            this.NG.UseTransparentBackground = true;
            // 
            // Inject
            // 
            this.Inject.BorderRadius = 14;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Inject.FillColor2 = System.Drawing.Color.Cyan;
            this.Inject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Inject.Location = new System.Drawing.Point(157, 156);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(161, 45);
            this.Inject.TabIndex = 5;
            this.Inject.Text = "Inject";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // Injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(468, 264);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.NG);
            this.Controls.Add(this.Website);
            this.Controls.Add(this.Discord);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Injector";
            this.Text = "Injector";
            ((System.ComponentModel.ISupportInitialize)(this.NG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        private Guna.UI2.WinForms.Guna2BorderlessForm Borderless;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI2.WinForms.Guna2Button Discord;
        private Guna.UI2.WinForms.Guna2Button Website;
        private Guna.UI2.WinForms.Guna2PictureBox NG;
        private Guna.UI2.WinForms.Guna2GradientButton Inject;
    }
}

