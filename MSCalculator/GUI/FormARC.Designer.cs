namespace MSCalculator
{
  partial class FormARC
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
      this.buttonConfirm = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.comboBoxARCLv = new System.Windows.Forms.ComboBox();
      this.labelARCName = new System.Windows.Forms.Label();
      this.labelLv = new System.Windows.Forms.Label();
      this.pictureBoxARC = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxARC)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonConfirm
      // 
      this.buttonConfirm.Location = new System.Drawing.Point(87, 191);
      this.buttonConfirm.Name = "buttonConfirm";
      this.buttonConfirm.Size = new System.Drawing.Size(135, 46);
      this.buttonConfirm.TabIndex = 0;
      this.buttonConfirm.Text = "確定";
      this.buttonConfirm.UseVisualStyleBackColor = true;
      this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(264, 191);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(135, 46);
      this.buttonCancel.TabIndex = 1;
      this.buttonCancel.Text = "取消";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // comboBoxARCLv
      // 
      this.comboBoxARCLv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxARCLv.Font = new System.Drawing.Font("新細明體", 12F);
      this.comboBoxARCLv.FormattingEnabled = true;
      this.comboBoxARCLv.Location = new System.Drawing.Point(239, 123);
      this.comboBoxARCLv.Name = "comboBoxARCLv";
      this.comboBoxARCLv.Size = new System.Drawing.Size(166, 36);
      this.comboBoxARCLv.TabIndex = 2;
      // 
      // labelARCName
      // 
      this.labelARCName.AutoSize = true;
      this.labelARCName.Font = new System.Drawing.Font("新細明體", 15F);
      this.labelARCName.Location = new System.Drawing.Point(102, 44);
      this.labelARCName.Name = "labelARCName";
      this.labelARCName.Size = new System.Drawing.Size(357, 35);
      this.labelARCName.TabIndex = 4;
      this.labelARCName.Text = "祕法符文 : 消逝的旅途";
      // 
      // labelLv
      // 
      this.labelLv.AutoSize = true;
      this.labelLv.Font = new System.Drawing.Font("新細明體", 12F);
      this.labelLv.Location = new System.Drawing.Point(59, 126);
      this.labelLv.Name = "labelLv";
      this.labelLv.Size = new System.Drawing.Size(145, 28);
      this.labelLv.TabIndex = 6;
      this.labelLv.Text = "符文等級 : ";
      // 
      // pictureBoxARC
      // 
      this.pictureBoxARC.BackColor = System.Drawing.Color.Transparent;
      this.pictureBoxARC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pictureBoxARC.Image = global::MSCalculator.Properties.Resources.arcane1;
      this.pictureBoxARC.InitialImage = null;
      this.pictureBoxARC.Location = new System.Drawing.Point(19, 16);
      this.pictureBoxARC.Margin = new System.Windows.Forms.Padding(0);
      this.pictureBoxARC.Name = "pictureBoxARC";
      this.pictureBoxARC.Size = new System.Drawing.Size(90, 90);
      this.pictureBoxARC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxARC.TabIndex = 3;
      this.pictureBoxARC.TabStop = false;
      // 
      // FormARC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(476, 250);
      this.Controls.Add(this.labelLv);
      this.Controls.Add(this.labelARCName);
      this.Controls.Add(this.pictureBoxARC);
      this.Controls.Add(this.comboBoxARCLv);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonConfirm);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FormARC";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormARC";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxARC)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonConfirm;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.ComboBox comboBoxARCLv;
    private System.Windows.Forms.PictureBox pictureBoxARC;
    private System.Windows.Forms.Label labelARCName;
    private System.Windows.Forms.Label labelLv;
  }
}