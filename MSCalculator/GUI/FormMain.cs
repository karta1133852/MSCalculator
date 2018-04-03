using System;
using System.Drawing;
using System.Windows.Forms;
using MSCalculatorLib;
using MSCalculatorLib.GUI;

namespace MSCalculator
{
  public partial class FormMain : Form
  {
    private Point mouse_offset;
    private bool isTitle = false;

    private String[] EquipCat = 
    {
      "戒指1", "戒指2", "戒指3", "戒指4", "口袋", null,
      null, "項鍊2", "項鍊1", "武器", "腰帶", null,
      "帽子", "臉飾", "眼飾", "衣服", "褲子", "鞋子",
      null, null, "耳飾", "肩飾", "手套", "機器人",
      "能源", "胸章", "勳章", "副手武器", "披風", "心臟"
    };

    public String[] ARCName =
    {
      "消逝的旅途", "啾啾愛爾蘭", "拉契爾恩",
      "阿爾卡娜", "魔菈斯", null
    };

    private Bitmap[] bitmap =
    {
      Properties.Resources.equipment, Properties.Resources.cash,
      Properties.Resources.pet, Properties.Resources.android
    };
    private Bitmap[] bitmapArcLv =
    {
      Properties.Resources.arcLv0,
      Properties.Resources.arcLv1,
      Properties.Resources.arcLv2,
      Properties.Resources.arcLv3,
      Properties.Resources.arcLv4,
      Properties.Resources.arcLv5,
      Properties.Resources.arcLv6,
      Properties.Resources.arcLv7,
      Properties.Resources.arcLv8,
      Properties.Resources.arcLv9
    };
    private Bitmap[] bitmapArcInc =
    {
      Properties.Resources.arcInc0,
      Properties.Resources.arcInc1,
      Properties.Resources.arcInc2,
      Properties.Resources.arcInc3,
      Properties.Resources.arcInc4,
      Properties.Resources.arcInc5,
      Properties.Resources.arcInc6,
      Properties.Resources.arcInc7,
      Properties.Resources.arcInc8,
      Properties.Resources.arcInc9
    };
    private int tab = 0;
    private CharacterData characterData;
    private PictureBox[] pictureBoxARCs, pictureBoxArcLvLabels;
    private PictureBox[,] pictureBoxArcLvs;
    private PictureBox[] pictureBoxArcMaxLvs;
    private PictureBox[,] pictureBoxArcIncs;

    public FormMain()
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
      this.ClientSize = new Size(840, 519);

      //Slow version
      //this.Region = BitmapToRegion.getRegion((Bitmap)this.BackgroundImage, Color.FromArgb(0, 255, 0), 100);

      //Fast version
      this.Region = BitmapToRegion.getRegionFast((Bitmap)Properties.Resources.equipmentMask1, Color.FromArgb(0, 255, 0), 100);

      this.KeyPreview = true;

      /*pictureBoxARC1.Location = new Point(603, 208);//600, 207
      pictureBoxARC2.Location = new Point(679, 208);
      pictureBoxARC3.Location = new Point(753, 208);
      pictureBoxARC4.Location = new Point(600, 346);
      pictureBoxARC5.Location = new Point(676, 344);*/

      /*pictureBoxArcLvLabel1.Location = new Point(598, 268);
      pictureBoxArcLv12.Location = new Point(633, 267);
      pictureBoxArcLv11.Location = new Point(644, 267);

      pictureBoxArcLvLabel2.Location = new Point(674, 267);
      pictureBoxArcLv21.Location = new Point(709, 267);
      pictureBoxArcLv22.Location = new Point(720, 267);

      pictureBoxArcLvLabel3.Location = new Point(751, 267);
      pictureBoxArcLv31.Location = new Point(786, 267);
      pictureBoxArcLv32.Location = new Point(797, 267);

      pictureBoxArcLvLabel4.Location = new Point(597, 406);
      pictureBoxArcLv41.Location = new Point(632, 406);
      pictureBoxArcLv42.Location = new Point(643, 406);

      pictureBoxArcLvLabel5.Location = new Point(674, 406);
      pictureBoxArcLv51.Location = new Point(709, 406);
      pictureBoxArcLv52.Location = new Point(720, 406);*/
      
      characterData = new CharacterData();

      GetComponent();
      RefreshARC();
    }

    private void GetComponent()
    {
      pictureBoxARCs = new PictureBox[5]
      {
        pictureBoxARC1, pictureBoxARC2, pictureBoxARC3,
        pictureBoxARC4, pictureBoxARC5
      };
      pictureBoxArcLvLabels = new PictureBox[5]
      {
        pictureBoxArcLvLabel1, pictureBoxArcLvLabel2, pictureBoxArcLvLabel3,
        pictureBoxArcLvLabel4, pictureBoxArcLvLabel5
      };
      pictureBoxArcLvs = new PictureBox[5, 2]
      {
        {pictureBoxArcLv11, pictureBoxArcLv12 }, {pictureBoxArcLv21, pictureBoxArcLv22 }, {pictureBoxArcLv31, pictureBoxArcLv32 },
        {pictureBoxArcLv41, pictureBoxArcLv42 }, {pictureBoxArcLv51, pictureBoxArcLv52 }
      };
      pictureBoxArcMaxLvs = new PictureBox[5]
      {
        pictureBoxARCMaxLv1, pictureBoxARCMaxLv2, pictureBoxARCMaxLv3,
        pictureBoxARCMaxLv4, pictureBoxARCMaxLv5
      };
      pictureBoxArcIncs = new PictureBox[4, 5]
      {
        {pictureBoxARCIncPlus1, pictureBoxARCInc11, pictureBoxARCInc12, pictureBoxARCInc13, pictureBoxARCInc14 },
        {pictureBoxARCIncPlus2, pictureBoxARCInc21, pictureBoxARCInc22, pictureBoxARCInc23, pictureBoxARCInc24 },
        {pictureBoxARCIncPlus3, pictureBoxARCInc31, pictureBoxARCInc32, pictureBoxARCInc33, pictureBoxARCInc34 },
        {pictureBoxARCIncPlus4, pictureBoxARCInc41, pictureBoxARCInc42, pictureBoxARCInc43, pictureBoxARCInc44 }
      };
    }

    public void RefreshARC()
    {
      int ARC = 0;
      int incStateQty = 1, incMainState = 0;
      for (int i = 0; i < MSData.arcQty; i++)
      {
        if (characterData.isArcEquiped[i])
        {
          ARC += 20 + characterData.arcLv[i] * 10;

          pictureBoxARCs[i].Visible = true;
          pictureBoxArcLvLabels[i].Visible = true;
          if (characterData.arcLv[i] < 10) pictureBoxArcLvs[i, 0].Visible = false;
          else pictureBoxArcLvs[i, 0].Visible = true;
          pictureBoxArcLvs[i, 1].Visible = true;
          pictureBoxArcLvs[i, 0].Image = bitmapArcLv[characterData.arcLv[i] / 10];
          pictureBoxArcLvs[i, 1].Image = bitmapArcLv[characterData.arcLv[i] % 10];
          if (characterData.arcLv[i] == MSData.arcMaxLv) pictureBoxArcMaxLvs[i].Visible = true;
          else pictureBoxArcMaxLvs[i].Visible = false;
        }
        else
        {
          pictureBoxARCs[i].Visible = false;
          pictureBoxArcLvLabels[i].Visible = false;
          pictureBoxArcLvs[i, 0].Visible = pictureBoxArcLvs[i, 1].Visible = false;
          pictureBoxArcMaxLvs[i].Visible = false;
        }
      }

      if (true)  //職業為傑諾 //三屬加成
      {
        incStateQty = 3;
        incMainState = ARC / 10 * 39;
        for (int i = 0; i < 4; i++)
        {
          for (int j = 0; j < 5; j++)
          {
            pictureBoxArcIncs[i, j].Visible = true;
          }
          pictureBoxArcIncs[i, 0].Location = new Point(715, pictureBoxArcIncs[i, 0].Location.Y);
          int incNum = (i == 1) ? ARC : incMainState;
          bool isNum = false;
          for (int j = 4; j >= 1; j--)
          {
            int num = incNum / (int)Math.Pow(10, j - 1);
            if (num == 0 && !isNum)
            {
              pictureBoxArcIncs[i, 5 - j].Visible = false;
              pictureBoxArcIncs[i, 0].Location = new Point(pictureBoxArcIncs[i, 0].Location.X + 12, pictureBoxArcIncs[i, 0].Location.Y);
            }
            else isNum = true;
            pictureBoxArcIncs[i, 5 - j].BackgroundImage = bitmapArcInc[num];
            incNum -= num * (int)Math.Pow(10, j - 1);
          }
        }
      }
      else
      {
        incMainState = ARC * 10;
        for (int i = 0; i < 4; i++)
        {
          pictureBoxArcIncs[i, 0].Location = new Point(715, pictureBoxArcIncs[i, 0].Location.Y);
          int incNum = (i == 1) ? ARC : incMainState;
          bool isNum = false;
          for (int j = 4; j >= 1; j--)
          {
            int num = incNum / (int)Math.Pow(10, j - 1);
            if (num == 0 && !isNum)
            {
              pictureBoxArcIncs[i, 5 - j].Visible = false;
              pictureBoxArcIncs[i, 0].Location = new Point(pictureBoxArcIncs[i, 0].Location.X + 12, pictureBoxArcIncs[i, 0].Location.Y);
            }
            else isNum = true;
            pictureBoxArcIncs[i, 5 - j].BackgroundImage = bitmapArcInc[num];
            incNum -= num * (int)Math.Pow(10, j - 1);
          }
          

          if (i == 0 || i == 3)
          {
            for (int j = 0; j < 5; j++)
            {
              pictureBoxArcIncs[i, j].Visible = false;
            }
          }
        }
      }
    }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
    {
      //MessageBox.Show("X : " + e.X);
      //MessageBox.Show("Y : " + e.Y);
      int x = e.X, y = e.Y;

      //532 8 544 21
      if (x >= 532 && y >= 8 && x <= 544 && y <= 21)
      {
        this.Close();
      }

      if (x >= 223 && y >= 35 && x <= 480 && y <= 60)
      {
        int x0 = x - 223;
        tab = x0 / 64;
        switchTab();
      }

      switch (tab)
      {
        case 0:
          TabEquipment(x, y);
          break;
        case 1:
          TabCash(x, y);
          break;
        case 2:
          TabPet(x, y);
          break;
        case 3:
          TabAndroid(x, y);
          break;
      }

    }

    private void TabEquipment(int x, int y)
    {
      //起點(232, 74) //寬55px 間隔6px
      if (x >= 232 && y >= 74 && x <= 533 && y <= 439)
      {
        int x0 = x - 232, y0 = y - 74;
        int idxX = 0, idxY = 0;
        while (x0 > 56)
        {
          idxX++;
          if (x0 - 6 < 56)
          {
            idxX = -1;
            break;
          }
          x0 -= 62;
        }
        while (y0 > 56)
        {
          idxY++;
          if (y0 - 6 < 56)
          {
            idxY = -1;
            break;
          }
          y0 -= 62;
        }
        if (idxX != -1 && idxY != -1 && EquipCat[idxX * 6 + idxY] != null)
        {
          //MessageBox.Show("(" + idxX + ", " + idxY + ")");
          //MessageBox.Show(EquipCat[idxX * 6 + idxY]);
          Equipment_Clicked(idxX * 6 + idxY);
        }
      }
      else if (x >= 15 && y >= 32 && x <= 194 && y <= 89) //起點(15, 32)
      {
        int x0 = x - 15;
        int idxX = 0;
        while (x0 > 55)
        {
          idxX++;
          if (x0 - 6 < 55)
          {
            idxX = -1;
            break;
          }
          x0 -= 61;
        }
        if (idxX != -1)
          MessageBox.Show("圖騰" + (idxX + 1));
      }
      else if (x >= 603 && y >= 211 && x <= 801 && y <= 391) //起點(603, 211) //寬46 間隔31
      {
        int x0 = x, y0 = y;
        int idxX, idxY;

        if (y0 >= 211 && y0 <= 253) idxY = 0;
        else if (y0 >= 347 && y0 <= 391) idxY = 1;
        else idxY = -1;

        if (x0 >= 603 && x0 <= 649) idxX = 0;
        else if (x0 >= 680 && x0 <= 726) idxX = 1;
        else if (x0 >= 756 && x0 <= 801) idxX = 2;
        else idxX = -1;

        if (idxX != -1 && idxY != -1 && ARCName[idxX + idxY * 3] != null)
        {
          //MessageBox.Show(ARCCat[idxX+idxY*3]);
          ARC_Clicked(idxX + idxY * 3);
        }
      }
    }

    private void TabCash(int x, int y)
    {

    }

    private void TabPet(int x, int y)
    {

    }

    private void TabAndroid(int x, int y)
    {

    }

    private void Equipment_Clicked(int type)
    {
      FormEquip formEquip = new FormEquip(type, this);
      formEquip.ShowDialog();
    }

    private void ARC_Clicked(int type)
    {
      FormARC formARC = new FormARC(type, this, characterData);
      formARC.ShowDialog();
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
      switch (keyData)
      {
        case Keys.Left:
          tab = (tab - 1 + 4) % 4;
          switchTab();
          break;
        case Keys.Right:
        case Keys.Tab:
          tab = (tab + 1) % 4;
          switchTab();
          break;
      }
      return true;
    }

    private void switchTab()
    {
      this.BackgroundImage = bitmap[tab];
      if (tab != 0)
      {
        this.Region = BitmapToRegion.getRegionFast((Bitmap)Properties.Resources.equipmentMask2, Color.FromArgb(0, 255, 0), 100);
        for (int i = 0; i < 5; i++)
        {
          pictureBoxARCs[i].Visible = false;
          pictureBoxArcLvLabels[i].Visible = false;
          pictureBoxArcLvs[i, 0].Visible = false;
          pictureBoxArcLvs[i, 1].Visible = false;
        }
      }
      else
      {
        this.Region = BitmapToRegion.getRegionFast((Bitmap)Properties.Resources.equipmentMask1, Color.FromArgb(0, 255, 0), 100);
        for (int i = 0; i < 5; i++)
        {
          pictureBoxARCs[i].Visible = true;
          pictureBoxArcLvLabels[i].Visible = true;
          pictureBoxArcLvs[i, 0].Visible = true;
          pictureBoxArcLvs[i, 1].Visible = true;
          RefreshARC();
        }
      }
    }

    private void FormMain_MouseDown(object sender, MouseEventArgs e)
    {
      isTitle = (e.X >= 214 && e.X <= 554 && e.Y <= 26) && !(e.X >= 532 && e.Y >= 8 && e.X <= 544 && e.Y <= 21);
      mouse_offset = new Point(-e.X, -e.Y);
    }

    private void FormMain_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && isTitle)
      {
        Point mousePos = Control.MousePosition;
        mousePos.Offset(mouse_offset.X, mouse_offset.Y);
        Location = mousePos;
      }
    }

    private void pictureBoxARC_Click(object sender, EventArgs e)
    {
      int type = 0;
      if (sender == pictureBoxARC1) type = 0;
      else if (sender == pictureBoxARC2) type = 1;
      else if (sender == pictureBoxARC3) type = 2;
      else if (sender == pictureBoxARC4) type = 3;
      else if (sender == pictureBoxARC5) type = 4;
      ARC_Clicked(type);
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      // Display a MsgBox asking the user to close or cancel.
      if (MessageBox.Show("確定要關閉視窗嗎?", "提示",
         MessageBoxButtons.YesNo) == DialogResult.No)
      {
        // Cancel the Closing event from closing the form.
        e.Cancel = true;
      }
    }


  }
}
