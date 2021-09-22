namespace OperaHouse_Assignment4
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
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPerformer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEvent
            // 
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.Location = new System.Drawing.Point(12, 39);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(524, 134);
            this.lstEvent.TabIndex = 0;
            this.lstEvent.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(542, 39);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 2;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(623, 39);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 23);
            this.btnTitle.TabIndex = 3;
            this.btnTitle.Text = "Title";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(461, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(211, 187);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(111, 23);
            this.btnExchange.TabIndex = 12;
            this.btnExchange.Text = "TicketExchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filters";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(568, 101);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(118, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open Shows";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPerformer
            // 
            this.btnPerformer.Location = new System.Drawing.Point(568, 130);
            this.btnPerformer.Name = "btnPerformer";
            this.btnPerformer.Size = new System.Drawing.Size(118, 23);
            this.btnPerformer.TabIndex = 15;
            this.btnPerformer.Text = "Performer";
            this.btnPerformer.UseVisualStyleBackColor = true;
            this.btnPerformer.Click += new System.EventHandler(this.btnPerformer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 222);
            this.Controls.Add(this.btnPerformer);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEvent);
            this.Name = "Form1";
            this.Text = "Grand Opera House Ticketing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPerformer;
    }
}