namespace PokemonGo.RocketAPI.GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.usernameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // boxPassword
            // 
            resources.ApplyResources(this.boxPassword, "boxPassword");
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxPassword_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // boxUsername
            // 
            resources.ApplyResources(this.boxUsername, "boxUsername");
            this.boxUsername.Name = "boxUsername";
            // 
            // usernameToolTip
            // 
            this.usernameToolTip.Tag = "Enter your PTC or Google Account the application will know which Authentication m" +
    "ethod to use.";
            this.usernameToolTip.ToolTipTitle = "Google Auth / PTC";
            this.usernameToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.usernameToolTip_Popup);
            // 
            // cbRemember
            // 
            resources.ApplyResources(this.cbRemember, "cbRemember");
            this.cbRemember.BackColor = System.Drawing.Color.Transparent;
            this.cbRemember.Checked = true;
            this.cbRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox boxPassword;
        public System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.ToolTip usernameToolTip;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}