namespace Lab4
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
            this.buttonStrictSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStrictSearchTime = new System.Windows.Forms.Label();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(13, 13);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(131, 23);
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
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово для поиска:";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(161, 67);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(295, 20);
            this.textBoxSearchWord.TabIndex = 4;
            // 
            // buttonStrictSearch
            // 
            this.buttonStrictSearch.Location = new System.Drawing.Point(13, 113);
            this.buttonStrictSearch.Name = "buttonStrictSearch";
            this.buttonStrictSearch.Size = new System.Drawing.Size(131, 23);
            this.buttonStrictSearch.TabIndex = 5;
            this.buttonStrictSearch.Text = "Четкий поиск";
            this.buttonStrictSearch.UseVisualStyleBackColor = true;
            this.buttonStrictSearch.Click += new System.EventHandler(this.buttonStrictSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска слова:";
            // 
            // labelStrictSearchTime
            // 
            this.labelStrictSearchTime.AutoSize = true;
            this.labelStrictSearchTime.Location = new System.Drawing.Point(286, 118);
            this.labelStrictSearchTime.Name = "labelStrictSearchTime";
            this.labelStrictSearchTime.Size = new System.Drawing.Size(0, 13);
            this.labelStrictSearchTime.TabIndex = 7;
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.Location = new System.Drawing.Point(15, 153);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(441, 147);
            this.listBoxSearchResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 322);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.labelStrictSearchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStrictSearch);
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
        private System.Windows.Forms.Button buttonStrictSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStrictSearchTime;
        private System.Windows.Forms.ListBox listBoxSearchResult;
    }
}

