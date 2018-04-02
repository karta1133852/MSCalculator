using System;
using System.Drawing;
using System.Windows.Forms;
using MSCalculatorLib;
using MSCalculatorLib.GUI;

namespace MSCalculator
{
  public partial class FormARC : Form
  {
    private int arcType;
    private String[] arcLvLabel;
    private FormMain formMain;
    private Bitmap[] iconARC =
    {
      Properties.Resources.arcane1,
      Properties.Resources.arcane2,
      Properties.Resources.arcane3,
      Properties.Resources.arcane4,
      Properties.Resources.arcane5
    };
    private CharacterData characterData;

    public FormARC(int arcType, FormMain formMain, CharacterData characterData)
    {
      InitializeComponent();

      this.arcType = arcType;
      this.characterData = characterData;
      pictureBoxARC.Image = iconARC[arcType];
      this.formMain = formMain;
      arcLvLabel = new String[MSData.arcMaxLv + 1];
      arcLvLabel[0] = "未裝備";
      for (int i = 0; i < MSData.arcMaxLv; i++)
      {
        arcLvLabel[i+1] = "Lv. " + (i + 1);
      }
      comboBoxARCLv.DataSource = arcLvLabel;
      comboBoxARCLv.SelectedIndex = characterData.arcLv[arcType];
      if (!characterData.isArcEquiped[arcType])
        comboBoxARCLv.SelectedIndex = 0;
      labelARCName.Text = "祕法符文 : " + this.formMain.ARCName[arcType];
    }

    private void buttonConfirm_Click(object sender, EventArgs e)
    {
      characterData.arcLv[arcType] = comboBoxARCLv.SelectedIndex;
      characterData.isArcEquiped[arcType] = comboBoxARCLv.SelectedIndex == 0 ? false : true;
      formMain.RefreshARC();
      this.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
