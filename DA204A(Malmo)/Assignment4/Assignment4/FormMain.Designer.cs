namespace Assignment4
{
    partial class FormMain
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
            this.grpNewRecipe = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnModfiyIngredients = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategoryCmb = new System.Windows.Forms.Label();
            this.txtNameOfRecipe = new System.Windows.Forms.TextBox();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumOfIngredients = new System.Windows.Forms.Label();
            this.lblCategoryLst = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewRecipe
            // 
            this.grpNewRecipe.Controls.Add(this.btnReset);
            this.grpNewRecipe.Controls.Add(this.txtDescription);
            this.grpNewRecipe.Controls.Add(this.btnModfiyIngredients);
            this.grpNewRecipe.Controls.Add(this.cmbCategory);
            this.grpNewRecipe.Controls.Add(this.lblCategoryCmb);
            this.grpNewRecipe.Controls.Add(this.txtNameOfRecipe);
            this.grpNewRecipe.Controls.Add(this.lblNameOfRecipe);
            this.grpNewRecipe.Location = new System.Drawing.Point(13, 13);
            this.grpNewRecipe.Name = "grpNewRecipe";
            this.grpNewRecipe.Size = new System.Drawing.Size(383, 305);
            this.grpNewRecipe.TabIndex = 0;
            this.grpNewRecipe.TabStop = false;
            this.grpNewRecipe.Text = "Add or edit recipe";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(13, 90);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(355, 200);
            this.txtDescription.TabIndex = 5;
            // 
            // btnModfiyIngredients
            // 
            this.btnModfiyIngredients.Location = new System.Drawing.Point(260, 53);
            this.btnModfiyIngredients.Name = "btnModfiyIngredients";
            this.btnModfiyIngredients.Size = new System.Drawing.Size(108, 23);
            this.btnModfiyIngredients.TabIndex = 4;
            this.btnModfiyIngredients.Text = "Modify ingredients";
            this.btnModfiyIngredients.UseVisualStyleBackColor = true;
            this.btnModfiyIngredients.Click += new System.EventHandler(this.btnModifyIngredients_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
            "Meat",
            "Vegeterian",
            "Fish",
            "SeaFood"});
            this.cmbCategory.Location = new System.Drawing.Point(92, 55);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(162, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblCategoryCmb
            // 
            this.lblCategoryCmb.AutoSize = true;
            this.lblCategoryCmb.Location = new System.Drawing.Point(10, 58);
            this.lblCategoryCmb.Name = "lblCategoryCmb";
            this.lblCategoryCmb.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryCmb.TabIndex = 2;
            this.lblCategoryCmb.Text = "Category";
            // 
            // txtNameOfRecipe
            // 
            this.txtNameOfRecipe.Location = new System.Drawing.Point(92, 17);
            this.txtNameOfRecipe.Name = "txtNameOfRecipe";
            this.txtNameOfRecipe.Size = new System.Drawing.Size(162, 20);
            this.txtNameOfRecipe.TabIndex = 1;
            // 
            // lblNameOfRecipe
            // 
            this.lblNameOfRecipe.AutoSize = true;
            this.lblNameOfRecipe.Location = new System.Drawing.Point(7, 20);
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            this.lblNameOfRecipe.Size = new System.Drawing.Size(79, 13);
            this.lblNameOfRecipe.TabIndex = 0;
            this.lblNameOfRecipe.Text = "Name of recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(26, 333);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(355, 23);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lstRecipes
            // 
            this.lstRecipes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.Location = new System.Drawing.Point(422, 54);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(399, 264);
            this.lstRecipes.TabIndex = 2;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(435, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblNumOfIngredients
            // 
            this.lblNumOfIngredients.Location = new System.Drawing.Point(561, 19);
            this.lblNumOfIngredients.Name = "lblNumOfIngredients";
            this.lblNumOfIngredients.Size = new System.Drawing.Size(42, 32);
            this.lblNumOfIngredients.TabIndex = 4;
            this.lblNumOfIngredients.Text = "No. of ingred.";
            // 
            // lblCategoryLst
            // 
            this.lblCategoryLst.AutoSize = true;
            this.lblCategoryLst.Location = new System.Drawing.Point(652, 33);
            this.lblCategoryLst.Name = "lblCategoryLst";
            this.lblCategoryLst.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryLst.TabIndex = 5;
            this.lblCategoryLst.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(745, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(422, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Apply Edits";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(736, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Recipe";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(260, 15);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 374);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategoryLst);
            this.Controls.Add(this.lblNumOfIngredients);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.grpNewRecipe);
            this.Name = "FormMain";
            this.Text = "ABU\'s Cooking Book";
            this.grpNewRecipe.ResumeLayout(false);
            this.grpNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewRecipe;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategoryCmb;
        private System.Windows.Forms.TextBox txtNameOfRecipe;
        private System.Windows.Forms.Label lblNameOfRecipe;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnModfiyIngredients;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumOfIngredients;
        private System.Windows.Forms.Label lblCategoryLst;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
    }
}

