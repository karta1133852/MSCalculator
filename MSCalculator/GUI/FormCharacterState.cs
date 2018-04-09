using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSCalculatorLib.GUI;

namespace MSCalculator
{
  public partial class FormCharacterState : Form
  {
    private Point mouse_offset;
    private bool isTitleBar = false;

    public FormCharacterState()
    {
      InitializeComponent();
      Init();
    }

    private void Init()
    {
      //Needed to make the custom shaped Form
      this.FormBorderStyle = FormBorderStyle.None;
      //this.Width = this.BackgroundImage.Width;
      //this.Height = this.BackgroundImage.Height;
      this.ClientSize = new Size(912, 534);

      //Slow version
      //this.Region = BitmapToRegion.getRegion((Bitmap)this.BackgroundImage, Color.FromArgb(0, 255, 0), 100);

      //Fast version
      this.Region = BitmapToRegion.getRegionFast((Bitmap)Properties.Resources.characterStateMask, Color.FromArgb(0, 255, 0), 100);
    }

    private void FormCharacterState_MouseClick(object sender, MouseEventArgs e)
    {
      //MessageBox.Show("X : " + e.X);
      //MessageBox.Show("Y : " + e.Y);
      int x = e.X, y = e.Y;

      //532 8 544 21
      if (x >= 564 && y >= 10 && x <= 577 && y <= 22)
      {
        this.Close();
      }
    }

    private void FormCharacterState_MouseDown(object sender, MouseEventArgs e)
    {
      isTitleBar = (e.X >= 278 && e.X <= 591 && e.Y <= 33) && !(e.X >= 564 && e.Y >= 10 && e.X <= 577 && e.Y <= 22);
      mouse_offset = new Point(-e.X, -e.Y);
    }

    private void FormCharacterState_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && isTitleBar)
      {
        Point mousePos = Control.MousePosition;
        mousePos.Offset(mouse_offset.X, mouse_offset.Y);
        Location = mousePos;
      }
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      // Display a MsgBox asking the user to close or cancel.
      if (MessageBox.Show("確定要關閉視窗嗎?", "提示",
         MessageBoxButtons.YesNo) == DialogResult.No)
      {
        // Cancel the Closing event from closing the form.
        e.Cancel = true;
        return;
      }
      Environment.Exit(1);
    }
  }
}
