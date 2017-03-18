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
            this.UdpPanel = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TcpPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UDP_Tile = new MetroFramework.Controls.MetroTile();
            this.TCP_Tile = new MetroFramework.Controls.MetroTile();
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
            this.Zigbee_Tile = new MetroFramework.Controls.MetroTile();
            this.WIFI_Tile = new MetroFramework.Controls.MetroTile();
            this.UART_Tile = new MetroFramework.Controls.MetroTile();
            this.RF_Tile = new MetroFramework.Controls.MetroTile();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdfasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddfdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendBtn = new MetroFramework.Controls.MetroButton();
            this.LogPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ReceiveWindowBox = new System.Windows.Forms.RichTextBox();
            this.SendWindowBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Chk_Hexa = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroPanel1.SuspendLayout();
            this.UdpPanel.SuspendLayout();
            this.TcpPanel.SuspendLayout();
            this.SerialPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.Controls.Add(this.TcpPanel);
            this.metroPanel1.Controls.Add(this.UdpPanel);
            this.metroPanel1.Controls.Add(this.UDP_Tile);
            this.metroPanel1.Controls.Add(this.TCP_Tile);
            this.metroPanel1.Controls.Add(this.SerialPanel);
            this.metroPanel1.Controls.Add(this.Zigbee_Tile);
            this.metroPanel1.Controls.Add(this.WIFI_Tile);
            this.metroPanel1.Controls.Add(this.UART_Tile);
            this.metroPanel1.Controls.Add(this.RF_Tile);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(563, 703);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // UdpPanel
            // 
            this.UdpPanel.Controls.Add(this.checkBox2);
            this.UdpPanel.Controls.Add(this.comboBox3);
            this.UdpPanel.Controls.Add(this.comboBox4);
            this.UdpPanel.Controls.Add(this.label9);
            this.UdpPanel.Controls.Add(this.label10);
            this.UdpPanel.Controls.Add(this.label11);
            this.UdpPanel.Controls.Add(this.button4);
            this.UdpPanel.Controls.Add(this.button5);
            this.UdpPanel.Location = new System.Drawing.Point(107, 539);
            this.UdpPanel.Name = "UdpPanel";
            this.UdpPanel.Size = new System.Drawing.Size(340, 161);
            this.UdpPanel.TabIndex = 15;
            this.UdpPanel.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 16);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "서버 활성화";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 25);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(109, 58);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "포트       (F) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "IP           (I) :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "UDP 설정";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(250, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "옵션적용";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TcpPanel
            // 
            this.TcpPanel.Controls.Add(this.textBox1);
            this.TcpPanel.Controls.Add(this.checkBox1);
            this.TcpPanel.Controls.Add(this.comboBox1);
            this.TcpPanel.Controls.Add(this.comboBox2);
            this.TcpPanel.Controls.Add(this.label1);
            this.TcpPanel.Controls.Add(this.label7);
            this.TcpPanel.Controls.Add(this.label8);
            this.TcpPanel.Controls.Add(this.button1);
            this.TcpPanel.Controls.Add(this.button3);
            this.TcpPanel.Location = new System.Drawing.Point(23, 342);
            this.TcpPanel.Name = "TcpPanel";
            this.TcpPanel.Size = new System.Drawing.Size(340, 180);
            this.TcpPanel.TabIndex = 14;
            this.TcpPanel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 16);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "서버 활성화";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "포트       (F) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "IP           (I) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "TCP 설정";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "옵션적용";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UDP_Tile
            // 
            this.UDP_Tile.BackColor = System.Drawing.Color.White;
            this.UDP_Tile.ForeColor = System.Drawing.SystemColors.Control;
            this.UDP_Tile.Location = new System.Drawing.Point(3, 286);
            this.UDP_Tile.Name = "UDP_Tile";
            this.UDP_Tile.Size = new System.Drawing.Size(115, 50);
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UDP_Tile.TabIndex = 9;
            this.UDP_Tile.Text = "UDP";
            this.UDP_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UDP_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UDP_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UDP_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.UDP_Tile.Click += new System.EventHandler(this.UDP_Tile_Click);
            // 
            // TCP_Tile
            // 
            this.TCP_Tile.BackColor = System.Drawing.Color.White;
            this.TCP_Tile.ForeColor = System.Drawing.SystemColors.Control;
            this.TCP_Tile.Location = new System.Drawing.Point(3, 230);
            this.TCP_Tile.Name = "TCP_Tile";
            this.TCP_Tile.Size = new System.Drawing.Size(115, 50);
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.TCP_Tile.TabIndex = 8;
            this.TCP_Tile.Text = "TCP";
            this.TCP_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCP_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCP_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TCP_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TCP_Tile.Click += new System.EventHandler(this.TCP_Tile_Click);
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
            this.SerialPanel.Location = new System.Drawing.Point(140, 6);
            this.SerialPanel.Name = "SerialPanel";
            this.SerialPanel.Size = new System.Drawing.Size(340, 286);
            this.SerialPanel.TabIndex = 7;
            this.SerialPanel.Visible = false;
            // 
            // Serial_Combo_FlowCon
            // 
            this.Serial_Combo_FlowCon.FormattingEnabled = true;
            this.Serial_Combo_FlowCon.Location = new System.Drawing.Point(111, 176);
            this.Serial_Combo_FlowCon.Name = "Serial_Combo_FlowCon";
            this.Serial_Combo_FlowCon.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_FlowCon.TabIndex = 13;
            this.Serial_Combo_FlowCon.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_FlowCon_SelectedIndexChanged);
            // 
            // Serial_Combo_StopBit
            // 
            this.Serial_Combo_StopBit.FormattingEnabled = true;
            this.Serial_Combo_StopBit.Location = new System.Drawing.Point(111, 145);
            this.Serial_Combo_StopBit.Name = "Serial_Combo_StopBit";
            this.Serial_Combo_StopBit.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_StopBit.TabIndex = 12;
            this.Serial_Combo_StopBit.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_StopBit_SelectedIndexChanged);
            // 
            // Serial_Combo_Parity
            // 
            this.Serial_Combo_Parity.FormattingEnabled = true;
            this.Serial_Combo_Parity.Location = new System.Drawing.Point(111, 116);
            this.Serial_Combo_Parity.Name = "Serial_Combo_Parity";
            this.Serial_Combo_Parity.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Parity.TabIndex = 11;
            this.Serial_Combo_Parity.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Parity_SelectedIndexChanged);
            // 
            // Serial_Combo_Data
            // 
            this.Serial_Combo_Data.FormattingEnabled = true;
            this.Serial_Combo_Data.Location = new System.Drawing.Point(111, 85);
            this.Serial_Combo_Data.Name = "Serial_Combo_Data";
            this.Serial_Combo_Data.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Data.TabIndex = 10;
            this.Serial_Combo_Data.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Data_SelectedIndexChanged);
            // 
            // Serial_Combo_Baud
            // 
            this.Serial_Combo_Baud.FormattingEnabled = true;
            this.Serial_Combo_Baud.Location = new System.Drawing.Point(111, 54);
            this.Serial_Combo_Baud.Name = "Serial_Combo_Baud";
            this.Serial_Combo_Baud.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Baud.TabIndex = 9;
            this.Serial_Combo_Baud.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Baud_SelectedIndexChanged);
            // 
            // Serial_Combo_Port
            // 
            this.Serial_Combo_Port.FormattingEnabled = true;
            this.Serial_Combo_Port.Location = new System.Drawing.Point(111, 22);
            this.Serial_Combo_Port.Name = "Serial_Combo_Port";
            this.Serial_Combo_Port.Size = new System.Drawing.Size(121, 20);
            this.Serial_Combo_Port.TabIndex = 8;
            this.Serial_Combo_Port.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Port_SelectedIndexChanged);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Serial_Btn_OK
            // 
            this.Serial_Btn_OK.Location = new System.Drawing.Point(250, 22);
            this.Serial_Btn_OK.Name = "Serial_Btn_OK";
            this.Serial_Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Serial_Btn_OK.TabIndex = 0;
            this.Serial_Btn_OK.Text = "옵션적용";
            this.Serial_Btn_OK.UseVisualStyleBackColor = true;
            this.Serial_Btn_OK.Click += new System.EventHandler(this.Serial_Btn_OK_Click);
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
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Pink;
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
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(173, 247);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(80, 32);
            this.SendBtn.TabIndex = 16;
            this.SendBtn.Text = "보내기";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(this.metroLabel7);
            this.LogPanel.Controls.Add(this.ReceiveWindowBox);
            this.LogPanel.HorizontalScrollbarBarColor = true;
            this.LogPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LogPanel.HorizontalScrollbarSize = 10;
            this.LogPanel.Location = new System.Drawing.Point(351, 369);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(442, 363);
            this.LogPanel.TabIndex = 6;
            this.LogPanel.VerticalScrollbarBarColor = true;
            this.LogPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LogPanel.VerticalScrollbarSize = 10;
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
            // ReceiveWindowBox
            // 
            this.ReceiveWindowBox.AcceptsTab = true;
            this.ReceiveWindowBox.AutoWordSelection = true;
            this.ReceiveWindowBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ReceiveWindowBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReceiveWindowBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ReceiveWindowBox.Location = new System.Drawing.Point(0, 24);
            this.ReceiveWindowBox.Name = "ReceiveWindowBox";
            this.ReceiveWindowBox.ReadOnly = true;
            this.ReceiveWindowBox.Size = new System.Drawing.Size(443, 339);
            this.ReceiveWindowBox.TabIndex = 3;
            this.ReceiveWindowBox.TabStop = false;
            this.ReceiveWindowBox.Text = "";
            // 
            // SendWindowBox
            // 
            this.SendWindowBox.AcceptsTab = true;
            this.SendWindowBox.AutoWordSelection = true;
            this.SendWindowBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.SendWindowBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SendWindowBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SendWindowBox.Location = new System.Drawing.Point(490, 89);
            this.SendWindowBox.Name = "SendWindowBox";
            this.SendWindowBox.Size = new System.Drawing.Size(284, 246);
            this.SendWindowBox.TabIndex = 2;
            this.SendWindowBox.TabStop = false;
            this.SendWindowBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Chk_Hexa
            // 
            this.Chk_Hexa.AutoSize = true;
            this.Chk_Hexa.Location = new System.Drawing.Point(269, 421);
            this.Chk_Hexa.Name = "Chk_Hexa";
            this.Chk_Hexa.Size = new System.Drawing.Size(60, 16);
            this.Chk_Hexa.TabIndex = 8;
            this.Chk_Hexa.Text = "16진수";
            this.Chk_Hexa.UseVisualStyleBackColor = true;
            this.Chk_Hexa.CheckedChanged += new System.EventHandler(this.Chk_Hexa_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 768);
            this.Controls.Add(this.Chk_Hexa);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.SendWindowBox);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SendBtn);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MultiTerminal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.UdpPanel.ResumeLayout(false);
            this.UdpPanel.PerformLayout();
            this.TcpPanel.ResumeLayout(false);
            this.TcpPanel.PerformLayout();
            this.SerialPanel.ResumeLayout(false);
            this.SerialPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
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
        private MetroFramework.Controls.MetroPanel LogPanel;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public System.Windows.Forms.RichTextBox ReceiveWindowBox;
        private MetroFramework.Controls.MetroTile TCP_Tile;
        private MetroFramework.Controls.MetroTile UDP_Tile;
        private MetroFramework.Controls.MetroButton SendBtn;
        private System.Windows.Forms.RichTextBox SendWindowBox;
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
        private System.Windows.Forms.CheckBox Chk_Hexa;
        private System.Windows.Forms.Panel TcpPanel;
        private System.Windows.Forms.Panel UdpPanel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

