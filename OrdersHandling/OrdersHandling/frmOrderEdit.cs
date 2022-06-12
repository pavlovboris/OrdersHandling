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
using System.Text.RegularExpressions;

namespace OrdersHandling
{
    public partial class frmOrderEdit : Form
    {
        public frmOrderEdit()
        {
            InitializeComponent();
        }

        private static frmOrderEdit _instance;
        public static frmOrderEdit Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmOrderEdit();
                return _instance;
            }
        }

        public Orders order = new Orders();
        public OrdersHandlingEntities db;
        private void frmOrderEdit_Load(object sender, EventArgs e)
        {
            _instance = this;

            if (frmLogin.Instance.UserInfo.RoleID == 1)
            {
                cmbPartnerName.Enabled = true;
                chkboxOffer.Enabled = true;
                chkBoxCompleated.Enabled = true;
            }
            else
            {
                cmbPartnerName.Enabled = false;
                chkboxOffer.Enabled = false;
                chkBoxCompleated.Enabled= false;
            }

            db.Database.Connection.ConnectionString = "data source=definedsolutions-sql-server.database.windows.net;initial catalog=OrdersHandling;persist security info=True;user id=CstmDBDefSol;Password=uncloak-TAIWAN-peccary-listless; MultipleActiveResultSets=True;App=EntityFramework;";

            uploadedFilesBindingSource.DataSource = db.UploadedFiles.Where(u => u.OrderID == order.ID).ToList();
            partnersBindingSource.DataSource = db.Partners.ToList();
            codesBindingSource.DataSource = db.Codes.Where(c => c.Type == 5).ToList();
            colorsBindingSource.DataSource = db.Colors.ToList();
            ordersBindingSource.DataSource = order;
            lblOrderNumber.Text = order.ID.ToString();
            codesBindingSource1.DataSource = db.Codes.ToList();
            surfaceBindingSource.DataSource = db.Surface.ToList();
            mUBindingSource.DataSource = db.MU.ToList();
            orderLinesBindingSource.DataSource = db.OrderLines.Where(o => o.OrderID == order.ID).ToList();
            cmbPartnerName.DropDownStyle = ComboBoxStyle.DropDownList;

            //Update order infor panel starts here 
            double sqm = 0;
            double kgr = 0;
            double value = 0;

            foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
            {
                try
                {
                    if (dgvr != null)
                    {
                        OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                        double tmpsqm = 0;
                        double tmpkgr = 0;
                        double tmpvalue = 0;
                        try
                        {
                            tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            tmpvalue = (double)(orderline1.Value);
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
                        if (tmpvalue.ToString() != "")
                        {
                            value += tmpvalue;
                        }
                    }
                }
                catch { };
            }
            lblSqmSum.Text = Math.Round(sqm, 2).ToString();
            lblKgrSum.Text = Math.Round(kgr, 2).ToString();
            lblValueSum.Text = Math.Round(value, 2).ToString();

            //Update order info panel ends here

            dgvOrderLines.Columns[2].Frozen = true;            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да запазите записа?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    order.OrderSQM = Convert.ToDouble(lblSqmSum.Text);
                    order.Orderkgr = Convert.ToDouble(lblKgrSum.Text);
                    order.OrderValue = Convert.ToDouble(lblValueSum.Text);

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

        private void btnEditLines_Click(object sender, EventArgs e)
        {
            OrderLines orderline = new OrderLines();
            orderline.OrderID = order.ID;
            orderline.CodeID = 6;
            Codes code = (from codes in db.Codes where codes.ID == orderline.CodeID select codes).SingleOrDefault();
            // Partners partner = cmbPartnerName.SelectedItem as Partners;

            orderline.SurfaceID = (int)code.DefaultSurface;

            if (partnerCoatingGroup != null && partnerCoatingGroup.DefaultMu != null && orderline.SurfaceID != 1)
            {

                orderline.MU = (int)partnerCoatingGroup.DefaultMu;

            }
            else
            {
                orderline.MU = code.DefaultMU;
            }


            //orderline.MU = code.DefaultMU;
            orderline.Length = code.DefaultLength;
            orderline.Perimeter = code.Perimeter;
            orderline.Weight = code.Weigth;
            orderline.ProtectiveFilm = partner.DefaultPF * code.PF;
            if (orderline.SurfaceID.ToString() == null)
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

            if (frmcodeselector.dgvCodeSelector.CurrentRow != null & frmcodeselector.cancel == false)
            {
                if (frmcodeselector.xclicked != true)
                {
                    Codes code = frmcodeselector.dgvCodeSelector.CurrentRow.DataBoundItem as Codes;
                    dgvOrderLines.Focus();
                    dgvOrderLines.CurrentCell = dgvOrderLines.CurrentRow.Cells[2];


                    dgvOrderLines.CurrentCell.Value = code.ID;
                }
                else if (dgvOrderLines.CurrentRow.Index == dgvOrderLines.RowCount - 1 && dgvOrderLines.Rows[dgvOrderLines.CurrentRow.Index].Cells[5].Value.ToString() == "0")
                {
                    OrderLines line = dgvOrderLines.CurrentRow.DataBoundItem as OrderLines;
                    orderLinesBindingSource.Remove(line);
                    db.OrderLines.Remove(line);
                }
            }
            else if (frmcodeselector.dgvCodeSelector.CurrentRow != null && dgvOrderLines.CurrentRow.Index == dgvOrderLines.RowCount - 1 && dgvOrderLines.Rows[dgvOrderLines.CurrentRow.Index].Cells[5].Value.ToString() == "0")
            {
                OrderLines line = dgvOrderLines.CurrentRow.DataBoundItem as OrderLines;
                orderLinesBindingSource.Remove(line);
                db.OrderLines.Remove(line);
            }

        }

        PartnerCoatingGroup partnerCoatingGroup;
        CoatingGroup coatingGroup;
        Codes powderCode;
        CoatingPrices coatingPrices;
        Partners partner;

        private void dgvOrderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrderLines.CurrentRow != null && dgvOrderLines.CurrentRow.DataBoundItem != null)
                {
                    OrderLines orderline = dgvOrderLines.Rows[e.RowIndex].DataBoundItem as OrderLines;
                    Codes code = (from codes in db.Codes where codes.ID == orderline.CodeID select codes).SingleOrDefault();
                    Types type = (from types in db.Types where types.TypeID == code.Type select types).SingleOrDefault();

                    if (e.ColumnIndex == 2 | e.ColumnIndex == 3)
                    {
                        if (code.DefaultSurface != null)
                        {
                            orderline.SurfaceID = (int)code.DefaultSurface;
                        }
                        else
                        {
                            orderline.SurfaceID = 1;
                        }


                        if (partnerCoatingGroup!=null && partnerCoatingGroup.DefaultMu!=null && orderline.SurfaceID != 1)
                        {
                            
                            orderline.MU = (int)partnerCoatingGroup.DefaultMu;

                        } else
                        {
                            orderline.MU = code.DefaultMU;
                        }
                        orderline.Length = code.DefaultLength;
                        orderline.Perimeter = code.Perimeter;
                        orderline.Weight = code.Weigth;
                        orderline.ProtectiveFilm = partner.DefaultPF * code.PF;

                        

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

                    if (partner.CoatingGroup != null & cmbPowder.SelectedValue != null )
                    {
                        powderCode = (from pc in db.Codes where pc.ID == (int)cmbPowder.SelectedValue select pc).SingleOrDefault();
                        coatingGroup = (from cg in db.CoatingGroup where cg.ID == powderCode.CoatingGroup select cg).SingleOrDefault();
                    }


                    try
                    {
                        lblCurrentSqmValue.Text = Math.Round((double)(orderline.QTY * (orderline.Perimeter / 1000) * orderline.SqmCorrections * orderline.IsForCoating), 2).ToString();
                        lblCurrentRowKgrValue.Text = Math.Round((double)(orderline.QTY * (orderline.Weight / 1000) * orderline.SqmCorrections * orderline.IsForCoating), 2).ToString();
                        orderline.QtySqm = Convert.ToDouble(lblCurrentSqmValue.Text);
                        orderline.QtyKgr = Convert.ToDouble(lblCurrentRowKgrValue.Text);
                    }
                    catch
                    {
                        lblCurrentSqmValue.Text = "0";
                        lblCurrentRowKgrValue.Text = "0";
                        orderline.QtySqm = Convert.ToDouble(lblCurrentSqmValue.Text);
                        orderline.QtyKgr = Convert.ToDouble(lblCurrentRowKgrValue.Text);
                    }




                    if (coatingGroup!=null & powderCode!=null & partnerCoatingGroup!=null)
                    {


                        coatingPrices = (from cp in db.CoatingPrices where cp.PartnerCoatingGrpID == partnerCoatingGroup.ID & cp.CoatingGroupID == coatingGroup.ID & cp.MuID == orderline.MU select cp).SingleOrDefault();

                        if (coatingPrices !=null)
                        {
                            orderline.Price = coatingPrices.Price;

                            switch (orderline.MU)
                            {
                                case 1:
                                    orderline.Value = Math.Round((double)orderline.QtySqm * (double)orderline.Price, 2);
                                    break;
                                case 2:
                                    orderline.Value = Math.Round((double)orderline.QtyKgr * (double)orderline.Price, 2);
                                    break;
                                case 4:
                                    orderline.Value = Math.Round((double)orderline.QTY * (double)orderline.Price, 2);
                                    break;

                                default:
                                    orderline.Value = 0;
                                    break;
                            }
                            dgvOrderLines.Refresh();
                        }
                    }

                    //Update order infor panel starts here 
                    double sqm = 0;
                    double kgr = 0;
                    double value = 0;

                    foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
                    {
                        if (dgvr != null)
                        {
                            OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                            double tmpsqm = 0;
                            double tmpkgr = 0;
                            double tmpvalue = 0;
                            try
                            {
                                tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                                tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                                tmpvalue = (double)(orderline1.Value);
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
                            if (tmpvalue.ToString() != "")
                            {
                                value += tmpvalue;
                            }
                        }
                    }
                    lblSqmSum.Text = Math.Round(sqm, 2).ToString();
                    lblKgrSum.Text = Math.Round(kgr, 2).ToString();
                    lblValueSum.Text = Math.Round(value, 2).ToString();
                    //Update order info panel ends here
                }
            }
            catch { }
        }

        private void dgvOrderLines_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 21)
            {
                frmDatePicker frmdatepicker = new frmDatePicker();
                frmdatepicker.Show();
                frmdatepicker.FormClosed += Frmdatepicker_FormClosed;
            }
        }

        private void Frmdatepicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDatePicker datepicker = (frmDatePicker)sender;

            if (datepicker.isClosed == 0)
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
            if (e.RowIndex!=-1 & e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                frmCodeSelector frmcodeselector = new frmCodeSelector();
                frmcodeselector.FormClosing += Frmcodeselector_FormClosing;
                frmcodeselector.Show();
            }
        }

        private void dgvOrderLines_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1 && dgvOrderLines.Rows[e.RowIndex].DataBoundItem != null)
                {

                    dgvOrderLines.ClearSelection();
                    dgvOrderLines.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void dgvContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete")
            {
                foreach (DataGridViewRow dr in dgvOrderLines.Rows)
                {
                    if (dr.DataBoundItem != null && dr.Selected == true)
                    {
                        if (MessageBox.Show("Сигурни ли сте, че искате да изтриете избраните редове?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                double value = 0;

                foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
                {
                    if (dgvr != null)
                    {
                        OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                        double tmpsqm = 0;
                        double tmpkgr = 0;
                        double tmpvalue = 0;
                        try
                        {
                            tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            tmpvalue = (double)(orderline1.Value);
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
                        if (tmpvalue.ToString() != "")
                        {
                            value += tmpvalue;
                        }
                    }
                }
                lblSqmSum.Text = Math.Round(sqm, 2).ToString();
                lblKgrSum.Text = Math.Round(kgr, 2).ToString();
                lblValueSum.Text = Math.Round(value, 2).ToString();
                //Update order info panel ends here
            }
            else if (e.ClickedItem.Text=="Paste")
            {
                try
                {
                   // Partners partner = cmbPartnerName.SelectedItem as Partners;
                    DataObject dataObject = (DataObject)Clipboard.GetDataObject();
                    if (dataObject.GetDataPresent(DataFormats.Text))
                    {

                        string[] pastedRows = Regex.Split(dataObject.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");

                        if (MessageBox.Show("Сигурни ли сте, че искате да въведете автоматично следните данни : \n " + dataObject.GetData(DataFormats.Text).ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (string row in pastedRows)
                            {
                                OrderLines newOrderLine = new OrderLines();
                                string[] pastedRowCells = row.Split(new char[] { '\t' });

                                string codeofPasted = pastedRowCells[0];

                                Codes code = (from pastedCode in db.Codes where pastedCode.Code == codeofPasted select pastedCode).SingleOrDefault();

                                if (code != null)
                                {
                                    newOrderLine.CodeID = code.ID;
                                    newOrderLine.Pcs = Convert.ToInt32(pastedRowCells[1]);

                                    orderLinesBindingSource.Add(newOrderLine);
                                    db.OrderLines.Add(newOrderLine);

                                    if (partnerCoatingGroup != null && partnerCoatingGroup.DefaultMu != null && newOrderLine.SurfaceID != 1)
                                    {

                                        newOrderLine.MU = (int)partnerCoatingGroup.DefaultMu;

                                    }
                                    else
                                    {
                                        newOrderLine.MU = code.DefaultMU;
                                    }

                                    newOrderLine.Length = code.DefaultLength;
                                    newOrderLine.Perimeter = code.Perimeter;
                                    newOrderLine.Weight = code.Weigth;
                                    newOrderLine.ProtectiveFilm = partner.DefaultPF * code.PF;
                                    newOrderLine.DeliveryDate = dateTimeExpectedDate.Value;
                                    newOrderLine.OrderID = order.ID;

                                    if (code.DefaultSurface != null)
                                    {
                                        newOrderLine.SurfaceID = (int)code.DefaultSurface;
                                    }
                                    else
                                    {
                                        newOrderLine.SurfaceID = 1;
                                    }

                                    Types type = db.Types.Where(t => t.TypeID == code.Type).SingleOrDefault();

                                    newOrderLine.IsForCoating = type.IsForCoating;
                                    newOrderLine.SqmCorrections = 1;

                                    if (newOrderLine.Length == null)
                                    {
                                        newOrderLine.Length = 1;
                                    }

                                    newOrderLine.QTY = Math.Round((double)(newOrderLine.Pcs * newOrderLine.Length), 2);

                                    //Update order infor panel starts here 
                                    double sqm = 0;
                                    double kgr = 0;
                                    double value = 0;

                                    foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
                                    {
                                        if (dgvr != null)
                                        {
                                            OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                                            double tmpsqm = 0;
                                            double tmpkgr = 0;
                                            double tmpvalue = 0;
                                            try
                                            {
                                                tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                                                tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                                                tmpvalue = (double)(orderline1.Value);
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
                                            if (tmpvalue.ToString() != "")
                                            {
                                                value += tmpvalue;
                                            }
                                        }
                                    }
                                    lblSqmSum.Text = Math.Round(sqm, 2).ToString();
                                    lblKgrSum.Text = Math.Round(kgr, 2).ToString();
                                    lblValueSum.Text = Math.Round(value, 2).ToString();

                                    //Update order info panel ends here
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("Грешка при автоматично въвеждане на данни. За да въведете автоматично данните на всеки ред трябва да имате само две копирани полета - Код и количество", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void uploadFileDialog_FileOk(object sender, CancelEventArgs e)
        {
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

                    MessageBox.Show("Файлът е качен успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
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
                        }
                        catch
                        {
                            MessageBox.Show("Възникна грешка при записшане на файла, файла не записан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                }
            }
        }

        private void dgvOrderLines_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentCell.RowIndex == dgv.RowCount - 1)
            {
                if (e.Modifiers != Keys.Shift & e.KeyValue == 13 | e.KeyValue == 40 && dgv.CurrentRow.Cells[5].Value.ToString() != "0")
                {
                    e.IsInputKey = true;
                    btnEditLines.PerformClick();
                }
                else if (e.Modifiers != Keys.Shift & e.KeyValue == 13)
                {
                    dgv.CurrentCell = dgv.CurrentRow.Cells[5];
                }
            }
            else if (dgv.CurrentCell.ColumnIndex == dgv.ColumnCount - 1 & dgv.CurrentCell.RowIndex == dgv.RowCount - 1)
            {
                if (e.Modifiers != Keys.Shift & e.KeyValue == 9)
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

            if (dgv.CurrentRow != null)
            {

                OrderLines orderline1 = dgv.CurrentRow.DataBoundItem as OrderLines;
                try
                {
                    lblCurrentSqmValue.Text = Math.Round((double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating), 2).ToString();
                    lblCurrentRowKgrValue.Text = Math.Round((double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating), 2).ToString();
                    orderline1.QtySqm = Convert.ToDouble(lblCurrentSqmValue.Text);
                    orderline1.QtyKgr = Convert.ToDouble(lblCurrentRowKgrValue.Text);
                }
                catch
                {
                    lblCurrentSqmValue.Text = "0";
                    lblCurrentRowKgrValue.Text = "0";
                    orderline1.QtySqm = Convert.ToDouble(lblCurrentSqmValue.Text);
                    orderline1.QtyKgr = Convert.ToDouble(lblCurrentRowKgrValue.Text);
                }
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
                                if (dgv.Rows[i].Index != -1 & dgv.Rows[i].DataBoundItem != null)
                                {

                                    OrderLines ordln = dgv.Rows[i].DataBoundItem as OrderLines;
                                    selectedSqm += (double)ordln.QtySqm;
                                    selectedKgr += (double)ordln.QtyKgr;
                                    rowIsAdded = true;
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
            lblSqmSelectedSum.Text = selectedSqm.ToString();
            lblKgrSelectedSum.Text = selectedKgr.ToString();
        }

        private void btnAttachmentRemove_Click(object sender, EventArgs e)
        {
            if (dgvAttachments.CurrentRow != null && dgvAttachments.CurrentRow.Index != -1 & dgvAttachments.CurrentRow.DataBoundItem != null )
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
            for (int j = 1; j < dgvOrderLines.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgvOrderLines.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgvOrderLines.Rows.Count; i++)
            {
                for (int j = 1; j < dgvOrderLines.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    string vle = "";
                    OrderLines ordline = dgvOrderLines.Rows[i].DataBoundItem as OrderLines;

                    switch (StartCol + j)
                    {
                        case 1:
                            vle = dgvOrderLines[j, i].Value == null ? "" : dgvOrderLines[j, i].Value.ToString();
                            break;
                        case 2:
                            vle = ordline.Codes.Code.ToString();
                            break;
                        case 3:
                            vle = ordline.Codes.Description.ToString();
                            break;
                        case 4:
                            vle = ordline.Surface.Name.ToString();
                            break;
                        case 5:
                            vle = ordline.Pcs.ToString();
                            break;
                        case 6:
                            vle = ordline.Length.ToString();
                            break;
                        case 7:
                            vle = ordline.QTY.ToString();
                            break;
                        case 8:
                            vle = ordline.MU1.MuName.ToString();
                            break;
                    }
                    myRange.Value2 = vle;
                }
            }
        }

        private void FrmColorSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmColorSelector frmColorSelector = (frmColorSelector)sender;
            Enabled = true;
            if (frmColorSelector.dgvColorSelector.CurrentRow != null & frmColorSelector.cancel == false)
            {
                if (frmColorSelector.xclicked != true)
                {
                    Colors selectedcolor = frmColorSelector.dgvColorSelector.CurrentRow.DataBoundItem as Colors;
                    cmbColor.SelectedIndex = -1;
                    int selectedValue = selectedcolor.ID;
                    cmbColor.SelectedValue = selectedValue;
                }
            }
        }

        private void lblColor_DoubleClick(object sender, EventArgs e)
        {
            frmColorSelector frmColorSelector = new frmColorSelector();
            frmColorSelector.FormClosing += FrmColorSelector_FormClosing;
            Enabled = false;
            frmColorSelector.ShowDialog();

        }

        private void lblPowder_DoubleClick(object sender, EventArgs e)
        {
            frmPowderCodeSelector frmPowderCodeSelector = new frmPowderCodeSelector();
            frmPowderCodeSelector.FormClosing += FrmPowderCodeSelector_FormClosing;
            Enabled = false;
            frmPowderCodeSelector.ShowDialog();
        }

        private void FrmPowderCodeSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPowderCodeSelector frmPowderCodeSelector = (frmPowderCodeSelector)sender;
            Enabled = true;
            if (frmPowderCodeSelector.dgvCodeSelector.CurrentRow != null & frmPowderCodeSelector.cancel == false)
            {
                if (frmPowderCodeSelector.xclicked != true)
                {
                    Codes selectedPowder = frmPowderCodeSelector.dgvCodeSelector.CurrentRow.DataBoundItem as Codes;
                    cmbPowder.SelectedIndex = -1;
                    int selectedValue = selectedPowder.ID;
                    cmbPowder.SelectedValue = selectedValue;
                }
            }
        }

        private void cmbPartnerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox cmbPartnerName = (ComboBox)sender;

            if (cmbPartnerName.SelectedIndex != -1)
            {
                partner = cmbPartnerName.SelectedItem as Partners;

                partnerCoatingGroup = (from pcg in db.PartnerCoatingGroup where pcg.ID == partner.CoatingGroup select pcg).SingleOrDefault();

            }
        }

        private void cmbPowder_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
            {
                try
                {
                    if (dgvr.Index != -1 & dgvr.DataBoundItem != null)
                    {
                        OrderLines orderLines = dgvr.DataBoundItem as OrderLines;
                        if (partner.CoatingGroup != null & cmbPowder.SelectedValue != null)
                        {
                            powderCode = (from pc in db.Codes where pc.ID == (int)cmbPowder.SelectedValue select pc).SingleOrDefault();
                            coatingGroup = (from cg in db.CoatingGroup where cg.ID == powderCode.CoatingGroup select cg).SingleOrDefault();
                        } else
                        {
                            orderLines.Price = 0;
                            dgvOrderLines.Refresh();
                        }

                        if (coatingGroup != null & powderCode != null & partnerCoatingGroup != null)
                        {
                            coatingPrices = (from cp in db.CoatingPrices where cp.PartnerCoatingGrpID == partnerCoatingGroup.ID & cp.CoatingGroupID == coatingGroup.ID & cp.MuID == orderLines.MU select cp).SingleOrDefault();

                            if (coatingPrices != null)
                            {

                                orderLines.Price = coatingPrices.Price;
                                switch (orderLines.MU)
                                {
                                    case 1:
                                        orderLines.Value = Math.Round(  (double)orderLines.QtySqm*(double)orderLines.Price, 2);
                                        break;
                                    case 2:
                                        orderLines.Value = Math.Round((double)orderLines.QtyKgr * (double)orderLines.Price, 2);
                                        break;
                                    case 4:
                                        orderLines.Value = Math.Round((double)orderLines.QTY*(double)orderLines.Price, 2);
                                        break;

                                    default:
                                        orderLines.Value = 0;
                                        break;
                                }
                                dgvOrderLines.Refresh();

                            }
                        } else
                        {
                            orderLines.Price = 0;
                            orderLines.Value = 0;
                            dgvOrderLines.Refresh();
                        }


                    }
                } catch
                {

                }
            }
            //Update order infor panel starts here 
            double sqm = 0;
            double kgr = 0;
            double value = 0;

            foreach (DataGridViewRow dgvr in dgvOrderLines.Rows)
            {
                try
                {
                    if (dgvr != null)
                    {
                        OrderLines orderline1 = dgvr.DataBoundItem as OrderLines;
                        double tmpsqm = 0;
                        double tmpkgr = 0;
                        double tmpvalue = 0;
                        try
                        {
                            tmpsqm = (double)(orderline1.QTY * (orderline1.Perimeter / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            tmpkgr = (double)(orderline1.QTY * (orderline1.Weight / 1000) * orderline1.SqmCorrections * orderline1.IsForCoating);
                            tmpvalue = (double)(orderline1.Value);
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
                        if (tmpvalue.ToString() != "")
                        {
                            value += tmpvalue;
                        }
                    }
                } catch { };
            }
            lblSqmSum.Text = Math.Round(sqm, 2).ToString();
            lblKgrSum.Text = Math.Round(kgr, 2).ToString();
            lblValueSum.Text = Math.Round(value, 2).ToString();
            //Update order info panel ends here
        }
    }
}
