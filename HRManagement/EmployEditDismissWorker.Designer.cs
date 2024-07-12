namespace HRManagement
{
    partial class EmployEditDismissWorker
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
            this.nudEarnings = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoDismissalDate = new System.Windows.Forms.Button();
            this.ttDateDescription = new System.Windows.Forms.ToolTip(this.components);
            this.btnRestoreEmploymentDate = new System.Windows.Forms.Button();
            this.btnUnknownDismissalDate = new System.Windows.Forms.Button();
            this.btnUnknownEmploymentDate = new System.Windows.Forms.Button();
            this.btnRestoreDismissalDate = new System.Windows.Forms.Button();
            this.dtpEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.tbNoOrUnknownDismissalDate = new System.Windows.Forms.TextBox();
            this.tbUnknownEmploymentDate = new System.Windows.Forms.TextBox();
            this.lblDismissalDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEarnings)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEarnings
            // 
            this.nudEarnings.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudEarnings.Location = new System.Drawing.Point(159, 69);
            this.nudEarnings.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudEarnings.Name = "nudEarnings";
            this.nudEarnings.Size = new System.Drawing.Size(315, 22);
            this.nudEarnings.TabIndex = 28;
            this.nudEarnings.ThousandsSeparator = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(325, 254);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(149, 23);
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(159, 97);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(315, 96);
            this.rtbComments.TabIndex = 23;
            this.rtbComments.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Uwagi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Miesięczne zarobki (zł):";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(159, 40);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(315, 22);
            this.tbLastName.TabIndex = 22;
            this.tbLastName.TextChanged += new System.EventHandler(this.TbLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nazwisko:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(159, 12);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(315, 22);
            this.tbFirstName.TabIndex = 16;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Imię:";
            // 
            // btnNoDismissalDate
            // 
            this.btnNoDismissalDate.Location = new System.Drawing.Point(417, 225);
            this.btnNoDismissalDate.Name = "btnNoDismissalDate";
            this.btnNoDismissalDate.Size = new System.Drawing.Size(57, 23);
            this.btnNoDismissalDate.TabIndex = 30;
            this.btnNoDismissalDate.Text = "Brak";
            this.ttDateDescription.SetToolTip(this.btnNoDismissalDate, "Kliknij ten przycisk jeśli omyłkowo została wprowadzona data mimo że pracownik ni" +
        "e został zwolniony ani nie ma zaplanowanego zwolnienia.");
            this.btnNoDismissalDate.UseVisualStyleBackColor = true;
            this.btnNoDismissalDate.Visible = false;
            this.btnNoDismissalDate.Click += new System.EventHandler(this.BtnNoDismissalDate_Click);
            // 
            // ttDateDescription
            // 
            this.ttDateDescription.AutoPopDelay = 50000;
            this.ttDateDescription.InitialDelay = 500;
            this.ttDateDescription.ReshowDelay = 100;
            // 
            // btnRestoreEmploymentDate
            // 
            this.btnRestoreEmploymentDate.Location = new System.Drawing.Point(325, 198);
            this.btnRestoreEmploymentDate.Name = "btnRestoreEmploymentDate";
            this.btnRestoreEmploymentDate.Size = new System.Drawing.Size(149, 23);
            this.btnRestoreEmploymentDate.TabIndex = 39;
            this.btnRestoreEmploymentDate.Text = "Ustaw datę";
            this.ttDateDescription.SetToolTip(this.btnRestoreEmploymentDate, "Jeśli omyłkowo został kliknięty przycisk \"Nieznana\" można ustawić datę po kliknię" +
        "ciu tego przycisku.");
            this.btnRestoreEmploymentDate.UseVisualStyleBackColor = true;
            this.btnRestoreEmploymentDate.Visible = false;
            this.btnRestoreEmploymentDate.Click += new System.EventHandler(this.BtnRestoreEmploymentDate_Click);
            // 
            // btnUnknownDismissalDate
            // 
            this.btnUnknownDismissalDate.Location = new System.Drawing.Point(325, 225);
            this.btnUnknownDismissalDate.Name = "btnUnknownDismissalDate";
            this.btnUnknownDismissalDate.Size = new System.Drawing.Size(87, 23);
            this.btnUnknownDismissalDate.TabIndex = 37;
            this.btnUnknownDismissalDate.Text = "Nieznana";
            this.ttDateDescription.SetToolTip(this.btnUnknownDismissalDate, "Kliknij ten przycisk jeśli pracownik został zwolniony, ale nie umiesz sobie przyp" +
        "omnieć kiedy.");
            this.btnUnknownDismissalDate.UseVisualStyleBackColor = true;
            this.btnUnknownDismissalDate.Visible = false;
            this.btnUnknownDismissalDate.Click += new System.EventHandler(this.BtnUnknownDismissalDate_Click);
            // 
            // btnUnknownEmploymentDate
            // 
            this.btnUnknownEmploymentDate.Location = new System.Drawing.Point(324, 198);
            this.btnUnknownEmploymentDate.Name = "btnUnknownEmploymentDate";
            this.btnUnknownEmploymentDate.Size = new System.Drawing.Size(150, 23);
            this.btnUnknownEmploymentDate.TabIndex = 38;
            this.btnUnknownEmploymentDate.Text = "Nieznana";
            this.ttDateDescription.SetToolTip(this.btnUnknownEmploymentDate, "Kliknij ten przycisk jeśli nie umiesz przypomnieć sobie daty zatrudnienia.");
            this.btnUnknownEmploymentDate.UseVisualStyleBackColor = true;
            this.btnUnknownEmploymentDate.Click += new System.EventHandler(this.BtnUnknownEmploymentDate_Click);
            // 
            // btnRestoreDismissalDate
            // 
            this.btnRestoreDismissalDate.Location = new System.Drawing.Point(325, 226);
            this.btnRestoreDismissalDate.Name = "btnRestoreDismissalDate";
            this.btnRestoreDismissalDate.Size = new System.Drawing.Size(149, 23);
            this.btnRestoreDismissalDate.TabIndex = 40;
            this.btnRestoreDismissalDate.Text = "Ustaw datę";
            this.btnRestoreDismissalDate.UseVisualStyleBackColor = true;
            this.btnRestoreDismissalDate.Click += new System.EventHandler(this.BtnRestoreDismissalDate_Click);
            // 
            // dtpEmploymentDate
            // 
            this.dtpEmploymentDate.CustomFormat = "dd.MM.yyyy";
            this.dtpEmploymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmploymentDate.Location = new System.Drawing.Point(159, 198);
            this.dtpEmploymentDate.Name = "dtpEmploymentDate";
            this.dtpEmploymentDate.Size = new System.Drawing.Size(159, 22);
            this.dtpEmploymentDate.TabIndex = 36;
            this.dtpEmploymentDate.ValueChanged += new System.EventHandler(this.DtpEmploymentDate_ValueChanged);
            // 
            // dtpDismissalDate
            // 
            this.dtpDismissalDate.CustomFormat = "";
            this.dtpDismissalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDismissalDate.Location = new System.Drawing.Point(159, 226);
            this.dtpDismissalDate.Name = "dtpDismissalDate";
            this.dtpDismissalDate.Size = new System.Drawing.Size(159, 22);
            this.dtpDismissalDate.TabIndex = 35;
            this.dtpDismissalDate.Visible = false;
            // 
            // tbNoOrUnknownDismissalDate
            // 
            this.tbNoOrUnknownDismissalDate.BackColor = System.Drawing.Color.White;
            this.tbNoOrUnknownDismissalDate.Location = new System.Drawing.Point(159, 226);
            this.tbNoOrUnknownDismissalDate.Name = "tbNoOrUnknownDismissalDate";
            this.tbNoOrUnknownDismissalDate.ReadOnly = true;
            this.tbNoOrUnknownDismissalDate.Size = new System.Drawing.Size(159, 22);
            this.tbNoOrUnknownDismissalDate.TabIndex = 41;
            this.tbNoOrUnknownDismissalDate.Text = "Brak";
            // 
            // tbUnknownEmploymentDate
            // 
            this.tbUnknownEmploymentDate.BackColor = System.Drawing.Color.White;
            this.tbUnknownEmploymentDate.Location = new System.Drawing.Point(159, 198);
            this.tbUnknownEmploymentDate.Name = "tbUnknownEmploymentDate";
            this.tbUnknownEmploymentDate.ReadOnly = true;
            this.tbUnknownEmploymentDate.Size = new System.Drawing.Size(159, 22);
            this.tbUnknownEmploymentDate.TabIndex = 43;
            this.tbUnknownEmploymentDate.Text = "Nieznana";
            this.tbUnknownEmploymentDate.Visible = false;
            // 
            // lblDismissalDate
            // 
            this.lblDismissalDate.AutoSize = true;
            this.lblDismissalDate.Location = new System.Drawing.Point(10, 226);
            this.lblDismissalDate.Name = "lblDismissalDate";
            this.lblDismissalDate.Size = new System.Drawing.Size(104, 16);
            this.lblDismissalDate.TabIndex = 33;
            this.lblDismissalDate.Text = "Data zwolnienia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data zatrudnienia:";
            // 
            // EmployEditDismissWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 285);
            this.Controls.Add(this.dtpEmploymentDate);
            this.Controls.Add(this.dtpDismissalDate);
            this.Controls.Add(this.tbNoOrUnknownDismissalDate);
            this.Controls.Add(this.tbUnknownEmploymentDate);
            this.Controls.Add(this.btnRestoreEmploymentDate);
            this.Controls.Add(this.btnRestoreDismissalDate);
            this.Controls.Add(this.btnUnknownDismissalDate);
            this.Controls.Add(this.btnUnknownEmploymentDate);
            this.Controls.Add(this.lblDismissalDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNoDismissalDate);
            this.Controls.Add(this.nudEarnings);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(499, 332);
            this.MinimumSize = new System.Drawing.Size(499, 332);
            this.Name = "EmployEditDismissWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.nudEarnings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEarnings;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoDismissalDate;
        private System.Windows.Forms.ToolTip ttDateDescription;
        private System.Windows.Forms.DateTimePicker dtpEmploymentDate;
        private System.Windows.Forms.DateTimePicker dtpDismissalDate;
        private System.Windows.Forms.TextBox tbNoOrUnknownDismissalDate;
        private System.Windows.Forms.TextBox tbUnknownEmploymentDate;
        private System.Windows.Forms.Button btnRestoreEmploymentDate;
        private System.Windows.Forms.Button btnRestoreDismissalDate;
        private System.Windows.Forms.Button btnUnknownDismissalDate;
        private System.Windows.Forms.Button btnUnknownEmploymentDate;
        private System.Windows.Forms.Label lblDismissalDate;
        private System.Windows.Forms.Label label3;
    }
}