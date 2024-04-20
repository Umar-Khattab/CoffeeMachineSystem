namespace CoffeeMachineSystem.GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            idTxtBx = new Krypton.Toolkit.KryptonTextBox();
            passTxtbx = new Krypton.Toolkit.KryptonTextBox();
            IDLabel = new Label();
            passLabel = new Label();
            LoginBtn = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
            SwitchIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SwitchIcon).BeginInit();
            SuspendLayout();
            // 
            // idTxtBx
            // 
            idTxtBx.CornerRoundingRadius = 15F;
            idTxtBx.Location = new Point(366, 86);
            idTxtBx.Name = "idTxtBx";
            idTxtBx.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            idTxtBx.Size = new Size(255, 41);
            idTxtBx.StateCommon.Back.Color1 = Color.FromArgb(255, 237, 217);
            idTxtBx.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            idTxtBx.StateCommon.Border.Rounding = 15F;
            idTxtBx.TabIndex = 0;
            // 
            // passTxtbx
            // 
            passTxtbx.CornerRoundingRadius = 15F;
            passTxtbx.Location = new Point(366, 159);
            passTxtbx.Name = "passTxtbx";
            passTxtbx.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            passTxtbx.Size = new Size(255, 41);
            passTxtbx.StateCommon.Back.Color1 = Color.FromArgb(255, 237, 217);
            passTxtbx.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            passTxtbx.StateCommon.Border.Rounding = 15F;
            passTxtbx.TabIndex = 1;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IDLabel.Location = new Point(217, 86);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(108, 29);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "User ID";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passLabel.Location = new Point(217, 159);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(132, 29);
            passLabel.TabIndex = 3;
            passLabel.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.CornerRoundingRadius = 20F;
            LoginBtn.Location = new Point(266, 234);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(210, 59);
            LoginBtn.StateCommon.Back.Color1 = Color.FromArgb(102, 66, 24);
            LoginBtn.StateCommon.Back.Color2 = Color.FromArgb(102, 66, 24);
            LoginBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginBtn.StateCommon.Border.Rounding = 20F;
            LoginBtn.StateCommon.Content.LongText.Color1 = Color.White;
            LoginBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            LoginBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            LoginBtn.StateCommon.Content.ShortText.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.TabIndex = 4;
            LoginBtn.Values.Text = "Log In";
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SwitchIcon
            // 
            SwitchIcon.Image = (Image)resources.GetObject("SwitchIcon.Image");
            SwitchIcon.Location = new Point(607, 5);
            SwitchIcon.Name = "SwitchIcon";
            SwitchIcon.Size = new Size(63, 63);
            SwitchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            SwitchIcon.TabIndex = 6;
            SwitchIcon.TabStop = false;
            SwitchIcon.Click += SwitchIcon_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 342);
            Controls.Add(SwitchIcon);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(passLabel);
            Controls.Add(IDLabel);
            Controls.Add(passTxtbx);
            Controls.Add(idTxtBx);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SwitchIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox idTxtBx;
        private Krypton.Toolkit.KryptonTextBox passTxtbx;
        private Label IDLabel;
        private Label passLabel;
        private Krypton.Toolkit.KryptonButton LoginBtn;
        private PictureBox pictureBox1;
        private PictureBox SwitchIcon;
    }
}