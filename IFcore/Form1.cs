using EFCoreTutorial.Model;

namespace IFcore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //B1: lấy dữ liệu
            StudentDB db = new StudentDB();
            var ls = db.Classrooms//Where(e=>e.Name.Contains("A") || e.Name.Contains("B") 
            //)
            .ToList();
            //B1 đẩy dữ liệu lên giao diện
            cbbLopHoc.DataSource = ls;
            cbbLopHoc.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}