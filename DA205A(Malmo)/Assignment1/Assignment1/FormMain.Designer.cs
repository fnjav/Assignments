namespace Assignment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpAnimal = new System.Windows.Forms.GroupBox();
            this.txtSpecificAnimal = new System.Windows.Forms.TextBox();
            this.txtSpecificCategory = new System.Windows.Forms.TextBox();
            this.lblSpecificAnimal = new System.Windows.Forms.Label();
            this.lblSpecificCategory = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lstAnimal = new System.Windows.Forms.ListBox();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.lstGender = new System.Windows.Forms.ListBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lstRegisteredAnimals = new System.Windows.Forms.ListBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpAnimal.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.grpAnimal);
            this.grpInput.Controls.Add(this.lblSpecies);
            this.grpInput.Controls.Add(this.lblCategory);
            this.grpInput.Controls.Add(this.lstAnimal);
            this.grpInput.Controls.Add(this.lstCategory);
            this.grpInput.Controls.Add(this.grpGender);
            this.grpInput.Controls.Add(this.lblAge);
            this.grpInput.Controls.Add(this.txtAge);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.ForeColor = System.Drawing.Color.ForestGreen;
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(437, 252);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Animal Specifications";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 48);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add this new animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpAnimal
            // 
            this.grpAnimal.Controls.Add(this.txtSpecificAnimal);
            this.grpAnimal.Controls.Add(this.txtSpecificCategory);
            this.grpAnimal.Controls.Add(this.lblSpecificAnimal);
            this.grpAnimal.Controls.Add(this.lblSpecificCategory);
            this.grpAnimal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpAnimal.Location = new System.Drawing.Point(16, 162);
            this.grpAnimal.Name = "grpAnimal";
            this.grpAnimal.Size = new System.Drawing.Size(273, 84);
            this.grpAnimal.TabIndex = 9;
            this.grpAnimal.TabStop = false;
            this.grpAnimal.Text = "<Specific Text For Each Animal>";
            // 
            // txtSpecificAnimal
            // 
            this.txtSpecificAnimal.Location = new System.Drawing.Point(153, 50);
            this.txtSpecificAnimal.Name = "txtSpecificAnimal";
            this.txtSpecificAnimal.Size = new System.Drawing.Size(114, 20);
            this.txtSpecificAnimal.TabIndex = 3;
            // 
            // txtSpecificCategory
            // 
            this.txtSpecificCategory.Location = new System.Drawing.Point(153, 22);
            this.txtSpecificCategory.Name = "txtSpecificCategory";
            this.txtSpecificCategory.Size = new System.Drawing.Size(114, 20);
            this.txtSpecificCategory.TabIndex = 2;
            // 
            // lblSpecificAnimal
            // 
            this.lblSpecificAnimal.AutoSize = true;
            this.lblSpecificAnimal.Location = new System.Drawing.Point(4, 53);
            this.lblSpecificAnimal.Name = "lblSpecificAnimal";
            this.lblSpecificAnimal.Size = new System.Drawing.Size(57, 13);
            this.lblSpecificAnimal.TabIndex = 1;
            this.lblSpecificAnimal.Text = "<Species>";
            // 
            // lblSpecificCategory
            // 
            this.lblSpecificCategory.AutoSize = true;
            this.lblSpecificCategory.Location = new System.Drawing.Point(4, 25);
            this.lblSpecificCategory.Name = "lblSpecificCategory";
            this.lblSpecificCategory.Size = new System.Drawing.Size(61, 13);
            this.lblSpecificCategory.TabIndex = 0;
            this.lblSpecificCategory.Text = "<Category>";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(330, 10);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(79, 13);
            this.lblSpecies.TabIndex = 8;
            this.lblSpecies.Text = "Animal Species";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(202, 10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // lstAnimal
            // 
            this.lstAnimal.FormattingEnabled = true;
            this.lstAnimal.Location = new System.Drawing.Point(304, 27);
            this.lstAnimal.Name = "lstAnimal";
            this.lstAnimal.Size = new System.Drawing.Size(120, 121);
            this.lstAnimal.TabIndex = 6;
            this.lstAnimal.SelectedIndexChanged += new System.EventHandler(this.lstAnimal_SelectedIndexChanged);
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(169, 27);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(120, 121);
            this.lstCategory.TabIndex = 5;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.lstGender);
            this.grpGender.Location = new System.Drawing.Point(16, 87);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(138, 75);
            this.grpGender.TabIndex = 4;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // lstGender
            // 
            this.lstGender.FormattingEnabled = true;
            this.lstGender.Location = new System.Drawing.Point(7, 20);
            this.lstGender.Name = "lstGender";
            this.lstGender.Size = new System.Drawing.Size(125, 43);
            this.lstGender.TabIndex = 0;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 56);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(108, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(46, 20);
            this.txtAge.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lstRegisteredAnimals);
            this.grpOutput.Controls.Add(this.lblDescription);
            this.grpOutput.ForeColor = System.Drawing.Color.ForestGreen;
            this.grpOutput.Location = new System.Drawing.Point(13, 280);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(436, 187);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "List of registered animals";
            // 
            // lstRegisteredAnimals
            // 
            this.lstRegisteredAnimals.FormattingEnabled = true;
            this.lstRegisteredAnimals.Location = new System.Drawing.Point(15, 36);
            this.lstRegisteredAnimals.Name = "lstRegisteredAnimals";
            this.lstRegisteredAnimals.Size = new System.Drawing.Size(408, 147);
            this.lstRegisteredAnimals.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(230, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ID, Name, Age, Gender, Special characteristics";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 479);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Apu Animal Motel";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpAnimal.ResumeLayout(false);
            this.grpAnimal.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstGender;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ListBox lstAnimal;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpAnimal;
        private System.Windows.Forms.TextBox txtSpecificAnimal;
        private System.Windows.Forms.TextBox txtSpecificCategory;
        private System.Windows.Forms.Label lblSpecificAnimal;
        private System.Windows.Forms.Label lblSpecificCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstRegisteredAnimals;
    }
}

