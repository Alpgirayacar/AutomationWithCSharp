
namespace EntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmound = new System.Windows.Forms.TextBox();
            this.tbxUnitPrace = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblStockAmound = new System.Windows.Forms.Label();
            this.lblUnitPrace = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitParaceUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(18, 25);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(753, 168);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxStockAmound);
            this.gbxAdd.Controls.Add(this.tbxUnitPrace);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblStockAmound);
            this.gbxAdd.Controls.Add(this.lblUnitPrace);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Location = new System.Drawing.Point(22, 212);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(300, 228);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "add new";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmound
            // 
            this.tbxStockAmound.Location = new System.Drawing.Point(91, 104);
            this.tbxStockAmound.Name = "tbxStockAmound";
            this.tbxStockAmound.Size = new System.Drawing.Size(100, 20);
            this.tbxStockAmound.TabIndex = 5;
            // 
            // tbxUnitPrace
            // 
            this.tbxUnitPrace.Location = new System.Drawing.Point(91, 69);
            this.tbxUnitPrace.Name = "tbxUnitPrace";
            this.tbxUnitPrace.Size = new System.Drawing.Size(100, 20);
            this.tbxUnitPrace.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(91, 32);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 3;
            // 
            // lblStockAmound
            // 
            this.lblStockAmound.AutoSize = true;
            this.lblStockAmound.Location = new System.Drawing.Point(8, 107);
            this.lblStockAmound.Name = "lblStockAmound";
            this.lblStockAmound.Size = new System.Drawing.Size(77, 13);
            this.lblStockAmound.TabIndex = 2;
            this.lblStockAmound.Text = "Stock Amound";
            this.lblStockAmound.Click += new System.EventHandler(this.lblStockAmound_Click);
            // 
            // lblUnitPrace
            // 
            this.lblUnitPrace.AutoSize = true;
            this.lblUnitPrace.Location = new System.Drawing.Point(27, 69);
            this.lblUnitPrace.Name = "lblUnitPrace";
            this.lblUnitPrace.Size = new System.Drawing.Size(57, 13);
            this.lblUnitPrace.TabIndex = 1;
            this.lblUnitPrace.Text = "Unit Prace";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxStockAmountUpdate);
            this.groupBox1.Controls.Add(this.tbxUnitParaceUpdate);
            this.groupBox1.Controls.Add(this.tbxNameUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(362, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(91, 104);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxStockAmountUpdate.TabIndex = 5;
            // 
            // tbxUnitParaceUpdate
            // 
            this.tbxUnitParaceUpdate.Location = new System.Drawing.Point(91, 69);
            this.tbxUnitParaceUpdate.Name = "tbxUnitParaceUpdate";
            this.tbxUnitParaceUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxUnitParaceUpdate.TabIndex = 4;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(91, 32);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxNameUpdate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock Amound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Prace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(689, 218);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 24);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxStockAmound;
        private System.Windows.Forms.TextBox tbxUnitPrace;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblStockAmound;
        private System.Windows.Forms.Label lblUnitPrace;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.TextBox tbxUnitParaceUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnRemove;
    }
}

