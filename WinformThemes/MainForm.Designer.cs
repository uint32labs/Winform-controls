using Dio;
using MentQ;

namespace WinformThemes
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageListTabControl = new System.Windows.Forms.ImageList(this.components);
            this.mentQTabControl = new MentQ.MentQTabControl();
            this.tabPageMenQ = new System.Windows.Forms.TabPage();
            this.mentQGroupBoxRegularIcon = new MentQ.MentQGroupBox();
            this.mentQGroupBoxColoredBorder = new MentQ.MentQGroupBox();
            this.mentQCheckBoxChecked = new MentQ.MentQCheckBox();
            this.mentQCheckBoxUnchecked = new MentQ.MentQCheckBox();
            this.mentQRadioButtonChecked = new MentQ.MentQRadioButton();
            this.mentQRadioButtonUnchecked = new MentQ.MentQRadioButton();
            this.mentQGroupBoxColoredHeader = new MentQ.MentQGroupBox();
            this.mentQProgressBarUnderlineColored = new MentQ.MentQProgressBar();
            this.mentQProgressBarDefault = new MentQ.MentQProgressBar();
            this.mentQGroupBoxClosed = new MentQ.MentQGroupBox();
            this.mentQNotificationDefault = new MentQ.MentQNotification();
            this.mentQInfoBoxUnderlineExclude = new MentQ.MentQInfoBox();
            this.mentQInfoBoxWhiteUnderline = new MentQ.MentQInfoBox();
            this.mentQInfoBoxUnderlineImageOnly = new MentQ.MentQInfoBox();
            this.mentQInfoBoxImageDefault = new MentQ.MentQInfoBox();
            this.mentQInfoBoxDefaultTransparent = new MentQ.MentQInfoBox();
            this.mentQInfoBoxScaledContainer = new MentQ.MentQInfoBox();
            this.mentQInfoBoxDefault = new MentQ.MentQInfoBox();
            this.mentQInfoBoxScaledNoContainer = new MentQ.MentQInfoBox();
            this.mentQInfoBoxDefaultNoUnderline = new MentQ.MentQInfoBox();
            this.mentQGroupBoxClosable = new MentQ.MentQGroupBox();
            this.mentQButtonImage = new MentQ.MentQButton();
            this.mentQButtonUnderline = new MentQ.MentQButton();
            this.mentQButtonDefault = new MentQ.MentQButton();
            this.mentQEllipticalProgressDefault = new MentQ.MentQEllipticalProgress();
            this.mentQEllipticalProgressHatchBrush = new MentQ.MentQEllipticalProgress();
            this.tabPageDio = new System.Windows.Forms.TabPage();
            this.dioGroupBoxColored = new Dio.DioGroupBox();
            this.dioGroupBoxBiggerShadow = new Dio.DioGroupBox();
            this.dioGroupBoxColoredShadow = new Dio.DioGroupBox();
            this.dioGroupBoxProgressBars = new Dio.DioGroupBox();
            this.labelColored = new System.Windows.Forms.Label();
            this.dioMarqueeProgressBarColored = new Dio.DioMarqueeProgressBar();
            this.labelDifferentPosition = new System.Windows.Forms.Label();
            this.dioMarqueeProgressBarDifferentPosition = new Dio.DioMarqueeProgressBar();
            this.labelBiggerMarquee = new System.Windows.Forms.Label();
            this.dioMarqueeProgressBarBiggerMarquee = new Dio.DioMarqueeProgressBar();
            this.labelNoMarquee = new System.Windows.Forms.Label();
            this.dioMarqueeProgressBarNoMarquee = new Dio.DioMarqueeProgressBar();
            this.labelDefault = new System.Windows.Forms.Label();
            this.dioMarqueeProgressBarDefault = new Dio.DioMarqueeProgressBar();
            this.dioGroupBoxDefault = new Dio.DioGroupBox();
            this.dioTextBoxDefault = new Dio.DioTextBox();
            this.dioRadioButtonDefaultChecked = new Dio.DioRadioButton();
            this.dioRadioButtonDefaultUnchecked = new Dio.DioRadioButton();
            this.dioCheckBoxColoredChecked = new Dio.DioCheckBox();
            this.dioCheckBoxDefaultChecked = new Dio.DioCheckBox();
            this.dioCheckBoxDefaultUnchecked = new Dio.DioCheckBox();
            this.dioButtonColored = new Dio.DioButton();
            this.dioLabelTitle = new Dio.DioLabel();
            this.dioLabelDefault = new Dio.DioLabel();
            this.dioButtonDefault = new Dio.DioButton();
            this.mentQNumericUpDown1 = new MentQ.MentQNumericUpDown();
            this.mentQTabControl.SuspendLayout();
            this.tabPageMenQ.SuspendLayout();
            this.mentQGroupBoxRegularIcon.SuspendLayout();
            this.mentQGroupBoxColoredBorder.SuspendLayout();
            this.mentQGroupBoxColoredHeader.SuspendLayout();
            this.mentQGroupBoxClosed.SuspendLayout();
            this.mentQGroupBoxClosable.SuspendLayout();
            this.tabPageDio.SuspendLayout();
            this.dioGroupBoxColored.SuspendLayout();
            this.dioGroupBoxProgressBars.SuspendLayout();
            this.dioGroupBoxDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListTabControl
            // 
            this.imageListTabControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabControl.ImageStream")));
            this.imageListTabControl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabControl.Images.SetKeyName(0, "1473390513_Streamline-18.png");
            this.imageListTabControl.Images.SetKeyName(1, "1473394051_Streamline-77.png");
            // 
            // mentQTabControl
            // 
            this.mentQTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mentQTabControl.Controls.Add(this.tabPageMenQ);
            this.mentQTabControl.Controls.Add(this.tabPageDio);
            this.mentQTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mentQTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mentQTabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mentQTabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mentQTabControl.ImageList = this.imageListTabControl;
            this.mentQTabControl.ItemSize = new System.Drawing.Size(35, 175);
            this.mentQTabControl.Location = new System.Drawing.Point(0, 0);
            this.mentQTabControl.Multiline = true;
            this.mentQTabControl.Name = "mentQTabControl";
            this.mentQTabControl.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.mentQTabControl.SelectedIndex = 0;
            this.mentQTabControl.Size = new System.Drawing.Size(1011, 509);
            this.mentQTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mentQTabControl.TabIndex = 0;
            // 
            // tabPageMenQ
            // 
            this.tabPageMenQ.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMenQ.Controls.Add(this.mentQGroupBoxRegularIcon);
            this.tabPageMenQ.Controls.Add(this.mentQGroupBoxColoredHeader);
            this.tabPageMenQ.Controls.Add(this.mentQGroupBoxClosable);
            this.tabPageMenQ.ImageIndex = 1;
            this.tabPageMenQ.Location = new System.Drawing.Point(179, 4);
            this.tabPageMenQ.Name = "tabPageMenQ";
            this.tabPageMenQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenQ.Size = new System.Drawing.Size(828, 501);
            this.tabPageMenQ.TabIndex = 0;
            this.tabPageMenQ.Text = "MenQ";
            // 
            // mentQGroupBoxRegularIcon
            // 
            this.mentQGroupBoxRegularIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mentQGroupBoxRegularIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQGroupBoxRegularIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mentQGroupBoxRegularIcon.Closable = false;
            this.mentQGroupBoxRegularIcon.Closed = false;
            this.mentQGroupBoxRegularIcon.Controls.Add(this.mentQGroupBoxColoredBorder);
            this.mentQGroupBoxRegularIcon.Controls.Add(this.mentQCheckBoxChecked);
            this.mentQGroupBoxRegularIcon.Controls.Add(this.mentQCheckBoxUnchecked);
            this.mentQGroupBoxRegularIcon.Controls.Add(this.mentQRadioButtonChecked);
            this.mentQGroupBoxRegularIcon.Controls.Add(this.mentQRadioButtonUnchecked);
            this.mentQGroupBoxRegularIcon.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mentQGroupBoxRegularIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mentQGroupBoxRegularIcon.Icon = ((System.Drawing.Image)(resources.GetObject("mentQGroupBoxRegularIcon.Icon")));
            this.mentQGroupBoxRegularIcon.Location = new System.Drawing.Point(615, 231);
            this.mentQGroupBoxRegularIcon.Name = "mentQGroupBoxRegularIcon";
            this.mentQGroupBoxRegularIcon.Size = new System.Drawing.Size(202, 262);
            this.mentQGroupBoxRegularIcon.TabIndex = 2;
            this.mentQGroupBoxRegularIcon.Text = "Regular icon group box";
            this.mentQGroupBoxRegularIcon.UpperColor = System.Drawing.Color.Empty;
            // 
            // mentQGroupBoxColoredBorder
            // 
            this.mentQGroupBoxColoredBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQGroupBoxColoredBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.mentQGroupBoxColoredBorder.Closable = false;
            this.mentQGroupBoxColoredBorder.Closed = false;
            this.mentQGroupBoxColoredBorder.Controls.Add(this.mentQNumericUpDown1);
            this.mentQGroupBoxColoredBorder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mentQGroupBoxColoredBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mentQGroupBoxColoredBorder.Icon = null;
            this.mentQGroupBoxColoredBorder.Location = new System.Drawing.Point(16, 126);
            this.mentQGroupBoxColoredBorder.Name = "mentQGroupBoxColoredBorder";
            this.mentQGroupBoxColoredBorder.Size = new System.Drawing.Size(169, 126);
            this.mentQGroupBoxColoredBorder.TabIndex = 4;
            this.mentQGroupBoxColoredBorder.Text = "Colored border group box";
            this.mentQGroupBoxColoredBorder.UpperColor = System.Drawing.Color.Empty;
            // 
            // mentQCheckBoxChecked
            // 
            this.mentQCheckBoxChecked.AutoSize = true;
            this.mentQCheckBoxChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.mentQCheckBoxChecked.Checked = true;
            this.mentQCheckBoxChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mentQCheckBoxChecked.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQCheckBoxChecked.ForeColor = System.Drawing.Color.Black;
            this.mentQCheckBoxChecked.Location = new System.Drawing.Point(16, 99);
            this.mentQCheckBoxChecked.Name = "mentQCheckBoxChecked";
            this.mentQCheckBoxChecked.Size = new System.Drawing.Size(113, 14);
            this.mentQCheckBoxChecked.TabIndex = 3;
            this.mentQCheckBoxChecked.Text = "Checked check box";
            this.mentQCheckBoxChecked.UseVisualStyleBackColor = false;
            // 
            // mentQCheckBoxUnchecked
            // 
            this.mentQCheckBoxUnchecked.AutoSize = true;
            this.mentQCheckBoxUnchecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQCheckBoxUnchecked.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQCheckBoxUnchecked.ForeColor = System.Drawing.Color.Black;
            this.mentQCheckBoxUnchecked.Location = new System.Drawing.Point(16, 79);
            this.mentQCheckBoxUnchecked.Name = "mentQCheckBoxUnchecked";
            this.mentQCheckBoxUnchecked.Size = new System.Drawing.Size(124, 14);
            this.mentQCheckBoxUnchecked.TabIndex = 2;
            this.mentQCheckBoxUnchecked.Text = "Unchecked check box";
            this.mentQCheckBoxUnchecked.UseVisualStyleBackColor = false;
            // 
            // mentQRadioButtonChecked
            // 
            this.mentQRadioButtonChecked.AutoSize = true;
            this.mentQRadioButtonChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQRadioButtonChecked.Checked = true;
            this.mentQRadioButtonChecked.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQRadioButtonChecked.ForeColor = System.Drawing.Color.Black;
            this.mentQRadioButtonChecked.Location = new System.Drawing.Point(16, 58);
            this.mentQRadioButtonChecked.Name = "mentQRadioButtonChecked";
            this.mentQRadioButtonChecked.Size = new System.Drawing.Size(110, 14);
            this.mentQRadioButtonChecked.TabIndex = 1;
            this.mentQRadioButtonChecked.TabStop = true;
            this.mentQRadioButtonChecked.Text = "Checked radio box";
            this.mentQRadioButtonChecked.UseVisualStyleBackColor = false;
            // 
            // mentQRadioButtonUnchecked
            // 
            this.mentQRadioButtonUnchecked.AutoSize = true;
            this.mentQRadioButtonUnchecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQRadioButtonUnchecked.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQRadioButtonUnchecked.ForeColor = System.Drawing.Color.Black;
            this.mentQRadioButtonUnchecked.Location = new System.Drawing.Point(16, 38);
            this.mentQRadioButtonUnchecked.Name = "mentQRadioButtonUnchecked";
            this.mentQRadioButtonUnchecked.Size = new System.Drawing.Size(121, 14);
            this.mentQRadioButtonUnchecked.TabIndex = 0;
            this.mentQRadioButtonUnchecked.Text = "Unchecked radio box";
            this.mentQRadioButtonUnchecked.UseVisualStyleBackColor = false;
            // 
            // mentQGroupBoxColoredHeader
            // 
            this.mentQGroupBoxColoredHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mentQGroupBoxColoredHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQGroupBoxColoredHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mentQGroupBoxColoredHeader.Closable = false;
            this.mentQGroupBoxColoredHeader.Closed = false;
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQProgressBarUnderlineColored);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQProgressBarDefault);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQGroupBoxClosed);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxUnderlineExclude);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxWhiteUnderline);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxUnderlineImageOnly);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxImageDefault);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxDefaultTransparent);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxScaledContainer);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxDefault);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxScaledNoContainer);
            this.mentQGroupBoxColoredHeader.Controls.Add(this.mentQInfoBoxDefaultNoUnderline);
            this.mentQGroupBoxColoredHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mentQGroupBoxColoredHeader.ForeColor = System.Drawing.Color.White;
            this.mentQGroupBoxColoredHeader.Icon = null;
            this.mentQGroupBoxColoredHeader.Location = new System.Drawing.Point(9, 8);
            this.mentQGroupBoxColoredHeader.Name = "mentQGroupBoxColoredHeader";
            this.mentQGroupBoxColoredHeader.Size = new System.Drawing.Size(598, 485);
            this.mentQGroupBoxColoredHeader.TabIndex = 0;
            this.mentQGroupBoxColoredHeader.Text = "Colored header";
            this.mentQGroupBoxColoredHeader.UpperColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            // 
            // mentQProgressBarUnderlineColored
            // 
            this.mentQProgressBarUnderlineColored.AlternateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mentQProgressBarUnderlineColored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mentQProgressBarUnderlineColored.CornerRounding = 5;
            this.mentQProgressBarUnderlineColored.DiagonalLines = false;
            this.mentQProgressBarUnderlineColored.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.mentQProgressBarUnderlineColored.ForeColor = System.Drawing.Color.White;
            this.mentQProgressBarUnderlineColored.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.mentQProgressBarUnderlineColored.Location = new System.Drawing.Point(11, 455);
            this.mentQProgressBarUnderlineColored.Name = "mentQProgressBarUnderlineColored";
            this.mentQProgressBarUnderlineColored.Size = new System.Drawing.Size(575, 20);
            this.mentQProgressBarUnderlineColored.TabIndex = 13;
            this.mentQProgressBarUnderlineColored.Text = "Progress bar with underline";
            this.mentQProgressBarUnderlineColored.Underline = true;
            this.mentQProgressBarUnderlineColored.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQProgressBarUnderlineColored.UnderlineSize = 2;
            this.mentQProgressBarUnderlineColored.Value = 45;
            // 
            // mentQProgressBarDefault
            // 
            this.mentQProgressBarDefault.AlternateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mentQProgressBarDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQProgressBarDefault.CornerRounding = 5;
            this.mentQProgressBarDefault.DiagonalLines = false;
            this.mentQProgressBarDefault.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.mentQProgressBarDefault.ForeColor = System.Drawing.Color.White;
            this.mentQProgressBarDefault.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.mentQProgressBarDefault.Location = new System.Drawing.Point(11, 429);
            this.mentQProgressBarDefault.Name = "mentQProgressBarDefault";
            this.mentQProgressBarDefault.Size = new System.Drawing.Size(575, 20);
            this.mentQProgressBarDefault.TabIndex = 12;
            this.mentQProgressBarDefault.Text = "Progress bar";
            this.mentQProgressBarDefault.Underline = false;
            this.mentQProgressBarDefault.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQProgressBarDefault.UnderlineSize = 2;
            this.mentQProgressBarDefault.Value = 30;
            // 
            // mentQGroupBoxClosed
            // 
            this.mentQGroupBoxClosed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQGroupBoxClosed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mentQGroupBoxClosed.Closable = true;
            this.mentQGroupBoxClosed.Closed = true;
            this.mentQGroupBoxClosed.Controls.Add(this.mentQNotificationDefault);
            this.mentQGroupBoxClosed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mentQGroupBoxClosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mentQGroupBoxClosed.Icon = null;
            this.mentQGroupBoxClosed.Location = new System.Drawing.Point(11, 395);
            this.mentQGroupBoxClosed.Name = "mentQGroupBoxClosed";
            this.mentQGroupBoxClosed.Size = new System.Drawing.Size(575, 27);
            this.mentQGroupBoxClosed.TabIndex = 9;
            this.mentQGroupBoxClosed.Text = "Closed group box";
            this.mentQGroupBoxClosed.UpperColor = System.Drawing.Color.Empty;
            // 
            // mentQNotificationDefault
            // 
            this.mentQNotificationDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQNotificationDefault.EffectColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.mentQNotificationDefault.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQNotificationDefault.ForeColor = System.Drawing.Color.White;
            this.mentQNotificationDefault.Location = new System.Drawing.Point(407, 6);
            this.mentQNotificationDefault.Name = "mentQNotificationDefault";
            this.mentQNotificationDefault.Size = new System.Drawing.Size(135, 15);
            this.mentQNotificationDefault.Style = MentQ.Styles.None;
            this.mentQNotificationDefault.TabIndex = 14;
            this.mentQNotificationDefault.Text = "Default notification box";
            this.mentQNotificationDefault.TextAlignment = MentQ.MentQNotification.TextAlign.Center;
            this.mentQNotificationDefault.UnderlineSize = 2;
            // 
            // mentQInfoBoxUnderlineExclude
            // 
            this.mentQInfoBoxUnderlineExclude.AntiAliasImage = true;
            this.mentQInfoBoxUnderlineExclude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.mentQInfoBoxUnderlineExclude.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mentQInfoBoxUnderlineExclude.BackgroundImage")));
            this.mentQInfoBoxUnderlineExclude.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.Scaled;
            this.mentQInfoBoxUnderlineExclude.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxUnderlineExclude.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxUnderlineExclude.ImageContainer = true;
            this.mentQInfoBoxUnderlineExclude.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxUnderlineExclude.ImageTransparency = 255;
            this.mentQInfoBoxUnderlineExclude.Location = new System.Drawing.Point(299, 253);
            this.mentQInfoBoxUnderlineExclude.Name = "mentQInfoBoxUnderlineExclude";
            this.mentQInfoBoxUnderlineExclude.Size = new System.Drawing.Size(287, 65);
            this.mentQInfoBoxUnderlineExclude.TabIndex = 6;
            this.mentQInfoBoxUnderlineExclude.Text = "Exclude image";
            this.mentQInfoBoxUnderlineExclude.Title = "Underline";
            this.mentQInfoBoxUnderlineExclude.Underline = MentQ.MentQInfoBox.UnderlineStyle.ExcludeImage;
            this.mentQInfoBoxUnderlineExclude.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxUnderlineExclude.UnderlineSize = 4;
            // 
            // mentQInfoBoxWhiteUnderline
            // 
            this.mentQInfoBoxWhiteUnderline.AntiAliasImage = true;
            this.mentQInfoBoxWhiteUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mentQInfoBoxWhiteUnderline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mentQInfoBoxWhiteUnderline.BackgroundImage")));
            this.mentQInfoBoxWhiteUnderline.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.None;
            this.mentQInfoBoxWhiteUnderline.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxWhiteUnderline.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxWhiteUnderline.ImageContainer = true;
            this.mentQInfoBoxWhiteUnderline.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxWhiteUnderline.ImageTransparency = 100;
            this.mentQInfoBoxWhiteUnderline.Location = new System.Drawing.Point(11, 182);
            this.mentQInfoBoxWhiteUnderline.Name = "mentQInfoBoxWhiteUnderline";
            this.mentQInfoBoxWhiteUnderline.Size = new System.Drawing.Size(575, 65);
            this.mentQInfoBoxWhiteUnderline.TabIndex = 4;
            this.mentQInfoBoxWhiteUnderline.Text = "White underline & container with unscaled image";
            this.mentQInfoBoxWhiteUnderline.Title = "Underline";
            this.mentQInfoBoxWhiteUnderline.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBoxWhiteUnderline.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQInfoBoxWhiteUnderline.UnderlineSize = 4;
            // 
            // mentQInfoBoxUnderlineImageOnly
            // 
            this.mentQInfoBoxUnderlineImageOnly.AntiAliasImage = true;
            this.mentQInfoBoxUnderlineImageOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.mentQInfoBoxUnderlineImageOnly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mentQInfoBoxUnderlineImageOnly.BackgroundImage")));
            this.mentQInfoBoxUnderlineImageOnly.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.Scaled;
            this.mentQInfoBoxUnderlineImageOnly.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxUnderlineImageOnly.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxUnderlineImageOnly.ImageContainer = true;
            this.mentQInfoBoxUnderlineImageOnly.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxUnderlineImageOnly.ImageTransparency = 255;
            this.mentQInfoBoxUnderlineImageOnly.Location = new System.Drawing.Point(299, 324);
            this.mentQInfoBoxUnderlineImageOnly.Name = "mentQInfoBoxUnderlineImageOnly";
            this.mentQInfoBoxUnderlineImageOnly.Size = new System.Drawing.Size(287, 65);
            this.mentQInfoBoxUnderlineImageOnly.TabIndex = 8;
            this.mentQInfoBoxUnderlineImageOnly.Text = "Image only";
            this.mentQInfoBoxUnderlineImageOnly.Title = "Underline";
            this.mentQInfoBoxUnderlineImageOnly.Underline = MentQ.MentQInfoBox.UnderlineStyle.ImageOnly;
            this.mentQInfoBoxUnderlineImageOnly.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxUnderlineImageOnly.UnderlineSize = 4;
            // 
            // mentQInfoBoxImageDefault
            // 
            this.mentQInfoBoxImageDefault.AntiAliasImage = true;
            this.mentQInfoBoxImageDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mentQInfoBoxImageDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mentQInfoBoxImageDefault.BackgroundImage")));
            this.mentQInfoBoxImageDefault.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.None;
            this.mentQInfoBoxImageDefault.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxImageDefault.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxImageDefault.ImageContainer = false;
            this.mentQInfoBoxImageDefault.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxImageDefault.ImageTransparency = 255;
            this.mentQInfoBoxImageDefault.Location = new System.Drawing.Point(260, 40);
            this.mentQInfoBoxImageDefault.Name = "mentQInfoBoxImageDefault";
            this.mentQInfoBoxImageDefault.Size = new System.Drawing.Size(326, 65);
            this.mentQInfoBoxImageDefault.TabIndex = 1;
            this.mentQInfoBoxImageDefault.Text = "Unscaled & opaque";
            this.mentQInfoBoxImageDefault.Title = "Image";
            this.mentQInfoBoxImageDefault.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBoxImageDefault.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxImageDefault.UnderlineSize = 4;
            // 
            // mentQInfoBoxDefaultTransparent
            // 
            this.mentQInfoBoxDefaultTransparent.AntiAliasImage = true;
            this.mentQInfoBoxDefaultTransparent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mentQInfoBoxDefaultTransparent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mentQInfoBoxDefaultTransparent.BackgroundImage")));
            this.mentQInfoBoxDefaultTransparent.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.None;
            this.mentQInfoBoxDefaultTransparent.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxDefaultTransparent.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxDefaultTransparent.ImageContainer = false;
            this.mentQInfoBoxDefaultTransparent.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxDefaultTransparent.ImageTransparency = 100;
            this.mentQInfoBoxDefaultTransparent.Location = new System.Drawing.Point(260, 111);
            this.mentQInfoBoxDefaultTransparent.Name = "mentQInfoBoxDefaultTransparent";
            this.mentQInfoBoxDefaultTransparent.Size = new System.Drawing.Size(326, 65);
            this.mentQInfoBoxDefaultTransparent.TabIndex = 3;
            this.mentQInfoBoxDefaultTransparent.Text = "Unscaled & semi-transparent";
            this.mentQInfoBoxDefaultTransparent.Title = "Image";
            this.mentQInfoBoxDefaultTransparent.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBoxDefaultTransparent.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxDefaultTransparent.UnderlineSize = 4;
            // 
            // mentQInfoBoxScaledContainer
            // 
            this.mentQInfoBoxScaledContainer.AntiAliasImage = true;
            this.mentQInfoBoxScaledContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.mentQInfoBoxScaledContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mentQInfoBoxScaledContainer.BackgroundImage")));
            this.mentQInfoBoxScaledContainer.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.Scaled;
            this.mentQInfoBoxScaledContainer.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxScaledContainer.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxScaledContainer.ImageContainer = true;
            this.mentQInfoBoxScaledContainer.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxScaledContainer.ImageTransparency = 255;
            this.mentQInfoBoxScaledContainer.Location = new System.Drawing.Point(11, 253);
            this.mentQInfoBoxScaledContainer.Name = "mentQInfoBoxScaledContainer";
            this.mentQInfoBoxScaledContainer.Size = new System.Drawing.Size(282, 65);
            this.mentQInfoBoxScaledContainer.TabIndex = 5;
            this.mentQInfoBoxScaledContainer.Text = "Scaled with container";
            this.mentQInfoBoxScaledContainer.Title = "Image";
            this.mentQInfoBoxScaledContainer.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBoxScaledContainer.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxScaledContainer.UnderlineSize = 4;
            // 
            // mentQInfoBoxDefault
            // 
            this.mentQInfoBoxDefault.AntiAliasImage = true;
            this.mentQInfoBoxDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQInfoBoxDefault.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.None;
            this.mentQInfoBoxDefault.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxDefault.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxDefault.ImageContainer = false;
            this.mentQInfoBoxDefault.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxDefault.ImageTransparency = 255;
            this.mentQInfoBoxDefault.Location = new System.Drawing.Point(11, 40);
            this.mentQInfoBoxDefault.Name = "mentQInfoBoxDefault";
            this.mentQInfoBoxDefault.Size = new System.Drawing.Size(243, 65);
            this.mentQInfoBoxDefault.TabIndex = 0;
            this.mentQInfoBoxDefault.Text = "Full underline";
            this.mentQInfoBoxDefault.Title = "Default";
            this.mentQInfoBoxDefault.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBoxDefault.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxDefault.UnderlineSize = 4;
            // 
            // mentQInfoBoxScaledNoContainer
            // 
            this.mentQInfoBoxScaledNoContainer.AntiAliasImage = true;
            this.mentQInfoBoxScaledNoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.mentQInfoBoxScaledNoContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mentQInfoBoxScaledNoContainer.BackgroundImage")));
            this.mentQInfoBoxScaledNoContainer.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.Scaled;
            this.mentQInfoBoxScaledNoContainer.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxScaledNoContainer.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxScaledNoContainer.ImageContainer = false;
            this.mentQInfoBoxScaledNoContainer.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxScaledNoContainer.ImageTransparency = 255;
            this.mentQInfoBoxScaledNoContainer.Location = new System.Drawing.Point(11, 324);
            this.mentQInfoBoxScaledNoContainer.Name = "mentQInfoBoxScaledNoContainer";
            this.mentQInfoBoxScaledNoContainer.Size = new System.Drawing.Size(282, 65);
            this.mentQInfoBoxScaledNoContainer.TabIndex = 7;
            this.mentQInfoBoxScaledNoContainer.Text = "Scaled no container";
            this.mentQInfoBoxScaledNoContainer.Title = "Image";
            this.mentQInfoBoxScaledNoContainer.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBoxScaledNoContainer.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxScaledNoContainer.UnderlineSize = 4;
            // 
            // mentQInfoBoxDefaultNoUnderline
            // 
            this.mentQInfoBoxDefaultNoUnderline.AntiAliasImage = true;
            this.mentQInfoBoxDefaultNoUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQInfoBoxDefaultNoUnderline.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.None;
            this.mentQInfoBoxDefaultNoUnderline.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.mentQInfoBoxDefaultNoUnderline.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBoxDefaultNoUnderline.ImageContainer = false;
            this.mentQInfoBoxDefaultNoUnderline.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBoxDefaultNoUnderline.ImageTransparency = 255;
            this.mentQInfoBoxDefaultNoUnderline.Location = new System.Drawing.Point(11, 111);
            this.mentQInfoBoxDefaultNoUnderline.Name = "mentQInfoBoxDefaultNoUnderline";
            this.mentQInfoBoxDefaultNoUnderline.Size = new System.Drawing.Size(243, 65);
            this.mentQInfoBoxDefaultNoUnderline.TabIndex = 2;
            this.mentQInfoBoxDefaultNoUnderline.Text = "No underline";
            this.mentQInfoBoxDefaultNoUnderline.Title = "Default";
            this.mentQInfoBoxDefaultNoUnderline.Underline = MentQ.MentQInfoBox.UnderlineStyle.None;
            this.mentQInfoBoxDefaultNoUnderline.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBoxDefaultNoUnderline.UnderlineSize = 4;
            // 
            // mentQGroupBoxClosable
            // 
            this.mentQGroupBoxClosable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mentQGroupBoxClosable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQGroupBoxClosable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mentQGroupBoxClosable.Closable = true;
            this.mentQGroupBoxClosable.Closed = false;
            this.mentQGroupBoxClosable.Controls.Add(this.mentQButtonImage);
            this.mentQGroupBoxClosable.Controls.Add(this.mentQButtonUnderline);
            this.mentQGroupBoxClosable.Controls.Add(this.mentQButtonDefault);
            this.mentQGroupBoxClosable.Controls.Add(this.mentQEllipticalProgressDefault);
            this.mentQGroupBoxClosable.Controls.Add(this.mentQEllipticalProgressHatchBrush);
            this.mentQGroupBoxClosable.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mentQGroupBoxClosable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mentQGroupBoxClosable.Icon = null;
            this.mentQGroupBoxClosable.Location = new System.Drawing.Point(615, 8);
            this.mentQGroupBoxClosable.Name = "mentQGroupBoxClosable";
            this.mentQGroupBoxClosable.Size = new System.Drawing.Size(202, 217);
            this.mentQGroupBoxClosable.TabIndex = 1;
            this.mentQGroupBoxClosable.Text = "Closable group box";
            this.mentQGroupBoxClosable.UpperColor = System.Drawing.Color.Empty;
            // 
            // mentQButtonImage
            // 
            this.mentQButtonImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mentQButtonImage.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQButtonImage.ForeColor = System.Drawing.Color.White;
            this.mentQButtonImage.Image = ((System.Drawing.Image)(resources.GetObject("mentQButtonImage.Image")));
            this.mentQButtonImage.Location = new System.Drawing.Point(16, 183);
            this.mentQButtonImage.Name = "mentQButtonImage";
            this.mentQButtonImage.Size = new System.Drawing.Size(169, 23);
            this.mentQButtonImage.TabIndex = 5;
            this.mentQButtonImage.Text = "With image";
            this.mentQButtonImage.Underline = false;
            this.mentQButtonImage.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButtonImage.UnderlineSize = 2;
            this.mentQButtonImage.UseVisualStyleBackColor = false;
            // 
            // mentQButtonUnderline
            // 
            this.mentQButtonUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.mentQButtonUnderline.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQButtonUnderline.ForeColor = System.Drawing.Color.White;
            this.mentQButtonUnderline.Location = new System.Drawing.Point(16, 154);
            this.mentQButtonUnderline.Name = "mentQButtonUnderline";
            this.mentQButtonUnderline.Size = new System.Drawing.Size(169, 23);
            this.mentQButtonUnderline.TabIndex = 4;
            this.mentQButtonUnderline.Text = "Underline";
            this.mentQButtonUnderline.Underline = true;
            this.mentQButtonUnderline.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButtonUnderline.UnderlineSize = 3;
            this.mentQButtonUnderline.UseVisualStyleBackColor = false;
            // 
            // mentQButtonDefault
            // 
            this.mentQButtonDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQButtonDefault.Font = new System.Drawing.Font("Verdana", 7F);
            this.mentQButtonDefault.ForeColor = System.Drawing.Color.White;
            this.mentQButtonDefault.Location = new System.Drawing.Point(16, 125);
            this.mentQButtonDefault.Name = "mentQButtonDefault";
            this.mentQButtonDefault.Size = new System.Drawing.Size(169, 23);
            this.mentQButtonDefault.TabIndex = 3;
            this.mentQButtonDefault.Text = "Default button";
            this.mentQButtonDefault.Underline = false;
            this.mentQButtonDefault.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButtonDefault.UnderlineSize = 2;
            this.mentQButtonDefault.UseVisualStyleBackColor = false;
            // 
            // mentQEllipticalProgressDefault
            // 
            this.mentQEllipticalProgressDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.mentQEllipticalProgressDefault.Font = new System.Drawing.Font("Verdana", 8F);
            this.mentQEllipticalProgressDefault.ForeColor = System.Drawing.Color.Black;
            this.mentQEllipticalProgressDefault.HatchBrushSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.mentQEllipticalProgressDefault.HatchBrushStyle = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
            this.mentQEllipticalProgressDefault.Location = new System.Drawing.Point(115, 40);
            this.mentQEllipticalProgressDefault.Name = "mentQEllipticalProgressDefault";
            this.mentQEllipticalProgressDefault.Size = new System.Drawing.Size(70, 70);
            this.mentQEllipticalProgressDefault.TabIndex = 1;
            this.mentQEllipticalProgressDefault.Text = "Default";
            this.mentQEllipticalProgressDefault.UseHatchBrush = false;
            this.mentQEllipticalProgressDefault.Value = 50;
            // 
            // mentQEllipticalProgressHatchBrush
            // 
            this.mentQEllipticalProgressHatchBrush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQEllipticalProgressHatchBrush.Font = new System.Drawing.Font("Verdana", 8F);
            this.mentQEllipticalProgressHatchBrush.ForeColor = System.Drawing.Color.Black;
            this.mentQEllipticalProgressHatchBrush.HatchBrushSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.mentQEllipticalProgressHatchBrush.HatchBrushStyle = System.Drawing.Drawing2D.HatchStyle.LightUpwardDiagonal;
            this.mentQEllipticalProgressHatchBrush.Location = new System.Drawing.Point(16, 40);
            this.mentQEllipticalProgressHatchBrush.Name = "mentQEllipticalProgressHatchBrush";
            this.mentQEllipticalProgressHatchBrush.Size = new System.Drawing.Size(70, 70);
            this.mentQEllipticalProgressHatchBrush.TabIndex = 0;
            this.mentQEllipticalProgressHatchBrush.Text = "Hatchbrush";
            this.mentQEllipticalProgressHatchBrush.UseHatchBrush = true;
            this.mentQEllipticalProgressHatchBrush.Value = 75;
            // 
            // tabPageDio
            // 
            this.tabPageDio.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDio.Controls.Add(this.dioGroupBoxColored);
            this.tabPageDio.Controls.Add(this.dioGroupBoxProgressBars);
            this.tabPageDio.Controls.Add(this.dioGroupBoxDefault);
            this.tabPageDio.ImageIndex = 0;
            this.tabPageDio.Location = new System.Drawing.Point(179, 4);
            this.tabPageDio.Name = "tabPageDio";
            this.tabPageDio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDio.Size = new System.Drawing.Size(828, 501);
            this.tabPageDio.TabIndex = 1;
            this.tabPageDio.Text = "Dio";
            // 
            // dioGroupBoxColored
            // 
            this.dioGroupBoxColored.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioGroupBoxColored.BorderColor = System.Drawing.Color.Empty;
            this.dioGroupBoxColored.Controls.Add(this.dioGroupBoxBiggerShadow);
            this.dioGroupBoxColored.Controls.Add(this.dioGroupBoxColoredShadow);
            this.dioGroupBoxColored.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioGroupBoxColored.ForeColor = System.Drawing.Color.White;
            this.dioGroupBoxColored.Location = new System.Drawing.Point(7, 207);
            this.dioGroupBoxColored.Name = "dioGroupBoxColored";
            this.dioGroupBoxColored.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dioGroupBoxColored.ShadowSize = 4;
            this.dioGroupBoxColored.Size = new System.Drawing.Size(382, 286);
            this.dioGroupBoxColored.TabIndex = 2;
            this.dioGroupBoxColored.TabStop = false;
            this.dioGroupBoxColored.Text = "Colored group box";
            // 
            // dioGroupBoxBiggerShadow
            // 
            this.dioGroupBoxBiggerShadow.BackColor = System.Drawing.Color.YellowGreen;
            this.dioGroupBoxBiggerShadow.BorderColor = System.Drawing.Color.Empty;
            this.dioGroupBoxBiggerShadow.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioGroupBoxBiggerShadow.ForeColor = System.Drawing.Color.White;
            this.dioGroupBoxBiggerShadow.Location = new System.Drawing.Point(7, 111);
            this.dioGroupBoxBiggerShadow.Name = "dioGroupBoxBiggerShadow";
            this.dioGroupBoxBiggerShadow.ShadowColor = System.Drawing.Color.White;
            this.dioGroupBoxBiggerShadow.ShadowSize = 10;
            this.dioGroupBoxBiggerShadow.Size = new System.Drawing.Size(369, 68);
            this.dioGroupBoxBiggerShadow.TabIndex = 1;
            this.dioGroupBoxBiggerShadow.TabStop = false;
            this.dioGroupBoxBiggerShadow.Text = "Bigger shadow";
            // 
            // dioGroupBoxColoredShadow
            // 
            this.dioGroupBoxColoredShadow.BackColor = System.Drawing.Color.SandyBrown;
            this.dioGroupBoxColoredShadow.BorderColor = System.Drawing.Color.Empty;
            this.dioGroupBoxColoredShadow.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioGroupBoxColoredShadow.ForeColor = System.Drawing.Color.White;
            this.dioGroupBoxColoredShadow.Location = new System.Drawing.Point(7, 37);
            this.dioGroupBoxColoredShadow.Name = "dioGroupBoxColoredShadow";
            this.dioGroupBoxColoredShadow.ShadowColor = System.Drawing.Color.White;
            this.dioGroupBoxColoredShadow.ShadowSize = 4;
            this.dioGroupBoxColoredShadow.Size = new System.Drawing.Size(369, 68);
            this.dioGroupBoxColoredShadow.TabIndex = 0;
            this.dioGroupBoxColoredShadow.TabStop = false;
            this.dioGroupBoxColoredShadow.Text = "Custom shadow color";
            // 
            // dioGroupBoxProgressBars
            // 
            this.dioGroupBoxProgressBars.BackColor = System.Drawing.Color.White;
            this.dioGroupBoxProgressBars.BorderColor = System.Drawing.Color.Empty;
            this.dioGroupBoxProgressBars.Controls.Add(this.labelColored);
            this.dioGroupBoxProgressBars.Controls.Add(this.dioMarqueeProgressBarColored);
            this.dioGroupBoxProgressBars.Controls.Add(this.labelDifferentPosition);
            this.dioGroupBoxProgressBars.Controls.Add(this.dioMarqueeProgressBarDifferentPosition);
            this.dioGroupBoxProgressBars.Controls.Add(this.labelBiggerMarquee);
            this.dioGroupBoxProgressBars.Controls.Add(this.dioMarqueeProgressBarBiggerMarquee);
            this.dioGroupBoxProgressBars.Controls.Add(this.labelNoMarquee);
            this.dioGroupBoxProgressBars.Controls.Add(this.dioMarqueeProgressBarNoMarquee);
            this.dioGroupBoxProgressBars.Controls.Add(this.labelDefault);
            this.dioGroupBoxProgressBars.Controls.Add(this.dioMarqueeProgressBarDefault);
            this.dioGroupBoxProgressBars.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioGroupBoxProgressBars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioGroupBoxProgressBars.Location = new System.Drawing.Point(396, 9);
            this.dioGroupBoxProgressBars.Name = "dioGroupBoxProgressBars";
            this.dioGroupBoxProgressBars.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dioGroupBoxProgressBars.ShadowSize = 4;
            this.dioGroupBoxProgressBars.Size = new System.Drawing.Size(424, 484);
            this.dioGroupBoxProgressBars.TabIndex = 1;
            this.dioGroupBoxProgressBars.TabStop = false;
            this.dioGroupBoxProgressBars.Text = "Default group box";
            // 
            // labelColored
            // 
            this.labelColored.AutoSize = true;
            this.labelColored.Location = new System.Drawing.Point(32, 198);
            this.labelColored.Name = "labelColored";
            this.labelColored.Size = new System.Drawing.Size(164, 13);
            this.labelColored.TabIndex = 22;
            this.labelColored.Text = "Colored marquee progress bar";
            // 
            // dioMarqueeProgressBarColored
            // 
            this.dioMarqueeProgressBarColored.BackColor = System.Drawing.Color.White;
            this.dioMarqueeProgressBarColored.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dioMarqueeProgressBarColored.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioMarqueeProgressBarColored.ForeColor = System.Drawing.Color.IndianRed;
            this.dioMarqueeProgressBarColored.Location = new System.Drawing.Point(32, 214);
            this.dioMarqueeProgressBarColored.MarqueeVisible = true;
            this.dioMarqueeProgressBarColored.MarqueeWidth = 80;
            this.dioMarqueeProgressBarColored.MarqueeXPos = 160;
            this.dioMarqueeProgressBarColored.Name = "dioMarqueeProgressBarColored";
            this.dioMarqueeProgressBarColored.Size = new System.Drawing.Size(358, 14);
            this.dioMarqueeProgressBarColored.TabIndex = 21;
            this.dioMarqueeProgressBarColored.Text = "dioMarqueeProgressBar5";
            // 
            // labelDifferentPosition
            // 
            this.labelDifferentPosition.AutoSize = true;
            this.labelDifferentPosition.Location = new System.Drawing.Point(32, 161);
            this.labelDifferentPosition.Name = "labelDifferentPosition";
            this.labelDifferentPosition.Size = new System.Drawing.Size(255, 13);
            this.labelDifferentPosition.TabIndex = 20;
            this.labelDifferentPosition.Text = "Default different position marquee progress bar";
            // 
            // dioMarqueeProgressBarDifferentPosition
            // 
            this.dioMarqueeProgressBarDifferentPosition.BackColor = System.Drawing.Color.White;
            this.dioMarqueeProgressBarDifferentPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dioMarqueeProgressBarDifferentPosition.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioMarqueeProgressBarDifferentPosition.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dioMarqueeProgressBarDifferentPosition.Location = new System.Drawing.Point(32, 177);
            this.dioMarqueeProgressBarDifferentPosition.MarqueeVisible = true;
            this.dioMarqueeProgressBarDifferentPosition.MarqueeWidth = 80;
            this.dioMarqueeProgressBarDifferentPosition.MarqueeXPos = 160;
            this.dioMarqueeProgressBarDifferentPosition.Name = "dioMarqueeProgressBarDifferentPosition";
            this.dioMarqueeProgressBarDifferentPosition.Size = new System.Drawing.Size(358, 14);
            this.dioMarqueeProgressBarDifferentPosition.TabIndex = 19;
            this.dioMarqueeProgressBarDifferentPosition.Text = "dioMarqueeProgressBar4";
            // 
            // labelBiggerMarquee
            // 
            this.labelBiggerMarquee.AutoSize = true;
            this.labelBiggerMarquee.Location = new System.Drawing.Point(32, 123);
            this.labelBiggerMarquee.Name = "labelBiggerMarquee";
            this.labelBiggerMarquee.Size = new System.Drawing.Size(198, 13);
            this.labelBiggerMarquee.TabIndex = 18;
            this.labelBiggerMarquee.Text = "Default bigger marquee progress bar";
            // 
            // dioMarqueeProgressBarBiggerMarquee
            // 
            this.dioMarqueeProgressBarBiggerMarquee.BackColor = System.Drawing.Color.White;
            this.dioMarqueeProgressBarBiggerMarquee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dioMarqueeProgressBarBiggerMarquee.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioMarqueeProgressBarBiggerMarquee.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dioMarqueeProgressBarBiggerMarquee.Location = new System.Drawing.Point(32, 139);
            this.dioMarqueeProgressBarBiggerMarquee.MarqueeVisible = true;
            this.dioMarqueeProgressBarBiggerMarquee.MarqueeWidth = 80;
            this.dioMarqueeProgressBarBiggerMarquee.MarqueeXPos = 20;
            this.dioMarqueeProgressBarBiggerMarquee.Name = "dioMarqueeProgressBarBiggerMarquee";
            this.dioMarqueeProgressBarBiggerMarquee.Size = new System.Drawing.Size(358, 14);
            this.dioMarqueeProgressBarBiggerMarquee.TabIndex = 17;
            this.dioMarqueeProgressBarBiggerMarquee.Text = "dioMarqueeProgressBar3";
            // 
            // labelNoMarquee
            // 
            this.labelNoMarquee.AutoSize = true;
            this.labelNoMarquee.Location = new System.Drawing.Point(32, 84);
            this.labelNoMarquee.Name = "labelNoMarquee";
            this.labelNoMarquee.Size = new System.Drawing.Size(178, 13);
            this.labelNoMarquee.TabIndex = 16;
            this.labelNoMarquee.Text = "Default no marquee progress bar";
            // 
            // dioMarqueeProgressBarNoMarquee
            // 
            this.dioMarqueeProgressBarNoMarquee.BackColor = System.Drawing.Color.White;
            this.dioMarqueeProgressBarNoMarquee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dioMarqueeProgressBarNoMarquee.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioMarqueeProgressBarNoMarquee.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dioMarqueeProgressBarNoMarquee.Location = new System.Drawing.Point(32, 100);
            this.dioMarqueeProgressBarNoMarquee.MarqueeVisible = false;
            this.dioMarqueeProgressBarNoMarquee.MarqueeWidth = 50;
            this.dioMarqueeProgressBarNoMarquee.MarqueeXPos = 20;
            this.dioMarqueeProgressBarNoMarquee.Name = "dioMarqueeProgressBarNoMarquee";
            this.dioMarqueeProgressBarNoMarquee.Size = new System.Drawing.Size(358, 14);
            this.dioMarqueeProgressBarNoMarquee.TabIndex = 15;
            this.dioMarqueeProgressBarNoMarquee.Text = "dioMarqueeProgressBar2";
            // 
            // labelDefault
            // 
            this.labelDefault.AutoSize = true;
            this.labelDefault.Location = new System.Drawing.Point(32, 45);
            this.labelDefault.Name = "labelDefault";
            this.labelDefault.Size = new System.Drawing.Size(161, 13);
            this.labelDefault.TabIndex = 14;
            this.labelDefault.Text = "Default marquee progress bar";
            // 
            // dioMarqueeProgressBarDefault
            // 
            this.dioMarqueeProgressBarDefault.BackColor = System.Drawing.Color.White;
            this.dioMarqueeProgressBarDefault.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dioMarqueeProgressBarDefault.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioMarqueeProgressBarDefault.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dioMarqueeProgressBarDefault.Location = new System.Drawing.Point(32, 61);
            this.dioMarqueeProgressBarDefault.MarqueeVisible = true;
            this.dioMarqueeProgressBarDefault.MarqueeWidth = 50;
            this.dioMarqueeProgressBarDefault.MarqueeXPos = 20;
            this.dioMarqueeProgressBarDefault.Name = "dioMarqueeProgressBarDefault";
            this.dioMarqueeProgressBarDefault.Size = new System.Drawing.Size(358, 14);
            this.dioMarqueeProgressBarDefault.TabIndex = 13;
            this.dioMarqueeProgressBarDefault.Text = "dioMarqueeProgressBar1";
            // 
            // dioGroupBoxDefault
            // 
            this.dioGroupBoxDefault.BackColor = System.Drawing.Color.White;
            this.dioGroupBoxDefault.BorderColor = System.Drawing.Color.Empty;
            this.dioGroupBoxDefault.Controls.Add(this.dioTextBoxDefault);
            this.dioGroupBoxDefault.Controls.Add(this.dioRadioButtonDefaultChecked);
            this.dioGroupBoxDefault.Controls.Add(this.dioRadioButtonDefaultUnchecked);
            this.dioGroupBoxDefault.Controls.Add(this.dioCheckBoxColoredChecked);
            this.dioGroupBoxDefault.Controls.Add(this.dioCheckBoxDefaultChecked);
            this.dioGroupBoxDefault.Controls.Add(this.dioCheckBoxDefaultUnchecked);
            this.dioGroupBoxDefault.Controls.Add(this.dioButtonColored);
            this.dioGroupBoxDefault.Controls.Add(this.dioLabelTitle);
            this.dioGroupBoxDefault.Controls.Add(this.dioLabelDefault);
            this.dioGroupBoxDefault.Controls.Add(this.dioButtonDefault);
            this.dioGroupBoxDefault.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioGroupBoxDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioGroupBoxDefault.Location = new System.Drawing.Point(7, 9);
            this.dioGroupBoxDefault.Name = "dioGroupBoxDefault";
            this.dioGroupBoxDefault.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dioGroupBoxDefault.ShadowSize = 4;
            this.dioGroupBoxDefault.Size = new System.Drawing.Size(382, 191);
            this.dioGroupBoxDefault.TabIndex = 0;
            this.dioGroupBoxDefault.TabStop = false;
            this.dioGroupBoxDefault.Text = "Default group box";
            // 
            // dioTextBoxDefault
            // 
            this.dioTextBoxDefault.BackColor = System.Drawing.Color.White;
            this.dioTextBoxDefault.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.dioTextBoxDefault.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioTextBoxDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioTextBoxDefault.InitialBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dioTextBoxDefault.Location = new System.Drawing.Point(7, 146);
            this.dioTextBoxDefault.Multiline = false;
            this.dioTextBoxDefault.Name = "dioTextBoxDefault";
            this.dioTextBoxDefault.Size = new System.Drawing.Size(176, 22);
            this.dioTextBoxDefault.TabIndex = 9;
            this.dioTextBoxDefault.Text = "Default text box";
            // 
            // dioRadioButtonDefaultChecked
            // 
            this.dioRadioButtonDefaultChecked.AutoSize = true;
            this.dioRadioButtonDefaultChecked.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioRadioButtonDefaultChecked.BorderColor = System.Drawing.Color.Empty;
            this.dioRadioButtonDefaultChecked.Checked = true;
            this.dioRadioButtonDefaultChecked.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioRadioButtonDefaultChecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioRadioButtonDefaultChecked.Location = new System.Drawing.Point(190, 146);
            this.dioRadioButtonDefaultChecked.Name = "dioRadioButtonDefaultChecked";
            this.dioRadioButtonDefaultChecked.Size = new System.Drawing.Size(168, 15);
            this.dioRadioButtonDefaultChecked.TabIndex = 8;
            this.dioRadioButtonDefaultChecked.TabStop = true;
            this.dioRadioButtonDefaultChecked.Text = "Default checked radio button";
            this.dioRadioButtonDefaultChecked.UseVisualStyleBackColor = false;
            // 
            // dioRadioButtonDefaultUnchecked
            // 
            this.dioRadioButtonDefaultUnchecked.AutoSize = true;
            this.dioRadioButtonDefaultUnchecked.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioRadioButtonDefaultUnchecked.BorderColor = System.Drawing.Color.Empty;
            this.dioRadioButtonDefaultUnchecked.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioRadioButtonDefaultUnchecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioRadioButtonDefaultUnchecked.Location = new System.Drawing.Point(190, 125);
            this.dioRadioButtonDefaultUnchecked.Name = "dioRadioButtonDefaultUnchecked";
            this.dioRadioButtonDefaultUnchecked.Size = new System.Drawing.Size(181, 15);
            this.dioRadioButtonDefaultUnchecked.TabIndex = 7;
            this.dioRadioButtonDefaultUnchecked.Text = "Default unchecked radio button";
            this.dioRadioButtonDefaultUnchecked.UseVisualStyleBackColor = false;
            // 
            // dioCheckBoxColoredChecked
            // 
            this.dioCheckBoxColoredChecked.AutoSize = true;
            this.dioCheckBoxColoredChecked.BackColor = System.Drawing.Color.YellowGreen;
            this.dioCheckBoxColoredChecked.BorderColor = System.Drawing.Color.Empty;
            this.dioCheckBoxColoredChecked.Checked = true;
            this.dioCheckBoxColoredChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dioCheckBoxColoredChecked.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioCheckBoxColoredChecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioCheckBoxColoredChecked.Location = new System.Drawing.Point(190, 103);
            this.dioCheckBoxColoredChecked.Name = "dioCheckBoxColoredChecked";
            this.dioCheckBoxColoredChecked.Size = new System.Drawing.Size(142, 15);
            this.dioCheckBoxColoredChecked.TabIndex = 6;
            this.dioCheckBoxColoredChecked.Text = "Custom color check box";
            this.dioCheckBoxColoredChecked.UseVisualStyleBackColor = false;
            // 
            // dioCheckBoxDefaultChecked
            // 
            this.dioCheckBoxDefaultChecked.AutoSize = true;
            this.dioCheckBoxDefaultChecked.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioCheckBoxDefaultChecked.BorderColor = System.Drawing.Color.Empty;
            this.dioCheckBoxDefaultChecked.Checked = true;
            this.dioCheckBoxDefaultChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dioCheckBoxDefaultChecked.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioCheckBoxDefaultChecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioCheckBoxDefaultChecked.Location = new System.Drawing.Point(190, 82);
            this.dioCheckBoxDefaultChecked.Name = "dioCheckBoxDefaultChecked";
            this.dioCheckBoxDefaultChecked.Size = new System.Drawing.Size(155, 15);
            this.dioCheckBoxDefaultChecked.TabIndex = 5;
            this.dioCheckBoxDefaultChecked.Text = "Default checked check box";
            this.dioCheckBoxDefaultChecked.UseVisualStyleBackColor = false;
            // 
            // dioCheckBoxDefaultUnchecked
            // 
            this.dioCheckBoxDefaultUnchecked.AutoSize = true;
            this.dioCheckBoxDefaultUnchecked.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioCheckBoxDefaultUnchecked.BorderColor = System.Drawing.Color.Empty;
            this.dioCheckBoxDefaultUnchecked.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioCheckBoxDefaultUnchecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioCheckBoxDefaultUnchecked.Location = new System.Drawing.Point(190, 61);
            this.dioCheckBoxDefaultUnchecked.Name = "dioCheckBoxDefaultUnchecked";
            this.dioCheckBoxDefaultUnchecked.Size = new System.Drawing.Size(168, 15);
            this.dioCheckBoxDefaultUnchecked.TabIndex = 4;
            this.dioCheckBoxDefaultUnchecked.Text = "Default unchecked check box";
            this.dioCheckBoxDefaultUnchecked.UseVisualStyleBackColor = false;
            // 
            // dioButtonColored
            // 
            this.dioButtonColored.BackColor = System.Drawing.Color.SandyBrown;
            this.dioButtonColored.BorderColor = System.Drawing.Color.Empty;
            this.dioButtonColored.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioButtonColored.ForeColor = System.Drawing.Color.White;
            this.dioButtonColored.Location = new System.Drawing.Point(189, 35);
            this.dioButtonColored.Name = "dioButtonColored";
            this.dioButtonColored.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dioButtonColored.ShadowSize = 4;
            this.dioButtonColored.Size = new System.Drawing.Size(176, 23);
            this.dioButtonColored.TabIndex = 3;
            this.dioButtonColored.Text = "Custom color";
            this.dioButtonColored.UseVisualStyleBackColor = false;
            // 
            // dioLabelTitle
            // 
            this.dioLabelTitle.BackColor = System.Drawing.Color.SandyBrown;
            this.dioLabelTitle.DrawSide = true;
            this.dioLabelTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dioLabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioLabelTitle.Location = new System.Drawing.Point(7, 95);
            this.dioLabelTitle.Name = "dioLabelTitle";
            this.dioLabelTitle.Size = new System.Drawing.Size(135, 39);
            this.dioLabelTitle.TabIndex = 2;
            this.dioLabelTitle.Text = "Label with title";
            this.dioLabelTitle.Title = "Default";
            this.dioLabelTitle.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F);
            // 
            // dioLabelDefault
            // 
            this.dioLabelDefault.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioLabelDefault.DrawSide = true;
            this.dioLabelDefault.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dioLabelDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioLabelDefault.Location = new System.Drawing.Point(7, 61);
            this.dioLabelDefault.Name = "dioLabelDefault";
            this.dioLabelDefault.Size = new System.Drawing.Size(122, 25);
            this.dioLabelDefault.TabIndex = 1;
            this.dioLabelDefault.Text = "Default label";
            this.dioLabelDefault.Title = "";
            this.dioLabelDefault.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F);
            // 
            // dioButtonDefault
            // 
            this.dioButtonDefault.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioButtonDefault.BorderColor = System.Drawing.Color.Empty;
            this.dioButtonDefault.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dioButtonDefault.ForeColor = System.Drawing.Color.White;
            this.dioButtonDefault.Location = new System.Drawing.Point(7, 35);
            this.dioButtonDefault.Name = "dioButtonDefault";
            this.dioButtonDefault.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dioButtonDefault.ShadowSize = 4;
            this.dioButtonDefault.Size = new System.Drawing.Size(176, 23);
            this.dioButtonDefault.TabIndex = 0;
            this.dioButtonDefault.Text = "Default button";
            this.dioButtonDefault.UseVisualStyleBackColor = false;
            // 
            // mentQNumericUpDown1
            // 
            this.mentQNumericUpDown1.BackColor = System.Drawing.Color.White;
            this.mentQNumericUpDown1.Location = new System.Drawing.Point(14, 46);
            this.mentQNumericUpDown1.MaximumSize = new System.Drawing.Size(32767, 24);
            this.mentQNumericUpDown1.MinimumSize = new System.Drawing.Size(0, 24);
            this.mentQNumericUpDown1.Name = "mentQNumericUpDown1";
            this.mentQNumericUpDown1.Padding = new System.Windows.Forms.Padding(3);
            this.mentQNumericUpDown1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQNumericUpDown1.Size = new System.Drawing.Size(138, 24);
            this.mentQNumericUpDown1.TabIndex = 0;
            this.mentQNumericUpDown1.Text = "mentQNumericUpDown1";
            this.mentQNumericUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 509);
            this.Controls.Add(this.mentQTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1027, 548);
            this.MinimumSize = new System.Drawing.Size(1027, 548);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.mentQTabControl.ResumeLayout(false);
            this.tabPageMenQ.ResumeLayout(false);
            this.mentQGroupBoxRegularIcon.ResumeLayout(false);
            this.mentQGroupBoxRegularIcon.PerformLayout();
            this.mentQGroupBoxColoredBorder.ResumeLayout(false);
            this.mentQGroupBoxColoredHeader.ResumeLayout(false);
            this.mentQGroupBoxClosed.ResumeLayout(false);
            this.mentQGroupBoxClosable.ResumeLayout(false);
            this.tabPageDio.ResumeLayout(false);
            this.dioGroupBoxColored.ResumeLayout(false);
            this.dioGroupBoxProgressBars.ResumeLayout(false);
            this.dioGroupBoxProgressBars.PerformLayout();
            this.dioGroupBoxDefault.ResumeLayout(false);
            this.dioGroupBoxDefault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MentQTabControl mentQTabControl;
        private System.Windows.Forms.TabPage tabPageMenQ;
        private System.Windows.Forms.TabPage tabPageDio;
        private MentQGroupBox mentQGroupBoxColoredHeader;
        private MentQGroupBox mentQGroupBoxClosable;
        private MentQInfoBox mentQInfoBoxScaledContainer;
        private MentQInfoBox mentQInfoBoxScaledNoContainer;
        private MentQInfoBox mentQInfoBoxDefaultNoUnderline;
        private MentQInfoBox mentQInfoBoxDefaultTransparent;
        private MentQInfoBox mentQInfoBoxImageDefault;
        private MentQInfoBox mentQInfoBoxDefault;
        private MentQInfoBox mentQInfoBoxWhiteUnderline;
        private MentQInfoBox mentQInfoBoxUnderlineExclude;
        private MentQInfoBox mentQInfoBoxUnderlineImageOnly;
        private MentQGroupBox mentQGroupBoxRegularIcon;
        private MentQGroupBox mentQGroupBoxClosed;
        private MentQProgressBar mentQProgressBarUnderlineColored;
        private MentQProgressBar mentQProgressBarDefault;
        private MentQButton mentQButtonDefault;
        private MentQEllipticalProgress mentQEllipticalProgressDefault;
        private MentQEllipticalProgress mentQEllipticalProgressHatchBrush;
        private MentQButton mentQButtonUnderline;
        private MentQButton mentQButtonImage;
        private MentQRadioButton mentQRadioButtonUnchecked;
        private MentQCheckBox mentQCheckBoxChecked;
        private MentQCheckBox mentQCheckBoxUnchecked;
        private MentQRadioButton mentQRadioButtonChecked;
        private System.Windows.Forms.ImageList imageListTabControl;
        private DioGroupBox dioGroupBoxDefault;
        private DioButton dioButtonColored;
        private DioLabel dioLabelTitle;
        private DioLabel dioLabelDefault;
        private DioButton dioButtonDefault;
        private DioCheckBox dioCheckBoxDefaultUnchecked;
        private DioRadioButton dioRadioButtonDefaultUnchecked;
        private DioCheckBox dioCheckBoxColoredChecked;
        private DioCheckBox dioCheckBoxDefaultChecked;
        private DioGroupBox dioGroupBoxColored;
        private DioGroupBox dioGroupBoxBiggerShadow;
        private DioGroupBox dioGroupBoxColoredShadow;
        private DioGroupBox dioGroupBoxProgressBars;
        private System.Windows.Forms.Label labelColored;
        private DioMarqueeProgressBar dioMarqueeProgressBarColored;
        private System.Windows.Forms.Label labelDifferentPosition;
        private DioMarqueeProgressBar dioMarqueeProgressBarDifferentPosition;
        private System.Windows.Forms.Label labelBiggerMarquee;
        private DioMarqueeProgressBar dioMarqueeProgressBarBiggerMarquee;
        private System.Windows.Forms.Label labelNoMarquee;
        private DioMarqueeProgressBar dioMarqueeProgressBarNoMarquee;
        private System.Windows.Forms.Label labelDefault;
        private DioMarqueeProgressBar dioMarqueeProgressBarDefault;
        private DioTextBox dioTextBoxDefault;
        private DioRadioButton dioRadioButtonDefaultChecked;
        private MentQGroupBox mentQGroupBoxColoredBorder;
        private MentQNotification mentQNotificationDefault;
        private MentQNumericUpDown mentQNumericUpDown1;
    }
}

