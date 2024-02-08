using System.Text.RegularExpressions;
using WinFormsApp.Presenter;

namespace WinFormsApp
{
    public partial class SampleForm : Form
    {
        private readonly ISamplePresenter _presenter;

        public SampleForm(ISamplePresenter presenter)
        {

            InitializeComponent();
            _presenter = presenter;
            LoadData();
        }

        private void LoadData()
        {
            int left = 0;
            List<EFModels.Color> colors = _presenter.GetColors();
            foreach (var color in colors)
            {
                RadioButton rb = new() { Text = color.ColorName, AutoSize = true, Top = 5, Left = left };
                plColor.Controls.Add(rb);
                left += 75;
            }

            grdUsers.DataSource = _presenter.GetUsers();
            grdUsers.CellDoubleClick += GrdUsers_CellDoubleClick;
            grdUsers.Columns["Id"].Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string color = string.Empty;
                foreach (Control control in plColor.Controls)
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        color = control.Text;
                        break;
                    }

                if (string.IsNullOrEmpty(txtName.Text))
                    MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrEmpty(txtEMail.Text))
                    MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!IsValidEmail(txtEMail.Text))
                    MessageBox.Show("Email is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (dpBirthday.Value.Date > DateTime.Now.Date)
                    MessageBox.Show("Birthday cannot be a future date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrEmpty(color))
                    MessageBox.Show("Color is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    EFModels.User user = new()
                    {
                        UserId = 0,
                        UserName = txtName.Text,
                        Email = txtEMail.Text,
                        BirthDay = DateOnly.FromDateTime(dpBirthday.Value),
                        ColorId = _presenter.GetColors().FirstOrDefault(x => x.ColorName == color).ColorId,
                        Married = cbMarried.Checked
                    };

                    //long? result = _presenter.InsertUser(user);
                    //if (result.HasValue)
                    //{
                        _presenter.InsertUser(user);
                        MessageBox.Show("User added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grdUsers.DataSource = _presenter.GetUsers();
                        txtName.Text = string.Empty;
                        txtEMail.Text = string.Empty;
                        dpBirthday.ResetText();
                        cbMarried.Checked = false;
                        foreach (Control control in plColor.Controls)
                            if (control is RadioButton radioButton && radioButton.Checked)
                            {
                                radioButton.Checked = false;
                                break;
                            }
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new(pattern);
            return regex.IsMatch(email);
        }

        private void GrdUsers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long id = (long)grdUsers.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    //long? result = _presenter.DeleteUser(id);
                    //if (result.HasValue)
                    //{
                        _presenter.DeleteUser(id);
                        MessageBox.Show("User deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grdUsers.DataSource = _presenter.GetUsers();
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
