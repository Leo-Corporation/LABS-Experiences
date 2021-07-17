using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LABS_Experiences.Forms
{
	public partial class ExcelForm : LABSForm
	{
		public ExcelForm()
		{
			InitializeComponent();
		}

		private void button34_Click(object sender, EventArgs e)
		{
			Excel.Application application = new();
			string filePath = textBox1.Text;

			if (application == null)
			{
				MessageBox.Show("Excel is not installed on this computer!");
				return;
			}
			object misValue = System.Reflection.Missing.Value;

			Excel.Workbook workbook = application.Workbooks.Add(misValue);
			Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

			worksheet.Cells[1, 1] = "Hello, ";
			worksheet.Cells[2, 1] = "World!";

			workbook.SaveAs2(filePath, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
			workbook.Close(true, misValue, misValue);
			application.Quit();

			System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
			System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
			System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

			MessageBox.Show("Excel file created!");
		}
	}
}
