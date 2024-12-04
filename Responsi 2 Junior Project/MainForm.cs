using System.Data;
using System.Windows.Forms;
using Npgsql;
using Responsi_2_Junior_Project;

namespace Responsi_2_Junior_Project
{
    public partial class MainForm : Form
    {
        private readonly EmployeeService _employeeService;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            var dbContext = new DbContext();
            _employeeService = new EmployeeService(dbContext);

            BtnLoad_Click(null, null);
            btnInsert.Enabled = false;
        }

        private async void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = await _employeeService.GetAllEmployeesAsync();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(comboDep.Text))
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var employee = new Employee(
                    txtNama.Text,
                    comboDep.Text,
                    GetDepartmentId(comboDep.Text)
                );

                await _employeeService.AddEmployeeAsync(employee);
                ClearForm();
                BtnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedId = dataGridView1.SelectedRows[0].Cells["id_karyawan"].Value.ToString();
                var employee = new Employee(
                    txtNama.Text,
                    comboDep.Text,
                    GetDepartmentId(comboDep.Text)
                )
                { Id = selectedId };

                await _employeeService.UpdateEmployeeAsync(employee);
                ClearForm();
                BtnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedId = dataGridView1.SelectedRows[0].Cells["id_karyawan"].Value.ToString();
                var result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await _employeeService.DeleteEmployeeAsync(selectedId);
                    ClearForm();
                    BtnLoad_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtNama.Text = row.Cells["nama"].Value.ToString();
                comboDep.Text = GetDepartmentCode(Convert.ToInt32(row.Cells["id_dep"].Value));
            }
        }

        private void TxtNama_TextChanged(object sender, EventArgs e)
        {
            btnInsert.Enabled = !string.IsNullOrEmpty(txtNama.Text);
        }

        private void ComboDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDep.SelectedIndex >= 0)
            {
                MessageBox.Show($"{comboDep.Text} Selected!");
            }
        }

        private void ClearForm()
        {
            txtNama.Clear();
            comboDep.SelectedIndex = -1;
            btnInsert.Enabled = false;
        }

        private int GetDepartmentId(string departmentCode)
        {
            return departmentCode switch
            {
                "HR" => 1,
                "ENG" => 2,
                "DEV" => 3,
                "PM" => 4,
                "FIN" => 5,
                _ => throw new ArgumentException("Invalid department code")
            };
        }

        private string GetDepartmentCode(int departmentId)
        {
            return departmentId switch
            {
                1 => "HR",
                2 => "ENG",
                3 => "DEV",
                4 => "PM",
                5 => "FIN",
                _ => throw new ArgumentException("Invalid department ID")
            };
        }
    }
}