
namespace BoMandMCEGenerator
{

    //I dont really get how these codes work but theyre very useful
    public partial class MagicCodes
    {
//PLACE THIS INSIDE THE CONSTRUCTOR OF A CONTROL TO REMOVE FLICKERING

        //SOLUTION A
        /*
        this.SetStyle(
        System.Windows.Forms.ControlStyles.UserPaint | 
        System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | 
        System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
        true);
        */

        //SOLUTION B
        //typeof(
        //
        //          PLACE OBJECT TYPE HERE
        //
        //).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null,
        //
        //          PLACE OBJECT NAME HERE
        //
        //, new object[] { true });

    }
}
