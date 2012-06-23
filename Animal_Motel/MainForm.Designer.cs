namespace Animal_Motel
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grbAnimalSpecs = new System.Windows.Forms.GroupBox();
            this.grbSpec = new System.Windows.Forms.GroupBox();
            this.chbSpec2 = new System.Windows.Forms.CheckBox();
            this.txtSpec2 = new System.Windows.Forms.TextBox();
            this.lblSpec2 = new System.Windows.Forms.Label();
            this.chbSpec1 = new System.Windows.Forms.CheckBox();
            this.txtSpec1 = new System.Windows.Forms.TextBox();
            this.lblSpec1 = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnAnimalPhoto = new System.Windows.Forms.Button();
            this.chbAllAnimals = new System.Windows.Forms.CheckBox();
            this.rtbImpInfo = new System.Windows.Forms.RichTextBox();
            this.lblImpInfo = new System.Windows.Forms.Label();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lstAnimal = new System.Windows.Forms.ListBox();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.lstGender = new System.Windows.Forms.ListBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbSpecificData = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAnimalSpecs.SuspendLayout();
            this.grbSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.grbGender.SuspendLayout();
            this.grbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAnimalSpecs
            // 
            this.grbAnimalSpecs.Controls.Add(this.grbSpec);
            this.grbAnimalSpecs.Controls.Add(this.btnAddAnimal);
            this.grbAnimalSpecs.Controls.Add(this.btnAnimalPhoto);
            this.grbAnimalSpecs.Controls.Add(this.chbAllAnimals);
            this.grbAnimalSpecs.Controls.Add(this.rtbImpInfo);
            this.grbAnimalSpecs.Controls.Add(this.lblImpInfo);
            this.grbAnimalSpecs.Controls.Add(this.pcImage);
            this.grbAnimalSpecs.Controls.Add(this.lblAnimal);
            this.grbAnimalSpecs.Controls.Add(this.lstAnimal);
            this.grbAnimalSpecs.Controls.Add(this.lstCategory);
            this.grbAnimalSpecs.Controls.Add(this.lblCategory);
            this.grbAnimalSpecs.Controls.Add(this.txtAge);
            this.grbAnimalSpecs.Controls.Add(this.txtName);
            this.grbAnimalSpecs.Controls.Add(this.grbGender);
            this.grbAnimalSpecs.Controls.Add(this.lblAge);
            this.grbAnimalSpecs.Controls.Add(this.lblName);
            this.grbAnimalSpecs.Location = new System.Drawing.Point(12, 12);
            this.grbAnimalSpecs.Name = "grbAnimalSpecs";
            this.grbAnimalSpecs.Size = new System.Drawing.Size(892, 258);
            this.grbAnimalSpecs.TabIndex = 0;
            this.grbAnimalSpecs.TabStop = false;
            this.grbAnimalSpecs.Text = "Animal Specifications";
            // 
            // grbSpec
            // 
            this.grbSpec.Controls.Add(this.chbSpec2);
            this.grbSpec.Controls.Add(this.txtSpec2);
            this.grbSpec.Controls.Add(this.lblSpec2);
            this.grbSpec.Controls.Add(this.chbSpec1);
            this.grbSpec.Controls.Add(this.txtSpec1);
            this.grbSpec.Controls.Add(this.lblSpec1);
            this.grbSpec.Location = new System.Drawing.Point(19, 168);
            this.grbSpec.Name = "grbSpec";
            this.grbSpec.Size = new System.Drawing.Size(341, 73);
            this.grbSpec.TabIndex = 14;
            this.grbSpec.TabStop = false;
            this.grbSpec.Text = "Mammal Specifications";
            // 
            // chbSpec2
            // 
            this.chbSpec2.AutoSize = true;
            this.chbSpec2.Location = new System.Drawing.Point(186, 19);
            this.chbSpec2.Name = "chbSpec2";
            this.chbSpec2.Size = new System.Drawing.Size(110, 17);
            this.chbSpec2.TabIndex = 18;
            this.chbSpec2.Text = "Under Quarantine";
            this.chbSpec2.UseVisualStyleBackColor = true;
            this.chbSpec2.CheckedChanged += new System.EventHandler(this.chbSpec2_CheckedChanged);
            // 
            // txtSpec2
            // 
            this.txtSpec2.Location = new System.Drawing.Point(271, 43);
            this.txtSpec2.Name = "txtSpec2";
            this.txtSpec2.Size = new System.Drawing.Size(41, 20);
            this.txtSpec2.TabIndex = 17;
            this.txtSpec2.Visible = false;
            // 
            // lblSpec2
            // 
            this.lblSpec2.AutoSize = true;
            this.lblSpec2.Location = new System.Drawing.Point(168, 46);
            this.lblSpec2.Name = "lblSpec2";
            this.lblSpec2.Size = new System.Drawing.Size(97, 13);
            this.lblSpec2.TabIndex = 16;
            this.lblSpec2.Text = "Days in Quarantine";
            this.lblSpec2.Visible = false;
            // 
            // chbSpec1
            // 
            this.chbSpec1.AutoSize = true;
            this.chbSpec1.Location = new System.Drawing.Point(28, 20);
            this.chbSpec1.Name = "chbSpec1";
            this.chbSpec1.Size = new System.Drawing.Size(110, 17);
            this.chbSpec1.TabIndex = 15;
            this.chbSpec1.Text = "Under Quarantine";
            this.chbSpec1.UseVisualStyleBackColor = true;
            // 
            // txtSpec1
            // 
            this.txtSpec1.Location = new System.Drawing.Point(109, 43);
            this.txtSpec1.Name = "txtSpec1";
            this.txtSpec1.Size = new System.Drawing.Size(41, 20);
            this.txtSpec1.TabIndex = 15;
            this.txtSpec1.Visible = false;
            // 
            // lblSpec1
            // 
            this.lblSpec1.AutoSize = true;
            this.lblSpec1.Location = new System.Drawing.Point(6, 46);
            this.lblSpec1.Name = "lblSpec1";
            this.lblSpec1.Size = new System.Drawing.Size(66, 13);
            this.lblSpec1.TabIndex = 15;
            this.lblSpec1.Text = "No.Of Teeth";
            this.lblSpec1.Visible = false;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(383, 208);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(149, 33);
            this.btnAddAnimal.TabIndex = 13;
            this.btnAddAnimal.Text = "Add this new Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnAnimalPhoto
            // 
            this.btnAnimalPhoto.Location = new System.Drawing.Point(557, 27);
            this.btnAnimalPhoto.Name = "btnAnimalPhoto";
            this.btnAnimalPhoto.Size = new System.Drawing.Size(116, 30);
            this.btnAnimalPhoto.TabIndex = 12;
            this.btnAnimalPhoto.Text = "Load Animal Photo";
            this.btnAnimalPhoto.UseVisualStyleBackColor = true;
            this.btnAnimalPhoto.Click += new System.EventHandler(this.btnAnimalPhoto_Click);
            // 
            // chbAllAnimals
            // 
            this.chbAllAnimals.AutoSize = true;
            this.chbAllAnimals.Location = new System.Drawing.Point(548, 197);
            this.chbAllAnimals.Name = "chbAllAnimals";
            this.chbAllAnimals.Size = new System.Drawing.Size(95, 17);
            this.chbAllAnimals.TabIndex = 11;
            this.chbAllAnimals.Text = "List All Animals";
            this.chbAllAnimals.UseVisualStyleBackColor = true;
            this.chbAllAnimals.CheckedChanged += new System.EventHandler(this.chbAllAnimals_CheckedChanged);
            // 
            // rtbImpInfo
            // 
            this.rtbImpInfo.Location = new System.Drawing.Point(720, 29);
            this.rtbImpInfo.Name = "rtbImpInfo";
            this.rtbImpInfo.Size = new System.Drawing.Size(149, 173);
            this.rtbImpInfo.TabIndex = 10;
            this.rtbImpInfo.Text = "";
            // 
            // lblImpInfo
            // 
            this.lblImpInfo.AutoSize = true;
            this.lblImpInfo.Location = new System.Drawing.Point(762, 13);
            this.lblImpInfo.Name = "lblImpInfo";
            this.lblImpInfo.Size = new System.Drawing.Size(72, 13);
            this.lblImpInfo.TabIndex = 9;
            this.lblImpInfo.Text = "Important Info";
            // 
            // pcImage
            // 
            this.pcImage.Image = ((System.Drawing.Image)(resources.GetObject("pcImage.Image")));
            this.pcImage.Location = new System.Drawing.Point(548, 63);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(136, 118);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 8;
            this.pcImage.TabStop = false;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(427, 13);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(38, 13);
            this.lblAnimal.TabIndex = 7;
            this.lblAnimal.Text = "Animal";
            // 
            // lstAnimal
            // 
            this.lstAnimal.FormattingEnabled = true;
            this.lstAnimal.Location = new System.Drawing.Point(383, 29);
            this.lstAnimal.Name = "lstAnimal";
            this.lstAnimal.Size = new System.Drawing.Size(149, 173);
            this.lstAnimal.TabIndex = 6;
            this.lstAnimal.SelectedIndexChanged += new System.EventHandler(this.lstAnimal_SelectedIndexChanged);
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(221, 29);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(139, 134);
            this.lstCategory.TabIndex = 1;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(265, 13);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(137, 43);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(41, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.lstGender);
            this.grbGender.Location = new System.Drawing.Point(19, 63);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(171, 98);
            this.grbGender.TabIndex = 2;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // lstGender
            // 
            this.lstGender.FormattingEnabled = true;
            this.lstGender.Location = new System.Drawing.Point(15, 19);
            this.lstGender.Name = "lstGender";
            this.lstGender.Size = new System.Drawing.Size(139, 56);
            this.lstGender.TabIndex = 0;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 46);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.label6);
            this.grbData.Controls.Add(this.rtbSpecificData);
            this.grbData.Controls.Add(this.label5);
            this.grbData.Controls.Add(this.label4);
            this.grbData.Controls.Add(this.label3);
            this.grbData.Controls.Add(this.label2);
            this.grbData.Controls.Add(this.lsbData);
            this.grbData.Controls.Add(this.label1);
            this.grbData.Location = new System.Drawing.Point(13, 277);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(891, 222);
            this.grbData.TabIndex = 1;
            this.grbData.TabStop = false;
            this.grbData.Text = "List of registered animals with general data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Species";
            // 
            // rtbSpecificData
            // 
            this.rtbSpecificData.Location = new System.Drawing.Point(547, 32);
            this.rtbSpecificData.Name = "rtbSpecificData";
            this.rtbSpecificData.ReadOnly = true;
            this.rtbSpecificData.Size = new System.Drawing.Size(321, 173);
            this.rtbSpecificData.TabIndex = 22;
            this.rtbSpecificData.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gender";
            // 
            // lsbData
            // 
            this.lsbData.FormattingEnabled = true;
            this.lsbData.Location = new System.Drawing.Point(18, 32);
            this.lsbData.Name = "lsbData";
            this.lsbData.Size = new System.Drawing.Size(503, 173);
            this.lsbData.TabIndex = 16;
            this.lsbData.SelectedIndexChanged += new System.EventHandler(this.lsbData_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Specific Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 511);
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.grbAnimalSpecs);
            this.Name = "MainForm";
            this.Text = "Apu Animal Motel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grbAnimalSpecs.ResumeLayout(false);
            this.grbAnimalSpecs.PerformLayout();
            this.grbSpec.ResumeLayout(false);
            this.grbSpec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.grbGender.ResumeLayout(false);
            this.grbData.ResumeLayout(false);
            this.grbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAnimalSpecs;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbSpec;
        private System.Windows.Forms.TextBox txtSpec2;
        private System.Windows.Forms.Label lblSpec2;
        private System.Windows.Forms.CheckBox chbSpec1;
        private System.Windows.Forms.TextBox txtSpec1;
        private System.Windows.Forms.Label lblSpec1;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnAnimalPhoto;
        private System.Windows.Forms.CheckBox chbAllAnimals;
        private System.Windows.Forms.RichTextBox rtbImpInfo;
        private System.Windows.Forms.Label lblImpInfo;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ListBox lstAnimal;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstGender;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbSpec2;
        private System.Windows.Forms.RichTextBox rtbSpecificData;
        private System.Windows.Forms.Label label6;
    }
}

