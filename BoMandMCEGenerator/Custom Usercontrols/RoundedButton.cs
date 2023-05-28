using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

public class RoundButton : Button
{
    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // X-coordinate of upper-left corner or padding at start
        int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
        int nRightRect, // X-coordinate of lower-right corner or Width of the object
        int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                        //RADIUS, how round do you want it to be?
        int nheightRect, //height of ellipse 
        int nweightRect //width of ellipse
    );
    
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        GraphicsPath grPath = new GraphicsPath();
        this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
        base.OnPaint(e);
    }

    protected void OnFontChanged(EventArgs e)
    {
        base.OnFontChanged(e);
        this.Font = this.Font;
        base.Invalidate();
    }

}
