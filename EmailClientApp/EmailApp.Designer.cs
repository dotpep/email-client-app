namespace EmailClientApp
{
    partial class EmailApp
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
            txtSender = new TextBox();
            txtRecipient = new TextBox();
            txtSubject = new TextBox();
            txtBody = new TextBox();
            btnSend = new Button();
            btnReceive = new Button();
            lstEmails = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtSender
            // 
            txtSender.Location = new Point(28, 56);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(182, 27);
            txtSender.TabIndex = 0;
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(28, 125);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(182, 27);
            txtRecipient.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(28, 200);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(182, 27);
            txtSubject.TabIndex = 2;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(28, 262);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(182, 27);
            txtBody.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(28, 325);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(28, 387);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(94, 29);
            btnReceive.TabIndex = 5;
            btnReceive.Text = "Receive";
            btnReceive.UseVisualStyleBackColor = true;
            btnReceive.Click += btnReceive_Click;
            // 
            // lstEmails
            // 
            lstEmails.FormattingEnabled = true;
            lstEmails.ItemHeight = 20;
            lstEmails.Location = new Point(234, 31);
            lstEmails.Name = "lstEmails";
            lstEmails.Size = new Size(864, 404);
            lstEmails.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Sender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 102);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "Recipient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 177);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 9;
            label3.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 239);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 11;
            label5.Text = "Body";
            // 
            // EmailApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1110, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstEmails);
            Controls.Add(btnReceive);
            Controls.Add(btnSend);
            Controls.Add(txtBody);
            Controls.Add(txtSubject);
            Controls.Add(txtRecipient);
            Controls.Add(txtSender);
            Name = "EmailApp";
            Text = "EmailClientApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSender;
        private TextBox txtRecipient;
        private TextBox txtSubject;
        private TextBox txtBody;
        private Button btnSend;
        private Button btnReceive;
        private ListBox lstEmails;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}