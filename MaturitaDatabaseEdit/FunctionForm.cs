using System;
using System.Windows.Forms;

namespace MaturitaDatabaseEdit
{
    public partial class FunctionForm : Form
    {
        private BikeRepository _repository = new BikeRepository();

        public FunctionForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Insert();
        }

        public void Insert()
        {
            Bike bike = new Bike();

            bike.Name = this.NameTextBox.Text;
            bike.Power = int.Parse(this.PowerTextBox.Text);

            this._repository.Insert(bike);
        }
    }
}
