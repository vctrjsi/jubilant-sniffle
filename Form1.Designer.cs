using OutOfSchoolClubDatabase;

namespace WindowsFormsApplication2
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
            this.StudentDetailsTable = new System.Windows.Forms.ListView();
            this.StudentIDPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateofBirthSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllergiesSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MedicalNotesSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParentIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ParentDetailsTable = new System.Windows.Forms.ListView();
            this.ParentIDPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNamePD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNamePD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactDetail1PD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactDetaill2PD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmergencyContactPD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WorkerDetailsTable = new System.Windows.Forms.ListView();
            this.WorkerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameWD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameWD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactDetail1WD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactDetail2WD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmergencyContactWD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.database1DataSet1 = new WindowsFormsApplication2.Database1DataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDetailsTable
            // 
            this.StudentDetailsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentIDPK,
            this.FirstNameSD,
            this.LastNameSD,
            this.DateofBirthSD,
            this.AllergiesSD,
            this.MedicalNotesSD,
            this.ParentIDFK});
            this.StudentDetailsTable.Location = new System.Drawing.Point(6, 6);
            this.StudentDetailsTable.Name = "StudentDetailsTable";
            this.StudentDetailsTable.Size = new System.Drawing.Size(553, 183);
            this.StudentDetailsTable.TabIndex = 0;
            this.StudentDetailsTable.UseCompatibleStateImageBehavior = false;
            this.StudentDetailsTable.View = System.Windows.Forms.View.Details;
            this.StudentDetailsTable.SelectedIndexChanged += new System.EventHandler(this.StudentDetailsTable_SelectedIndexChanged);
            // 
            // StudentIDPK
            // 
            this.StudentIDPK.Text = "Student ID";
            this.StudentIDPK.Width = 65;
            // 
            // FirstNameSD
            // 
            this.FirstNameSD.Text = "First Name";
            this.FirstNameSD.Width = 72;
            // 
            // LastNameSD
            // 
            this.LastNameSD.Text = "Last Name";
            this.LastNameSD.Width = 71;
            // 
            // DateofBirthSD
            // 
            this.DateofBirthSD.Text = "Date of Birth";
            this.DateofBirthSD.Width = 78;
            // 
            // AllergiesSD
            // 
            this.AllergiesSD.Text = "Allergies";
            // 
            // MedicalNotesSD
            // 
            this.MedicalNotesSD.Text = "Medical Notes";
            this.MedicalNotesSD.Width = 89;
            // 
            // ParentIDFK
            // 
            this.ParentIDFK.Text = "Parent ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(25, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 266);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StudentDetailsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(565, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StudentDetails Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ParentDetailsTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(565, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ParentDetails Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ParentDetailsTable
            // 
            this.ParentDetailsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParentIDPK,
            this.FirstNamePD,
            this.LastNamePD,
            this.ContactDetail1PD,
            this.ContactDetaill2PD,
            this.EmergencyContactPD});
            this.ParentDetailsTable.Location = new System.Drawing.Point(0, 0);
            this.ParentDetailsTable.Name = "ParentDetailsTable";
            this.ParentDetailsTable.Size = new System.Drawing.Size(562, 240);
            this.ParentDetailsTable.TabIndex = 0;
            this.ParentDetailsTable.UseCompatibleStateImageBehavior = false;
            this.ParentDetailsTable.View = System.Windows.Forms.View.Details;
            // 
            // ParentIDPK
            // 
            this.ParentIDPK.Text = "Parent ID";
            // 
            // FirstNamePD
            // 
            this.FirstNamePD.Text = "Firs tName";
            this.FirstNamePD.Width = 73;
            // 
            // LastNamePD
            // 
            this.LastNamePD.Text = "Last Name";
            this.LastNamePD.Width = 72;
            // 
            // ContactDetail1PD
            // 
            this.ContactDetail1PD.Text = "Contact Detail 1";
            this.ContactDetail1PD.Width = 91;
            // 
            // ContactDetaill2PD
            // 
            this.ContactDetaill2PD.Text = "Contact Detail 2";
            this.ContactDetaill2PD.Width = 91;
            // 
            // EmergencyContactPD
            // 
            this.EmergencyContactPD.Text = "Emergency Contact";
            this.EmergencyContactPD.Width = 112;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WorkerDetailsTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "WorkerDetails Table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WorkerDetailsTable
            // 
            this.WorkerDetailsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WorkerID,
            this.FirstNameWD,
            this.LastNameWD,
            this.ContactDetail1WD,
            this.ContactDetail2WD,
            this.EmergencyContactWD,
            this.WorkerUsername,
            this.WorkerPassword});
            this.WorkerDetailsTable.Location = new System.Drawing.Point(6, 6);
            this.WorkerDetailsTable.Name = "WorkerDetailsTable";
            this.WorkerDetailsTable.Size = new System.Drawing.Size(624, 135);
            this.WorkerDetailsTable.TabIndex = 0;
            this.WorkerDetailsTable.UseCompatibleStateImageBehavior = false;
            this.WorkerDetailsTable.View = System.Windows.Forms.View.Details;
            // 
            // WorkerID
            // 
            this.WorkerID.Text = "Worker ID";
            this.WorkerID.Width = 64;
            // 
            // FirstNameWD
            // 
            this.FirstNameWD.Text = "First Name";
            this.FirstNameWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameWD.Width = 71;
            // 
            // LastNameWD
            // 
            this.LastNameWD.Text = "Last Name";
            this.LastNameWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameWD.Width = 70;
            // 
            // ContactDetail1WD
            // 
            this.ContactDetail1WD.Text = "Contact Detail 1";
            this.ContactDetail1WD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContactDetail1WD.Width = 93;
            // 
            // ContactDetail2WD
            // 
            this.ContactDetail2WD.Text = "Contact Detail 2";
            this.ContactDetail2WD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContactDetail2WD.Width = 93;
            // 
            // EmergencyContactWD
            // 
            this.EmergencyContactWD.Text = "Emergency Contact";
            this.EmergencyContactWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmergencyContactWD.Width = 107;
            // 
            // WorkerUsername
            // 
            this.WorkerUsername.Text = "Username";
            this.WorkerUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WorkerPassword
            // 
            this.WorkerPassword.Text = "Password";
            this.WorkerPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 282);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.ListView StudentDetailsTable;
        private System.Windows.Forms.ColumnHeader StudentIDPK;
        private System.Windows.Forms.ColumnHeader FirstNameSD;
        private System.Windows.Forms.ColumnHeader LastNameSD;
        private System.Windows.Forms.ColumnHeader DateofBirthSD;
        private System.Windows.Forms.ColumnHeader AllergiesSD;
        private System.Windows.Forms.ColumnHeader MedicalNotesSD;
        private System.Windows.Forms.ColumnHeader ParentIDFK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ParentDetailsTable;
        private System.Windows.Forms.ColumnHeader ParentIDPK;
        private System.Windows.Forms.ColumnHeader FirstNamePD;
        private System.Windows.Forms.ColumnHeader LastNamePD;
        private System.Windows.Forms.ColumnHeader ContactDetail1PD;
        private System.Windows.Forms.ColumnHeader ContactDetaill2PD;
        private System.Windows.Forms.ColumnHeader EmergencyContactPD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView WorkerDetailsTable;
        private System.Windows.Forms.ColumnHeader WorkerID;
        private System.Windows.Forms.ColumnHeader FirstNameWD;
        private System.Windows.Forms.ColumnHeader LastNameWD;
        private System.Windows.Forms.ColumnHeader ContactDetail1WD;
        private System.Windows.Forms.ColumnHeader ContactDetail2WD;
        private System.Windows.Forms.ColumnHeader EmergencyContactWD;
        private System.Windows.Forms.ColumnHeader WorkerUsername;
        private System.Windows.Forms.ColumnHeader WorkerPassword;
    }

    internal class Database1DataSet : OutOfSchoolClubDatabase.Database1DataSet
    {
    }
}

