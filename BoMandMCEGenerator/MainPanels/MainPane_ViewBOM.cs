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
            int initialRows = tableLayoutPanel1.RowCount ;

            // Define the width and height increments
            int columnWidthIncrement = 220;
            int rowHeightIncrement = 150;

            // Calculate the total number of columns and rows
            //int totalColumns = (int)(initialColumns + (tableLayoutPanel1.Width - tableLayoutPanel1.ColumnStyles[0].Width) / columnWidthIncrement);
            //int totalRows = (int)(initialRows + (tableLayoutPanel1.Height - tableLayoutPanel1.RowStyles[0].Height) / rowHeightIncrement);

            int desiredColumns = (int)(tableLayoutPanel1.Width / 200);
            int desiredRows = (int)(tableLayoutPanel1.Height / 150);

            Console.WriteLine("Total Rows: " + desiredRows + "\nTotal Columns: " + desiredColumns);
            Console.WriteLine("Current Rows: " + tableLayoutPanel1.RowCount + "\nCurrent Columns: " + tableLayoutPanel1.ColumnCount);

            // Adjust the column styles
            if (initialColumns != desiredColumns)
            {
                tableLayoutPanel1.ColumnCount = desiredColumns;
                if (initialColumns < desiredColumns)
                {     
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100/ tableLayoutPanel1.ColumnCount));
                }
                else if(initialColumns > desiredColumns)
                {
                    try
                    {
                        tableLayoutPanel1.ColumnStyles.RemoveAt(initialColumns - 1);
                    }
                    catch(ArgumentOutOfRangeException d)
                    {
                        Console.WriteLine(d.Message);
                    }
                }
                for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                {
                    try
                    {
                        tableLayoutPanel1.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 100 / tableLayoutPanel1.ColumnCount);
                    }
                    
                    catch(ArgumentOutOfRangeException d)
                    {
                        Console.WriteLine(d.Message);
                    }
                }
            }

        }

       

    }
}
