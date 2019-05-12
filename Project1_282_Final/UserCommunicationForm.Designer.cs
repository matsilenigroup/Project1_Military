namespace Project1_282_Final
{
    partial class UserCommunicationForm
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
            this.richTextBoxEncryptedMessage = new System.Windows.Forms.RichTextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.dgvNewMessages = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.decryptDurationTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDecryptedMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveInfoBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastReader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.dataGridViewOldMessages = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.uctextBoxCurrentUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewMessages)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldMessages)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxEncryptedMessage
            // 
            this.richTextBoxEncryptedMessage.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxEncryptedMessage.Name = "richTextBoxEncryptedMessage";
            this.richTextBoxEncryptedMessage.ReadOnly = true;
            this.richTextBoxEncryptedMessage.Size = new System.Drawing.Size(273, 63);
            this.richTextBoxEncryptedMessage.TabIndex = 2;
            this.richTextBoxEncryptedMessage.Text = "";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(6, 16);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(241, 20);
            this.txtpath.TabIndex = 3;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(6, 45);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(118, 34);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(163, 97);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(116, 32);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // dgvNewMessages
            // 
            this.dgvNewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewMessages.Location = new System.Drawing.Point(5, 85);
            this.dgvNewMessages.Name = "dgvNewMessages";
            this.dgvNewMessages.Size = new System.Drawing.Size(275, 389);
            this.dgvNewMessages.TabIndex = 6;
            this.dgvNewMessages.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxStatus);
            this.groupBox1.Controls.Add(this.decryptDurationTxt);
            this.groupBox1.Controls.Add(this.richTextBoxEncryptedMessage);
            this.groupBox1.Controls.Add(this.decryptBtn);
            this.groupBox1.Location = new System.Drawing.Point(309, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decrypt Data Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Status of Decryption";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(7, 138);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(150, 20);
            this.textBoxStatus.TabIndex = 8;
            // 
            // decryptDurationTxt
            // 
            this.decryptDurationTxt.Location = new System.Drawing.Point(7, 99);
            this.decryptDurationTxt.Name = "decryptDurationTxt";
            this.decryptDurationTxt.ReadOnly = true;
            this.decryptDurationTxt.Size = new System.Drawing.Size(150, 20);
            this.decryptDurationTxt.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.txtpath);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Controls.Add(this.dgvNewMessages);
            this.groupBox2.Location = new System.Drawing.Point(17, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 480);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text File Data";
            // 
            // richTextBoxDecryptedMessage
            // 
            this.richTextBoxDecryptedMessage.Location = new System.Drawing.Point(6, 15);
            this.richTextBoxDecryptedMessage.Name = "richTextBoxDecryptedMessage";
            this.richTextBoxDecryptedMessage.ReadOnly = true;
            this.richTextBoxDecryptedMessage.Size = new System.Drawing.Size(456, 63);
            this.richTextBoxDecryptedMessage.TabIndex = 6;
            this.richTextBoxDecryptedMessage.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Khaki;
            this.groupBox3.Controls.Add(this.saveInfoBtn);
            this.groupBox3.Controls.Add(this.richTextBoxDecryptedMessage);
            this.groupBox3.Location = new System.Drawing.Point(603, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 163);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decrypted Info";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // saveInfoBtn
            // 
            this.saveInfoBtn.Location = new System.Drawing.Point(6, 96);
            this.saveInfoBtn.Name = "saveInfoBtn";
            this.saveInfoBtn.Size = new System.Drawing.Size(116, 32);
            this.saveInfoBtn.TabIndex = 6;
            this.saveInfoBtn.Text = "Save Information";
            this.saveInfoBtn.UseVisualStyleBackColor = true;
            this.saveInfoBtn.Click += new System.EventHandler(this.saveInfoBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Khaki;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxLastReader);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxDuration);
            this.groupBox4.Controls.Add(this.richTextBoxMessage);
            this.groupBox4.Controls.Add(this.dataGridViewOldMessages);
            this.groupBox4.Location = new System.Drawing.Point(309, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(762, 360);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Past Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Read User ID";
            // 
            // textBoxLastReader
            // 
            this.textBoxLastReader.Location = new System.Drawing.Point(9, 334);
            this.textBoxLastReader.Name = "textBoxLastReader";
            this.textBoxLastReader.ReadOnly = true;
            this.textBoxLastReader.Size = new System.Drawing.Size(138, 20);
            this.textBoxLastReader.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duration of Decryption";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(9, 292);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.ReadOnly = true;
            this.textBoxDuration.Size = new System.Drawing.Size(138, 20);
            this.textBoxDuration.TabIndex = 9;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(9, 194);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(366, 76);
            this.richTextBoxMessage.TabIndex = 8;
            this.richTextBoxMessage.Text = "";
            // 
            // dataGridViewOldMessages
            // 
            this.dataGridViewOldMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOldMessages.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOldMessages.Name = "dataGridViewOldMessages";
            this.dataGridViewOldMessages.Size = new System.Drawing.Size(750, 156);
            this.dataGridViewOldMessages.TabIndex = 7;
            this.dataGridViewOldMessages.SelectionChanged += new System.EventHandler(this.datavg_SelectionChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Khaki;
            this.groupBox5.Controls.Add(this.uctextBoxCurrentUser);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(17, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 37);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Info";
            // 
            // uctextBoxCurrentUser
            // 
            this.uctextBoxCurrentUser.Location = new System.Drawing.Point(78, 11);
            this.uctextBoxCurrentUser.Name = "uctextBoxCurrentUser";
            this.uctextBoxCurrentUser.ReadOnly = true;
            this.uctextBoxCurrentUser.Size = new System.Drawing.Size(202, 20);
            this.uctextBoxCurrentUser.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current User";
            // 
            // UserCommunicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 548);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCommunicationForm";
            this.Text = "Communication";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewMessages)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldMessages)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEncryptedMessage;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.DataGridView dgvNewMessages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxDecryptedMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveInfoBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.DataGridView dataGridViewOldMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryptDurationTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox uctextBoxCurrentUser;
        private System.Windows.Forms.Label label8;
    }
}