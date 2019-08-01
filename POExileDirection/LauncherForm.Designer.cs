namespace POExileDirection
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.DeadlyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxKOREA = new System.Windows.Forms.PictureBox();
            this.panelWaiting = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.xuiFlatProgressBar2 = new XanderUI.XUIFlatProgressBar();
            this.xuiFlatProgressBar1 = new XanderUI.XUIFlatProgressBar();
            this.labelNINJASTATUS = new System.Windows.Forms.Label();
            this.labelReady = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelUserLeague = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelAddonStatus = new System.Windows.Forms.Label();
            this.labelPOEAddonNotice = new System.Windows.Forms.Label();
            this.labelPOERealPath = new System.Windows.Forms.Label();
            this.labelPOEAdddonNotifyText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartAddon = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNeedToUpdate = new System.Windows.Forms.Label();
            this.labelVersionState = new System.Windows.Forms.Label();
            this.labelUI = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelServerVer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurrentVer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIconDeadlyTrade = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherTimer = new System.Windows.Forms.Timer(this.components);
            this.timerDetect = new System.Windows.Forms.Timer(this.components);
            this.timerOutFocus = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKOREA)).BeginInit();
            this.panelWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.pictureBox3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(558, 43);
            this.panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::POExileDirection.Properties.Resources.CloseButton_45_45_48_24px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(543, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::POExileDirection.Properties.Resources.Minimize_45_45_48_24px;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(524, 27);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POExileDirection.Properties.Resources.DeadlyCrush_Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(560, 43);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.pictureBoxKOREA);
            this.panel2.Controls.Add(this.panelWaiting);
            this.panel2.Controls.Add(this.xuiFlatProgressBar2);
            this.panel2.Controls.Add(this.xuiFlatProgressBar1);
            this.panel2.Controls.Add(this.labelNINJASTATUS);
            this.panel2.Controls.Add(this.labelReady);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.labelUserLeague);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnStartAddon);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelNeedToUpdate);
            this.panel2.Controls.Add(this.labelVersionState);
            this.panel2.Controls.Add(this.labelUI);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelClient);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelServerVer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelCurrentVer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 375);
            this.panel2.TabIndex = 3;
            // 
            // pictureBoxKOREA
            // 
            this.pictureBoxKOREA.BackgroundImage = global::POExileDirection.Properties.Resources.flag_korea;
            this.pictureBoxKOREA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKOREA.Location = new System.Drawing.Point(525, 303);
            this.pictureBoxKOREA.Name = "pictureBoxKOREA";
            this.pictureBoxKOREA.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxKOREA.TabIndex = 13;
            this.pictureBoxKOREA.TabStop = false;
            this.pictureBoxKOREA.Visible = false;
            // 
            // panelWaiting
            // 
            this.panelWaiting.BackColor = System.Drawing.Color.White;
            this.panelWaiting.Controls.Add(this.label7);
            this.panelWaiting.Controls.Add(this.label8);
            this.panelWaiting.Controls.Add(this.label6);
            this.panelWaiting.Controls.Add(this.pictureBox2);
            this.panelWaiting.Location = new System.Drawing.Point(0, 1);
            this.panelWaiting.Name = "panelWaiting";
            this.panelWaiting.Size = new System.Drawing.Size(20, 20);
            this.panelWaiting.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 49);
            this.label7.TabIndex = 1;
            this.label7.Text = "잠시만 기다려주세요.\r\n\r\nWait a moment plz...";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(247, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "DeadlyTrade";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 49);
            this.label6.TabIndex = 1;
            this.label6.Text = "업데이트를 확인중입니다.\r\n\r\nUpdate Checking...";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::POExileDirection.Properties.Resources.lg_double_ring_spinner;
            this.pictureBox2.Location = new System.Drawing.Point(158, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // xuiFlatProgressBar2
            // 
            this.xuiFlatProgressBar2.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuiFlatProgressBar2.BorderColor = System.Drawing.Color.Black;
            this.xuiFlatProgressBar2.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiFlatProgressBar2.InocmpletedColor = System.Drawing.Color.White;
            this.xuiFlatProgressBar2.Location = new System.Drawing.Point(245, 163);
            this.xuiFlatProgressBar2.MaxValue = 100;
            this.xuiFlatProgressBar2.Name = "xuiFlatProgressBar2";
            this.xuiFlatProgressBar2.ShowBorder = true;
            this.xuiFlatProgressBar2.Size = new System.Drawing.Size(305, 14);
            this.xuiFlatProgressBar2.TabIndex = 9;
            this.xuiFlatProgressBar2.Value = 0;
            // 
            // xuiFlatProgressBar1
            // 
            this.xuiFlatProgressBar1.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuiFlatProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.xuiFlatProgressBar1.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiFlatProgressBar1.InocmpletedColor = System.Drawing.Color.White;
            this.xuiFlatProgressBar1.Location = new System.Drawing.Point(245, 140);
            this.xuiFlatProgressBar1.MaxValue = 100;
            this.xuiFlatProgressBar1.Name = "xuiFlatProgressBar1";
            this.xuiFlatProgressBar1.ShowBorder = true;
            this.xuiFlatProgressBar1.Size = new System.Drawing.Size(305, 14);
            this.xuiFlatProgressBar1.TabIndex = 9;
            this.xuiFlatProgressBar1.Value = 0;
            // 
            // labelNINJASTATUS
            // 
            this.labelNINJASTATUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.labelNINJASTATUS.ForeColor = System.Drawing.Color.Silver;
            this.labelNINJASTATUS.Location = new System.Drawing.Point(17, 138);
            this.labelNINJASTATUS.Name = "labelNINJASTATUS";
            this.labelNINJASTATUS.Size = new System.Drawing.Size(228, 20);
            this.labelNINJASTATUS.TabIndex = 4;
            this.labelNINJASTATUS.Text = "POE.NINJA 데이터 (2019.07.21.20:27:32)";
            this.labelNINJASTATUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReady
            // 
            this.labelReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.labelReady.Location = new System.Drawing.Point(5, 262);
            this.labelReady.Name = "labelReady";
            this.labelReady.Size = new System.Drawing.Size(548, 20);
            this.labelReady.TabIndex = 4;
            this.labelReady.Text = "POE [KAKAO] Client Readly to";
            this.labelReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReady.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::POExileDirection.Properties.Resources.POExileDirection;
            this.pictureBox4.Location = new System.Drawing.Point(5, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // labelUserLeague
            // 
            this.labelUserLeague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.labelUserLeague.ForeColor = System.Drawing.Color.Silver;
            this.labelUserLeague.Location = new System.Drawing.Point(55, 26);
            this.labelUserLeague.Name = "labelUserLeague";
            this.labelUserLeague.Size = new System.Drawing.Size(495, 20);
            this.labelUserLeague.TabIndex = 4;
            this.labelUserLeague.Text = "최근 선택한 리그는 \'Legion\'\' 입니다. ( Last Your Chosen League is \'Legion\' )";
            this.labelUserLeague.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.panel4.Location = new System.Drawing.Point(5, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 53);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.labelAddonStatus);
            this.panel3.Controls.Add(this.labelPOEAddonNotice);
            this.panel3.Controls.Add(this.labelPOERealPath);
            this.panel3.Controls.Add(this.labelPOEAdddonNotifyText);
            this.panel3.Location = new System.Drawing.Point(5, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 115);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::POExileDirection.Properties.Resources.POEKAKAOfavicon;
            this.pictureBox5.Location = new System.Drawing.Point(12, 70);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // labelAddonStatus
            // 
            this.labelAddonStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.labelAddonStatus.ForeColor = System.Drawing.Color.Silver;
            this.labelAddonStatus.Location = new System.Drawing.Point(12, 33);
            this.labelAddonStatus.Name = "labelAddonStatus";
            this.labelAddonStatus.Size = new System.Drawing.Size(228, 20);
            this.labelAddonStatus.TabIndex = 4;
            this.labelAddonStatus.Text = "Addon Data (2019.07.21.20:27:32)";
            this.labelAddonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPOEAddonNotice
            // 
            this.labelPOEAddonNotice.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelPOEAddonNotice.Location = new System.Drawing.Point(48, 68);
            this.labelPOEAddonNotice.Name = "labelPOEAddonNotice";
            this.labelPOEAddonNotice.Size = new System.Drawing.Size(497, 20);
            this.labelPOEAddonNotice.TabIndex = 4;
            this.labelPOEAddonNotice.Text = "게임을 실행하면 자동으로 경로를 찾습니다. Launch Path of Exile first. (Auto Detect)";
            this.labelPOEAddonNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPOEAddonNotice.Visible = false;
            // 
            // labelPOERealPath
            // 
            this.labelPOERealPath.ForeColor = System.Drawing.Color.Silver;
            this.labelPOERealPath.Location = new System.Drawing.Point(151, 85);
            this.labelPOERealPath.Name = "labelPOERealPath";
            this.labelPOERealPath.Size = new System.Drawing.Size(390, 20);
            this.labelPOERealPath.TabIndex = 4;
            this.labelPOERealPath.Text = "게임이 실행 되기를 기다리고 있습니다. (Waiting for \'POE\' Started)";
            this.labelPOERealPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPOERealPath.Visible = false;
            // 
            // labelPOEAdddonNotifyText
            // 
            this.labelPOEAdddonNotifyText.ForeColor = System.Drawing.Color.Silver;
            this.labelPOEAdddonNotifyText.Location = new System.Drawing.Point(48, 85);
            this.labelPOEAdddonNotifyText.Name = "labelPOEAdddonNotifyText";
            this.labelPOEAdddonNotifyText.Size = new System.Drawing.Size(115, 20);
            this.labelPOEAdddonNotifyText.TabIndex = 4;
            this.labelPOEAdddonNotifyText.Text = "POE 경로(Path) :";
            this.labelPOEAdddonNotifyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPOEAdddonNotifyText.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 43);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POExileDirection.Properties.Resources.DeadlyTrade_Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartAddon
            // 
            this.btnStartAddon.FlatAppearance.BorderSize = 0;
            this.btnStartAddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAddon.ForeColor = System.Drawing.Color.LightBlue;
            this.btnStartAddon.Image = global::POExileDirection.Properties.Resources.DeadlyTradeWaitingButton;
            this.btnStartAddon.Location = new System.Drawing.Point(191, 280);
            this.btnStartAddon.Name = "btnStartAddon";
            this.btnStartAddon.Size = new System.Drawing.Size(190, 53);
            this.btnStartAddon.TabIndex = 5;
            this.btnStartAddon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartAddon.UseVisualStyleBackColor = true;
            this.btnStartAddon.Click += new System.EventHandler(this.BtnStartAddon_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Image = global::POExileDirection.Properties.Resources.DeadlyCrush_CheckUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(520, 249);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(15, 15);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(532, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "└ 수동 업데이트 (Manual Update)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // labelNeedToUpdate
            // 
            this.labelNeedToUpdate.ForeColor = System.Drawing.Color.Silver;
            this.labelNeedToUpdate.Location = new System.Drawing.Point(172, 98);
            this.labelNeedToUpdate.Name = "labelNeedToUpdate";
            this.labelNeedToUpdate.Size = new System.Drawing.Size(381, 20);
            this.labelNeedToUpdate.TabIndex = 4;
            this.labelNeedToUpdate.Text = "업데이트가 필요하지 않습니다. (No Update Nedeed)";
            this.labelNeedToUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersionState
            // 
            this.labelVersionState.ForeColor = System.Drawing.Color.Silver;
            this.labelVersionState.Location = new System.Drawing.Point(172, 74);
            this.labelVersionState.Name = "labelVersionState";
            this.labelVersionState.Size = new System.Drawing.Size(381, 20);
            this.labelVersionState.TabIndex = 4;
            this.labelVersionState.Text = "최신 버전을 사용하고 있습니다. (Current Version is the Newest)";
            this.labelVersionState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUI
            // 
            this.labelUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.labelUI.Location = new System.Drawing.Point(469, 309);
            this.labelUI.Name = "labelUI";
            this.labelUI.Size = new System.Drawing.Size(84, 20);
            this.labelUI.TabIndex = 4;
            this.labelUI.Text = "Your UI : KOR";
            this.labelUI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUI.Visible = false;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(403, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "1920 * 1080";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(403, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Resolution and Language";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Visible = false;
            // 
            // labelClient
            // 
            this.labelClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.labelClient.Location = new System.Drawing.Point(17, 309);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(151, 20);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "CLIENT : KAKAO";
            this.labelClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelClient.Visible = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "최신 버전 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelServerVer
            // 
            this.labelServerVer.ForeColor = System.Drawing.Color.Silver;
            this.labelServerVer.Location = new System.Drawing.Point(92, 98);
            this.labelServerVer.Name = "labelServerVer";
            this.labelServerVer.Size = new System.Drawing.Size(60, 20);
            this.labelServerVer.TabIndex = 4;
            this.labelServerVer.Text = "서버 버전";
            this.labelServerVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(149, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "→";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(149, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "→";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCurrentVer
            // 
            this.labelCurrentVer.ForeColor = System.Drawing.Color.Silver;
            this.labelCurrentVer.Location = new System.Drawing.Point(92, 74);
            this.labelCurrentVer.Name = "labelCurrentVer";
            this.labelCurrentVer.Size = new System.Drawing.Size(60, 20);
            this.labelCurrentVer.TabIndex = 4;
            this.labelCurrentVer.Text = "현재 버전";
            this.labelCurrentVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "현재 버전 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIconDeadlyTrade
            // 
            this.notifyIconDeadlyTrade.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconDeadlyTrade.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDeadlyTrade.Icon")));
            this.notifyIconDeadlyTrade.Text = "notifyIcon1";
            this.notifyIconDeadlyTrade.DoubleClick += new System.EventHandler(this.NotifyIconDeadlyTrade_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem1.Text = "최대화 (Maximize)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem2.Text = "종료 (Exit)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // launcherTimer
            // 
            this.launcherTimer.Interval = 200;
            this.launcherTimer.Tick += new System.EventHandler(this.LauncherTimer_Tick);
            // 
            // timerDetect
            // 
            this.timerDetect.Interval = 1000;
            this.timerDetect.Tick += new System.EventHandler(this.TimerDetect_Tick);
            // 
            // timerOutFocus
            // 
            this.timerOutFocus.Interval = 350;
            this.timerOutFocus.Tick += new System.EventHandler(this.TimerOutFocus_Tick);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(558, 418);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LauncherForm_FormClosed);
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.Resize += new System.EventHandler(this.LauncherForm_Resize);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKOREA)).EndInit();
            this.panelWaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip DeadlyToolTip;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelWaiting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStartAddon;
        private System.Windows.Forms.Label labelNeedToUpdate;
        private System.Windows.Forms.Label labelVersionState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelServerVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NotifyIcon notifyIconDeadlyTrade;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar2;
        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar1;
        private System.Windows.Forms.Timer launcherTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNINJASTATUS;
        private System.Windows.Forms.Label labelUserLeague;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelAddonStatus;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelPOEAddonNotice;
        private System.Windows.Forms.Label labelPOEAdddonNotifyText;
        private System.Windows.Forms.Label labelPOERealPath;
        private System.Windows.Forms.Timer timerDetect;
        private System.Windows.Forms.Label labelReady;
        private System.Windows.Forms.Label labelUI;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.PictureBox pictureBoxKOREA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerOutFocus;
    }
}