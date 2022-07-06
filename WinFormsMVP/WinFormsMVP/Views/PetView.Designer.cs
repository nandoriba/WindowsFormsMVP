namespace WinFormsMVP.Views
{
    partial class PetView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetDetails = new System.Windows.Forms.TabPage();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.lblSearchPet = new System.Windows.Forms.Label();
            this.txtSearchPet = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewPet = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPetId = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPetType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPetColour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPetSave = new System.Windows.Forms.Button();
            this.btnPetCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePetDetails.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PETS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePetDetails);
            this.tabControl1.Controls.Add(this.tabPagePetList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 308);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePetDetails
            // 
            this.tabPagePetDetails.Controls.Add(this.btnPetCancel);
            this.tabPagePetDetails.Controls.Add(this.btnPetSave);
            this.tabPagePetDetails.Controls.Add(this.txtPetColour);
            this.tabPagePetDetails.Controls.Add(this.label5);
            this.tabPagePetDetails.Controls.Add(this.txtPetType);
            this.tabPagePetDetails.Controls.Add(this.label4);
            this.tabPagePetDetails.Controls.Add(this.txtPetName);
            this.tabPagePetDetails.Controls.Add(this.label3);
            this.tabPagePetDetails.Controls.Add(this.txtPetId);
            this.tabPagePetDetails.Controls.Add(this.label2);
            this.tabPagePetDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPagePetDetails.Name = "tabPagePetDetails";
            this.tabPagePetDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetails.Size = new System.Drawing.Size(607, 279);
            this.tabPagePetDetails.TabIndex = 0;
            this.tabPagePetDetails.Text = "Pet list";
            this.tabPagePetDetails.UseVisualStyleBackColor = true;
            // 
            // tabPagePetList
            // 
            this.tabPagePetList.Controls.Add(this.btnDelete);
            this.tabPagePetList.Controls.Add(this.btnEdit);
            this.tabPagePetList.Controls.Add(this.btnAddNew);
            this.tabPagePetList.Controls.Add(this.dataGridViewPet);
            this.tabPagePetList.Controls.Add(this.btnSearch);
            this.tabPagePetList.Controls.Add(this.txtSearchPet);
            this.tabPagePetList.Controls.Add(this.lblSearchPet);
            this.tabPagePetList.Location = new System.Drawing.Point(4, 25);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.Size = new System.Drawing.Size(607, 279);
            this.tabPagePetList.TabIndex = 1;
            this.tabPagePetList.Text = "Pet detail";
            this.tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // lblSearchPet
            // 
            this.lblSearchPet.AutoSize = true;
            this.lblSearchPet.Location = new System.Drawing.Point(11, 7);
            this.lblSearchPet.Name = "lblSearchPet";
            this.lblSearchPet.Size = new System.Drawing.Size(72, 16);
            this.lblSearchPet.TabIndex = 0;
            this.lblSearchPet.Text = "Search pet";
            // 
            // txtSearchPet
            // 
            this.txtSearchPet.Location = new System.Drawing.Point(11, 26);
            this.txtSearchPet.Name = "txtSearchPet";
            this.txtSearchPet.Size = new System.Drawing.Size(392, 22);
            this.txtSearchPet.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(408, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPet
            // 
            this.dataGridViewPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPet.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewPet.Name = "dataGridViewPet";
            this.dataGridViewPet.RowTemplate.Height = 25;
            this.dataGridViewPet.Size = new System.Drawing.Size(471, 216);
            this.dataGridViewPet.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(489, 57);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(489, 86);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(489, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // txtPetId
            // 
            this.txtPetId.Location = new System.Drawing.Point(28, 29);
            this.txtPetId.Name = "txtPetId";
            this.txtPetId.Size = new System.Drawing.Size(135, 22);
            this.txtPetId.TabIndex = 1;
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(32, 77);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(135, 22);
            this.txtPetName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtPetType
            // 
            this.txtPetType.Location = new System.Drawing.Point(201, 77);
            this.txtPetType.Name = "txtPetType";
            this.txtPetType.Size = new System.Drawing.Size(135, 22);
            this.txtPetType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            // 
            // txtPetColour
            // 
            this.txtPetColour.Location = new System.Drawing.Point(32, 129);
            this.txtPetColour.Name = "txtPetColour";
            this.txtPetColour.Size = new System.Drawing.Size(304, 22);
            this.txtPetColour.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Colour";
            // 
            // btnPetSave
            // 
            this.btnPetSave.Location = new System.Drawing.Point(32, 167);
            this.btnPetSave.Name = "btnPetSave";
            this.btnPetSave.Size = new System.Drawing.Size(143, 30);
            this.btnPetSave.TabIndex = 8;
            this.btnPetSave.Text = "Save";
            this.btnPetSave.UseVisualStyleBackColor = true;
            // 
            // btnPetCancel
            // 
            this.btnPetCancel.Location = new System.Drawing.Point(193, 167);
            this.btnPetCancel.Name = "btnPetCancel";
            this.btnPetCancel.Size = new System.Drawing.Size(143, 30);
            this.btnPetCancel.TabIndex = 9;
            this.btnPetCancel.Text = "Cancel";
            this.btnPetCancel.UseVisualStyleBackColor = true;
            // 
            // frmPetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 350);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPetView";
            this.Text = "frmPetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePetDetails.ResumeLayout(false);
            this.tabPagePetDetails.PerformLayout();
            this.tabPagePetList.ResumeLayout(false);
            this.tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePetDetails;
        private Button btnPetCancel;
        private Button btnPetSave;
        private TextBox txtPetColour;
        private Label label5;
        private TextBox txtPetType;
        private Label label4;
        private TextBox txtPetName;
        private Label label3;
        private TextBox txtPetId;
        private Label label2;
        private TabPage tabPagePetList;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private DataGridView dataGridViewPet;
        private Button btnSearch;
        private TextBox txtSearchPet;
        private Label lblSearchPet;
    }
}