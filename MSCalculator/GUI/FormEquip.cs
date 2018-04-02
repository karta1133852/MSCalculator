using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSCalculator
{
  public partial class FormEquip : Form
  {
    private FormMain formMain;

    public FormEquip(int type, FormMain formMain)
    {
      InitializeComponent();
      this.formMain = formMain;

      //labelCat.Location = new Point(41 * 72 / 96, 182 * 72 / 96);
    }

    private void buttonConfirm_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
