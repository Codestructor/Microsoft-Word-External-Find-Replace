namespace Word
{
    partial class PrimeForm
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findTextTxtBox = new System.Windows.Forms.TextBox();
            this.replaceTextTxtBox = new System.Windows.Forms.TextBox();
            this.pathTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.allRadioBtn = new System.Windows.Forms.RadioButton();
            this.onlyRadioBtn = new System.Windows.Forms.RadioButton();
            this.progressTxtBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 351);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert text to be found and replaced:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert replacing text:";
            // 
            // findTextTxtBox
            // 
            this.findTextTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextTxtBox.Location = new System.Drawing.Point(12, 76);
            this.findTextTxtBox.Multiline = true;
            this.findTextTxtBox.Name = "findTextTxtBox";
            this.findTextTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.findTextTxtBox.Size = new System.Drawing.Size(378, 55);
            this.findTextTxtBox.TabIndex = 4;
            this.findTextTxtBox.Text = "2015";
            // 
            // replaceTextTxtBox
            // 
            this.replaceTextTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceTextTxtBox.Location = new System.Drawing.Point(12, 154);
            this.replaceTextTxtBox.Multiline = true;
            this.replaceTextTxtBox.Name = "replaceTextTxtBox";
            this.replaceTextTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.replaceTextTxtBox.Size = new System.Drawing.Size(378, 55);
            this.replaceTextTxtBox.TabIndex = 5;
            this.replaceTextTxtBox.Text = "2016";
            // 
            // pathTxtBox
            // 
            this.pathTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTxtBox.Location = new System.Drawing.Point(12, 29);
            this.pathTxtBox.Multiline = true;
            this.pathTxtBox.Name = "pathTxtBox";
            this.pathTxtBox.Size = new System.Drawing.Size(378, 24);
            this.pathTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insert directory/ specific file path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Progress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Replace in:";
            // 
            // allRadioBtn
            // 
            this.allRadioBtn.AutoSize = true;
            this.allRadioBtn.Checked = true;
            this.allRadioBtn.Location = new System.Drawing.Point(12, 232);
            this.allRadioBtn.Name = "allRadioBtn";
            this.allRadioBtn.Size = new System.Drawing.Size(269, 17);
            this.allRadioBtn.TabIndex = 11;
            this.allRadioBtn.TabStop = true;
            this.allRadioBtn.Text = "All the files in the parent directory and subdirectories";
            this.allRadioBtn.UseVisualStyleBackColor = true;
            // 
            // onlyRadioBtn
            // 
            this.onlyRadioBtn.AutoSize = true;
            this.onlyRadioBtn.Location = new System.Drawing.Point(12, 255);
            this.onlyRadioBtn.Name = "onlyRadioBtn";
            this.onlyRadioBtn.Size = new System.Drawing.Size(190, 17);
            this.onlyRadioBtn.TabIndex = 12;
            this.onlyRadioBtn.Text = "Only the files in the parent directory";
            this.onlyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // progressTxtBox
            // 
            this.progressTxtBox.BackColor = System.Drawing.Color.White;
            this.progressTxtBox.Location = new System.Drawing.Point(399, 31);
            this.progressTxtBox.Name = "progressTxtBox";
            this.progressTxtBox.ReadOnly = true;
            this.progressTxtBox.Size = new System.Drawing.Size(463, 343);
            this.progressTxtBox.TabIndex = 13;
            this.progressTxtBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(480, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(382, 17);
            this.progressBar1.TabIndex = 14;
            // 
            // PrimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 386);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progressTxtBox);
            this.Controls.Add(this.onlyRadioBtn);
            this.Controls.Add(this.allRadioBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replaceTextTxtBox);
            this.Controls.Add(this.findTextTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecute);
            this.Name = "PrimeForm";
            this.Text = "Word External FindAndReplace Soft - (c) SmashHeaders Ind.";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PrimeForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PrimeForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox findTextTxtBox;
        private System.Windows.Forms.TextBox replaceTextTxtBox;
        private System.Windows.Forms.TextBox pathTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton allRadioBtn;
        private System.Windows.Forms.RadioButton onlyRadioBtn;
        private System.Windows.Forms.RichTextBox progressTxtBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

