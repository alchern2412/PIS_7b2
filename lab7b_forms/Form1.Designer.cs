namespace lab7b_forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddRecordName = new System.Windows.Forms.TextBox();
            this.textBoxAddRecordNumber = new System.Windows.Forms.TextBox();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdateNumber = new System.Windows.Forms.TextBox();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateId = new System.Windows.Forms.TextBox();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // textBoxAddRecordName
            // 
            this.textBoxAddRecordName.Location = new System.Drawing.Point(405, 38);
            this.textBoxAddRecordName.Name = "textBoxAddRecordName";
            this.textBoxAddRecordName.Size = new System.Drawing.Size(86, 20);
            this.textBoxAddRecordName.TabIndex = 2;
            // 
            // textBoxAddRecordNumber
            // 
            this.textBoxAddRecordNumber.Location = new System.Drawing.Point(518, 37);
            this.textBoxAddRecordNumber.Name = "textBoxAddRecordNumber";
            this.textBoxAddRecordNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddRecordNumber.TabIndex = 3;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(659, 33);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(98, 23);
            this.buttonAddRecord.TabIndex = 4;
            this.buttonAddRecord.Text = "Add Record";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.ButtonAddRecord_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(659, 84);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(98, 23);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update Record";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // textBoxUpdateNumber
            // 
            this.textBoxUpdateNumber.Location = new System.Drawing.Point(518, 88);
            this.textBoxUpdateNumber.Name = "textBoxUpdateNumber";
            this.textBoxUpdateNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateNumber.TabIndex = 6;
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(405, 89);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(86, 20);
            this.textBoxUpdateName.TabIndex = 5;
            // 
            // textBoxUpdateId
            // 
            this.textBoxUpdateId.Location = new System.Drawing.Point(290, 89);
            this.textBoxUpdateId.Name = "textBoxUpdateId";
            this.textBoxUpdateId.Size = new System.Drawing.Size(86, 20);
            this.textBoxUpdateId.TabIndex = 8;
            // 
            // textBoxDeleteId
            // 
            this.textBoxDeleteId.Location = new System.Drawing.Point(532, 132);
            this.textBoxDeleteId.Name = "textBoxDeleteId";
            this.textBoxDeleteId.Size = new System.Drawing.Size(86, 20);
            this.textBoxDeleteId.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(659, 132);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete Record";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxDeleteId);
            this.Controls.Add(this.textBoxUpdateId);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxUpdateNumber);
            this.Controls.Add(this.textBoxUpdateName);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.textBoxAddRecordNumber);
            this.Controls.Add(this.textBoxAddRecordName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddRecordName;
        private System.Windows.Forms.TextBox textBoxAddRecordNumber;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdateNumber;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.TextBox textBoxUpdateId;
        private System.Windows.Forms.TextBox textBoxDeleteId;
        private System.Windows.Forms.Button buttonDelete;
    }
}

