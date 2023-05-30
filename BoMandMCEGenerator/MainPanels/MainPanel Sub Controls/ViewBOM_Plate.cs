using System.Windows.Forms;

namespace BoMandMCEGenerator.MainPanels
{
    public partial class ViewBOM_Plate : UserControl
    {
        public ViewBOM_Plate(PreviousBOM previousBOM)
        {
            InitializeComponent();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Margin = new System.Windows.Forms.Padding(20);

            this.SetStyle(
            System.Windows.Forms.ControlStyles.UserPaint |
            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
            true);

            lblDate.Text = previousBOM.getDate.ToString();
            lblID.Text = previousBOM.getID.ToString();
            lblTotal.Text = previousBOM.getTotal.ToString();


        }
    }
}
