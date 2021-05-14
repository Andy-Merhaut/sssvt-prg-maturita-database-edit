using System.Windows.Forms;

namespace MaturitaDatabaseEdit
{
    public partial class MainForm : Form
    {
        private BikeRepository _repository = new BikeRepository();

        public MainForm()
        {
            InitializeComponent();
            this.MainDataGridView.DataSource = this._repository.SelectAll();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            FunctionForm functionForm = new FunctionForm();
            functionForm.ShowDialog();
        }
    }
}