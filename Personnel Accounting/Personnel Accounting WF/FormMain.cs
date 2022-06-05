using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Personnel_Accounting_WF
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            fillDataSetTables();
        }

        private void fillDataSetTables(int tableIndex = -1)
        {
            switch (tableIndex)
            {
                case -1:
                    tableAdapterStaff.Fill(dataSetMain.Staff);
                    tableAdapterJobPositions.Fill(dataSetMain.JobPositions);
                    tableAdapterStaffPositions.Fill(dataSetMain.StaffPositions);
                    break;
                case 0:
                    tableAdapterStaffPositions.Fill(dataSetMain.StaffPositions);
                    break;
                case 1:
                    tableAdapterStaff.Fill(dataSetMain.Staff);
                    break;
                case 2:
                    tableAdapterJobPositions.Fill(dataSetMain.JobPositions);
                    break;
            }
            bindingSourceStaffPositionsTable.Filter = null;
            fillGridToolTips();
        }

        private void fillGridToolTips()
        {
            foreach (DataGridViewRow row in dataGridViewStaffPositions.Rows)
                if (row.Index != dataGridViewStaffPositions.RowCount - 1) row.Cells["ColumnSPAddInfo"].ToolTipText = dataGridViewJobPositions.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["ColumnJPId"].Value.ToString() == row.Cells["ColumnSPJobPositionsId"].Value.ToString())
                    .First()
                    .Cells["ColumnJPAddInfoName"]
                    .Value.ToString();
        }

        private void dataUpdated()
        {
            labelDataEditMessages.Text = $"Data updated on {DateTime.Now.ToString("H:mm:ss")}";
        }

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            bindingSourceStaffPositionsTable.Filter = null;
        }

        private void buttonCommitChangesS_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceStaffTable.EndEdit();
                tableAdapterStaff.Update(dataSetMain);
                dataUpdated();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"You are probably trying to delete data, that used in another tables...\n{ex.Message}");
            }
            fillDataSetTables();
        }

        private void buttonCommitChangesSP_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceStaffPositionsTable.EndEdit();
                tableAdapterStaffPositions.Update(dataSetMain);
                dataUpdated();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"You are probably trying to delete data, that used in another tables...\n{ex.Message}");
            }
            fillDataSetTables();
        }

        private void buttonCommitChangesJP_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceJobPositionsTable.EndEdit();
                tableAdapterJobPositions.Update(dataSetMain);
                dataUpdated();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"You are probably trying to delete data, that used in another tables...\n{ex.Message}");
            }
            fillDataSetTables();
        }

        private void buttonResetSPData_Click(object sender, EventArgs e)
        {
            fillDataSetTables(0);
        }

        private void buttonResetSData_Click(object sender, EventArgs e)
        {
            fillDataSetTables(1);
        }

        private void buttonResetJBData_Click(object sender, EventArgs e)
        {
            fillDataSetTables(2);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string and = "";
            if (comboBoxJobPositionFindField.Text != "") bindingSourceStaffPositionsTable.Filter = $"JobPositionsId = {comboBoxJobPositionFindField.SelectedValue}";
            if (textBoxAddInfoFindField.Text != "")
            {
                if (bindingSourceStaffPositionsTable.Filter != null) and += " and ";
                bindingSourceStaffPositionsTable.Filter += $"{and}AddInfo = '{textBoxAddInfoFindField.Text}'";
            }
        }
    }
}