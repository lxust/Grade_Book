

namespace Grade_Book
{
    public partial class Form1 : Form
    {
        List<Teacher> teachers = new List<Teacher>();
        Teacher? courentTeacher = null;
        public Form1()
        {
            InitializeComponent();
            AccessFields(true, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            courentTeacher = null;
            AccessFields(true, false);
            lblName1.Text = "";
            lblSurname.Text = "";
            lblObject.Text = "";
            dgvPuple.Rows.Clear();
        }

        private void dgvPuple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTeacher_Click(object sender, EventArgs e)
        {

        }

        private void tbAuthorizationName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void lblRegisterSurname_Click(object sender, EventArgs e)
        {

        }

        private void lblShowClass_Click(object sender, EventArgs e)
        {

        }

        private void tbRegisterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            string login = tbAuthorizationLogin.Text;
            string password = tbAuthorizationPassword.Text;

            var teacher = teachers.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (teacher != null)
            {
                courentTeacher = teacher;
                FillInfo(teacher);
                AccessFields(false, true);
                FillDgv();
            }
                

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = tbRegisterLogin.Text;
            string password = tbRegisterPassword.Text;
            string name = tbRegisterName.Text;
            string surname = tbRegisterSurname.Text;
            string _object = tbRegisterObject.Text;

            Teacher a = new Teacher(name, surname, _object, password, login);
            teachers.Add(a);
            courentTeacher = a;
            FillInfo(a);
            AccessFields(false, true);
            FillDgv();
        }

        private void btnAddPuple_Click(object sender, EventArgs e)
        {
            string name = tbAddPupleName.Text;
            string surname = tbAddPupleSurname.Text;
            string _class = tbAddPupleClass.Text;
            int _age = Convert.ToInt32(tbAddPupleAge.Text);
            courentTeacher.Puples.Add(new Puple(name, surname, _age, _class));
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            string name = tbAddGradeName.Text;
            string surname = tbAddGradeSurname.Text;
            string _class = tbAddGradeClass.Text;
            int grade = Convert.ToInt32(tbAddGrade.Text);

            var puple = courentTeacher.Puples.FirstOrDefault(x => x.Name == name && x.Surname == surname && x.Class == _class);
            if (puple != null)
            {
                if (grade < 6 && grade > 1)
                    puple.Grades.Add(grade);
            }
            

        }

        private void FillInfo(Teacher teacher)
        {
            lblName1.Text = teacher.Name;
            lblSurname.Text = teacher.Surname;
            lblObject.Text = teacher.Subject;
        }

        private void AccessFields(bool authForm, bool workspace)
        {
            
            btnExit.Enabled = workspace;
            btnShow.Enabled = workspace;
            btnAddPuple.Enabled = workspace;
            btnAddGrade.Enabled = workspace;
            tbAddGradeName.Enabled = workspace;
            tbAddGradeClass.Enabled = workspace;
            tbAddGradeSurname.Enabled = workspace;
            tbAddGrade.Enabled = workspace;
            tbAddPupleAge.Enabled = workspace;
            tbAddPupleClass.Enabled = workspace;
            tbAddPupleName.Enabled = workspace;
            tbAddPupleSurname.Enabled = workspace;

            btnAuthorization.Enabled = authForm;
            tbAuthorizationLogin.Enabled = authForm;
            tbAuthorizationPassword.Enabled = authForm;
            btnRegister.Enabled = authForm;
            tbRegisterLogin.Enabled = authForm;
            tbRegisterName.Enabled = authForm;
            tbRegisterObject.Enabled = authForm;
            tbRegisterPassword.Enabled = authForm;
        }

        private void FillDgv()
        {
            dgvPuple.Rows.Clear();
            foreach (Puple puple in courentTeacher.Puples)
            {
                string grades = "";
                foreach (int grade in puple.Grades)
                {
                    grades += $"{grade} ";
                }

                dgvPuple.Rows.Add(puple.Class, puple.Name, puple.Surname, puple.Age, grades);
            }
        }
        private void FillDgv(string _class)
        {
            dgvPuple.Rows.Clear();
            var puples = courentTeacher.Puples.Where(x => x.Class == _class);
            foreach (Puple puple in puples)
            {
                string grades = "";
                foreach (int grade in puple.Grades)
                {
                    grades += $"{grade} ";
                }

                dgvPuple.Rows.Add(puple.Class, puple.Name, puple.Surname, puple.Age, grades);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string b = textBox1.Text;
            if (String.IsNullOrEmpty(b))
                FillDgv();
            else
                FillDgv(textBox1.Text);
        }
    }
}