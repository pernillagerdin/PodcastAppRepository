namespace PodcastApp {
    partial class PodcastAppGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lvEpisodeList = new System.Windows.Forms.ListView();
            this.BtnNewFeed = new System.Windows.Forms.Button();
            this.BtnSaveFeed = new System.Windows.Forms.Button();
            this.BtnRemoveFeed = new System.Windows.Forms.Button();
            this.lvCategoryList = new System.Windows.Forms.ListView();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.BtnNewCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUpdateFrequency = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lvPodcastList = new System.Windows.Forms.ListView();
            this.columnEpisodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEpisodeTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEpisodeList
            // 
            this.lvEpisodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEpisodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEpisodeList.HideSelection = false;
            this.lvEpisodeList.Location = new System.Drawing.Point(4, 551);
            this.lvEpisodeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvEpisodeList.Name = "lvEpisodeList";
            this.lvEpisodeList.Size = new System.Drawing.Size(813, 285);
            this.lvEpisodeList.TabIndex = 0;
            this.lvEpisodeList.UseCompatibleStateImageBehavior = false;
            // 
            // BtnNewFeed
            // 
            this.BtnNewFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewFeed.Location = new System.Drawing.Point(299, 490);
            this.BtnNewFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNewFeed.Name = "BtnNewFeed";
            this.BtnNewFeed.Size = new System.Drawing.Size(143, 38);
            this.BtnNewFeed.TabIndex = 1;
            this.BtnNewFeed.Text = "New";
            this.BtnNewFeed.UseVisualStyleBackColor = true;
            // 
            // BtnSaveFeed
            // 
            this.BtnSaveFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFeed.Location = new System.Drawing.Point(484, 490);
            this.BtnSaveFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSaveFeed.Name = "BtnSaveFeed";
            this.BtnSaveFeed.Size = new System.Drawing.Size(143, 38);
            this.BtnSaveFeed.TabIndex = 2;
            this.BtnSaveFeed.Text = "Save";
            this.BtnSaveFeed.UseVisualStyleBackColor = true;
            this.BtnSaveFeed.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRemoveFeed
            // 
            this.BtnRemoveFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveFeed.Location = new System.Drawing.Point(677, 487);
            this.BtnRemoveFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRemoveFeed.Name = "BtnRemoveFeed";
            this.BtnRemoveFeed.Size = new System.Drawing.Size(143, 38);
            this.BtnRemoveFeed.TabIndex = 3;
            this.BtnRemoveFeed.Text = "Remove";
            this.BtnRemoveFeed.UseVisualStyleBackColor = true;
            // 
            // lvCategoryList
            // 
            this.lvCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCategoryList.HideSelection = false;
            this.lvCategoryList.Location = new System.Drawing.Point(4, 44);
            this.lvCategoryList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvCategoryList.Name = "lvCategoryList";
            this.lvCategoryList.Size = new System.Drawing.Size(600, 261);
            this.lvCategoryList.TabIndex = 4;
            this.lvCategoryList.UseCompatibleStateImageBehavior = false;
            this.lvCategoryList.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // tbCategory
            // 
            this.tbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategory.Location = new System.Drawing.Point(4, 335);
            this.tbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(600, 36);
            this.tbCategory.TabIndex = 5;
            // 
            // BtnNewCategory
            // 
            this.BtnNewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCategory.Location = new System.Drawing.Point(4, 379);
            this.BtnNewCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNewCategory.Name = "BtnNewCategory";
            this.BtnNewCategory.Size = new System.Drawing.Size(188, 44);
            this.BtnNewCategory.TabIndex = 6;
            this.BtnNewCategory.Text = "New";
            this.BtnNewCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.Location = new System.Drawing.Point(200, 379);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(203, 44);
            this.btnSaveCategory.TabIndex = 7;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCategory.Location = new System.Drawing.Point(411, 379);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(195, 44);
            this.btnRemoveCategory.TabIndex = 8;
            this.btnRemoveCategory.Text = "Remove";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblUpdateFrequency);
            this.panel1.Controls.Add(this.lblURL);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.cbFrequency);
            this.panel1.Controls.Add(this.tbURL);
            this.panel1.Controls.Add(this.lvPodcastList);
            this.panel1.Controls.Add(this.lvEpisodeList);
            this.panel1.Controls.Add(this.BtnNewFeed);
            this.panel1.Controls.Add(this.BtnSaveFeed);
            this.panel1.Controls.Add(this.BtnRemoveFeed);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 841);
            this.panel1.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(657, 416);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Category";
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFrequency.Location = new System.Drawing.Point(465, 416);
            this.lblUpdateFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(173, 25);
            this.lblUpdateFrequency.TabIndex = 10;
            this.lblUpdateFrequency.Text = "Update Frequency";
            this.lblUpdateFrequency.Click += new System.EventHandler(this.lblUppdateringsfrekvens_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(8, 417);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(56, 25);
            this.lblURL.TabIndex = 8;
            this.lblURL.Text = "URL:";
            this.lblURL.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(657, 442);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 37);
            this.cbCategory.TabIndex = 7;
            // 
            // cbFrequency
            // 
            this.cbFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Location = new System.Drawing.Point(471, 442);
            this.cbFrequency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(177, 37);
            this.cbFrequency.TabIndex = 6;
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(13, 446);
            this.tbURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(448, 36);
            this.tbURL.TabIndex = 5;
            this.tbURL.Text = "http://.....";
            // 
            // lvPodcastList
            // 
            this.lvPodcastList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPodcastList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEpisodes,
            this.columnName,
            this.columnFrequency,
            this.columnCategory});
            this.lvPodcastList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPodcastList.HideSelection = false;
            this.lvPodcastList.Location = new System.Drawing.Point(13, 14);
            this.lvPodcastList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPodcastList.Name = "lvPodcastList";
            this.lvPodcastList.Size = new System.Drawing.Size(813, 384);
            this.lvPodcastList.TabIndex = 4;
            this.lvPodcastList.UseCompatibleStateImageBehavior = false;
            this.lvPodcastList.View = System.Windows.Forms.View.Details;
            this.lvPodcastList.SelectedIndexChanged += new System.EventHandler(this.lvPodcastList_SelectedIndexChanged);
            // 
            // columnEpisodes
            // 
            this.columnEpisodes.Text = "Ëpisodes";
            this.columnEpisodes.Width = 96;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 231;
            // 
            // columnFrequency
            // 
            this.columnFrequency.Text = "Frequency";
            this.columnFrequency.Width = 149;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 130;
            // 
            // lblEpisodeTitle
            // 
            this.lblEpisodeTitle.AutoSize = true;
            this.lblEpisodeTitle.Location = new System.Drawing.Point(27, 22);
            this.lblEpisodeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodeTitle.Name = "lblEpisodeTitle";
            this.lblEpisodeTitle.Size = new System.Drawing.Size(223, 24);
            this.lblEpisodeTitle.TabIndex = 10;
            this.lblEpisodeTitle.Text = "Podcast # Episode Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 66);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 24);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(4, 10);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(135, 29);
            this.lblCategories.TabIndex = 12;
            this.lblCategories.Text = "Categories";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblEpisodeTitle);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(880, 482);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 369);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvCategoryList);
            this.panel3.Controls.Add(this.lblCategories);
            this.panel3.Controls.Add(this.tbCategory);
            this.panel3.Controls.Add(this.BtnNewCategory);
            this.panel3.Controls.Add(this.btnSaveCategory);
            this.panel3.Controls.Add(this.btnRemoveCategory);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(876, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 427);
            this.panel3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 870);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Podcasts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEpisodeList;
        private System.Windows.Forms.Button BtnNewFeed;
        private System.Windows.Forms.Button BtnSaveFeed;
        private System.Windows.Forms.Button BtnRemoveFeed;
        private System.Windows.Forms.ListView lvCategoryList;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button BtnNewCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUpdateFrequency;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.ListView lvPodcastList;
        private System.Windows.Forms.Label lblEpisodeTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnEpisodes;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnFrequency;
        private System.Windows.Forms.ColumnHeader columnCategory;
    }
}

