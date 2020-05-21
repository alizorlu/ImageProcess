namespace IPTutorial
{
    partial class frmHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputPic = new System.Windows.Forms.PictureBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultPic = new System.Windows.Forms.PictureBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.resultSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.openBtn);
            this.groupBox1.Controls.Add(this.inputPic);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim Seçme";
            // 
            // inputPic
            // 
            this.inputPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPic.Location = new System.Drawing.Point(3, 18);
            this.inputPic.Name = "inputPic";
            this.inputPic.Size = new System.Drawing.Size(263, 280);
            this.inputPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPic.TabIndex = 0;
            this.inputPic.TabStop = false;
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(188, 305);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 49);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "[***]";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(6, 305);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 49);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "X";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Görüntü Netleştirme Uygula",
            "Gri Tonlama"});
            this.checkedListBox1.Location = new System.Drawing.Point(327, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(330, 127);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultSave);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.readBtn);
            this.groupBox2.Controls.Add(this.resultPic);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 372);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÇIKTI ";
            // 
            // resultPic
            // 
            this.resultPic.Location = new System.Drawing.Point(6, 21);
            this.resultPic.Name = "resultPic";
            this.resultPic.Size = new System.Drawing.Size(315, 277);
            this.resultPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPic.TabIndex = 2;
            this.resultPic.TabStop = false;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(514, 166);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(143, 30);
            this.readBtn.TabIndex = 3;
            this.readBtn.Text = "Tamam";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(327, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(337, 151);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // resultSave
            // 
            this.resultSave.Location = new System.Drawing.Point(192, 304);
            this.resultSave.Name = "resultSave";
            this.resultSave.Size = new System.Drawing.Size(129, 49);
            this.resultSave.TabIndex = 5;
            this.resultSave.Text = "Çıktıyı Kaydet";
            this.resultSave.UseVisualStyleBackColor = true;
            this.resultSave.Click += new System.EventHandler(this.resultSave_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHome";
            this.Text = "OCR Örnek";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputPic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.PictureBox inputPic;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.PictureBox resultPic;
        private System.Windows.Forms.Button resultSave;
    }
}