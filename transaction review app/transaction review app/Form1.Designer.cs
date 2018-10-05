namespace transaction_review_app
{
    partial class Form1
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
            this.review = new System.Windows.Forms.Button();
            this.refer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.review_label = new System.Windows.Forms.Label();
            this.reviewbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.transaction = new System.Windows.Forms.Label();
            this.trans_id = new System.Windows.Forms.Label();
            this.txidbox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Send_to = new System.Windows.Forms.Label();
            this.Send_to_box = new System.Windows.Forms.TextBox();
            this.labelmsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // review
            // 
            this.review.BackColor = System.Drawing.Color.Purple;
            this.review.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.review.Location = new System.Drawing.Point(52, 112);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(343, 33);
            this.review.TabIndex = 0;
            this.review.Text = "Click to Submit a Review";
            this.review.UseVisualStyleBackColor = false;
            this.review.Click += new System.EventHandler(this.review_Click);
            // 
            // refer
            // 
            this.refer.BackColor = System.Drawing.Color.Purple;
            this.refer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refer.Location = new System.Drawing.Point(586, 112);
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(315, 33);
            this.refer.TabIndex = 1;
            this.refer.Text = "Click to Refer Reviews";
            this.refer.UseVisualStyleBackColor = false;
            this.refer.Click += new System.EventHandler(this.refer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flo Review Systems";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.DarkOrange;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(52, 202);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(63, 20);
            this.name.TabIndex = 4;
            this.name.Text = "Name:";
            this.name.Visible = false;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(149, 202);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(246, 22);
            this.namebox.TabIndex = 5;
            this.namebox.Visible = false;
            this.namebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // review_label
            // 
            this.review_label.AutoSize = true;
            this.review_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_label.Location = new System.Drawing.Point(52, 313);
            this.review_label.Name = "review_label";
            this.review_label.Size = new System.Drawing.Size(75, 20);
            this.review_label.TabIndex = 6;
            this.review_label.Text = "Review:";
            this.review_label.Visible = false;
            // 
            // reviewbox
            // 
            this.reviewbox.Location = new System.Drawing.Point(149, 304);
            this.reviewbox.Multiline = true;
            this.reviewbox.Name = "reviewbox";
            this.reviewbox.Size = new System.Drawing.Size(246, 55);
            this.reviewbox.TabIndex = 7;
            this.reviewbox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // transaction
            // 
            this.transaction.AutoSize = true;
            this.transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction.Location = new System.Drawing.Point(603, 157);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(270, 22);
            this.transaction.TabIndex = 9;
            this.transaction.Text = "Enter TRANSACTION details";
            this.transaction.Visible = false;
            // 
            // trans_id
            // 
            this.trans_id.AutoSize = true;
            this.trans_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_id.Location = new System.Drawing.Point(582, 214);
            this.trans_id.Name = "trans_id";
            this.trans_id.Size = new System.Drawing.Size(133, 20);
            this.trans_id.TabIndex = 12;
            this.trans_id.Text = "Transaction ID";
            this.trans_id.Visible = false;
            // 
            // txidbox2
            // 
            this.txidbox2.Location = new System.Drawing.Point(763, 212);
            this.txidbox2.Name = "txidbox2";
            this.txidbox2.Size = new System.Drawing.Size(176, 22);
            this.txidbox2.TabIndex = 15;
            this.txidbox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Send_to
            // 
            this.Send_to.AutoSize = true;
            this.Send_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_to.Location = new System.Drawing.Point(52, 253);
            this.Send_to.Name = "Send_to";
            this.Send_to.Size = new System.Drawing.Size(84, 20);
            this.Send_to.TabIndex = 17;
            this.Send_to.Text = "Send To:";
            this.Send_to.Visible = false;
            // 
            // Send_to_box
            // 
            this.Send_to_box.Location = new System.Drawing.Point(149, 253);
            this.Send_to_box.Name = "Send_to_box";
            this.Send_to_box.Size = new System.Drawing.Size(246, 22);
            this.Send_to_box.TabIndex = 18;
            this.Send_to_box.Visible = false;
            // 
            // labelmsg
            // 
            this.labelmsg.AutoSize = true;
            this.labelmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmsg.Location = new System.Drawing.Point(221, 432);
            this.labelmsg.Name = "labelmsg";
            this.labelmsg.Size = new System.Drawing.Size(0, 20);
            this.labelmsg.TabIndex = 19;
            this.labelmsg.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(963, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelmsg);
            this.Controls.Add(this.Send_to_box);
            this.Controls.Add(this.Send_to);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txidbox2);
            this.Controls.Add(this.trans_id);
            this.Controls.Add(this.transaction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reviewbox);
            this.Controls.Add(this.review_label);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refer);
            this.Controls.Add(this.review);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Flo review app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Button refer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label review_label;
        private System.Windows.Forms.TextBox reviewbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label transaction;
        private System.Windows.Forms.Label trans_id;
        private System.Windows.Forms.TextBox txidbox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Send_to;
        private System.Windows.Forms.TextBox Send_to_box;
        private System.Windows.Forms.Label labelmsg;
        private System.Windows.Forms.Label label2;
    }
}

