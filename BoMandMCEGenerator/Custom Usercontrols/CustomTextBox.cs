using System;
using System.Drawing;
using System.Windows.Forms;


namespace BoMandMCEGenerator.Custom_Usercontrols
{
    public partial class CustomTextBox : TextBox
    {
        private const int DesiredHeight = 100; // Set the desired height here

        public override Size GetPreferredSize(Size proposedSize)
        {
            Size preferredSize = base.GetPreferredSize(proposedSize);
            preferredSize.Height = DesiredHeight;
            return preferredSize;
        }
    }
}
