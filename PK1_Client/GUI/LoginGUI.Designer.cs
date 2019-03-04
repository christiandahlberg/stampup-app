namespace PK1_Client.GUI
{


        partial class LoginGUI
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
            this.tb_LoginPassword = new System.Windows.Forms.TextBox();
            this.tb_LoginEmail = new System.Windows.Forms.TextBox();
            this.lbl_LoginPassword = new System.Windows.Forms.Label();
            this.lbl_LoginEmail = new System.Windows.Forms.Label();
            this.btn_Signin = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Slogan = new System.Windows.Forms.Label();
            this.lbl_SystemMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lbl_RegisterName = new System.Windows.Forms.Label();
            this.lbl_RegisterEmail = new System.Windows.Forms.Label();
            this.lbl_RegisterPhone = new System.Windows.Forms.Label();
            this.lbl_RegisterPassword = new System.Windows.Forms.Label();
            this.lbl_RegisterPassword2 = new System.Windows.Forms.Label();
            this.tb_RegisterName = new System.Windows.Forms.TextBox();
            this.tb_RegisterEmail = new System.Windows.Forms.TextBox();
            this.tb_RegisterPhone = new System.Windows.Forms.TextBox();
            this.tb_RegisterPassword = new System.Windows.Forms.TextBox();
            this.tb_RegisterPassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_LoginPassword
            // 
            this.tb_LoginPassword.Location = new System.Drawing.Point(581, 78);
            this.tb_LoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_LoginPassword.Name = "tb_LoginPassword";
            this.tb_LoginPassword.PasswordChar = '*';
            this.tb_LoginPassword.Size = new System.Drawing.Size(167, 22);
            this.tb_LoginPassword.TabIndex = 9;
            // 
            // tb_LoginEmail
            // 
            this.tb_LoginEmail.Location = new System.Drawing.Point(581, 33);
            this.tb_LoginEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_LoginEmail.Name = "tb_LoginEmail";
            this.tb_LoginEmail.Size = new System.Drawing.Size(167, 22);
            this.tb_LoginEmail.TabIndex = 8;
            // 
            // lbl_LoginPassword
            // 
            this.lbl_LoginPassword.AutoSize = true;
            this.lbl_LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginPassword.Location = new System.Drawing.Point(483, 81);
            this.lbl_LoginPassword.Name = "lbl_LoginPassword";
            this.lbl_LoginPassword.Size = new System.Drawing.Size(82, 17);
            this.lbl_LoginPassword.TabIndex = 7;
            this.lbl_LoginPassword.Text = "Password:";
            // 
            // lbl_LoginEmail
            // 
            this.lbl_LoginEmail.AutoSize = true;
            this.lbl_LoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginEmail.Location = new System.Drawing.Point(483, 34);
            this.lbl_LoginEmail.Name = "lbl_LoginEmail";
            this.lbl_LoginEmail.Size = new System.Drawing.Size(58, 17);
            this.lbl_LoginEmail.TabIndex = 6;
            this.lbl_LoginEmail.Text = "E-mail:";
            // 
            // btn_Signin
            // 
            this.btn_Signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Signin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Signin.FlatAppearance.BorderSize = 0;
            this.btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.ForeColor = System.Drawing.Color.White;
            this.btn_Signin.Location = new System.Drawing.Point(485, 123);
            this.btn_Signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(261, 34);
            this.btn_Signin.TabIndex = 0;
            this.btn_Signin.TabStop = false;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Click += new System.EventHandler(this.SignInEvent);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(485, 348);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(261, 34);
            this.btn_Register.TabIndex = 10;
            this.btn_Register.TabStop = false;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.RegisterEvent);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(39, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(178, 25);
            this.lbl_Title.TabIndex = 12;
            this.lbl_Title.Text = "JDBC Consulting";
            // 
            // lbl_Slogan
            // 
            this.lbl_Slogan.AutoSize = true;
            this.lbl_Slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Slogan.Location = new System.Drawing.Point(41, 66);
            this.lbl_Slogan.Name = "lbl_Slogan";
            this.lbl_Slogan.Size = new System.Drawing.Size(319, 17);
            this.lbl_Slogan.TabIndex = 13;
            this.lbl_Slogan.Text = "Probably the best consulting in the world...";
            // 
            // lbl_SystemMessage
            // 
            this.lbl_SystemMessage.AutoSize = true;
            this.lbl_SystemMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SystemMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_SystemMessage.Location = new System.Drawing.Point(41, 164);
            this.lbl_SystemMessage.Name = "lbl_SystemMessage";
            this.lbl_SystemMessage.Size = new System.Drawing.Size(0, 17);
            this.lbl_SystemMessage.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(44, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 2);
            this.label1.TabIndex = 15;
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.Location = new System.Drawing.Point(41, 217);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(160, 18);
            this.lbl_Register.TabIndex = 16;
            this.lbl_Register.Text = "New user? Register!";
            // 
            // lbl_RegisterName
            // 
            this.lbl_RegisterName.AutoSize = true;
            this.lbl_RegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterName.Location = new System.Drawing.Point(57, 254);
            this.lbl_RegisterName.Name = "lbl_RegisterName";
            this.lbl_RegisterName.Size = new System.Drawing.Size(54, 17);
            this.lbl_RegisterName.TabIndex = 17;
            this.lbl_RegisterName.Text = "Name:";
            // 
            // lbl_RegisterEmail
            // 
            this.lbl_RegisterEmail.AutoSize = true;
            this.lbl_RegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterEmail.Location = new System.Drawing.Point(57, 302);
            this.lbl_RegisterEmail.Name = "lbl_RegisterEmail";
            this.lbl_RegisterEmail.Size = new System.Drawing.Size(58, 17);
            this.lbl_RegisterEmail.TabIndex = 18;
            this.lbl_RegisterEmail.Text = "E-mail:";
            // 
            // lbl_RegisterPhone
            // 
            this.lbl_RegisterPhone.AutoSize = true;
            this.lbl_RegisterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterPhone.Location = new System.Drawing.Point(57, 348);
            this.lbl_RegisterPhone.Name = "lbl_RegisterPhone";
            this.lbl_RegisterPhone.Size = new System.Drawing.Size(59, 17);
            this.lbl_RegisterPhone.TabIndex = 19;
            this.lbl_RegisterPhone.Text = "Phone:";
            // 
            // lbl_RegisterPassword
            // 
            this.lbl_RegisterPassword.AutoSize = true;
            this.lbl_RegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterPassword.Location = new System.Drawing.Point(483, 249);
            this.lbl_RegisterPassword.Name = "lbl_RegisterPassword";
            this.lbl_RegisterPassword.Size = new System.Drawing.Size(82, 17);
            this.lbl_RegisterPassword.TabIndex = 20;
            this.lbl_RegisterPassword.Text = "Password:";
            // 
            // lbl_RegisterPassword2
            // 
            this.lbl_RegisterPassword2.AutoSize = true;
            this.lbl_RegisterPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterPassword2.Location = new System.Drawing.Point(413, 295);
            this.lbl_RegisterPassword2.Name = "lbl_RegisterPassword2";
            this.lbl_RegisterPassword2.Size = new System.Drawing.Size(150, 17);
            this.lbl_RegisterPassword2.TabIndex = 21;
            this.lbl_RegisterPassword2.Text = "Re-enter password:";
            // 
            // tb_RegisterName
            // 
            this.tb_RegisterName.Location = new System.Drawing.Point(127, 254);
            this.tb_RegisterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_RegisterName.Name = "tb_RegisterName";
            this.tb_RegisterName.Size = new System.Drawing.Size(167, 22);
            this.tb_RegisterName.TabIndex = 22;
            // 
            // tb_RegisterEmail
            // 
            this.tb_RegisterEmail.Location = new System.Drawing.Point(127, 302);
            this.tb_RegisterEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_RegisterEmail.Name = "tb_RegisterEmail";
            this.tb_RegisterEmail.Size = new System.Drawing.Size(167, 22);
            this.tb_RegisterEmail.TabIndex = 23;
            // 
            // tb_RegisterPhone
            // 
            this.tb_RegisterPhone.Location = new System.Drawing.Point(127, 348);
            this.tb_RegisterPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_RegisterPhone.Name = "tb_RegisterPhone";
            this.tb_RegisterPhone.Size = new System.Drawing.Size(167, 22);
            this.tb_RegisterPhone.TabIndex = 24;
            // 
            // tb_RegisterPassword
            // 
            this.tb_RegisterPassword.Location = new System.Drawing.Point(581, 249);
            this.tb_RegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_RegisterPassword.Name = "tb_RegisterPassword";
            this.tb_RegisterPassword.PasswordChar = '*';
            this.tb_RegisterPassword.Size = new System.Drawing.Size(167, 22);
            this.tb_RegisterPassword.TabIndex = 25;
            // 
            // tb_RegisterPassword2
            // 
            this.tb_RegisterPassword2.Location = new System.Drawing.Point(581, 295);
            this.tb_RegisterPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_RegisterPassword2.Name = "tb_RegisterPassword2";
            this.tb_RegisterPassword2.PasswordChar = '*';
            this.tb_RegisterPassword2.Size = new System.Drawing.Size(167, 22);
            this.tb_RegisterPassword2.TabIndex = 26;
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.tb_RegisterPassword2);
            this.Controls.Add(this.tb_RegisterPassword);
            this.Controls.Add(this.tb_RegisterPhone);
            this.Controls.Add(this.tb_RegisterEmail);
            this.Controls.Add(this.tb_RegisterName);
            this.Controls.Add(this.lbl_RegisterPassword2);
            this.Controls.Add(this.lbl_RegisterPassword);
            this.Controls.Add(this.lbl_RegisterPhone);
            this.Controls.Add(this.lbl_RegisterEmail);
            this.Controls.Add(this.lbl_RegisterName);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SystemMessage);
            this.Controls.Add(this.lbl_Slogan);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_LoginPassword);
            this.Controls.Add(this.tb_LoginEmail);
            this.Controls.Add(this.lbl_LoginPassword);
            this.Controls.Add(this.lbl_LoginEmail);
            this.Controls.Add(this.btn_Signin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginGUI";
            this.Text = "Stämpelkortify";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.TextBox tb_LoginPassword;
            private System.Windows.Forms.TextBox tb_LoginEmail;
            private System.Windows.Forms.Label lbl_LoginPassword;
            private System.Windows.Forms.Label lbl_LoginEmail;
            private System.Windows.Forms.Button btn_Signin;
            private System.Windows.Forms.Button btn_Register;
            private System.Windows.Forms.Label lbl_Title;
            private System.Windows.Forms.Label lbl_Slogan;
            private System.Windows.Forms.Label lbl_SystemMessage;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label lbl_Register;
            private System.Windows.Forms.Label lbl_RegisterName;
            private System.Windows.Forms.Label lbl_RegisterEmail;
            private System.Windows.Forms.Label lbl_RegisterPhone;
            private System.Windows.Forms.Label lbl_RegisterPassword;
            private System.Windows.Forms.Label lbl_RegisterPassword2;
            private System.Windows.Forms.TextBox tb_RegisterName;
            private System.Windows.Forms.TextBox tb_RegisterEmail;
            private System.Windows.Forms.TextBox tb_RegisterPhone;
            private System.Windows.Forms.TextBox tb_RegisterPassword;
            private System.Windows.Forms.TextBox tb_RegisterPassword2;
        }
    }