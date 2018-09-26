namespace Lab5
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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelReadTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchWord = new System.Windows.Forms.TextBox();
            this.buttonApproxSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelApproxSearchTime = new System.Windows.Forms.Label();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(13, 13);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(131, 61);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Чтение из файла";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время чтения из файла:";
            // 
            // labelReadTime
            // 
            this.labelReadTime.AutoSize = true;
            this.labelReadTime.Location = new System.Drawing.Point(311, 18);
            this.labelReadTime.Name = "labelReadTime";
            this.labelReadTime.Size = new System.Drawing.Size(0, 13);
            this.labelReadTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово для поиска:";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(272, 54);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(200, 20);
            this.textBoxSearchWord.TabIndex = 4;
            // 
            // buttonApproxSearch
            // 
            this.buttonApproxSearch.Location = new System.Drawing.Point(13, 104);
            this.buttonApproxSearch.Name = "buttonApproxSearch";
            this.buttonApproxSearch.Size = new System.Drawing.Size(131, 52);
            this.buttonApproxSearch.TabIndex = 5;
            this.buttonApproxSearch.Text = "Нечеткий поиск";
            this.buttonApproxSearch.UseVisualStyleBackColor = true;
            this.buttonApproxSearch.Click += new System.EventHandler(this.buttonApproxSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска слова:";
            // 
            // labelApproxSearchTime
            // 
            this.labelApproxSearchTime.AutoSize = true;
            this.labelApproxSearchTime.Location = new System.Drawing.Point(286, 104);
            this.labelApproxSearchTime.Name = "labelApproxSearchTime";
            this.labelApproxSearchTime.Size = new System.Drawing.Size(0, 13);
            this.labelApproxSearchTime.TabIndex = 7;
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.Location = new System.Drawing.Point(13, 183);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(459, 147);
            this.listBoxSearchResult.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Максимальное расстояние:";
            // 
            // textBoxMaxDistance
            // 
            this.textBoxMaxDistance.Location = new System.Drawing.Point(320, 140);
            this.textBoxMaxDistance.Name = "textBoxMaxDistance";
            this.textBoxMaxDistance.Size = new System.Drawing.Size(152, 20);
            this.textBoxMaxDistance.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 342);
            this.Controls.Add(this.textBoxMaxDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.labelApproxSearchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonApproxSearch);
            this.Controls.Add(this.textBoxSearchWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelReadTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadFile);
            this.MinimumSize = new System.Drawing.Size(500, 360);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelReadTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchWord;
        private System.Windows.Forms.Button buttonApproxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelApproxSearchTime;
        private System.Windows.Forms.ListBox listBoxSearchResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxDistance;
    }
}

