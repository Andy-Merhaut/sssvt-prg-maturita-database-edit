using System;
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

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            DataGridViewRow currentRow = this.MainDataGridView.CurrentRow;

            object id = currentRow.Cells[0].Value;

            Bike bike = this._repository.FindBike(Convert.ToInt32(id));

            this._repository.Delete(bike);

            BikeRepository bikeRepository = new BikeRepository();
            this.MainDataGridView.DataSource = bikeRepository.SelectAll();
        }
    }
}