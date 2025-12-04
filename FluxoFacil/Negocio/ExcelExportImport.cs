using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FluxoFacil.Negocio
{
    public class ExcelExportImport
    {

        public void ExportExcel(DataGridView dgv)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Sem dados para exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Exportado";

                // Cabeçalhos
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                // Dados
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Mostrar Excel
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
