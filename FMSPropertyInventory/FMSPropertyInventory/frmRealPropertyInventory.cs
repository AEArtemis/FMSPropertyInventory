using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Common.StringUtilities;
using DataManager;

namespace FMSPropertyInventory 
{
    public partial class frmLandInventory : Form
    {
        private string selectedPropertyKind;
        private string selectedModeOfProcurement;
        public frmLandInventory()
        {
            InitializeComponent();

        }
        private void frmLandInventory_Load(object sender, EventArgs e)
        {
            cboxPropertyKind.Items.Add("Land");
            cboxPropertyKind.Items.Add("Building");

            cboxModeOfProcurement.Items.Add("Purchased");
            cboxModeOfProcurement.Items.Add("Donation");
            cboxModeOfProcurement.Items.Add("Deed of Donation");
            cboxModeOfProcurement.Items.Add("Deed of Exchange");
            cboxModeOfProcurement.Items.Add("Usufruct");

            cboxStatus.Items.Add("Acquisition");
            cboxStatus.Items.Add("Disposal");

            cboxNameTag.Items.Add("DONOR");
            cboxNameTag.Items.Add("DONEE");
        }

        private void LabelsAndCbox()
        {
            if (selectedModeOfProcurement == "Purchased")
            {
                /*Datagrid Rows*/
                dgLandInventory.Columns[5].Visible = false;
                dgLandInventory.Columns[6].Visible = true;
                dgLandInventory.Columns[8].Visible = true;
                dgLandInventory.Columns[9].Visible = true;
                dgLandInventory.Columns[11].Visible = false;
                dgLandInventory.Columns[12].Visible = true;

                /*Labels*/
                lbDateAcquired.Visible = true;
                lbPurpose.Visible = true;
                lbAppraisedValue.Visible = true;
                lbRemarks.Visible = true;
                lbDonor.Visible = false;
                lbNameTag.Visible = false;

                /*Textboxt & Combobox*/
                txtBoxDateAcquired.Visible = true;
                txtBoxPurpose.Visible = true;
                txtBoxAppraisedValue.Visible = true;
                txtBoxRemarks.Visible = true;
                txtBoxDonor.Visible = false;
                cboxNameTag.Visible = false;
            }
            else
            {
                dgLandInventory.Columns[5].Visible = true;
                dgLandInventory.Columns[6].Visible = false;
                dgLandInventory.Columns[8].Visible = false;
                dgLandInventory.Columns[9].Visible = false;
                dgLandInventory.Columns[11].Visible = true;
                dgLandInventory.Columns[12].Visible = false;

                lbDateAcquired.Visible = false;
                lbPurpose.Visible = false;
                lbAppraisedValue.Visible = false;
                lbRemarks.Visible = false;
                lbDonor.Visible = true;
                lbNameTag.Visible = true;

                txtBoxDateAcquired.Visible = false;
                txtBoxPurpose.Visible = false;
                txtBoxAppraisedValue.Visible = false;
                txtBoxRemarks.Visible = false;
                txtBoxDonor.Visible = true;
                cboxNameTag.Visible = true;
            }
        }

        private void InputsEnable()
        {
            txtBoxPropertyDescription.Enabled = true;
            txtBoxPropertyLocation.Enabled = true;
            txtBoxPropertyArea.Enabled = true;
            txtBoxDonor.Enabled = true;
            txtBoxDateAcquired.Enabled = true;
            cboxNameTag.Enabled = true;
            txtBoxAppraisedValue.Enabled = true;
            cboxStatus.Enabled = true;
            txtBoxPurpose.Enabled = true;
            txtBoxRemarks.Enabled = true;
        }

        private void InputsDisable()
        {
            txtBoxPropertyDescription.Enabled = false;
            txtBoxPropertyLocation.Enabled = false;
            txtBoxPropertyArea.Enabled = false;
            txtBoxDonor.Enabled = false;
            txtBoxDateAcquired.Enabled = false;
            cboxNameTag.Enabled = false;
            txtBoxAppraisedValue.Enabled = false;
            cboxStatus.Enabled = false;
            txtBoxPurpose.Enabled = false;
            txtBoxRemarks.Enabled = false;
        }

        private void ClearInputs()
        {
            txtBoxPropertyDescription.Text = string.Empty;
            txtBoxPropertyLocation.Text = string.Empty;
            txtBoxPropertyArea.Text = string.Empty;
            txtBoxDonor.Text = string.Empty;
            txtBoxDateAcquired.Text = string.Empty;
            txtBoxAppraisedValue.Text = string.Empty;
            txtBoxPurpose.Text = string.Empty;
            txtBoxRemarks.Text = string.Empty;
            cboxNameTag.SelectedIndex = -1;
            cboxStatus.SelectedIndex = -1;

            //txtBoxPropInvId.Text = string.Empty;
            txtBoxPropValue.Text = string.Empty;
            txtBox2ndRemarks.Text = string.Empty;
        }

        private void SupplementaryButtonsControl(bool enable)
        {

            btnSAdd.Enabled = enable;
            btnSEdit.Enabled = enable;
            btnSDelete.Enabled = enable;
        }

        private void MainButtonsControl(bool enable)
        {
            btnAdd.Enabled = enable;
            btnEdit.Enabled = enable;
            btnDelete.Enabled = enable;
            btnDelete.Enabled = enable;
        }
        private void cboxPropertyKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPropertyKind = cboxPropertyKind.SelectedItem.ToString();
            cboxModeOfProcurement.Enabled = true;
            if (cboxModeOfProcurement.SelectedItem != null)
            {
                if (!string.IsNullOrEmpty(selectedModeOfProcurement))
                {
                    ViewPropertyInventory();
                }
            }
        }

        private void cboxModeOfProcurement_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboxModeOfProcurement.SelectedItem != null)
            {
                selectedModeOfProcurement = cboxModeOfProcurement.SelectedItem.ToString();
                ViewPropertyInventory();
            }
        }

        private bool ValidateMainInputs()
        {
            if (txtBoxPropertyDescription.Text.Trim() == "" ||
                //txtBoxPropertyLocation.Text.Trim() == "" ||
                //txtBoxPropertyArea.Text.Trim() == "" ||
                cboxStatus.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            //if (selectedModeOfProcurement == "Purchased")
            //{
            //    if (txtBoxDateAcquired.Text.Trim() == "" ||
            //        txtBoxAppraisedValue.Text.Trim() == "" ||
            //        txtBoxPurpose.Text.Trim() == "" ||
            //        txtBoxRemarks.Text.Trim() == "")
            //    {
            //        MessageBox.Show("Please fill in all the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        return false;
            //    }
            //}
            else
            {
                if (txtBoxDonor.Text.Trim() == "" ||
                    cboxNameTag.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in all the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }

            return true;
        }

        private bool ValidateSupplementaryInputs()
        {
            if (txtBoxPropValue.Text.Trim() == "" ||
                txtBox2ndRemarks.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void ViewPropertyInventory()
        {
            InputsDisable();
            LabelsAndCbox();
            dgLandInventory.Rows.Clear();
            dgLandInventorySupplementary.Rows.Clear();
            btnAdd.Text = "Add";
            btnEdit.Text = "Edit";
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnPrint.Enabled = true;

            int mRowCount = 0;
            DataResultSet m_set = new DataResultSet();
            m_set.Query = $"SELECT id, prop_kind, prop_desc, prop_loc, prop_area, date_acquired, mode_proc, purpose, appraised_value, status, remarks, name, name_tag FROM tbl_prop_inv WHERE mode_proc = '{selectedModeOfProcurement}' AND prop_kind = '{selectedPropertyKind}'";
            
            if (m_set.Execute())
            {
                while (m_set.Read())
                {
                    mRowCount++;
                    string propInvId = m_set.GetString(0);
                    int propArea = 0;
                    int.TryParse(m_set.GetString(4), out propArea);
                    /* Note: "" means that the column for datagrid is hidden base on Mode of Procurement selected*/

                    if(selectedModeOfProcurement == "Purchased")
                    {
                        dgLandInventory.Rows.Add(m_set.GetString(0), m_set.GetString(1), m_set.GetString(2), m_set.GetString(3), propArea.ToString("#,###"), "", m_set.GetString(5),
                            m_set.GetString(6), m_set.GetString(7), m_set.GetString(8), m_set.GetString(9), "", m_set.GetString(10));
                    }
                    else
                    {
                        dgLandInventory.Rows.Add(m_set.GetString(0), m_set.GetString(1), m_set.GetString(2), m_set.GetString(3), propArea.ToString("#,###"), m_set.GetString(11), "", m_set.GetString(6), "", "", m_set.GetString(9), m_set.GetString(12));
                    }
                }
            }
            m_set.Close();
            dgLandInventorySupplementary.ClearSelection();



            if (mRowCount == 0)
            {
                dgLandInventory.AllowUserToAddRows = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                dgLandInventory.AllowUserToAddRows = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        /*Note: Fetch Supplementary Data base on Selected ID*/
        private void dgLandInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgLandInventory.CurrentRow.Cells[0].Value != null)
            {   
                DataResultSet m_set = new DataResultSet();
                m_set.Query = $"SELECT * FROM tbl_prop_inv WHERE id = '" + dgLandInventory.CurrentRow.Cells[0].Value.ToString() + "'";

                if (m_set.Execute())
                {
                    if (m_set.Read())
                    {
                        txtBoxPropertyDescription.Text = m_set.GetString(2) ?? string.Empty;
                        txtBoxPropertyLocation.Text = m_set.GetString(3) ?? string.Empty;
                        txtBoxPropertyArea.Text = m_set.GetString(4) ?? string.Empty;

                        string status = m_set.GetString(6);
                        string nameTag = m_set.GetString(13);
                        if (cboxStatus.Items.Contains(status))
                        {
                            cboxStatus.SelectedItem = status;
                        }

                        if (cboxNameTag.Items.Contains(nameTag))
                        {
                            cboxNameTag.SelectedItem = nameTag;
                        }

                        txtBoxAppraisedValue.Text = m_set.GetString(8) ?? string.Empty;
                        txtBoxPurpose.Text = m_set.GetString(9) ?? string.Empty;
                        txtBoxDateAcquired.Text = m_set.GetString(10) ?? string.Empty;
                        txtBoxRemarks.Text = m_set.GetString(11) ?? string.Empty;
                        txtBoxDonor.Text = m_set.GetString(12) ?? string.Empty;
                    }
                }
                m_set.Close();
            }
            else
            {
                ClearInputs();
            }

            int sRowCount = 0;
            double propValue = 0;
            dgLandInventorySupplementary.Rows.Clear();
            if (dgLandInventory.CurrentRow.Cells[0].Value != null)
            {
                DataResultSet m_set = new DataResultSet();
                m_set.Query = $"SELECT id, tbl_prop_inv, prop_value, remarks FROM tbl_prop_inv_items WHERE tbl_prop_inv = '" + dgLandInventory.CurrentRow.Cells[0].Value.ToString() + "'";


                if (m_set.Execute())
                {
                    while (m_set.Read())
                    {
                        sRowCount++;
                        double.TryParse(m_set.GetString(2), out propValue);
                        //dgLandInventorySupplementary.Rows.Add(m_set.GetString(0), m_set.GetString(1), propValue.ToString("#,###.00"), m_set.GetString(3));
                        dgLandInventorySupplementary.Rows.Add(m_set.GetString(0), m_set.GetString(1), propValue != 0 ? propValue.ToString("#,###.00") : "", m_set.GetString(3));
                    }
                }
                m_set.Close();

                if (sRowCount == 0)
                {
                    dgLandInventorySupplementary.AllowUserToAddRows = true;
                    btnSAdd.Enabled = true;
                    btnSEdit.Enabled = false;
                    btnSDelete.Enabled = false;
                }
                else
                {
                    dgLandInventorySupplementary.AllowUserToAddRows = false;
                    btnSEdit.Enabled = true;
                    btnSDelete.Enabled = true;
                    btnSAdd.Enabled = true;
                }
            }
            
        }

        private void dgLandInventorySupplementary_SelectionChanged(object sender, EventArgs e)
        {
            DataResultSet m_set = new DataResultSet();
            if (dgLandInventorySupplementary.CurrentRow.Cells[0].Value != null)
            {
                m_set.Query = $"SELECT * FROM tbl_prop_inv_items WHERE id = '" + dgLandInventorySupplementary.CurrentRow.Cells[0].Value.ToString() + "'";
                if (m_set.Execute())
                {
                    if (m_set.Read())
                    {
                        txtBoxPropValue.Text = m_set.GetString(2) ?? string.Empty;
                        txtBox2ndRemarks.Text = m_set.GetString(3) ?? string.Empty;
                    }
                }
                m_set.Close();
            }
        }

        private void SaveMainData()
        {
            if (!ValidateMainInputs())
                return;

            if (MessageBox.Show("Are you sure you want to save?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

                DataResultSet m_set = new DataResultSet();
                if (selectedModeOfProcurement == "Purchased")
                {
                    m_set.Query = "INSERT INTO tbl_prop_inv (prop_kind, prop_desc, prop_loc, prop_area, date_acquired, mode_proc, purpose, appraised_value, status, remarks) " +
                                  "VALUES (@prop_kind, @prop_desc, @prop_loc, @prop_area, @date_acquired, @mode_proc, @purpose, @appraised_value, @status, @remarks)";
                    m_set.AddParameter("prop_kind", selectedPropertyKind);
                    m_set.AddParameter("mode_proc", selectedModeOfProcurement);
                    m_set.AddParameter("prop_desc", txtBoxPropertyDescription.Text.Trim());
                    m_set.AddParameter("prop_loc", txtBoxPropertyLocation.Text.Trim());
                    m_set.AddParameter("prop_area", txtBoxPropertyArea.Text.Trim());
                    m_set.AddParameter("status", cboxStatus.Text.Trim());
                    m_set.AddParameter("date_acquired", txtBoxDateAcquired.Text.Trim());
                    m_set.AddParameter("purpose", txtBoxPurpose.Text.Trim());
                    m_set.AddParameter("appraised_value", txtBoxAppraisedValue.Text.Trim());
                    m_set.AddParameter("remarks", txtBoxRemarks.Text.Trim());
                }
                else
                {
                    m_set.Query = "INSERT INTO tbl_prop_inv (prop_kind, prop_desc, prop_loc, prop_area, name, mode_proc, status, name_tag) " +
                                  "VALUES (@prop_kind, @prop_desc, @prop_loc, @prop_area, @name, @mode_proc, @status, @name_tag)";
                    m_set.AddParameter("prop_kind", selectedPropertyKind);
                    m_set.AddParameter("mode_proc", selectedModeOfProcurement);
                    m_set.AddParameter("prop_desc", txtBoxPropertyDescription.Text.Trim());
                    m_set.AddParameter("prop_loc", txtBoxPropertyLocation.Text.Trim());
                    m_set.AddParameter("prop_area", txtBoxPropertyArea.Text.Trim());
                    m_set.AddParameter("status", cboxStatus.Text.Trim());
                    m_set.AddParameter("name", txtBoxDonor.Text.Trim());
                    m_set.AddParameter("name_tag", cboxNameTag.Text.Trim());
                }

                m_set.Execute();
                m_set.Close();

                MessageBox.Show("Item has been added.", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewPropertyInventory();
                ClearInputs();
                btnAdd.Text = "Add";
                btnPrint.Text = "Print";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                InputsDisable();
        }
        private void SaveSupplementaryData()
        {
            if (!ValidateSupplementaryInputs())
                return;

            if (MessageBox.Show("Are you sure you want to save?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (dgLandInventory.CurrentRow.Cells[0].Value != null)
            {
                DataResultSet m_set = new DataResultSet();
                m_set.Query = "INSERT INTO tbl_prop_inv_items (tbl_prop_inv, prop_value, remarks) VALUES (@tbl_prop_inv, @prop_value, @remarks)";
                m_set.AddParameter("tbl_prop_inv", dgLandInventory.CurrentRow.Cells[0].Value.ToString());
                m_set.AddParameter("prop_value", txtBoxPropValue.Text.Trim());
                m_set.AddParameter("remarks", txtBox2ndRemarks.Text.Trim());
                m_set.Execute();
                m_set.Close();

                MessageBox.Show("Item has been added.", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewPropertyInventory();
                ClearInputs();
                btnSAdd.Text = "Add";
                btnSDelete.Text = "Delete";
                txtBoxPropValue.Enabled = false;
                txtBox2ndRemarks.Enabled = false;
                btnSEdit.Enabled = true;
                btnSDelete.Enabled = true;
                InputsDisable();
            }
            else
            {
                MessageBox.Show("No data selected");
            }
        }

        private void UpdateMainData()
        {
            if (!ValidateMainInputs())
                return;

            if (MessageBox.Show("Are you sure you want to update this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DataResultSet m_set = new DataResultSet();
            if(selectedModeOfProcurement == "Purchased")
            {
                m_set.Query = "UPDATE tbl_prop_inv SET prop_kind = @prop_kind, mode_proc = @mode_proc, prop_desc = @prop_desc, prop_loc = @prop_loc, prop_area = @prop_area, date_acquired = @date_acquired, purpose = @purpose, appraised_value = @appraised_value, status = @status, remarks = @remarks WHERE id = @id";
                m_set.AddParameter("id", dgLandInventory.CurrentRow.Cells[0].Value.ToString());
                m_set.AddParameter("prop_kind", selectedPropertyKind);
                m_set.AddParameter("mode_proc", selectedModeOfProcurement);
                m_set.AddParameter("prop_desc", txtBoxPropertyDescription.Text.Trim());
                m_set.AddParameter("prop_loc", txtBoxPropertyLocation.Text.Trim());
                m_set.AddParameter("prop_area", txtBoxPropertyArea.Text.Trim());
                m_set.AddParameter("status", cboxStatus.Text.Trim());

                m_set.AddParameter("date_acquired", txtBoxDateAcquired.Text.Trim());
                m_set.AddParameter("purpose", txtBoxPurpose.Text.Trim());
                m_set.AddParameter("appraised_value", txtBoxAppraisedValue.Text.Trim());
                m_set.AddParameter("remarks", txtBoxRemarks.Text.Trim());
            }
            else
            {
                m_set.Query = "UPDATE tbl_prop_inv SET prop_kind = @prop_kind, mode_proc = @mode_proc, prop_desc = @prop_desc, prop_loc = @prop_loc, prop_area = @prop_area, status = @status, name = @name, name_tag = @name_tag WHERE id = @id";
                m_set.AddParameter("id", dgLandInventory.CurrentRow.Cells[0].Value.ToString());
                m_set.AddParameter("prop_kind", selectedPropertyKind);
                m_set.AddParameter("mode_proc", selectedModeOfProcurement);
                m_set.AddParameter("prop_desc", txtBoxPropertyDescription.Text.Trim());
                m_set.AddParameter("prop_loc", txtBoxPropertyLocation.Text.Trim());
                m_set.AddParameter("prop_area", txtBoxPropertyArea.Text.Trim());
                m_set.AddParameter("status", cboxStatus.Text.Trim());
                m_set.AddParameter("name", txtBoxDonor.Text.Trim());
                m_set.AddParameter("name_tag", cboxNameTag.Text.Trim());
            }

            m_set.Execute();
            m_set.Close();
            cboxModeOfProcurement.Enabled = true;
            cboxPropertyKind.Enabled = true;
            MessageBox.Show("Record has been updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEdit.Text = "Edit";
            btnPrint.Text = "Print";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            ViewPropertyInventory();
            ClearInputs();
            InputsDisable();
        }

        private void UpdateSupplementaryData()
        {
            if (!ValidateSupplementaryInputs())
                return;

            if (MessageBox.Show("Are you sure you want to update this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DataResultSet m_set = new DataResultSet();
            m_set.Query = "Update tbl_prop_inv_items SET prop_value = @prop_value, remarks = @remarks WHERE id = @id";
            m_set.AddParameter("id", dgLandInventorySupplementary.CurrentRow.Cells[0].Value.ToString());
            m_set.AddParameter("prop_value", txtBoxPropValue.Text.Trim());
            m_set.AddParameter("remarks", txtBox2ndRemarks.Text.Trim());
            m_set.Execute();
            m_set.Close();

            MessageBox.Show("Record has been updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSEdit.Text = "Edit";
            btnSDelete.Text = "Delete";

            txtBoxPropValue.Enabled = false;
            txtBox2ndRemarks.Enabled = false;
            ViewPropertyInventory();
            ClearInputs();
            InputsDisable();
        }

        private void DeleteMainData()
        {
            if (MessageBox.Show("Do you want to delete the selected record?", ".", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgLandInventory.SelectedCells.Count > 0)
                {
                    DataResultSet m_set = new DataResultSet();
                    m_set.Query = "DELETE FROM tbl_prop_inv WHERE id = '" + dgLandInventory.CurrentRow.Cells[0].Value.ToString() + "'";
                    m_set.Execute();
                    m_set.Close();

                    m_set.Query = "DELETE FROM tbl_prop_inv_items WHERE tbl_prop_inv= '" + dgLandInventory.CurrentRow.Cells[0].Value.ToString() + "'";
                    m_set.Execute();
                    m_set.Close();

                    MessageBox.Show("Item has been deleted", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewPropertyInventory();
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        private void DeleteSupplementaryData()
        {
            if (MessageBox.Show("Do you want to delete the selected record?", ".", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgLandInventorySupplementary.SelectedCells.Count > 0)
                {
                    if (dgLandInventorySupplementary.CurrentRow.Cells[0].Value != null)
                    {
                        DataResultSet m_set = new DataResultSet();
                        m_set.Query = "DELETE FROM tbl_prop_inv_items WHERE id = '" + dgLandInventorySupplementary.CurrentRow.Cells[0].Value.ToString() + "'";
                        m_set.Execute();
                        m_set.Close();
                        MessageBox.Show("Item has been deleted", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViewPropertyInventory();
                    }
                    else
                    {
                        MessageBox.Show("There are no data selected.", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                return;
            }
        }
        private void PrintData()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                SupplementaryButtonsControl(false);
                btnAdd.Text = "Save";
                btnPrint.Text = "Cancel";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                InputsEnable();
            }
            else if (btnAdd.Text == "Save")
            {
                SaveMainData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                if (dgLandInventory.Focused || dgLandInventory.SelectedCells.Count > 0)
                {
                    SupplementaryButtonsControl(false);
                    cboxPropertyKind.Enabled = false;
                    cboxModeOfProcurement.Enabled = false;
                    btnEdit.Text = "Update";
                    btnPrint.Text = "Cancel";
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    InputsEnable();
                }
                else
                {
                    btnEdit.Text = "Edit";
                    btnPrint.Text = "Print";
                    SupplementaryButtonsControl(true);
                    MessageBox.Show("Cannot Edit this data using this button.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (btnEdit.Text == "Update")
            {
 
                UpdateMainData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgLandInventory.SelectedCells.Count > 0)
            {
                DeleteMainData();
            }
            else
            {
                MessageBox.Show("Cannot delete this data using this button.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(btnPrint.Text == "Print")
            {
                PrintData();
            }
            else if (btnPrint.Text == "Cancel")
            {
                InputsDisable();
                ClearInputs();
                //SupplementaryButtonsControl(true);
                ViewPropertyInventory();
                txtBoxPropValue.Enabled = false;
                txtBox2ndRemarks.Enabled = false;
                cboxPropertyKind.Enabled = true;
                cboxModeOfProcurement.Enabled = true;
                btnPrint.Text = "Print";
            }
        }

        /* Note: Supplementary Buttons */
        private void btnSAdd_Click(object sender, EventArgs e)
        {
            if (btnSAdd.Text == "Add")
            {
                if (dgLandInventory.Focused || dgLandInventory.SelectedCells.Count > 0)
                {
                    InputsDisable();
                    MainButtonsControl(false);
                    btnSAdd.Text = "Save";
                    btnSDelete.Text = "Cancel";
                    btnSEdit.Enabled = false;
                    btnSDelete.Enabled = true;
                    txtBoxPropValue.Enabled = true;
                    txtBox2ndRemarks.Enabled = true;
                }
                else
                {
                    MainButtonsControl(true);
                    btnSAdd.Text = "Add";
                    btnSDelete.Text = "Delete";
                    MessageBox.Show("Please select a data first to add.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnSAdd.Text == "Save")
            {
                 SaveSupplementaryData();
            }
        }

        private void btnSEdit_Click(object sender, EventArgs e)
        {
            if (btnSEdit.Text == "Edit")
            {
                //if (dgLandInventorySupplementary.Focused)
                if (dgLandInventorySupplementary.Focused || dgLandInventorySupplementary.SelectedCells.Count > 0)
                {
                    MainButtonsControl(false);
                    btnSEdit.Text = "Update";
                    btnSDelete.Text = "Cancel";
                    txtBoxPropValue.Enabled = true;
                    txtBox2ndRemarks.Enabled = true;
                    InputsDisable();
                }
                else
                {
                    MainButtonsControl(true);
                    btnSEdit.Text = "Edit";
                    btnSDelete.Text = "Delete";
                    MessageBox.Show("Cannot Edit this data using this button.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnSEdit.Text == "Update")
            {
                UpdateSupplementaryData();
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            if (btnSDelete.Text == "Delete")
            {
                if (dgLandInventorySupplementary.SelectedCells.Count > 0)
                {
                    txtBoxPropValue.Enabled = true;
                    txtBox2ndRemarks.Enabled = true;
                    InputsDisable();
                    DeleteSupplementaryData();
                }
                else
                {
                    MessageBox.Show("Cannot delete this data using this button.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnSDelete.Text == "Cancel")
            {
                MainButtonsControl(true);
                InputsDisable();
                txtBoxPropValue.Enabled = false;
                txtBox2ndRemarks.Enabled = false;
                btnSAdd.Enabled = true;
                btnSEdit.Enabled = true;
                btnSAdd.Text = "Add";
                btnSEdit.Text = "Edit";
                btnSDelete.Text = "Delete";
            }
            
        }

        private void dgLandInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgLandInventorySupplementary.ClearSelection();
        }

        private void dgLandInventorySupplementary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgLandInventory.ClearSelection();
        }
    }
}
