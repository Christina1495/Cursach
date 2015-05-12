using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cursach
{
    class ExcelDiagram
    {
        /// <summary>
        /// Создание диаграммы прибыли по месяцам
        /// </summary>
        /// 

        
        public string excel(int[] exc)
        {
            Excel.Application xlapp = new Excel.Application();
            xlapp.Visible = true;
            Excel.Workbook xlappwb = xlapp.Workbooks.Add(Type.Missing);
            Excel.Worksheet xlappwsh = (Excel.Worksheet)xlappwb.Worksheets.get_Item(1);
            xlappwsh.Cells[1, 1] = "Месяц";
            xlappwsh.Cells[1, 2] = "Прибыль";            
            string[] month = { "январь", "февраль", "март", "апрель", "мая", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            for (int i = 0; i < 12; i++ )
            {
                xlappwsh.Cells[i + 2, 1] = month[i];
                xlappwsh.Cells[i + 2, 2] = exc[i];
            }
            xlapp.Cells.ColumnWidth = 10;
            Excel.Range chartRange;
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlappwsh.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(150, 10, 510, 293);
            Excel.Chart chartPage = myChart.Chart;
            chartRange = xlappwsh.get_Range("A1", "B13");
            chartPage.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xl3DColumnStacked;
            chartPage.Legend.Clear();
            object misValue = System.Reflection.Missing.Value;           
            chartPage.SetSourceData(chartRange, misValue);
            string path = System.Windows.Forms.Application.StartupPath + "\\doc\\excel_chart_export.bmp";
            //@"D:\excel_chart_export.bmp";
            //export chart as picture file
            chartPage.Export(path, "BMP", misValue);
           // xlappwb.Save();
            xlappwb.Close(true, Type.Missing, false);
            xlapp.Quit();
            return path;
        }
    }
}
