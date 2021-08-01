using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string strSQL = "select * from 【テーブル】";
            Class1.pDB_Setuzoku(strSQL, ref this.dataGridView1);
        }
    }
}
