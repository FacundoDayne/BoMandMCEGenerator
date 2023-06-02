using BoMandMCEGenerator.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator.MainPanels
{
    public partial class MainPanel_ViewBOM : UserControl
    {
        Stack<PreviousBOM> previousBOM;
        public MainPanel_ViewBOM()
        {
            InitializeComponent();
            previousBOM = new SampleData(17).previousBOMs;
            this.SizeChanged += reTable;
            this.OnSizeChanged(EventArgs.Empty);
        }

        private void reTable(object sender, EventArgs e)
        {
            if(LandingForm.landingForm.WindowState != FormWindowState.Minimized)
            {
                // Define the initial number of columns and rows
                int initialColumns = tableLayoutPanel1.ColumnCount;
                int initialRows = tableLayoutPanel1.RowCount;
                int neededCells = previousBOM.Count;
                int currentCells = initialColumns * initialRows;

                // Calculate the total number of columns and rows
                int desiredColumns = (int)(tableLayoutPanel1.Width / 400);
                int desiredRows = 0;
                try{
                    desiredRows = (int)Math.Ceiling(Convert.ToDouble((neededCells + desiredColumns - 1) / desiredColumns));
                }
                catch (DivideByZeroException d)
                {
                    Console.WriteLine("Minimized: {0}",d);
                    desiredColumns = 1;
                }                
                if (neededCells > currentCells)
                {

                    bool g = neededCells < currentCells - desiredColumns;

                }
                //int desiredRows = (int)(tableLayoutPanel1.Height / 300) + 1;

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
                            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300));
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
                                break;
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
                //Checks to see if the cells are empty
                for (int i = 1; i < tableLayoutPanel1.RowCount + 1; i++)
                {
                    for (int j = 1; j < tableLayoutPanel1.ColumnCount + 1; j++)
                    {
                        try { 
                            //Places a placeholder in the cells that are empty
                            tableLayoutPanel1.Controls.Add(new ViewBOM_Plate(previousBOM.Pop()));
                            cells++;
                        }
                        catch (InvalidOperationException b)
                        {
                            break;
                        }
                }
                }
                Console.WriteLine("Number of cells: {0}", cells);
            }
            
        } 
    }
}
