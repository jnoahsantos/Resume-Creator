
namespace Resume
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cpnLabel = new System.Windows.Forms.Label();
            this.llnLabel = new System.Windows.Forms.Label();
            this.emailaLabel = new System.Windows.Forms.Label();
            this.cpNumber = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.llNumber = new System.Windows.Forms.TextBox();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.educTitleLabel = new System.Windows.Forms.Label();
            this.highSchoolTitleLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.hsLabel = new System.Windows.Forms.Label();
            this.yrhsEnd = new System.Windows.Forms.Label();
            this.hsName = new System.Windows.Forms.TextBox();
            this.yGHS = new System.Windows.Forms.TextBox();
            this.collegeTitleLabel = new System.Windows.Forms.Label();
            this.yearClgGraduated = new System.Windows.Forms.TextBox();
            this.clgUnivName = new System.Windows.Forms.TextBox();
            this.yrClgGraduatedLabel = new System.Windows.Forms.Label();
            this.clgName = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.skillLabel = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.TextBox();
            this.workingExperienceLabel = new System.Windows.Forms.Label();
            this.summaryLabeel = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.TextBox();
            this.loadJsonButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.workExperience = new System.Windows.Forms.DataGridView();
            this.jobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredWorkExperience = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.GenerateJSON = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reset = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fNameLabel.Location = new System.Drawing.Point(49, 126);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(80, 19);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(41, 190);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(88, 19);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Full Address:";
            // 
            // cpnLabel
            // 
            this.cpnLabel.AutoSize = true;
            this.cpnLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpnLabel.Location = new System.Drawing.Point(15, 222);
            this.cpnLabel.Name = "cpnLabel";
            this.cpnLabel.Size = new System.Drawing.Size(114, 19);
            this.cpnLabel.TabIndex = 2;
            this.cpnLabel.Text = "Contact Number:";
            // 
            // llnLabel
            // 
            this.llnLabel.AutoSize = true;
            this.llnLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llnLabel.Location = new System.Drawing.Point(62, 254);
            this.llnLabel.Name = "llnLabel";
            this.llnLabel.Size = new System.Drawing.Size(67, 19);
            this.llnLabel.TabIndex = 3;
            this.llnLabel.Text = "Landline :";
            // 
            // emailaLabel
            // 
            this.emailaLabel.AutoSize = true;
            this.emailaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailaLabel.Location = new System.Drawing.Point(30, 286);
            this.emailaLabel.Name = "emailaLabel";
            this.emailaLabel.Size = new System.Drawing.Size(99, 19);
            this.emailaLabel.TabIndex = 4;
            this.emailaLabel.Text = "Email Address:";
            // 
            // cpNumber
            // 
            this.cpNumber.BackColor = System.Drawing.Color.LavenderBlush;
            this.cpNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpNumber.Location = new System.Drawing.Point(131, 215);
            this.cpNumber.Name = "cpNumber";
            this.cpNumber.Size = new System.Drawing.Size(593, 26);
            this.cpNumber.TabIndex = 4;
            this.cpNumber.Click += new System.EventHandler(this.cpNumber_Click);
            this.cpNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpNumber_KeyPress);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.LavenderBlush;
            this.address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(131, 183);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(593, 26);
            this.address.TabIndex = 3;
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // fName
            // 
            this.fName.BackColor = System.Drawing.Color.LavenderBlush;
            this.fName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fName.Location = new System.Drawing.Point(131, 119);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(593, 26);
            this.fName.TabIndex = 1;
            this.fName.Click += new System.EventHandler(this.fName_Click);
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // llNumber
            // 
            this.llNumber.BackColor = System.Drawing.Color.LavenderBlush;
            this.llNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llNumber.Location = new System.Drawing.Point(131, 247);
            this.llNumber.Name = "llNumber";
            this.llNumber.Size = new System.Drawing.Size(593, 26);
            this.llNumber.TabIndex = 5;
            this.llNumber.Click += new System.EventHandler(this.llNumber_Click);
            this.llNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.llNumber_KeyPress);
            // 
            // emailAddress
            // 
            this.emailAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.emailAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailAddress.Location = new System.Drawing.Point(131, 279);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(593, 26);
            this.emailAddress.TabIndex = 6;
            this.emailAddress.Click += new System.EventHandler(this.emailAddress_Click);
            // 
            // educTitleLabel
            // 
            this.educTitleLabel.AutoSize = true;
            this.educTitleLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.educTitleLabel.Location = new System.Drawing.Point(223, 335);
            this.educTitleLabel.Name = "educTitleLabel";
            this.educTitleLabel.Size = new System.Drawing.Size(313, 24);
            this.educTitleLabel.TabIndex = 6;
            this.educTitleLabel.Text = "EDUCATIONAL ATTAINMENT";
            // 
            // highSchoolTitleLabel
            // 
            this.highSchoolTitleLabel.AutoSize = true;
            this.highSchoolTitleLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highSchoolTitleLabel.Location = new System.Drawing.Point(19, 366);
            this.highSchoolTitleLabel.Name = "highSchoolTitleLabel";
            this.highSchoolTitleLabel.Size = new System.Drawing.Size(100, 19);
            this.highSchoolTitleLabel.TabIndex = 7;
            this.highSchoolTitleLabel.Text = "High School";
            this.highSchoolTitleLabel.Click += new System.EventHandler(this.highSchoolTitleLabel_Click);
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNameLabel.Location = new System.Drawing.Point(50, 158);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(79, 19);
            this.lNameLabel.TabIndex = 8;
            this.lNameLabel.Text = "Last Name:";
            // 
            // lName
            // 
            this.lName.BackColor = System.Drawing.Color.LavenderBlush;
            this.lName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(131, 151);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(593, 26);
            this.lName.TabIndex = 2;
            this.lName.Click += new System.EventHandler(this.lName_Click);
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // hsLabel
            // 
            this.hsLabel.AutoSize = true;
            this.hsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hsLabel.Location = new System.Drawing.Point(34, 396);
            this.hsLabel.Name = "hsLabel";
            this.hsLabel.Size = new System.Drawing.Size(95, 19);
            this.hsLabel.TabIndex = 10;
            this.hsLabel.Text = "School Name:";
            // 
            // yrhsEnd
            // 
            this.yrhsEnd.AutoSize = true;
            this.yrhsEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yrhsEnd.Location = new System.Drawing.Point(532, 395);
            this.yrhsEnd.Name = "yrhsEnd";
            this.yrhsEnd.Size = new System.Drawing.Size(96, 19);
            this.yrhsEnd.TabIndex = 11;
            this.yrhsEnd.Text = "Yr Graduated:";
            // 
            // hsName
            // 
            this.hsName.BackColor = System.Drawing.Color.LavenderBlush;
            this.hsName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hsName.Location = new System.Drawing.Point(131, 392);
            this.hsName.MaximumSize = new System.Drawing.Size(500, 23);
            this.hsName.Name = "hsName";
            this.hsName.Size = new System.Drawing.Size(399, 26);
            this.hsName.TabIndex = 8;
            this.hsName.Click += new System.EventHandler(this.hsName_Click);
            // 
            // yGHS
            // 
            this.yGHS.BackColor = System.Drawing.Color.LavenderBlush;
            this.yGHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yGHS.Location = new System.Drawing.Point(634, 392);
            this.yGHS.MaximumSize = new System.Drawing.Size(130, 23);
            this.yGHS.Name = "yGHS";
            this.yGHS.PlaceholderText = " (ex: 2015)";
            this.yGHS.Size = new System.Drawing.Size(90, 26);
            this.yGHS.TabIndex = 9;
            this.yGHS.Click += new System.EventHandler(this.yGHS_Click);
            this.yGHS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yGHS_KeyPress);
            // 
            // collegeTitleLabel
            // 
            this.collegeTitleLabel.AutoSize = true;
            this.collegeTitleLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collegeTitleLabel.Location = new System.Drawing.Point(15, 435);
            this.collegeTitleLabel.Name = "collegeTitleLabel";
            this.collegeTitleLabel.Size = new System.Drawing.Size(69, 19);
            this.collegeTitleLabel.TabIndex = 14;
            this.collegeTitleLabel.Text = "Tertiary";
            // 
            // yearClgGraduated
            // 
            this.yearClgGraduated.BackColor = System.Drawing.Color.LavenderBlush;
            this.yearClgGraduated.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearClgGraduated.Location = new System.Drawing.Point(634, 456);
            this.yearClgGraduated.MaximumSize = new System.Drawing.Size(150, 23);
            this.yearClgGraduated.Name = "yearClgGraduated";
            this.yearClgGraduated.PlaceholderText = " (ex: 2022)";
            this.yearClgGraduated.Size = new System.Drawing.Size(86, 26);
            this.yearClgGraduated.TabIndex = 12;
            this.yearClgGraduated.Click += new System.EventHandler(this.yearClgGraduated_Click);
            // 
            // clgUnivName
            // 
            this.clgUnivName.BackColor = System.Drawing.Color.LavenderBlush;
            this.clgUnivName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clgUnivName.Location = new System.Drawing.Point(131, 456);
            this.clgUnivName.MaximumSize = new System.Drawing.Size(500, 23);
            this.clgUnivName.Name = "clgUnivName";
            this.clgUnivName.Size = new System.Drawing.Size(395, 26);
            this.clgUnivName.TabIndex = 10;
            this.clgUnivName.Click += new System.EventHandler(this.clgUnivName_Click);
            // 
            // yrClgGraduatedLabel
            // 
            this.yrClgGraduatedLabel.AutoSize = true;
            this.yrClgGraduatedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yrClgGraduatedLabel.Location = new System.Drawing.Point(532, 460);
            this.yrClgGraduatedLabel.Name = "yrClgGraduatedLabel";
            this.yrClgGraduatedLabel.Size = new System.Drawing.Size(96, 19);
            this.yrClgGraduatedLabel.TabIndex = 16;
            this.yrClgGraduatedLabel.Text = "Yr Graduated:";
            // 
            // clgName
            // 
            this.clgName.AutoSize = true;
            this.clgName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clgName.Location = new System.Drawing.Point(30, 460);
            this.clgName.Name = "clgName";
            this.clgName.Size = new System.Drawing.Size(99, 19);
            this.clgName.TabIndex = 15;
            this.clgName.Text = "College Name:";
            // 
            // summaryLabel
            // 
            this.summaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(1403, 9);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(53, 15);
            this.summaryLabel.TabIndex = 19;
            this.summaryLabel.Text = "Summary";
            // 
            // textBox7
            // 
            this.textBox7.AcceptsReturn = true;
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(1156, 32);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(305, 180);
            this.textBox7.TabIndex = 20;
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skillLabel.Location = new System.Drawing.Point(85, 526);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(44, 19);
            this.skillLabel.TabIndex = 21;
            this.skillLabel.Text = "Skills:";
            // 
            // skills
            // 
            this.skills.BackColor = System.Drawing.Color.LavenderBlush;
            this.skills.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skills.Location = new System.Drawing.Point(135, 519);
            this.skills.Multiline = true;
            this.skills.Name = "skills";
            this.skills.PlaceholderText = "Seperate each by comma (ex: Computer Technician, Computer Programming such as C#," +
    " etc)";
            this.skills.Size = new System.Drawing.Size(589, 52);
            this.skills.TabIndex = 13;
            // 
            // workingExperienceLabel
            // 
            this.workingExperienceLabel.AutoSize = true;
            this.workingExperienceLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workingExperienceLabel.Location = new System.Drawing.Point(244, 595);
            this.workingExperienceLabel.Name = "workingExperienceLabel";
            this.workingExperienceLabel.Size = new System.Drawing.Size(267, 24);
            this.workingExperienceLabel.TabIndex = 23;
            this.workingExperienceLabel.Text = "WORKING EXPERIENCE";
            // 
            // summaryLabeel
            // 
            this.summaryLabeel.AutoSize = true;
            this.summaryLabeel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summaryLabeel.Location = new System.Drawing.Point(60, 770);
            this.summaryLabeel.Name = "summaryLabeel";
            this.summaryLabeel.Size = new System.Drawing.Size(69, 19);
            this.summaryLabeel.TabIndex = 36;
            this.summaryLabeel.Text = "Summary:";
            // 
            // summary
            // 
            this.summary.AcceptsReturn = true;
            this.summary.BackColor = System.Drawing.Color.LavenderBlush;
            this.summary.Location = new System.Drawing.Point(141, 770);
            this.summary.Multiline = true;
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(583, 49);
            this.summary.TabIndex = 7;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // loadJsonButton
            // 
            this.loadJsonButton.BackColor = System.Drawing.Color.Plum;
            this.loadJsonButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadJsonButton.Location = new System.Drawing.Point(634, 12);
            this.loadJsonButton.Name = "loadJsonButton";
            this.loadJsonButton.Size = new System.Drawing.Size(86, 35);
            this.loadJsonButton.TabIndex = 38;
            this.loadJsonButton.Text = "Load JSON";
            this.loadJsonButton.UseVisualStyleBackColor = false;
            this.loadJsonButton.Click += new System.EventHandler(this.loadJsonButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.BackColor = System.Drawing.Color.Plum;
            this.pdfButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pdfButton.Location = new System.Drawing.Point(11, 825);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(140, 35);
            this.pdfButton.TabIndex = 39;
            this.pdfButton.Text = "Generate PDF";
            this.pdfButton.UseVisualStyleBackColor = false;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // workExperience
            // 
            this.workExperience.BackgroundColor = System.Drawing.Color.Thistle;
            this.workExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workExperience.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobTitle,
            this.companyName,
            this.jobDuration});
            this.workExperience.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.workExperience.Location = new System.Drawing.Point(11, 628);
            this.workExperience.Name = "workExperience";
            this.workExperience.RowTemplate.Height = 25;
            this.workExperience.Size = new System.Drawing.Size(709, 125);
            this.workExperience.TabIndex = 40;
            this.workExperience.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workExperience_CellClick);
            // 
            // jobTitle
            // 
            this.jobTitle.HeaderText = "Job Title";
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Width = 225;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.Width = 230;
            // 
            // jobDuration
            // 
            this.jobDuration.HeaderText = "Job Duration";
            this.jobDuration.Name = "jobDuration";
            this.jobDuration.Width = 210;
            // 
            // requiredWorkExperience
            // 
            this.requiredWorkExperience.AutoSize = true;
            this.requiredWorkExperience.ForeColor = System.Drawing.Color.Red;
            this.requiredWorkExperience.Location = new System.Drawing.Point(15, 476);
            this.requiredWorkExperience.Name = "requiredWorkExperience";
            this.requiredWorkExperience.Size = new System.Drawing.Size(0, 15);
            this.requiredWorkExperience.TabIndex = 41;
            this.requiredWorkExperience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.LavenderBlush;
            this.course.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.course.Location = new System.Drawing.Point(131, 485);
            this.course.MaximumSize = new System.Drawing.Size(280, 23);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(280, 26);
            this.course.TabIndex = 11;
            this.course.Click += new System.EventHandler(this.course_Click);
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseLabel.Location = new System.Drawing.Point(73, 489);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(56, 19);
            this.courseLabel.TabIndex = 43;
            this.courseLabel.Text = "Course:";
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.ForeColor = System.Drawing.Color.Red;
            this.update.Location = new System.Drawing.Point(9, 673);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(0, 15);
            this.update.TabIndex = 44;
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.update_MouseDown);
            // 
            // GenerateJSON
            // 
            this.GenerateJSON.BackColor = System.Drawing.Color.Plum;
            this.GenerateJSON.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateJSON.Location = new System.Drawing.Point(580, 825);
            this.GenerateJSON.Name = "GenerateJSON";
            this.GenerateJSON.Size = new System.Drawing.Size(140, 35);
            this.GenerateJSON.TabIndex = 45;
            this.GenerateJSON.Text = "Generate JSON";
            this.GenerateJSON.UseVisualStyleBackColor = false;
            this.GenerateJSON.Click += new System.EventHandler(this.GenerateJSON_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Plum;
            this.reset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(634, 46);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(86, 35);
            this.reset.TabIndex = 48;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(17, 92);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(93, 19);
            this.fullNameLabel.TabIndex = 46;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullName.Location = new System.Drawing.Point(137, 92);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(0, 19);
            this.fullName.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "PERSONAL INFORMATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(733, 864);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.GenerateJSON);
            this.Controls.Add(this.update);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.course);
            this.Controls.Add(this.requiredWorkExperience);
            this.Controls.Add(this.workExperience);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.loadJsonButton);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.summaryLabeel);
            this.Controls.Add(this.workingExperienceLabel);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.yearClgGraduated);
            this.Controls.Add(this.clgUnivName);
            this.Controls.Add(this.yrClgGraduatedLabel);
            this.Controls.Add(this.clgName);
            this.Controls.Add(this.collegeTitleLabel);
            this.Controls.Add(this.yGHS);
            this.Controls.Add(this.hsName);
            this.Controls.Add(this.yrhsEnd);
            this.Controls.Add(this.hsLabel);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.highSchoolTitleLabel);
            this.Controls.Add(this.educTitleLabel);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.llNumber);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.address);
            this.Controls.Add(this.cpNumber);
            this.Controls.Add(this.emailaLabel);
            this.Controls.Add(this.llnLabel);
            this.Controls.Add(this.cpnLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.fNameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 1200);
            this.Name = "Form1";
            this.Text = "PDF Resume Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cpnLabel;
        private System.Windows.Forms.Label llnLabel;
        private System.Windows.Forms.Label emailaLabel;
        private System.Windows.Forms.TextBox cpNumber;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox llNumber;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.Label educTitleLabel;
        private System.Windows.Forms.Label highSchoolTitleLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label hsLabel;
        private System.Windows.Forms.Label yrhsEnd;
        private System.Windows.Forms.TextBox hsName;
        private System.Windows.Forms.TextBox yGHS;
        private System.Windows.Forms.Label collegeTitleLabel;
        private System.Windows.Forms.TextBox yearClgGraduated;
        private System.Windows.Forms.TextBox clgUnivName;
        private System.Windows.Forms.Label yrClgGraduatedLabel;
        private System.Windows.Forms.Label clgName;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.TextBox skills;
        private System.Windows.Forms.Label workingExperienceLabel;
        private System.Windows.Forms.Label summaryLabeel;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.Button loadJsonButton;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.DataGridView workExperience;
        private System.Windows.Forms.Label requiredWorkExperience;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Button GenerateJSON;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDuration;
    }
}

