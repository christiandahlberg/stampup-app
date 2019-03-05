using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_WindowsForms_Client.ServiceReference;


namespace ERP_WindowsForms_Client
{
    public partial class ERP_Client_GUI : Form
    {
        private Controller controller;

        public ERP_Client_GUI()
        {
            controller = new Controller();
            InitializeComponent();

            InitializeDGV();

            SetRelatedTablesComboBoxContent();
            SetMetadataComboBoxContent();

            SetSystemMessage("Welcome to the CRONUS ERP client");
            SetMetaSystemMessage("");
        }


        //------------------------------------------------------------------------------------
        //------------------------------UTIL METHODS------------------------------------------
        //------------------------------------------------------------------------------------

        private void InitializeDGV()
        {
            dgv_Employee.Columns.Add("", "No");
            dgv_Employee.Columns.Add("", "First name");
            dgv_Employee.Columns.Add("", "Last name");
            dgv_Employee.Columns.Add("", "Job title");
            dgv_Employee.Columns.Add("", "Address");
            dgv_Employee.Columns.Add("", "City");
            dgv_Employee.Columns.Add("", "Phone");
            dgv_Employee.Columns.Add("", "Email");
            dgv_Employee.Columns.Add("", "Ssn");

            UpdateDGV();
        }

        private void UpdateDGV()
        {
            dgv_Employee.Rows.Clear();

            foreach (Employee employee in controller.GetEmployees())
            {
                dgv_Employee.Rows.Add(employee.No, employee.FirstName, employee.LastName, employee.JobTitle, employee.Address, employee.City, employee.Phone, employee.Email, employee.SSN);
            }
        }

        // setup combobox with employee related table names
        private void SetRelatedTablesComboBoxContent()
        {
            cb_relatedTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cb_relatedTables.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_relatedTables.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (string name in controller.GetTableNames())
            {
                string tempname = name;
                if (tempname.Length > 17)
                {
                    if (tempname.Substring(0, 18).Equals("CRONUS Sverige AB$"))
                    {
                        tempname = tempname.Substring(18);
                    }
                }

                var comboBoxItem = new ComboBoxItem<string>
                {
                    DisplayMember = tempname,
                    ValueMember = name
                };

                cb_relatedTables.Items.Add(comboBoxItem);
            }
        }

        private void SetMetadataComboBoxContent()
        {
            foreach (string metadataname in new List<string>() { "All keys", "All indexes", "All constraints" })
            {
                cb_metadata.Items.Add(metadataname);
            }

        }


        private void ClearTextBoxes()
        {
            tb_no.Clear();
            tb_firstName.Clear();
            tb_lastName.Clear();
            tb_jobTitle.Clear();
            tb_address.Clear();
            tb_city.Clear();
            tb_phone.Clear();
            tb_email.Clear();
            tb_ssn.Clear();
        }

        private void SetSystemMessage(string message)
        {
            if (message.Contains("ERROR:"))
            {
                lbl_systemMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_systemMessage.ForeColor = System.Drawing.Color.Black;
            }
            lbl_systemMessage.Text = message;
        }

        private void SetMetaSystemMessage(string message)
        {
            if (message.Contains("ERROR:"))
            {
                lbl_relatedMetadataSystemMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_relatedMetadataSystemMessage.ForeColor = System.Drawing.Color.Black;
            }
            lbl_relatedMetadataSystemMessage.Text = message;
        }

        // Fills text boxes with data from the table row that was last klicked
        private void dgv_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_create.Enabled = false;
            btn_create.BackColor = Color.Gray;
            btn_create.ForeColor = Color.White;

            DataGridViewRow row = dgv_Employee.Rows[e.RowIndex];
            ClearTextBoxes();

            tb_no.Text = row.Cells[0].Value.ToString();
            tb_firstName.Text = row.Cells[1].Value.ToString();
            tb_lastName.Text = row.Cells[2].Value.ToString();
            tb_jobTitle.Text = row.Cells[3].Value.ToString();
            tb_address.Text = row.Cells[4].Value.ToString();
            tb_city.Text = row.Cells[5].Value.ToString();
            tb_phone.Text = row.Cells[6].Value.ToString();
            tb_email.Text = row.Cells[7].Value.ToString();
            tb_ssn.Text = row.Cells[8].Value.ToString();

            SetSystemMessage("");
        }

        //------------------------------------------------------------------------------------
        //------------------------------EVENT METHODS-----------------------------------------
        //------------------------------------------------------------------------------------


        //----------------- CRUD, CLEAR TB---------------------------

        // CLEAR
        private void btn_clearFields_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            SetSystemMessage("Fields cleared");
            btn_create.Enabled = true;
            btn_create.BackColor = Color.FromArgb(255,128,0);
        }

        // CREATE
        private void btn_create_Click(object sender, EventArgs e)
        {
            string firstName = tb_firstName.Text;
            string lastName = tb_lastName.Text;
            string jobTitle = tb_jobTitle.Text;
            string address = tb_address.Text;
            string city = tb_city.Text;
            string phone = tb_phone.Text;
            string email = tb_email.Text;
            string ssn = tb_ssn.Text;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(jobTitle) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(ssn))
            {
                SetSystemMessage("ERROR: one or more fields was left empty!");
            }
            else
            {

                // Create new insance of Employee with values equal to textfields
                Employee employee = new Employee()
                {
                    No = tb_no.Text,
                    FirstName = tb_firstName.Text,
                    LastName = tb_lastName.Text,
                    JobTitle = tb_jobTitle.Text,
                    Address = tb_address.Text,
                    City = tb_city.Text,
                    Phone = tb_phone.Text,
                    Email = tb_email.Text,
                    SSN = tb_ssn.Text
                };

                if (!controller.EmployeeExist(employee.No))
                {
                    controller.CreateEmployee(employee);
                    UpdateDGV();
                    ClearTextBoxes();
                    SetSystemMessage("Employee " + ssn + " successfully created!");
                } else
                {
                    SetSystemMessage("Employee with given No_ already exists.");
                }
                
                
            }
        }

        // UPDATE
        private void btn_update_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_no.Text) ||
                string.IsNullOrWhiteSpace(tb_firstName.Text) ||
                string.IsNullOrWhiteSpace(tb_lastName.Text) ||
                string.IsNullOrWhiteSpace(tb_jobTitle.Text) ||
                string.IsNullOrWhiteSpace(tb_address.Text) ||
                string.IsNullOrWhiteSpace(tb_city.Text) ||
                string.IsNullOrWhiteSpace(tb_phone.Text) ||
                string.IsNullOrWhiteSpace(tb_email.Text) ||
                string.IsNullOrWhiteSpace(tb_ssn.Text))
            {
                SetSystemMessage("ERROR: one or more fields was left empty!");
            }
            else
            {
                // Create new insance of Employee with values equal to textfields
                Employee employee = new Employee()
                {
                    No = tb_no.Text,
                    FirstName = tb_firstName.Text,
                    LastName = tb_lastName.Text,
                    JobTitle = tb_jobTitle.Text,
                    Address = tb_address.Text,
                    City = tb_city.Text,
                    Phone = tb_phone.Text,
                    Email = tb_email.Text,
                    SSN = tb_ssn.Text
                };

                if (controller.UpdateEmployee(employee))
                {
                    SetSystemMessage("Employee " + employee.SSN + " successfully updated!");
                    UpdateDGV();
                    ClearTextBoxes();
                }
                else
                {
                    SetSystemMessage("Error: update failed");
                    UpdateDGV();
                }
            }
        }

        // DELETE
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string no = tb_no.Text;
            DialogResult dialog = MessageBox.Show("Are you sure you want to remove customer " + no + "? All data will be removed.", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                if (controller.RemoveEmployee(no))
                {
                    SetSystemMessage("Employee " + no + " successfully removed!");
                    UpdateDGV();
                    ClearTextBoxes();
                }
                else
                {
                    SetSystemMessage("ERROR: remove failed.");
                }
            }
            else
            {
                SetSystemMessage("Employee" + no + "was not removed.");
            }
        }

        // GETS ALL EMPLOYEES OR EMPLOYEES BY NO
        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchNo = tb_searchByNo.Text.ToUpper();

            dgv_Employee.Rows.Clear();
            
            if (string.IsNullOrWhiteSpace(searchNo))
            {
                InitializeDGV();

                SetSystemMessage("Displaying all employees");
            }
            else
            {
                Employee employee = controller.SearchEmployee(searchNo);

                if (employee == null)
                {
                    SetSystemMessage("ERROR: No employee found that matches search No.");
                }
                else
                {
                    dgv_Employee.Rows.Add(employee.No, employee.FirstName, employee.LastName, employee.LastName, employee.Address, employee.Address, employee.City, employee.Phone, employee.Email, employee.SSN);

                    SetSystemMessage("Searched for employee with No: " + searchNo);
                }
            }
        }


        // GET EMPLOYEE WITH MOST SICK LEAVE
        private void btn_sickestPerson_Click(object sender, EventArgs e)
        {
            var sickest = new SickestEmployee(checkBox_specialMode.Checked);

            sickest.SetLblName(controller.GetSickestEmployee());
            sickest.Show();

            SetSystemMessage("");
        }

        // GET SICKEST EMPLOYEES BY YEAR
        private void btn_sickestEmpYear_Click(object sender, EventArgs e)
        {
            string year = tb_sickestEmployeeYear.Text;
            if (string.IsNullOrWhiteSpace(year))
            {
                SetSystemMessage("ERROR: Enter year!");
            }
            else
            {
                dgv_Employee.Rows.Clear();

                foreach (Employee employee in controller.GetSickEmployeesByYear(year))
                {
                    dgv_Employee.Rows.Add(employee.No, employee.FirstName, employee.LastName, employee.JobTitle, employee.Address, employee.City, employee.Phone, employee.Email, employee.SSN);
                }
                SetSystemMessage("Displaying employees who were on sick leave in the year " + year);
            }
        }


        private void btn_getRelatedTablesGet_Click(object sender, EventArgs e)
        {
            string value = ((ComboBoxItem<string>)cb_relatedTables.SelectedItem).ValueMember;

            TableContents tc = new TableContents(value, "contents");
            tc.Show();

            SetSystemMessage("");
        }

        private void btn_getMetadata_Click(object sender, EventArgs e)
        {

            if (cb_relatedTables.SelectedItem == null)
            {
                SetMetaSystemMessage("ERROR: no related table selected");
            }
            else
            {
                SetMetaSystemMessage("");

                string tableName = ((ComboBoxItem<string>)cb_relatedTables.SelectedItem).ValueMember;
                string action = cb_metadata.Text;

                TableContents tc = new TableContents(tableName, action);
                tc.Show();
            }

            SetSystemMessage("");
        }

        private void btn_getEmpRelatives_Click(object sender, EventArgs e)
        {
            string no = tb_no.Text;
            if (string.IsNullOrWhiteSpace(no))
            {
                SetSystemMessage("ERROR: no employee no entered. Please enter employee no.");
            }
            else
            {
                TableContents tc = new TableContents(no, "Relatives");
                tc.Show();
                SetSystemMessage("");
            }
            
        }

        public class ComboBoxItem<T>
        {
            public string DisplayMember = string.Empty;
            public T ValueMember = default(T);

            public override string ToString()
            {
                return DisplayMember;
            }
        }

        private void cb_metadataSelectionChanged(object sender, EventArgs e)
        {
            btn_getMetadata.Enabled = true;
            btn_getMetadata.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void tb_firstName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_firstName.Text) == false && 
                string.IsNullOrWhiteSpace(tb_lastName.Text) == false)
            {
                tb_no.Text = tb_firstName.Text.Substring(0, 1).ToUpper() + tb_lastName.Text.Substring(0, 1).ToUpper();
            }
        }

        private void tb_lastName_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_firstName.Text) == false && 
                string.IsNullOrWhiteSpace(tb_lastName.Text) == false)
            {
                tb_no.Text = tb_firstName.Text.Substring(0, 1).ToUpper() + tb_lastName.Text.Substring(0, 1).ToUpper();
            }
        }
    }
}
