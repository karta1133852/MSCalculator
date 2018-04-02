namespace MSCalculator
{
  partial class FormEquip
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelEquipName = new System.Windows.Forms.Label();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonConfirm = new System.Windows.Forms.Button();
      this.pictureBoxEquip = new System.Windows.Forms.PictureBox();
      this.labelCat = new System.Windows.Forms.Label();
      this.labelStr = new System.Windows.Forms.Label();
      this.labelDex = new System.Windows.Forms.Label();
      this.labelInt = new System.Windows.Forms.Label();
      this.labelLuk = new System.Windows.Forms.Label();
      this.labelHP = new System.Windows.Forms.Label();
      this.labelMP = new System.Windows.Forms.Label();
      this.labelAtk = new System.Windows.Forms.Label();
      this.labelMAtk = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.labelMDef = new System.Windows.Forms.Label();
      this.labelDef = new System.Windows.Forms.Label();
      this.labelBoss = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquip)).BeginInit();
      this.SuspendLayout();
      // 
      // labelEquipName
      // 
      this.labelEquipName.AutoSize = true;
      this.labelEquipName.Font = new System.Drawing.Font("新細明體", 15F);
      this.labelEquipName.Location = new System.Drawing.Point(137, 49);
      this.labelEquipName.Name = "labelEquipName";
      this.labelEquipName.Size = new System.Drawing.Size(260, 35);
      this.labelEquipName.TabIndex = 5;
      this.labelEquipName.Text = "強力的魔性戒指";
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(252, 703);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(135, 46);
      this.buttonCancel.TabIndex = 7;
      this.buttonCancel.Text = "取消";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // buttonConfirm
      // 
      this.buttonConfirm.Location = new System.Drawing.Point(75, 703);
      this.buttonConfirm.Name = "buttonConfirm";
      this.buttonConfirm.Size = new System.Drawing.Size(135, 46);
      this.buttonConfirm.TabIndex = 6;
      this.buttonConfirm.Text = "確定";
      this.buttonConfirm.UseVisualStyleBackColor = true;
      this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
      // 
      // pictureBoxEquip
      // 
      this.pictureBoxEquip.BackColor = System.Drawing.Color.Transparent;
      this.pictureBoxEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pictureBoxEquip.Image = global::MSCalculator.Properties.Resources.test;
      this.pictureBoxEquip.InitialImage = null;
      this.pictureBoxEquip.Location = new System.Drawing.Point(44, 22);
      this.pictureBoxEquip.Margin = new System.Windows.Forms.Padding(0);
      this.pictureBoxEquip.Name = "pictureBoxEquip";
      this.pictureBoxEquip.Size = new System.Drawing.Size(90, 90);
      this.pictureBoxEquip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxEquip.TabIndex = 4;
      this.pictureBoxEquip.TabStop = false;
      // 
      // labelCat
      // 
      this.labelCat.AutoSize = true;
      this.labelCat.Location = new System.Drawing.Point(40, 125);
      this.labelCat.Name = "labelCat";
      this.labelCat.Size = new System.Drawing.Size(151, 21);
      this.labelCat.TabIndex = 8;
      this.labelCat.Text = "裝備分類 : 戒指";
      // 
      // labelStr
      // 
      this.labelStr.AutoSize = true;
      this.labelStr.Location = new System.Drawing.Point(40, 158);
      this.labelStr.Name = "labelStr";
      this.labelStr.Size = new System.Drawing.Size(88, 21);
      this.labelStr.TabIndex = 9;
      this.labelStr.Text = "力量 : +4";
      // 
      // labelDex
      // 
      this.labelDex.AutoSize = true;
      this.labelDex.Location = new System.Drawing.Point(40, 189);
      this.labelDex.Name = "labelDex";
      this.labelDex.Size = new System.Drawing.Size(88, 21);
      this.labelDex.TabIndex = 10;
      this.labelDex.Text = "敏捷 : +4";
      // 
      // labelInt
      // 
      this.labelInt.AutoSize = true;
      this.labelInt.Location = new System.Drawing.Point(40, 220);
      this.labelInt.Name = "labelInt";
      this.labelInt.Size = new System.Drawing.Size(88, 21);
      this.labelInt.TabIndex = 11;
      this.labelInt.Text = "智力 : +4";
      // 
      // labelLuk
      // 
      this.labelLuk.AutoSize = true;
      this.labelLuk.Location = new System.Drawing.Point(40, 251);
      this.labelLuk.Name = "labelLuk";
      this.labelLuk.Size = new System.Drawing.Size(88, 21);
      this.labelLuk.TabIndex = 12;
      this.labelLuk.Text = "幸運 : +4";
      // 
      // labelHP
      // 
      this.labelHP.AutoSize = true;
      this.labelHP.Location = new System.Drawing.Point(40, 281);
      this.labelHP.Name = "labelHP";
      this.labelHP.Size = new System.Drawing.Size(128, 21);
      this.labelHP.TabIndex = 13;
      this.labelHP.Text = "MaxHP : +800";
      // 
      // labelMP
      // 
      this.labelMP.AutoSize = true;
      this.labelMP.Location = new System.Drawing.Point(40, 311);
      this.labelMP.Name = "labelMP";
      this.labelMP.Size = new System.Drawing.Size(132, 21);
      this.labelMP.TabIndex = 14;
      this.labelMP.Text = "MaxMP : +800";
      // 
      // labelAtk
      // 
      this.labelAtk.AutoSize = true;
      this.labelAtk.Location = new System.Drawing.Point(40, 341);
      this.labelAtk.Name = "labelAtk";
      this.labelAtk.Size = new System.Drawing.Size(109, 21);
      this.labelAtk.TabIndex = 15;
      this.labelAtk.Text = "攻擊力 : +3";
      // 
      // labelMAtk
      // 
      this.labelMAtk.AutoSize = true;
      this.labelMAtk.Location = new System.Drawing.Point(40, 373);
      this.labelMAtk.Name = "labelMAtk";
      this.labelMAtk.Size = new System.Drawing.Size(151, 21);
      this.labelMAtk.TabIndex = 16;
      this.labelMAtk.Text = "魔法攻擊力 : +3";
      // 
      // label10
      // 
      this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label10.Location = new System.Drawing.Point(42, 643);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(400, 2);
      this.label10.TabIndex = 17;
      this.label10.Text = "label10";
      // 
      // labelMDef
      // 
      this.labelMDef.AutoSize = true;
      this.labelMDef.Location = new System.Drawing.Point(40, 435);
      this.labelMDef.Name = "labelMDef";
      this.labelMDef.Size = new System.Drawing.Size(130, 21);
      this.labelMDef.TabIndex = 19;
      this.labelMDef.Text = "魔法防禦力 : ";
      // 
      // labelDef
      // 
      this.labelDef.AutoSize = true;
      this.labelDef.Location = new System.Drawing.Point(40, 403);
      this.labelDef.Name = "labelDef";
      this.labelDef.Size = new System.Drawing.Size(130, 21);
      this.labelDef.TabIndex = 18;
      this.labelDef.Text = "物理防禦力 : ";
      // 
      // labelBoss
      // 
      this.labelBoss.AutoSize = true;
      this.labelBoss.Location = new System.Drawing.Point(42, 465);
      this.labelBoss.Name = "labelBoss";
      this.labelBoss.Size = new System.Drawing.Size(216, 21);
      this.labelBoss.TabIndex = 20;
      this.labelBoss.Text = "BOSS攻擊時傷害 +30%";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(42, 495);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(193, 21);
      this.label2.TabIndex = 21;
      this.label2.Text = "無視怪物防禦力10%";
      // 
      // FormEquip
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(476, 936);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.labelBoss);
      this.Controls.Add(this.labelMDef);
      this.Controls.Add(this.labelDef);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.labelMAtk);
      this.Controls.Add(this.labelAtk);
      this.Controls.Add(this.labelMP);
      this.Controls.Add(this.labelHP);
      this.Controls.Add(this.labelLuk);
      this.Controls.Add(this.labelInt);
      this.Controls.Add(this.labelDex);
      this.Controls.Add(this.labelStr);
      this.Controls.Add(this.labelCat);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonConfirm);
      this.Controls.Add(this.labelEquipName);
      this.Controls.Add(this.pictureBoxEquip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FormEquip";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormEquip";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquip)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxEquip;
    private System.Windows.Forms.Label labelEquipName;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonConfirm;
    private System.Windows.Forms.Label labelCat;
    private System.Windows.Forms.Label labelStr;
    private System.Windows.Forms.Label labelDex;
    private System.Windows.Forms.Label labelInt;
    private System.Windows.Forms.Label labelLuk;
    private System.Windows.Forms.Label labelHP;
    private System.Windows.Forms.Label labelMP;
    private System.Windows.Forms.Label labelAtk;
    private System.Windows.Forms.Label labelMAtk;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label labelMDef;
    private System.Windows.Forms.Label labelDef;
    private System.Windows.Forms.Label labelBoss;
    private System.Windows.Forms.Label label2;
  }
}