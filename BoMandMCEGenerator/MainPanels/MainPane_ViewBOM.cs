using BoMandMCEGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator.MainPanels
{
    public partial class MainPane_ViewBOM : UserControl
    {
        public MainPane_ViewBOM()
        {

            InitializeComponent();
            this.SizeChanged += reTable;
            this.OnSizeChanged(EventArgs.Empty);
        }

        private void reTable(object sender, EventArgs e)
        {
            // Define the initial number of columns and rows
            int initialColumns = tableLayoutPanel1.ColumnCount;
            int initialRows = tableLayoutPanel1.RowCount;

            // Define the width and height increments
            int columnWidthIncrement = 220;
            int rowHeightIncrement = 150;

            // Calculate the total number of columns and rows
            //int totalColumns = (int)(initialColumns + (tableLayoutPanel1.Width - tableLayoutPanel1.ColumnStyles[0].Width) / columnWidthIncrement);
            //int totalRows = (int)(initialRows + (tableLayoutPanel1.Height - tableLayoutPanel1.RowStyles[0].Height) / rowHeightIncrement);

            int desiredColumns = (int)(tableLayoutPanel1.Width / 200);
            int desiredRows = (int)(tableLayoutPanel1.Height / 200) + 1;

            Console.WriteLine("Total Rows: " + desiredRows + "\nTotal Columns: " + desiredColumns);
            Console.WriteLine("Current Rows: " + tableLayoutPanel1.RowCount + "\nCurrent Columns: " + tableLayoutPanel1.ColumnCount);

            // Adjust the column styles
            if (initialColumns != desiredColumns)
            {
                tableLayoutPanel1.ColumnCount = desiredColumns;

                for (int i = initialColumns; i != desiredColumns;)
                {
                    if (initialColumns < desiredColumns)
                    {
                        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tableLayoutPanel1.ColumnCount));
                        i = i + 1;
                    }
                    else if (initialColumns > desiredColumns)
                    {
                        try
                        {
                            tableLayoutPanel1.ColumnStyles.RemoveAt(tableLayoutPanel1.ColumnCount - 1);
                            i = i - 1;
                        }
                        catch (ArgumentOutOfRangeException d)
                        {
                            Console.WriteLine("Line 63");
                        }
                    }
                }
                for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                {
                    try
                    {
                        tableLayoutPanel1.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 100 / tableLayoutPanel1.ColumnCount);
                    }

                    catch (ArgumentOutOfRangeException d)
                    {
                        Console.WriteLine("Line 76");
                    }
                }
            }

            //Adjust the Rows
            if (initialRows != desiredRows)
            {
                tableLayoutPanel1.RowCount = desiredRows;

                for (int i = initialRows; i != desiredRows;)
                {
                    if (initialRows < desiredRows)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / tableLayoutPanel1.RowCount));
                        i = i + 1;
                    }
                    else if (initialRows > desiredRows)
                    {
                        try
                        {
                            tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount - 1);
                            i = i - 1;
                        }
                        catch (ArgumentOutOfRangeException d)
                        {
                            Console.WriteLine("Line 102");
                        }
                    }
                }
                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    try
                    {
                        tableLayoutPanel1.RowStyles[i] = new RowStyle(SizeType.Percent, 100 / tableLayoutPanel1.RowCount);
                    }

                    catch (ArgumentOutOfRangeException d)
                    {
                        Console.WriteLine("Line 76");
                    }
                }
            }
            int cells = 0;
            for(int i = 1; i < tableLayoutPanel1.RowCount + 1; i++)
            {
                int row = i - 1;
                for (int j = 1; j < tableLayoutPanel1.ColumnCount + 1; j++)
                {
                    int col = j - 1;
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control == null) {
                        Console.WriteLine("Cell at Column: {0} Row: {1} is empty", col, row);
                        tableLayoutPanel1.Controls.Add(new TestPicture(Resources.bronya));
                    }
                    cells++;
                }
            }
            Console.WriteLine("Number of cells: {0}", cells);
        } 
    }
}
