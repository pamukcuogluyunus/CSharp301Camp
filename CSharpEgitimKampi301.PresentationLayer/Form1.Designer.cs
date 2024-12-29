namespace CSharpEgitimKampi301.PresentationLayer
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
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryStatus = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbPassive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(66, 19);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(63, 13);
            this.lblCategoryId.TabIndex = 0;
            this.lblCategoryId.Text = "Kategori ID:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(135, 16);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(156, 20);
            this.txtCategoryId.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(65, 100);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(164, 32);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 340);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(62, 40);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(67, 13);
            this.lblCategoryName.TabIndex = 4;
            this.lblCategoryName.Text = "Kategori Adı:";
            // 
            // lblCategoryStatus
            // 
            this.lblCategoryStatus.AutoSize = true;
            this.lblCategoryStatus.Location = new System.Drawing.Point(46, 72);
            this.lblCategoryStatus.Name = "lblCategoryStatus";
            this.lblCategoryStatus.Size = new System.Drawing.Size(83, 13);
            this.lblCategoryStatus.TabIndex = 5;
            this.lblCategoryStatus.Text = "Kategori Durum:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(135, 40);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(156, 20);
            this.txtCategoryName.TabIndex = 6;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Location = new System.Drawing.Point(135, 68);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(46, 17);
            this.rdbActive.TabIndex = 7;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Aktif";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            this.rdbPassive.AutoSize = true;
            this.rdbPassive.Location = new System.Drawing.Point(202, 68);
            this.rdbPassive.Name = "rdbPassive";
            this.rdbPassive.Size = new System.Drawing.Size(48, 17);
            this.rdbPassive.TabIndex = 8;
            this.rdbPassive.TabStop = true;
            this.rdbPassive.Text = "Pasif";
            this.rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(65, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(69, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(69, 252);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(164, 32);
            this.btnGetById.TabIndex = 12;
            this.btnGetById.Text = "ID\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 340);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdbPassive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblCategoryStatus);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.lblCategoryId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryStatus;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbPassive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
    }
}

