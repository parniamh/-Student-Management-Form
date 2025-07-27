using System.Windows.Forms;


namespace تکلیف_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ClsStudent> lststudent = new List<ClsStudent>();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Int64 NewId = Convert.ToInt64(IDtxt.Text);
            bool IsStudentInList = false;
            ClsStudent stu1 = new ClsStudent();
            List<double> lstID = new List<double>();
            if (Fnametxt.Text.Trim() == "" || Lnametxt.Text.Trim() == "" || IDtxt.Text.Trim() == "" || Avetxt.Text.Trim() == "")
            {
                MessageBox.Show("please enter all fields");
            }
            else
            {
                foreach (ClsStudent student in lststudent)
                {
                    if (student.IDnumber == NewId)
                    {
                        IsStudentInList = true;
                    }
                }
                if (IsStudentInList)
                {
                    MessageBox.Show("the student is repetitive");
                }
                else
                {
                    int Count = lststudent.Count;
                    if (lststudent.Count < 10)
                    {
                        stu1.Fname = Fnametxt.Text;
                        stu1.Lname = Lnametxt.Text;
                        stu1.IDnumber = Convert.ToInt64(IDtxt.Text);
                        stu1.Grade = Convert.ToDouble(Avetxt.Text);
                        lststudent.Add(stu1);
                        MessageBox.Show("students is saved");
                        Lnametxt.Text = "";
                        Fnametxt.Text = "";
                        IDtxt.Text = "";
                        Avetxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("list is completed. cant add new student");
                    }
                }

            }
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string l1 = "";
            foreach (ClsStudent stu in lststudent)
                l1 = l1 + "\n" + stu.Fname + " " + stu.Lname + "=" + "ID number:" + " " + stu.IDnumber + "_" + "grade:" + " " + stu.Grade;
            MessageBox.Show(l1);
        }
        private void AveTotalBtn_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (ClsStudent stu in lststudent)
            {
                sum += stu.Grade;
            }
            if (lststudent.Count > 0)
            {
                MessageBox.Show("average of" + lststudent.Count + "student grade:" + sum / lststudent.Count);
            }
            else
            {
                MessageBox.Show("still no student sign up");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
