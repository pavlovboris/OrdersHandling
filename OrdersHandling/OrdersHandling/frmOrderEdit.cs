using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace OrdersHandling
{
    public partial class frmOrderEdit : Form
    {
        public frmOrderEdit()
        {
            InitializeComponent();
        }
        public Orders order = new Orders();
        public OrdersHandlingEntities db;
        private void frmOrderEdit_Load(object sender, EventArgs e)
        {
            if (frmLogin.Instance.UserInfo.RoleID==1)
            {
                cmbPartnerName.Enabled = true;
                chkboxOffer.Enabled = true;
                chkBoxCompleated.Enabled = true;
            } else
            {
                cmbPartnerName.Enabled = false;
            }
            //db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            uploadedFilesBindingSource.DataSource = db.UploadedFiles.Where(u => u.OrderID==order.ID).ToList();
            partnersBindingSource.DataSource = db.Partners.ToList();
            codesBindingSource.DataSource = db.Codes.Where(c => c.Type == 5).ToList();
            colorsBindingSource.DataSource = db.Colors.ToList();
            ordersBindingSource.DataSource = order;
            lblOrderNumber.Text = order.ID.ToString();
            codesBindingSource1.DataSource = db.Codes.ToList();
            surfaceBindingSource.DataSource = db.Surface.ToList();
            mUBindingSource.DataSource = db.MU.ToList();
            orderLinesBindingSource.DataSource = db.OrderLines.Where(o => o.OrderID == order.ID).ToList();

            //Update order infor panel starts here 
            double sqm = 0;
            double kgr = 0;

            foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
            {
                if (dgvr != null)
                {
                    OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                    double tmpsqm = 0;
                    double tmpkgr = 0;
                    try
                    {
                        tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                        tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                    }
                    catch
                    {

                    }



                    if (tmpsqm.ToString() != "")
                    {
                        sqm += tmpsqm;
                    }
                    if (tmpkgr.ToString() != "")
                    {
                        kgr += tmpkgr;
                    }
                }
            }
            lblSqmSum.Text = Math.Round(sqm, 2).ToString();
            lblKgrSum.Text = Math.Round(kgr, 2).ToString();

            //Update order info panel ends here

            dgvOrderLines.Columns[2].Frozen = true;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    order.OrderSQM =Convert.ToDouble( lblSqmSum.Text);
                    order.Orderkgr = Convert.ToDouble(lblKgrSum.Text);
                    
                    ordersBindingSource.EndEdit();
                    orderLinesBindingSource.EndEdit();
                    dgvOrderLines.EndEdit();
                    await db.SaveChangesAsync();
                    
                    MessageBox.Show("Промените са успешно запаметени.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("Вероятно въведените данни са некоректни, искате ли да разгледате детайли?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        MessageBox.Show(ex.Source + " : " + ex.Message + " : " + ex.InnerException + " : " + ex.StackTrace + " : " + ex.Data);
                    }
                }
            }
        }
       
        private void dgvOrderLines_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderLines.Rows[e.RowIndex].Cells[1].Value==null)
            {
                dgvOrderLines.Rows[e.RowIndex].Cells[1].Value = order.ID;
                dgvOrderLines.Rows[e.RowIndex].Cells[2].Value = 6;
            }
           
        }

        private void dgvOrderLines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void btnEditLines_Click(object sender, EventArgs e)
        {
            OrderLines orderline = new OrderLines();
            orderline.OrderID = order.ID;
            orderline.CodeID = 6;
            Codes code = (from codes in db.Codes where codes.ID == orderline.CodeID select codes).SingleOrDefault();
            Partners partner = cmbPartnerName.SelectedItem as Partners;
            orderline.MU = code.DefaultMU;
            orderline.Length = code.DefaultLength;
            orderline.SurfaceID = (int)code.DefaultSurface;
            orderline.Perimeter = code.Perimeter;
            orderline.Weight = code.Weigth;
            orderline.ProtectiveFilm = partner.DefaultPF*code.PF;
            if (orderline.SurfaceID.ToString()==null)
            {
                orderline.SurfaceID = 1;
            }
            orderline.DeliveryDate = dateTimeExpectedDate.Value;
            Types type = (from types in db.Types where types.TypeID == code.Type select types).SingleOrDefault();
            orderline.IsForCoating = type.IsForCoating;
            orderline.SqmCorrections = 1;
            orderLinesBindingSource.Add(orderline);
            orderLinesBindingSource.MoveLast();
            db.OrderLines.Add(orderline);

            frmCodeSelector frmcodeselector = new frmCodeSelector();
            frmcodeselector.FormClosing += Frmcodeselector_FormClosing;
            frmcodeselector.Show();
            Enabled = false;
        }

        private void Frmcodeselector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmCodeSelector frmcodeselector = (frmCodeSelector)sender;
            Enabled = true;
            if(frmcodeselector.dgvCodeSelector.CurrentRow!=null & frmcodeselector.cancel==false)
            {
                if (frmcodeselector.xclicked!=true)
                {
                    Codes code = frmcodeselector.dgvCodeSelector.CurrentRow.DataBoundItem as Codes;
                    
                    dgvOrderLines.CurrentCell = dgvOrderLines.CurrentRow.Cells[2];
                    dgvOrderLines.CurrentCell.Value = code.ID;
                } else if (dgvOrderLines.CurrentRow.Index==dgvOrderLines.RowCount-1 && dgvOrderLines.Rows[dgvOrderLines.CurrentRow.Index].Cells[5].Value.ToString() == "0")
                {
                    OrderLines line = dgvOrderLines.CurrentRow.DataBoundItem as OrderLines;
                    orderLinesBindingSource.Remove(line);
                    db.OrderLines.Remove(line);
                }
            } else if (frmcodeselector.dgvCodeSelector.CurrentRow!=null && dgvOrderLines.CurrentRow.Index == dgvOrderLines.RowCount - 1 && dgvOrderLines.Rows[dgvOrderLines.CurrentRow.Index].Cells[5].Value.ToString()=="0")
            {
                OrderLines line = dgvOrderLines.CurrentRow.DataBoundItem as OrderLines;
                orderLinesBindingSource.Remove(line);
                db.OrderLines.Remove(line);
            }
        }

        private void dgvOrderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrderLines.CurrentRow != null && dgvOrderLines.CurrentRow.DataBoundItem != null)
                {
                    OrderLines orderline = dgvOrderLines.Rows[e.RowIndex].DataBoundItem as OrderLines;
                    Codes code = (from codes in db.Codes where codes.ID == orderline.CodeID select codes).SingleOrDefault();
                    Types type = (from types in db.Types where types.TypeID == code.Type select types).SingleOrDefault();
                    Partners partner = cmbPartnerName.SelectedItem as Partners;

                    if (e.ColumnIndex == 2 | e.ColumnIndex == 3)
                    {
                        orderline.MU = code.DefaultMU;
                        orderline.Length = code.DefaultLength;
                        orderline.Perimeter = code.Perimeter;
                        orderline.Weight = code.Weigth;
                        orderline.ProtectiveFilm = partner.DefaultPF * code.PF;

                        if (code.DefaultSurface != null)
                        {
                            orderline.SurfaceID = (int)code.DefaultSurface;
                        }
                        else
                        {
                            orderline.SurfaceID = 1;
                        }

                        orderline.IsForCoating = type.IsForCoating;
                        orderline.SqmCorrections = 1;

                        if (orderline.Length == null)
                        {
                            orderline.Length = 1;
                        }

                        orderline.QTY = Math.Round((double)(orderline.Pcs * orderline.Length), 2);
                    }
                    else if (e.ColumnIndex == 5 | e.ColumnIndex == 6)
                    {
                        orderline.QTY = Math.Round((double)(orderline.Pcs * orderline.Length), 2);
                    }

                    //Update order infor panel starts here 
                    double sqm = 0;
                    double kgr = 0;

                    foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
                    {
                        if (dgvr != null)
                        {
                            OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                            double tmpsqm = 0;
                            double tmpkgr = 0;
                            try
                            {
                                tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                                tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            }
                            catch
                            {
                            }
                            if (tmpsqm.ToString() != "")
                            {
                                sqm += tmpsqm;
                            }
                            if (tmpkgr.ToString() != "")
                            {
                                kgr += tmpkgr;
                            }
                        }
                    }
                    lblSqmSum.Text = Math.Round(sqm, 2).ToString();
                    lblKgrSum.Text = Math.Round(kgr, 2).ToString();
                    //Update order info panel ends here
                }
            } catch { }
        }

        private void dgvOrderLines_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex==21)
            {
                frmDatePicker frmdatepicker = new frmDatePicker();
                frmdatepicker.Show();
                frmdatepicker.FormClosed += Frmdatepicker_FormClosed;
            }
        }

        private void Frmdatepicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDatePicker datepicker = (frmDatePicker)sender;

            if (datepicker.isClosed==0)
            {
                dgvOrderLines.CurrentCell.Value = datepicker.cldrDatePick.SelectionStart;
            }
        }

        private void dateTimeExpectedDate_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker datetime = (DateTimePicker)sender;

            foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
            {
                OrderLines orderLines = dgvr.DataBoundItem as OrderLines;
                orderLines.DeliveryDate = datetime.Value; 
            }
        }

        private void dgvOrderLines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex==3)
            {
                frmCodeSelector frmcodeselector = new frmCodeSelector();
                frmcodeselector.FormClosing += Frmcodeselector_FormClosing;
                frmcodeselector.Show();
            }
        }

        private void dgvOrderLines_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                if (e.RowIndex != -1 && dgvOrderLines.Rows[e.RowIndex].DataBoundItem!=null  )
                {
                    dgvOrderLines.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void dgvContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete")
            {
                /*if (MessageBox.Show("Сигурни ли сте, че искате да изтриете маркираните изцяло редове?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                }*/

                foreach(DataGridViewRow dr in dgvOrderLines.Rows)
                {
                    if (dr.DataBoundItem!=null && dr.Selected==true)
                    {
                        if(MessageBox.Show("Сигурни ли сте, че искате да изтриете избраните редове?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            OrderLines orders = new OrderLines();
                            orders = dr.DataBoundItem as OrderLines;
                            dgvOrderLines.Rows.Remove(dr);
                            orderLinesBindingSource.Remove(orders);                            
                            db.OrderLines.Remove(orders);
                        }
                    }
                }
                //Update order infor panel starts here 
                double sqm = 0;
                double kgr = 0;

                foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
                {
                    if (dgvr != null)
                    {
                        OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                        double tmpsqm = 0;
                        double tmpkgr = 0;
                        try
                        {
                            tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                        }
                        catch
                        {
                        }
                        if (tmpsqm.ToString() != "")
                        {
                            sqm += tmpsqm;
                        }
                        if (tmpkgr.ToString() != "")
                        {
                            kgr += tmpkgr;
                        }
                    }
                }
                lblSqmSum.Text = Math.Round(sqm, 2).ToString();
                lblKgrSum.Text = Math.Round(kgr, 2).ToString();
                //Update order info panel ends here
            }
        }

        private void uploadFileDialog_FileOk(object sender, CancelEventArgs e)
        {
           /* OrdersHandlingEntities db = new OrdersHandlingEntities();
            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";*/
            FileDialog dialog = (FileDialog)sender;

            if (dialog.CheckFileExists == true)
            {
                try
                {
                    string filename = Path.GetFileName(dialog.FileName);
                    byte[] data = File.ReadAllBytes(dialog.FileName);

                    UploadedFiles uploadedFiles = new UploadedFiles();
                    uploadedFiles.FileName = filename;
                    uploadedFiles.File = data;
                    uploadedFiles.OrderID = order.ID;
                    uploadedFilesBindingSource.Add(uploadedFiles);
                    db.UploadedFiles.Add(uploadedFiles);

                    MessageBox.Show("Файлът е качен успешно","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            uploadFileDialog.ShowDialog();
        }

        private void dgvAttachments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UploadedFiles uploadedFiles = new UploadedFiles();
            uploadedFiles = dgvAttachments.Rows[e.RowIndex].DataBoundItem as UploadedFiles;
            byte[] bytes = uploadedFiles.File;
           
            saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.FileName = uploadedFiles.FileName;
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                saveFileDialog1.FileName = saveFileDialog1.FileName;
                try
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    fs.Write(bytes, 0, bytes.Length);

                    fs.Close();

                    if (MessageBox.Show("Сигурни ли сте, че искате да запаметите файл : " + saveFileDialog1.FileName, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            Process.Start(saveFileDialog1.FileName);
                            MessageBox.Show("Файла е успешно записан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch
                        {
                            MessageBox.Show("Възникна грешка при записшане на файла, файла не", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {

                }
            }
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void dgvOrderLines_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentCell.RowIndex==dgv.RowCount-1)
            {
                if(e.Modifiers!=Keys.Shift & e.KeyValue== 13 | e.KeyValue==40 && dgv.CurrentRow.Cells[5].Value.ToString() != "0")
                {
                    e.IsInputKey = true;
                    btnEditLines.PerformClick();
                } else if (e.Modifiers != Keys.Shift & e.KeyValue == 13) 
                { 
                    dgv.CurrentCell = dgv.CurrentRow.Cells[5]; 
                }
            } else if (dgv.CurrentCell.ColumnIndex == dgv.ColumnCount - 1 & dgv.CurrentCell.RowIndex == dgv.RowCount - 1)
            {
                if (e.Modifiers!=Keys.Shift & e.KeyValue==9)
                {
                    e.IsInputKey = true;
                    btnEditLines.PerformClick();
                   
                }
            } 
        }

        private void dgvOrderLines_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            double selectedSqm = 0;
            double selectedKgr = 0;

            if (dgv.CurrentRow!=null )
            {
   
                OrderLines orderline1 = dgv.CurrentRow.DataBoundItem as OrderLines;
                try
                {
                    lblCurrentSqmValue.Text = Math.Round((double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating), 2).ToString();
                    lblCurrentRowKgrValue.Text = Math.Round((double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating), 2).ToString();
                    orderline1.QtySqm = Convert.ToDouble(lblCurrentSqmValue.Text);
                    orderline1.QtyKgr = Convert.ToDouble(lblCurrentRowKgrValue.Text);
                } catch
                {
                    lblCurrentSqmValue.Text = "0";
                    lblCurrentRowKgrValue.Text = "0";
                    orderline1.QtySqm = Convert.ToDouble(lblCurrentSqmValue.Text);
                    orderline1.QtyKgr = Convert.ToDouble(lblCurrentRowKgrValue.Text);
                }
              /*  foreach (DataGridViewRow row in dgvOrderLines.Rows)
                {
                    try
                    {
                        if (row.Selected == true && row.DataBoundItem != null)
                        {
                            OrderLines ordline1 = row.DataBoundItem as OrderLines;
                            selectedSqm += (double)ordline1.QtySqm;
                            selectedKgr += (double)ordline1.QtyKgr;
                        }
                    } catch { }
                } */
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                bool rowIsAdded = false;
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (rowIsAdded == false)
                    {
                        if (dgv.Rows[i].Cells[j].Selected == true)
                        {
                            try
                            {
                                if (dgv.Rows[i].Index !=-1 & dgv.Rows[i].DataBoundItem!=null)
                                {
                                
                                    OrderLines ordln = dgv.Rows[i].DataBoundItem as OrderLines;
                                    selectedSqm += (double)ordln.QtySqm;
                                    selectedKgr += (double)ordln.QtyKgr;
                                    rowIsAdded = true;
                                
                                }
                            } catch { }
                        }
                    }
                }
            }
            lblSqmSelectedSum.Text = selectedSqm.ToString();
            lblKgrSelectedSum.Text = selectedKgr.ToString();
        }

        private void lblSelectedSum_Click(object sender, EventArgs e)
        {

        }

        private void btnAttachmentRemove_Click(object sender, EventArgs e)
        {
            if (dgvAttachments.CurrentRow.Index!=-1 & dgvAttachments.CurrentRow.DataBoundItem!=null)
            {
                if (MessageBox.Show("Сигурни ли сте, че искате да изтриете файл :" + dgvAttachments.CurrentRow.Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UploadedFiles uploadedFile = dgvAttachments.CurrentRow.DataBoundItem as UploadedFiles;
                    uploadedFilesBindingSource.Remove(uploadedFile);
                    db.UploadedFiles.Remove(uploadedFile);
                }
            }
        }

        private void btnExportExel_Click(object sender, EventArgs e)
        {
            Exel.Application exel = new Exel.Application();
            exel.Visible = true;

            object Missing = Type.Missing;

            Workbook workbook = exel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 0;
            int StartRow = 1;
            for(int j = 1; j < dgvOrderLines.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgvOrderLines.Columns[j].HeaderText;
            }
            StartRow++;
            for(int i = 0; i < dgvOrderLines.Rows.Count; i++)
            {
                for(int j=1; j< dgvOrderLines.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgvOrderLines.Rows[i].Cells[j].Value == null ? "" : dgvOrderLines[j, i].Value;
                }
            }
        }
    }
}
