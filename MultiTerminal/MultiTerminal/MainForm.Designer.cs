namespace MultiTerminal
    //choi에 분기만들고 커밋해보기
    //1212123123123
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Client_Tile = new MetroFramework.Controls.MetroTile();
            this.Server_Tile = new MetroFramework.Controls.MetroTile();
            this.Zigbee_Tile = new MetroFramework.Controls.MetroTile();
            this.WIFI_Tile = new MetroFramework.Controls.MetroTile();
            this.UART_Tile = new MetroFramework.Controls.MetroTile();
            this.RF_Tile = new MetroFramework.Controls.MetroTile();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdfasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddfdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.ReceiveBtn = new MetroFramework.Controls.MetroButton();
            this.SendBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.DisConBtn = new MetroFramework.Controls.MetroButton();
            this.ConnectBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.BaudRate = new MetroFramework.Controls.MetroTextBox();
            this.SeriPort = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SerialPanel = new System.Windows.Forms.Panel();
            this.Serial_Combo_FlowCon = new System.Windows.Forms.ComboBox();
            this.Serial_Combo_StopBit = new System.Windows.Forms.ComboBox();
            this.Serial_Combo_Parity = new System.Windows.Forms.ComboBox();
            this.Serial_Combo_Data = new System.Windows.Forms.ComboBox();
            this.Serial_Combo_Baud = new System.Windows.Forms.ComboBox();
            this.Serial_Combo_Port = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Se_Port = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Serial_Btn_OK = new System.Windows.Forms.Button();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metroPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SerialPanel.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.Controls.Add(this.Client_Tile);
            this.metroPanel1.Controls.Add(this.Server_Tile);
            this.metroPanel1.Controls.Add(this.Zigbee_Tile);
            this.metroPanel1.Controls.Add(this.WIFI_Tile);
            this.metroPanel1.Controls.Add(this.UART_Tile);
            this.metroPanel1.Controls.Add(this.RF_Tile);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(124, 397);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Client_Tile
            // 
            this.Client_Tile.BackColor = System.Drawing.Color.White;
            this.Client_Tile.ForeColor = System.Drawing.SystemColors.Control;
            this.Client_Tile.Location = new System.Drawing.Point(3, 286);
            this.Client_Tile.Name = "Client_Tile";
            this.Client_Tile.Size = new System.Drawing.Size(115, 50);
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Client_Tile.TabIndex = 9;
            this.Client_Tile.Text = "tcpclient";
            this.Client_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Client_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Client_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Client_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Client_Tile.Click += new System.EventHandler(this.Client_Tile_Click);
            // 
            // Server_Tile
            // 
            this.Server_Tile.BackColor = System.Drawing.Color.White;
            this.Server_Tile.ForeColor = System.Drawing.SystemColors.Control;
            this.Server_Tile.Location = new System.Drawing.Point(3, 230);
            this.Server_Tile.Name = "Server_Tile";
            this.Server_Tile.Size = new System.Drawing.Size(115, 50);
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Server_Tile.TabIndex = 8;
            this.Server_Tile.Text = "tcpserver";
            this.Server_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Server_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Server_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Server_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Server_Tile.Click += new System.EventHandler(this.Server_Tile_Click);
            // 
            // Zigbee_Tile
            // 
            this.Zigbee_Tile.BackColor = System.Drawing.Color.White;
            this.Zigbee_Tile.ForeColor = System.Drawing.SystemColors.Control;
            this.Zigbee_Tile.Location = new System.Drawing.Point(3, 174);
            this.Zigbee_Tile.Name = "Zigbee_Tile";
            this.Zigbee_Tile.Size = new System.Drawing.Size(115, 50);
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.TabIndex = 7;
            this.Zigbee_Tile.Text = "ZigBee";
            this.Zigbee_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Zigbee_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Zigbee_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Zigbee_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Zigbee_Tile.Click += new System.EventHandler(this.Zigbee_Tile_Click);
            // 
            // WIFI_Tile
            // 
            this.WIFI_Tile.Location = new System.Drawing.Point(3, 118);
            this.WIFI_Tile.Name = "WIFI_Tile";
            this.WIFI_Tile.Size = new System.Drawing.Size(115, 50);
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.WIFI_Tile.TabIndex = 6;
            this.WIFI_Tile.Text = "WIFI";
            this.WIFI_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WIFI_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WIFI_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.WIFI_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.WIFI_Tile.Click += new System.EventHandler(this.WIFI_Tile_Click);
            // 
            // UART_Tile
            // 
            this.UART_Tile.Location = new System.Drawing.Point(3, 62);
            this.UART_Tile.Name = "UART_Tile";
            this.UART_Tile.Size = new System.Drawing.Size(115, 50);
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.TabIndex = 5;
            this.UART_Tile.Text = "UART";
            this.UART_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UART_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UART_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UART_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.UART_Tile.Click += new System.EventHandler(this.UART_Tile_Click);
            // 
            // RF_Tile
            // 
            this.RF_Tile.Location = new System.Drawing.Point(3, 6);
            this.RF_Tile.Name = "RF_Tile";
            this.RF_Tile.Size = new System.Drawing.Size(115, 50);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.RF_Tile.TabIndex = 4;
            this.RF_Tile.Text = "RF";
            this.RF_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RF_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RF_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.RF_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.RF_Tile.Click += new System.EventHandler(this.RF_Tile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfasdfToolStripMenuItem,
            this.ddfdfToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(960, 19);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdfasdfToolStripMenuItem
            // 
            this.asdfasdfToolStripMenuItem.Name = "asdfasdfToolStripMenuItem";
            this.asdfasdfToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.asdfasdfToolStripMenuItem.Text = "메인";
            // 
            // ddfdfToolStripMenuItem
            // 
            this.ddfdfToolStripMenuItem.Name = "ddfdfToolStripMenuItem";
            this.ddfdfToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.ddfdfToolStripMenuItem.Text = "설정";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.ReceiveBtn);
            this.metroPanel2.Controls.Add(this.SendBtn);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroTextBox6);
            this.metroPanel2.Controls.Add(this.DisConBtn);
            this.metroPanel2.Controls.Add(this.ConnectBtn);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroTextBox5);
            this.metroPanel2.Controls.Add(this.BaudRate);
            this.metroPanel2.Controls.Add(this.SeriPort);
            this.metroPanel2.Controls.Add(this.metroTextBox2);
            this.metroPanel2.Controls.Add(this.metroTextBox1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(133, 82);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(341, 284);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // ReceiveBtn
            // 
            this.ReceiveBtn.Location = new System.Drawing.Point(252, 247);
            this.ReceiveBtn.Name = "ReceiveBtn";
            this.ReceiveBtn.Size = new System.Drawing.Size(80, 32);
            this.ReceiveBtn.TabIndex = 17;
            this.ReceiveBtn.Text = "받기";
            this.ReceiveBtn.Click += new System.EventHandler(this.ReceiveBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(173, 247);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(80, 32);
            this.SendBtn.TabIndex = 16;
            this.SendBtn.Text = "보내기";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "metroLabel6";
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(93, 208);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(239, 35);
            this.metroTextBox6.TabIndex = 14;
            this.metroTextBox6.Text = "metroTextBox6";
            // 
            // DisConBtn
            // 
            this.DisConBtn.Location = new System.Drawing.Point(87, 247);
            this.DisConBtn.Name = "DisConBtn";
            this.DisConBtn.Size = new System.Drawing.Size(80, 32);
            this.DisConBtn.TabIndex = 13;
            this.DisConBtn.Text = "연결 끊기";
            this.DisConBtn.Click += new System.EventHandler(this.DisConBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(4, 247);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(78, 32);
            this.ConnectBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.ConnectBtn.TabIndex = 12;
            this.ConnectBtn.Text = "연결";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 168);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "ClientMsg";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "BaudRate";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "포트넘버";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 45);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Port주소";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "IP주소";
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(93, 168);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(239, 35);
            this.metroTextBox5.TabIndex = 6;
            this.metroTextBox5.Text = "metroTextBox5";
            // 
            // BaudRate
            // 
            this.BaudRate.Location = new System.Drawing.Point(93, 127);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(239, 35);
            this.BaudRate.TabIndex = 5;
            this.BaudRate.Text = "9600";
            // 
            // SeriPort
            // 
            this.SeriPort.Location = new System.Drawing.Point(93, 86);
            this.SeriPort.Name = "SeriPort";
            this.SeriPort.Size = new System.Drawing.Size(239, 35);
            this.SeriPort.Style = MetroFramework.MetroColorStyle.Pink;
            this.SeriPort.TabIndex = 4;
            this.SeriPort.Text = "포트넘버 입력";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(93, 45);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(239, 35);
            this.metroTextBox2.TabIndex = 3;
            this.metroTextBox2.Text = "metroTextBox2";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(93, 4);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(239, 35);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // SerialPanel
            // 
            this.SerialPanel.Controls.Add(this.Serial_Combo_FlowCon);
            this.SerialPanel.Controls.Add(this.Serial_Combo_StopBit);
            this.SerialPanel.Controls.Add(this.Serial_Combo_Parity);
            this.SerialPanel.Controls.Add(this.Serial_Combo_Data);
            this.SerialPanel.Controls.Add(this.Serial_Combo_Baud);
            this.SerialPanel.Controls.Add(this.Serial_Combo_Port);
            this.SerialPanel.Controls.Add(this.label6);
            this.SerialPanel.Controls.Add(this.label5);
            this.SerialPanel.Controls.Add(this.label4);
            this.SerialPanel.Controls.Add(this.label3);
            this.SerialPanel.Controls.Add(this.label2);
            this.SerialPanel.Controls.Add(this.Label_Se_Port);
            this.SerialPanel.Controls.Add(this.button2);
            this.SerialPanel.Controls.Add(this.Serial_Btn_OK);
            this.SerialPanel.Location = new System.Drawing.Point(592, 200);
            this.SerialPanel.Name = "SerialPanel";
            this.SerialPanel.Size = new System.Drawing.Size(337, 325);
            this.SerialPanel.TabIndex = 7;
            // 
            // Serial_Combo_FlowCon
            // 
            this.Serial_Combo_FlowCon.FormattingEnabled = true;
            this.Serial_Combo_FlowCon.Location = new System.Drawing.Point(111, 176);
            this.Serial_Combo_FlowCon.Name = "Serial_Combo_FlowCon";
            this.Serial_Combo_FlowCon.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_FlowCon.TabIndex = 13;
            // 
            // Serial_Combo_StopBit
            // 
            this.Serial_Combo_StopBit.FormattingEnabled = true;
            this.Serial_Combo_StopBit.Location = new System.Drawing.Point(111, 145);
            this.Serial_Combo_StopBit.Name = "Serial_Combo_StopBit";
            this.Serial_Combo_StopBit.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_StopBit.TabIndex = 12;
            // 
            // Serial_Combo_Parity
            // 
            this.Serial_Combo_Parity.FormattingEnabled = true;
            this.Serial_Combo_Parity.Location = new System.Drawing.Point(111, 116);
            this.Serial_Combo_Parity.Name = "Serial_Combo_Parity";
            this.Serial_Combo_Parity.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Parity.TabIndex = 11;
            // 
            // Serial_Combo_Data
            // 
            this.Serial_Combo_Data.FormattingEnabled = true;
            this.Serial_Combo_Data.Location = new System.Drawing.Point(111, 85);
            this.Serial_Combo_Data.Name = "Serial_Combo_Data";
            this.Serial_Combo_Data.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Data.TabIndex = 10;
            // 
            // Serial_Combo_Baud
            // 
            this.Serial_Combo_Baud.FormattingEnabled = true;
            this.Serial_Combo_Baud.Location = new System.Drawing.Point(111, 54);
            this.Serial_Combo_Baud.Name = "Serial_Combo_Baud";
            this.Serial_Combo_Baud.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Baud.TabIndex = 9;
            // 
            // Serial_Combo_Port
            // 
            this.Serial_Combo_Port.FormattingEnabled = true;
            this.Serial_Combo_Port.Location = new System.Drawing.Point(111, 22);
            this.Serial_Combo_Port.Name = "Serial_Combo_Port";
            this.Serial_Combo_Port.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Port.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "흐름제어 (F) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "스탑비트 (S) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "패리티    (A) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "데이터    (D) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "속도       (B) :";
            // 
            // Label_Se_Port
            // 
            this.Label_Se_Port.AutoSize = true;
            this.Label_Se_Port.Location = new System.Drawing.Point(18, 27);
            this.Label_Se_Port.Name = "Label_Se_Port";
            this.Label_Se_Port.Size = new System.Drawing.Size(83, 12);
            this.Label_Se_Port.TabIndex = 2;
            this.Label_Se_Port.Text = "포트       (P) :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Serial_Btn_OK
            // 
            this.Serial_Btn_OK.Location = new System.Drawing.Point(250, 22);
            this.Serial_Btn_OK.Name = "Serial_Btn_OK";
            this.Serial_Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Serial_Btn_OK.TabIndex = 0;
            this.Serial_Btn_OK.Text = "옵션적용";
            this.Serial_Btn_OK.UseVisualStyleBackColor = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel7);
            this.metroPanel4.Controls.Add(this.richTextBox2);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(351, 369);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(442, 363);
            this.metroPanel4.TabIndex = 6;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(5, 2);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "로그";
            // 
            // richTextBox2
            // 
            this.richTextBox2.AcceptsTab = true;
            this.richTextBox2.AutoWordSelection = true;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBox2.Location = new System.Drawing.Point(0, 24);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(443, 339);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "받기 :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBox1.Location = new System.Drawing.Point(490, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 246);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "보내기 :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 768);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.SerialPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MultiTerminal";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.SerialPanel.ResumeLayout(false);
            this.SerialPanel.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile WIFI_Tile;
        private MetroFramework.Controls.MetroTile UART_Tile;
        private MetroFramework.Controls.MetroTile RF_Tile;
        private MetroFramework.Controls.MetroTile Zigbee_Tile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdfasdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ddfdfToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroButton DisConBtn;
        private MetroFramework.Controls.MetroButton ConnectBtn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox BaudRate;
        private MetroFramework.Controls.MetroTextBox SeriPort;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MetroFramework.Controls.MetroTile Server_Tile;
        private MetroFramework.Controls.MetroTile Client_Tile;
        private MetroFramework.Controls.MetroButton SendBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroButton ReceiveBtn;
        private System.Windows.Forms.Panel SerialPanel;
        private System.Windows.Forms.ComboBox Serial_Combo_FlowCon;
        private System.Windows.Forms.ComboBox Serial_Combo_StopBit;
        private System.Windows.Forms.ComboBox Serial_Combo_Parity;
        private System.Windows.Forms.ComboBox Serial_Combo_Data;
        private System.Windows.Forms.ComboBox Serial_Combo_Baud;
        private System.Windows.Forms.ComboBox Serial_Combo_Port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Se_Port;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Serial_Btn_OK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

