//using CloudinaryDotNet.Actions;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Size = System.Drawing.Size;

namespace doan
{
    public partial class DoanhThuForm : Form
    {
        THANHTOAN thanhtoan = new THANHTOAN();
        public DoanhThuForm()
        {
            InitializeComponent();
        }

        private void DoanhThuForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM doanhthu");
            dataGridViewDoanhThu.ReadOnly = true;
            dataGridViewDoanhThu.RowTemplate.Height = 30;
            dataGridViewDoanhThu.DataSource = thanhtoan.getDT(command);
            dataGridViewDoanhThu.AllowUserToAddRows = false;
        }

        private void buttonLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewDoanhThu, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;


                ///////   ĐÂY LÀ SAVE BÌNH THƯỜNG CHƯA CĂN CHỈNH

                /*Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
               for (int r = 0; r <= RowCount - 1; r++)
               {
                   oTemp = "";
                   for (int c = 0; c < ColumnCount - 1; c++)
                   {
                       oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                   }
                   var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                   oPara1.Range.Text = oTemp;
                   oPara1.Range.InsertParagraphAfter();
                   byte[] imgbyte = (byte[])dataGridViewPrint.Rows[r].Cells[7].Value;
                   MemoryStream ms = new MemoryStream(imgbyte);
                   //Image sparePicture = Image.FromStream(ms);
                   Image finalPic = (Image)new Bitmap(Image.FromStream(ms), new System.Drawing.Size(50, 50));
                   Clipboard.SetDataObject(finalPic);
                   var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                   oPara2.Range.Paste();
                   oPara2.Range.InsertParagraphAfter();
                   //oTemp += "\n";
               }
               //save the file
               oDoc.SaveAs2(filename);*/
                //////////////////////////////////////////////////////////////////////////////////////


                //////        ĐÂY LÀ SAVE CÓ CHIA CỘT THẲNG HÀNG       

                Object[,] dataArray = new object[RowCount + 1, ColumnCount + 1];
                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        dataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page origiantion
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + dataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                       Type.Missing, Type.Missing, ref ApplyBorders,
                                       Type.Missing, Type.Missing, Type.Missing,
                                       Type.Missing, Type.Missing, Type.Missing,
                                       Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Time New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 20;
                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table sytle
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text
                DateTime ngaybatdau = Convert.ToDateTime(dateTimePickerNgayBatDau.Value.ToString());
                DateTime ngayketthuc = Convert.ToDateTime(dateTimePickerNgayKetThuc.Value.ToString());
                
                TimeSpan check1 = ngaybatdau-ngayketthuc;
                int ngay = check1.Days;
                if (ngay < 1)
                {
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "Doanh Thu Ngay " + Convert.ToString(dateTimePickerNgayKetThuc.Value.ToString("dd/MM/yyyy"));
                        headerRange.Font.Size = 20;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                }
                else
                {
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "Doanh Thu  Tu Ngay " + Convert.ToString(dateTimePickerNgayBatDau.Value.ToString("dd/MM/yyyy")) + " den ngay " + Convert.ToString(dateTimePickerNgayKetThuc.Value.ToString("dd/MM/yyyy"));
                        headerRange.Font.Size = 20;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                }
                //save image
                
                //save file
                oDoc.SaveAs(filename);
            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerNgayBatDau.Value;
            DateTime end = dateTimePickerNgayKetThuc.Value;
            if (start > end)
            {
                DateTime temp = start;
                start = end;
                end = temp;
            }
             SqlCommand command = new SqlCommand("SELECT * FROM doanhthu where ngaytra between @start and @end");
             command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
             command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
             dataGridViewDoanhThu.DataSource = thanhtoan.getDT(command);
        }
    }
}
