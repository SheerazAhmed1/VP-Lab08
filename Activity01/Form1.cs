using System.Data;

namespace Activity01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            DataTable tableUsername = new DataTable();
            tableUsername.TableName = "Username";

            DataColumn tableUsernameFirstColumn = new DataColumn();
            tableUsernameFirstColumn.ColumnName = "Id";
            tableUsernameFirstColumn.DataType = Type.GetType("System.Int32");

            DataColumn tableUsernameSecondColumn=new DataColumn();
            tableUsernameSecondColumn.ColumnName = "username";
            tableUsernameSecondColumn.DataType = Type.GetType("System.String");

            DataColumn tableusernameThirdColumn=new DataColumn();
            tableusernameThirdColumn.ColumnName = "password";
            tableusernameThirdColumn.DataType = Type.GetType("System.String");


            tableUsername.Columns.Add(tableUsernameFirstColumn);
            tableUsername.Columns.Add(tableUsernameSecondColumn);
            tableUsername.Columns.Add(tableusernameThirdColumn);

            DataRow dr1 = tableUsername.NewRow();
            dr1[0] = 1;
            dr1[1] = "new user";
            dr1[2] = "new password";

            tableUsername.Rows.Add(dr1);
            dataset.Tables.Add(tableUsername);
            this.dataGridView1.DataSource = dataset.Tables["Username"];
        }
    }
}