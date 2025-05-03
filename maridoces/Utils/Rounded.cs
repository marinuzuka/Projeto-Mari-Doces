using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace maridoces.Utils
{
    internal class Rounded
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern nint CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );

        public static void setRoundedController(Control controller, int borderRadius)
        {
            AddBorderRadius(controller, borderRadius);
            controller.Resize += PaintOnResize;
        }

        public static void PaintOnResize(object sender, EventArgs e)
        {
            if (sender is not null)
            {
                AddBorderRadius((Control)sender);
            }
        }

        public static void AddBorderRadius(Control controller, int borderRadius = 16)
        {
            controller.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    controller.Width,
                    controller.Height,
                    borderRadius,
                    borderRadius
                )
            );
        }
    }
}
