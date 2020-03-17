namespace RedHead
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.startXText = new System.Windows.Forms.TextBox();
            this.startYText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.finishXText = new System.Windows.Forms.TextBox();
            this.finishYText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stringError = new System.Windows.Forms.Label();
            this.imageSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elapsedTimeMs = new System.Windows.Forms.Label();
            this.dequeueCountLabel = new System.Windows.Forms.Label();
            this.maximumQueueLen = new System.Windows.Forms.Label();
            this.diagnosticsGroup = new System.Windows.Forms.GroupBox();
            this.costText = new System.Windows.Forms.Label();
            this.diagnosticsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.diagnosticsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Best First Search";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(777, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm Selection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 112);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "A* w/ Heap";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "A*";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(192, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Best First Search w/ Heap";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(777, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "RUN!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startXText
            // 
            this.startXText.Location = new System.Drawing.Point(55, 68);
            this.startXText.Name = "startXText";
            this.startXText.Size = new System.Drawing.Size(61, 22);
            this.startXText.TabIndex = 3;
            this.startXText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startYText
            // 
            this.startYText.Location = new System.Drawing.Point(122, 68);
            this.startYText.Name = "startYText";
            this.startYText.Size = new System.Drawing.Size(61, 22);
            this.startYText.TabIndex = 4;
            this.startYText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.startYText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Finish:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // finishXText
            // 
            this.finishXText.Location = new System.Drawing.Point(55, 115);
            this.finishXText.Name = "finishXText";
            this.finishXText.Size = new System.Drawing.Size(61, 22);
            this.finishXText.TabIndex = 9;
            this.finishXText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.finishXText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // finishYText
            // 
            this.finishYText.Location = new System.Drawing.Point(122, 115);
            this.finishYText.Name = "finishYText";
            this.finishYText.Size = new System.Drawing.Size(61, 22);
            this.finishYText.TabIndex = 10;
            this.finishYText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stringError);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.finishYText);
            this.groupBox2.Controls.Add(this.startXText);
            this.groupBox2.Controls.Add(this.finishXText);
            this.groupBox2.Controls.Add(this.startYText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(777, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 182);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path Points";
            // 
            // stringError
            // 
            this.stringError.AutoSize = true;
            this.stringError.BackColor = System.Drawing.SystemColors.Control;
            this.stringError.ForeColor = System.Drawing.Color.Red;
            this.stringError.Location = new System.Drawing.Point(6, 144);
            this.stringError.MaximumSize = new System.Drawing.Size(200, 40);
            this.stringError.Name = "stringError";
            this.stringError.Size = new System.Drawing.Size(0, 17);
            this.stringError.TabIndex = 15;
            // 
            // imageSelectDialog
            // 
            this.imageSelectDialog.FileName = "imageSelectDialog";
            this.imageSelectDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Select Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // elapsedTimeMs
            // 
            this.elapsedTimeMs.AutoSize = true;
            this.elapsedTimeMs.Location = new System.Drawing.Point(6, 18);
            this.elapsedTimeMs.Name = "elapsedTimeMs";
            this.elapsedTimeMs.Size = new System.Drawing.Size(397, 17);
            this.elapsedTimeMs.TabIndex = 14;
            this.elapsedTimeMs.Text = "The amount of time it takes to find the path will be shown here";
            this.elapsedTimeMs.Click += new System.EventHandler(this.label5_Click);
            // 
            // dequeueCountLabel
            // 
            this.dequeueCountLabel.AutoSize = true;
            this.dequeueCountLabel.Location = new System.Drawing.Point(6, 64);
            this.dequeueCountLabel.Name = "dequeueCountLabel";
            this.dequeueCountLabel.Size = new System.Drawing.Size(363, 17);
            this.dequeueCountLabel.TabIndex = 15;
            this.dequeueCountLabel.Text = "The number of dequeues from queue will be shown here";
            // 
            // maximumQueueLen
            // 
            this.maximumQueueLen.AutoSize = true;
            this.maximumQueueLen.Location = new System.Drawing.Point(6, 88);
            this.maximumQueueLen.Name = "maximumQueueLen";
            this.maximumQueueLen.Size = new System.Drawing.Size(427, 17);
            this.maximumQueueLen.TabIndex = 16;
            this.maximumQueueLen.Text = "The moment where the maximum number of elements in the queue";
            // 
            // diagnosticsGroup
            // 
            this.diagnosticsGroup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.diagnosticsGroup.Controls.Add(this.costText);
            this.diagnosticsGroup.Controls.Add(this.elapsedTimeMs);
            this.diagnosticsGroup.Controls.Add(this.maximumQueueLen);
            this.diagnosticsGroup.Controls.Add(this.dequeueCountLabel);
            this.diagnosticsGroup.Location = new System.Drawing.Point(12, 680);
            this.diagnosticsGroup.Name = "diagnosticsGroup";
            this.diagnosticsGroup.Size = new System.Drawing.Size(491, 116);
            this.diagnosticsGroup.TabIndex = 17;
            this.diagnosticsGroup.TabStop = false;
            this.diagnosticsGroup.Tag = "diagnostics";
            this.diagnosticsGroup.Text = "Diagnostics";
            // 
            // costText
            // 
            this.costText.AutoSize = true;
            this.costText.Location = new System.Drawing.Point(7, 41);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(206, 17);
            this.costText.TabIndex = 17;
            this.costText.Text = "Cost amount will be shown here";
            // 
            // diagnosticsButton
            // 
            this.diagnosticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diagnosticsButton.Location = new System.Drawing.Point(777, 695);
            this.diagnosticsButton.Name = "diagnosticsButton";
            this.diagnosticsButton.Size = new System.Drawing.Size(204, 66);
            this.diagnosticsButton.TabIndex = 18;
            this.diagnosticsButton.Text = "RUN FOR DIAGNOSTICS";
            this.diagnosticsButton.UseVisualStyleBackColor = true;
            this.diagnosticsButton.Click += new System.EventHandler(this.diagnosticsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 768);
            this.label5.MaximumSize = new System.Drawing.Size(250, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 34);
            this.label5.TabIndex = 19;
            this.label5.Text = "Executes all algorithms and shows comparisons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 808);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diagnosticsButton);
            this.Controls.Add(this.diagnosticsGroup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RedHead";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.diagnosticsGroup.ResumeLayout(false);
            this.diagnosticsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox startXText;
        private System.Windows.Forms.TextBox startYText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox finishXText;
        private System.Windows.Forms.TextBox finishYText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog imageSelectDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label elapsedTimeMs;
        private System.Windows.Forms.Label stringError;
        private System.Windows.Forms.Label dequeueCountLabel;
        private System.Windows.Forms.Label maximumQueueLen;
        private System.Windows.Forms.GroupBox diagnosticsGroup;
        private System.Windows.Forms.Label costText;
        private System.Windows.Forms.Button diagnosticsButton;
        private System.Windows.Forms.Label label5;
    }
}

