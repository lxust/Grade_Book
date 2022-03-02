namespace Grade_Book
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
            this.dgvPuple = new System.Windows.Forms.DataGridView();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherSurname = new System.Windows.Forms.Label();
            this.lblTeacherObject = new System.Windows.Forms.Label();
            this.lblAuthorization = new System.Windows.Forms.Label();
            this.tbAuthorizationLogin = new System.Windows.Forms.TextBox();
            this.lblAuthorizationLogin = new System.Windows.Forms.Label();
            this.lblAuthorizationPassword = new System.Windows.Forms.Label();
            this.tbAuthorizationPassword = new System.Windows.Forms.TextBox();
            this.btnAuthorization = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblRegisterLogin = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterName = new System.Windows.Forms.Label();
            this.lblRegisterSurname = new System.Windows.Forms.Label();
            this.lblRegisterObject = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblShowClass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbRegisterLogin = new System.Windows.Forms.TextBox();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.tbRegisterSurname = new System.Windows.Forms.TextBox();
            this.tbRegisterObject = new System.Windows.Forms.TextBox();
            this.lblAddPuple = new System.Windows.Forms.Label();
            this.lblAddPupleName = new System.Windows.Forms.Label();
            this.lblAddPupleSurname = new System.Windows.Forms.Label();
            this.lblAddPupleClass = new System.Windows.Forms.Label();
            this.lblAddPupleAge = new System.Windows.Forms.Label();
            this.btnAddPuple = new System.Windows.Forms.Button();
            this.tbAddPupleName = new System.Windows.Forms.TextBox();
            this.tbAddPupleSurname = new System.Windows.Forms.TextBox();
            this.tbAddPupleClass = new System.Windows.Forms.TextBox();
            this.tbAddPupleAge = new System.Windows.Forms.TextBox();
            this.lblAddGrades = new System.Windows.Forms.Label();
            this.lblAddGradeName = new System.Windows.Forms.Label();
            this.tbAddGradeSurname = new System.Windows.Forms.TextBox();
            this.lblAddGradeSurname = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbAddGradeName = new System.Windows.Forms.TextBox();
            this.lblAddGradeClass = new System.Windows.Forms.Label();
            this.tbAddGradeClass = new System.Windows.Forms.TextBox();
            this.lblAddGrade = new System.Windows.Forms.Label();
            this.tbAddGrade = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.btnTop = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuple)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuple
            // 
            this.dgvPuple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Name,
            this.Surname,
            this.Age,
            this.lblName});
            this.dgvPuple.Location = new System.Drawing.Point(180, 38);
            this.dgvPuple.Name = "dgvPuple";
            this.dgvPuple.RowTemplate.Height = 25;
            this.dgvPuple.Size = new System.Drawing.Size(543, 128);
            this.dgvPuple.TabIndex = 0;
            this.dgvPuple.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuple_CellContentClick);
            // 
            // Class
            // 
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            // 
            // lblName
            // 
            this.lblName.HeaderText = "Оценки";
            this.lblName.Name = "lblName";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(666, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblTeacher.Location = new System.Drawing.Point(36, 12);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(52, 15);
            this.lblTeacher.TabIndex = 2;
            this.lblTeacher.Text = "Учитель";
            this.lblTeacher.Click += new System.EventHandler(this.lblTeacher_Click);
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(12, 33);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(37, 15);
            this.lblTeacherName.TabIndex = 3;
            this.lblTeacherName.Text = "Имя: ";
            this.lblTeacherName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTeacherSurname
            // 
            this.lblTeacherSurname.AutoSize = true;
            this.lblTeacherSurname.Location = new System.Drawing.Point(12, 48);
            this.lblTeacherSurname.Name = "lblTeacherSurname";
            this.lblTeacherSurname.Size = new System.Drawing.Size(64, 15);
            this.lblTeacherSurname.TabIndex = 4;
            this.lblTeacherSurname.Text = "Фамилия: ";
            // 
            // lblTeacherObject
            // 
            this.lblTeacherObject.AutoSize = true;
            this.lblTeacherObject.Location = new System.Drawing.Point(12, 63);
            this.lblTeacherObject.Name = "lblTeacherObject";
            this.lblTeacherObject.Size = new System.Drawing.Size(61, 15);
            this.lblTeacherObject.TabIndex = 5;
            this.lblTeacherObject.Text = "Предмет: ";
            // 
            // lblAuthorization
            // 
            this.lblAuthorization.AutoSize = true;
            this.lblAuthorization.Location = new System.Drawing.Point(36, 91);
            this.lblAuthorization.Name = "lblAuthorization";
            this.lblAuthorization.Size = new System.Drawing.Size(78, 15);
            this.lblAuthorization.TabIndex = 6;
            this.lblAuthorization.Text = "Авторизация";
            // 
            // tbAuthorizationLogin
            // 
            this.tbAuthorizationLogin.Location = new System.Drawing.Point(65, 109);
            this.tbAuthorizationLogin.Name = "tbAuthorizationLogin";
            this.tbAuthorizationLogin.Size = new System.Drawing.Size(100, 23);
            this.tbAuthorizationLogin.TabIndex = 7;
            this.tbAuthorizationLogin.TextChanged += new System.EventHandler(this.tbAuthorizationName_TextChanged);
            // 
            // lblAuthorizationLogin
            // 
            this.lblAuthorizationLogin.AutoSize = true;
            this.lblAuthorizationLogin.Location = new System.Drawing.Point(12, 112);
            this.lblAuthorizationLogin.Name = "lblAuthorizationLogin";
            this.lblAuthorizationLogin.Size = new System.Drawing.Size(47, 15);
            this.lblAuthorizationLogin.TabIndex = 8;
            this.lblAuthorizationLogin.Text = "Логин: ";
            // 
            // lblAuthorizationPassword
            // 
            this.lblAuthorizationPassword.AutoSize = true;
            this.lblAuthorizationPassword.Location = new System.Drawing.Point(12, 142);
            this.lblAuthorizationPassword.Name = "lblAuthorizationPassword";
            this.lblAuthorizationPassword.Size = new System.Drawing.Size(55, 15);
            this.lblAuthorizationPassword.TabIndex = 9;
            this.lblAuthorizationPassword.Text = "Пароль: ";
            // 
            // tbAuthorizationPassword
            // 
            this.tbAuthorizationPassword.Location = new System.Drawing.Point(65, 139);
            this.tbAuthorizationPassword.Name = "tbAuthorizationPassword";
            this.tbAuthorizationPassword.Size = new System.Drawing.Size(100, 23);
            this.tbAuthorizationPassword.TabIndex = 10;
            // 
            // btnAuthorization
            // 
            this.btnAuthorization.Location = new System.Drawing.Point(90, 168);
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorization.TabIndex = 11;
            this.btnAuthorization.Text = "Войти";
            this.btnAuthorization.UseVisualStyleBackColor = true;
            this.btnAuthorization.Click += new System.EventHandler(this.btnAuthorization_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(36, 206);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(76, 15);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.Text = "Регистрация";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblRegisterLogin
            // 
            this.lblRegisterLogin.AutoSize = true;
            this.lblRegisterLogin.Location = new System.Drawing.Point(12, 230);
            this.lblRegisterLogin.Name = "lblRegisterLogin";
            this.lblRegisterLogin.Size = new System.Drawing.Size(47, 15);
            this.lblRegisterLogin.TabIndex = 13;
            this.lblRegisterLogin.Text = "Логин: ";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(12, 256);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(55, 15);
            this.lblRegisterPassword.TabIndex = 14;
            this.lblRegisterPassword.Text = "Пароль: ";
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.AutoSize = true;
            this.lblRegisterName.Location = new System.Drawing.Point(12, 285);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(37, 15);
            this.lblRegisterName.TabIndex = 15;
            this.lblRegisterName.Text = "Имя: ";
            // 
            // lblRegisterSurname
            // 
            this.lblRegisterSurname.AutoSize = true;
            this.lblRegisterSurname.Location = new System.Drawing.Point(9, 311);
            this.lblRegisterSurname.Name = "lblRegisterSurname";
            this.lblRegisterSurname.Size = new System.Drawing.Size(64, 15);
            this.lblRegisterSurname.TabIndex = 16;
            this.lblRegisterSurname.Text = "Фамилия: ";
            this.lblRegisterSurname.Click += new System.EventHandler(this.lblRegisterSurname_Click);
            // 
            // lblRegisterObject
            // 
            this.lblRegisterObject.AutoSize = true;
            this.lblRegisterObject.Location = new System.Drawing.Point(9, 335);
            this.lblRegisterObject.Name = "lblRegisterObject";
            this.lblRegisterObject.Size = new System.Drawing.Size(61, 15);
            this.lblRegisterObject.TabIndex = 17;
            this.lblRegisterObject.Text = "Предмет: ";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(648, 172);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblShowClass
            // 
            this.lblShowClass.AutoSize = true;
            this.lblShowClass.Location = new System.Drawing.Point(551, 176);
            this.lblShowClass.Name = "lblShowClass";
            this.lblShowClass.Size = new System.Drawing.Size(45, 15);
            this.lblShowClass.TabIndex = 19;
            this.lblShowClass.Text = "Класс: ";
            this.lblShowClass.Click += new System.EventHandler(this.lblShowClass_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(602, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 23);
            this.textBox1.TabIndex = 20;
            // 
            // tbRegisterLogin
            // 
            this.tbRegisterLogin.Location = new System.Drawing.Point(73, 227);
            this.tbRegisterLogin.Name = "tbRegisterLogin";
            this.tbRegisterLogin.Size = new System.Drawing.Size(100, 23);
            this.tbRegisterLogin.TabIndex = 21;
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.Location = new System.Drawing.Point(73, 253);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.Size = new System.Drawing.Size(100, 23);
            this.tbRegisterPassword.TabIndex = 22;
            this.tbRegisterPassword.TextChanged += new System.EventHandler(this.tbRegisterPassword_TextChanged);
            // 
            // tbRegisterName
            // 
            this.tbRegisterName.Location = new System.Drawing.Point(73, 282);
            this.tbRegisterName.Name = "tbRegisterName";
            this.tbRegisterName.Size = new System.Drawing.Size(100, 23);
            this.tbRegisterName.TabIndex = 23;
            // 
            // tbRegisterSurname
            // 
            this.tbRegisterSurname.Location = new System.Drawing.Point(73, 308);
            this.tbRegisterSurname.Name = "tbRegisterSurname";
            this.tbRegisterSurname.Size = new System.Drawing.Size(100, 23);
            this.tbRegisterSurname.TabIndex = 24;
            // 
            // tbRegisterObject
            // 
            this.tbRegisterObject.Location = new System.Drawing.Point(73, 335);
            this.tbRegisterObject.Name = "tbRegisterObject";
            this.tbRegisterObject.Size = new System.Drawing.Size(100, 23);
            this.tbRegisterObject.TabIndex = 25;
            // 
            // lblAddPuple
            // 
            this.lblAddPuple.AutoSize = true;
            this.lblAddPuple.Location = new System.Drawing.Point(260, 206);
            this.lblAddPuple.Name = "lblAddPuple";
            this.lblAddPuple.Size = new System.Drawing.Size(107, 15);
            this.lblAddPuple.TabIndex = 26;
            this.lblAddPuple.Text = "Добавить ученика";
            // 
            // lblAddPupleName
            // 
            this.lblAddPupleName.AutoSize = true;
            this.lblAddPupleName.Location = new System.Drawing.Point(229, 238);
            this.lblAddPupleName.Name = "lblAddPupleName";
            this.lblAddPupleName.Size = new System.Drawing.Size(37, 15);
            this.lblAddPupleName.TabIndex = 27;
            this.lblAddPupleName.Text = "Имя: ";
            // 
            // lblAddPupleSurname
            // 
            this.lblAddPupleSurname.AutoSize = true;
            this.lblAddPupleSurname.Location = new System.Drawing.Point(229, 267);
            this.lblAddPupleSurname.Name = "lblAddPupleSurname";
            this.lblAddPupleSurname.Size = new System.Drawing.Size(64, 15);
            this.lblAddPupleSurname.TabIndex = 28;
            this.lblAddPupleSurname.Text = "Фамилия: ";
            // 
            // lblAddPupleClass
            // 
            this.lblAddPupleClass.AutoSize = true;
            this.lblAddPupleClass.Location = new System.Drawing.Point(229, 302);
            this.lblAddPupleClass.Name = "lblAddPupleClass";
            this.lblAddPupleClass.Size = new System.Drawing.Size(45, 15);
            this.lblAddPupleClass.TabIndex = 29;
            this.lblAddPupleClass.Text = "Класс: ";
            // 
            // lblAddPupleAge
            // 
            this.lblAddPupleAge.AutoSize = true;
            this.lblAddPupleAge.Location = new System.Drawing.Point(229, 331);
            this.lblAddPupleAge.Name = "lblAddPupleAge";
            this.lblAddPupleAge.Size = new System.Drawing.Size(56, 15);
            this.lblAddPupleAge.TabIndex = 30;
            this.lblAddPupleAge.Text = "Возраст: ";
            // 
            // btnAddPuple
            // 
            this.btnAddPuple.Location = new System.Drawing.Point(316, 357);
            this.btnAddPuple.Name = "btnAddPuple";
            this.btnAddPuple.Size = new System.Drawing.Size(75, 23);
            this.btnAddPuple.TabIndex = 31;
            this.btnAddPuple.Text = "Добавить";
            this.btnAddPuple.UseVisualStyleBackColor = true;
            this.btnAddPuple.Click += new System.EventHandler(this.btnAddPuple_Click);
            // 
            // tbAddPupleName
            // 
            this.tbAddPupleName.Location = new System.Drawing.Point(291, 235);
            this.tbAddPupleName.Name = "tbAddPupleName";
            this.tbAddPupleName.Size = new System.Drawing.Size(100, 23);
            this.tbAddPupleName.TabIndex = 32;
            // 
            // tbAddPupleSurname
            // 
            this.tbAddPupleSurname.Location = new System.Drawing.Point(291, 264);
            this.tbAddPupleSurname.Name = "tbAddPupleSurname";
            this.tbAddPupleSurname.Size = new System.Drawing.Size(100, 23);
            this.tbAddPupleSurname.TabIndex = 33;
            // 
            // tbAddPupleClass
            // 
            this.tbAddPupleClass.Location = new System.Drawing.Point(291, 299);
            this.tbAddPupleClass.Name = "tbAddPupleClass";
            this.tbAddPupleClass.Size = new System.Drawing.Size(100, 23);
            this.tbAddPupleClass.TabIndex = 34;
            // 
            // tbAddPupleAge
            // 
            this.tbAddPupleAge.Location = new System.Drawing.Point(291, 328);
            this.tbAddPupleAge.Name = "tbAddPupleAge";
            this.tbAddPupleAge.Size = new System.Drawing.Size(100, 23);
            this.tbAddPupleAge.TabIndex = 35;
            // 
            // lblAddGrades
            // 
            this.lblAddGrades.AutoSize = true;
            this.lblAddGrades.Location = new System.Drawing.Point(477, 208);
            this.lblAddGrades.Name = "lblAddGrades";
            this.lblAddGrades.Size = new System.Drawing.Size(101, 15);
            this.lblAddGrades.TabIndex = 36;
            this.lblAddGrades.Text = "Добавить оценку";
            // 
            // lblAddGradeName
            // 
            this.lblAddGradeName.AutoSize = true;
            this.lblAddGradeName.Location = new System.Drawing.Point(455, 244);
            this.lblAddGradeName.Name = "lblAddGradeName";
            this.lblAddGradeName.Size = new System.Drawing.Size(37, 15);
            this.lblAddGradeName.TabIndex = 37;
            this.lblAddGradeName.Text = "Имя: ";
            // 
            // tbAddGradeSurname
            // 
            this.tbAddGradeSurname.Location = new System.Drawing.Point(525, 264);
            this.tbAddGradeSurname.Name = "tbAddGradeSurname";
            this.tbAddGradeSurname.Size = new System.Drawing.Size(100, 23);
            this.tbAddGradeSurname.TabIndex = 38;
            // 
            // lblAddGradeSurname
            // 
            this.lblAddGradeSurname.AutoSize = true;
            this.lblAddGradeSurname.Location = new System.Drawing.Point(455, 272);
            this.lblAddGradeSurname.Name = "lblAddGradeSurname";
            this.lblAddGradeSurname.Size = new System.Drawing.Size(64, 15);
            this.lblAddGradeSurname.TabIndex = 39;
            this.lblAddGradeSurname.Text = "Фамилия: ";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(46, 364);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 23);
            this.btnRegister.TabIndex = 40;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbAddGradeName
            // 
            this.tbAddGradeName.Location = new System.Drawing.Point(525, 236);
            this.tbAddGradeName.Name = "tbAddGradeName";
            this.tbAddGradeName.Size = new System.Drawing.Size(100, 23);
            this.tbAddGradeName.TabIndex = 41;
            // 
            // lblAddGradeClass
            // 
            this.lblAddGradeClass.AutoSize = true;
            this.lblAddGradeClass.Location = new System.Drawing.Point(455, 302);
            this.lblAddGradeClass.Name = "lblAddGradeClass";
            this.lblAddGradeClass.Size = new System.Drawing.Size(45, 15);
            this.lblAddGradeClass.TabIndex = 42;
            this.lblAddGradeClass.Text = "Класс: ";
            // 
            // tbAddGradeClass
            // 
            this.tbAddGradeClass.Location = new System.Drawing.Point(525, 299);
            this.tbAddGradeClass.Name = "tbAddGradeClass";
            this.tbAddGradeClass.Size = new System.Drawing.Size(100, 23);
            this.tbAddGradeClass.TabIndex = 43;
            // 
            // lblAddGrade
            // 
            this.lblAddGrade.AutoSize = true;
            this.lblAddGrade.Location = new System.Drawing.Point(455, 331);
            this.lblAddGrade.Name = "lblAddGrade";
            this.lblAddGrade.Size = new System.Drawing.Size(54, 15);
            this.lblAddGrade.TabIndex = 44;
            this.lblAddGrade.Text = "Оценка: ";
            // 
            // tbAddGrade
            // 
            this.tbAddGrade.Location = new System.Drawing.Point(525, 328);
            this.tbAddGrade.Name = "tbAddGrade";
            this.tbAddGrade.Size = new System.Drawing.Size(100, 23);
            this.tbAddGrade.TabIndex = 45;
            this.tbAddGrade.TextChanged += new System.EventHandler(this.tbAddGrade_TextChanged);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(551, 357);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrade.TabIndex = 46;
            this.btnAddGrade.Text = "Добавить";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(73, 33);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(0, 15);
            this.lblName1.TabIndex = 47;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(73, 50);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(0, 15);
            this.lblSurname.TabIndex = 48;
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(73, 65);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(0, 15);
            this.lblObject.TabIndex = 49;
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(285, 6);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 23);
            this.btnTop.TabIndex = 50;
            this.btnTop.Text = "Найти";
            this.btnTop.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(180, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(99, 15);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Лучшая оценка: ";
            this.lbl1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 392);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.tbAddGrade);
            this.Controls.Add(this.lblAddGrade);
            this.Controls.Add(this.tbAddGradeClass);
            this.Controls.Add(this.lblAddGradeClass);
            this.Controls.Add(this.tbAddGradeName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblAddGradeSurname);
            this.Controls.Add(this.tbAddGradeSurname);
            this.Controls.Add(this.lblAddGradeName);
            this.Controls.Add(this.lblAddGrades);
            this.Controls.Add(this.tbAddPupleAge);
            this.Controls.Add(this.tbAddPupleClass);
            this.Controls.Add(this.tbAddPupleSurname);
            this.Controls.Add(this.tbAddPupleName);
            this.Controls.Add(this.btnAddPuple);
            this.Controls.Add(this.lblAddPupleAge);
            this.Controls.Add(this.lblAddPupleClass);
            this.Controls.Add(this.lblAddPupleSurname);
            this.Controls.Add(this.lblAddPupleName);
            this.Controls.Add(this.lblAddPuple);
            this.Controls.Add(this.tbRegisterObject);
            this.Controls.Add(this.tbRegisterSurname);
            this.Controls.Add(this.tbRegisterName);
            this.Controls.Add(this.tbRegisterPassword);
            this.Controls.Add(this.tbRegisterLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblShowClass);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblRegisterObject);
            this.Controls.Add(this.lblRegisterSurname);
            this.Controls.Add(this.lblRegisterName);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterLogin);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnAuthorization);
            this.Controls.Add(this.tbAuthorizationPassword);
            this.Controls.Add(this.lblAuthorizationPassword);
            this.Controls.Add(this.lblAuthorizationLogin);
            this.Controls.Add(this.tbAuthorizationLogin);
            this.Controls.Add(this.lblAuthorization);
            this.Controls.Add(this.lblTeacherObject);
            this.Controls.Add(this.lblTeacherSurname);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvPuple);
            //this.Name = "Form1";
            this.Text = "Grade_Book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPuple;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn lblName;
        private Button btnExit;
        private Label lblTeacher;
        private Label lblTeacherName;
        private Label lblTeacherSurname;
        private Label lblTeacherObject;
        private Label lblAuthorization;
        private TextBox tbAuthorizationLogin;
        private Label lblAuthorizationLogin;
        private Label lblAuthorizationPassword;
        private TextBox tbAuthorizationPassword;
        private Button btnAuthorization;
        private Label lblRegister;
        private Label lblRegisterLogin;
        private Label lblRegisterPassword;
        private Label lblRegisterName;
        private Label lblRegisterSurname;
        private Label lblRegisterObject;
        private Button btnShow;
        private Label lblShowClass;
        private TextBox textBox1;
        private TextBox tbRegisterLogin;
        private TextBox tbRegisterPassword;
        private TextBox tbRegisterName;
        private TextBox tbRegisterSurname;
        private TextBox tbRegisterObject;
        private Label lblAddPuple;
        private Label lblAddPupleName;
        private Label lblAddPupleSurname;
        private Label lblAddPupleClass;
        private Label lblAddPupleAge;
        private Button btnAddPuple;
        private TextBox tbAddPupleName;
        private TextBox tbAddPupleSurname;
        private TextBox tbAddPupleClass;
        private TextBox tbAddPupleAge;
        private Label lblAddGrades;
        private Label lblAddGradeName;
        private TextBox tbAddGradeSurname;
        private Label lblAddGradeSurname;
        private Button btnRegister;
        private TextBox tbAddGradeName;
        private Label lblAddGradeClass;
        private TextBox tbAddGradeClass;
        private Label lblAddGrade;
        private TextBox tbAddGrade;
        private Button btnAddGrade;
        private Label lblName1;
        private Label lblSurname;
        private Label lblObject;
        private Button btnTop;
        private Label lbl1;
    }
}