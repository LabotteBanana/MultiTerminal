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
            this.panel4 = new System.Windows.Forms.Panel();

            this.TcpPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();

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
            this.Serial_Btn_OK = new System.Windows.Forms.Button();

            this.F5 = new System.Windows.Forms.Button();
            
          
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();

            this.UdpPanel = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_StopLog = new System.Windows.Forms.Button();
            this.Btn_UseLog = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Chk_AS = new System.Windows.Forms.CheckBox();
            this.Chk_AE = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Chk_Hexa = new System.Windows.Forms.CheckBox();
            this.LogPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ReceiveWindowBox = new System.Windows.Forms.RichTextBox();
            this.UDP_Tile = new MetroFramework.Controls.MetroTile();
            this.TCP_Tile = new MetroFramework.Controls.MetroTile();
            this.UART_Tile = new MetroFramework.Controls.MetroTile();
            this.panel3 = new System.Windows.Forms.Panel();

            this.label16 = new System.Windows.Forms.Label();

            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();

            this.Btn_ASCII4 = new System.Windows.Forms.Button();
            this.Btn_AEAS4 = new System.Windows.Forms.Button();
            this.Btn_ASCII3 = new System.Windows.Forms.Button();
            this.Btn_AEAS3 = new System.Windows.Forms.Button();
            this.Btn_ASCII2 = new System.Windows.Forms.Button();
            this.Btn_AEAS2 = new System.Windows.Forms.Button();
            this.Btn_ASCII1 = new System.Windows.Forms.Button();
            this.Btn_AEAS1 = new System.Windows.Forms.Button();
            this.Btn_Send3 = new System.Windows.Forms.Button();
            this.SendBox3 = new System.Windows.Forms.RichTextBox();
            this.Btn_Send4 = new System.Windows.Forms.Button();
            this.Btn_Send2 = new System.Windows.Forms.Button();
            this.SendBox4 = new System.Windows.Forms.RichTextBox();
            this.Btn_Send1 = new System.Windows.Forms.Button();
            this.SendBox2 = new System.Windows.Forms.RichTextBox();

            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendBox1 = new System.Windows.Forms.RichTextBox();
            this.Zigbee_Tile = new MetroFramework.Controls.MetroTile();
            this.WIFI_Tile = new MetroFramework.Controls.MetroTile();
            this.RF_Tile = new MetroFramework.Controls.MetroTile();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdfasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddfdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendBtn = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.panel4.SuspendLayout();

            this.SerialPanel.SuspendLayout();
            this.TcpPanel.SuspendLayout();

            this.UdpPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.Controls.Add(this.panel4);
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.LogPanel);
            this.metroPanel1.Controls.Add(this.UDP_Tile);
            this.metroPanel1.Controls.Add(this.TCP_Tile);
            this.metroPanel1.Controls.Add(this.UART_Tile);
            this.metroPanel1.Controls.Add(this.panel3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(720, 611);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TcpPanel);
            this.panel4.Controls.Add(this.SerialPanel);
            this.panel4.Controls.Add(this.UdpPanel);
            this.panel4.Location = new System.Drawing.Point(5, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 285);
            this.panel4.TabIndex = 17;
            // 

            // TcpPanel
            // 
            this.TcpPanel.Controls.Add(this.checkBox1);
            this.TcpPanel.Controls.Add(this.comboBox1);
            this.TcpPanel.Controls.Add(this.comboBox2);
            this.TcpPanel.Controls.Add(this.label1);
            this.TcpPanel.Controls.Add(this.label7);
            this.TcpPanel.Controls.Add(this.label8);
            this.TcpPanel.Controls.Add(this.button1);
            this.TcpPanel.Controls.Add(this.button3);
            this.TcpPanel.Location = new System.Drawing.Point(3, 3);
            this.TcpPanel.Name = "TcpPanel";
            this.TcpPanel.Size = new System.Drawing.Size(150, 276);
            this.TcpPanel.TabIndex = 14;
            this.TcpPanel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 85);
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
            this.comboBox1.Location = new System.Drawing.Point(59, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 20);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(50, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "포트 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "IP :";
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
            this.button1.Location = new System.Drawing.Point(9, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "옵션적용";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.SerialPanel.Controls.Add(this.Serial_Btn_OK);
            this.SerialPanel.Controls.Add(this.F5);
            this.SerialPanel.Location = new System.Drawing.Point(3, 3);
            this.SerialPanel.Name = "SerialPanel";
            this.SerialPanel.Size = new System.Drawing.Size(150, 276);
            this.SerialPanel.TabIndex = 7;
            this.SerialPanel.Visible = false;
            // 
            // Serial_Combo_FlowCon
            // 
            this.Serial_Combo_FlowCon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Combo_FlowCon.FormattingEnabled = true;
            this.Serial_Combo_FlowCon.Location = new System.Drawing.Point(70, 176);
            this.Serial_Combo_FlowCon.Name = "Serial_Combo_FlowCon";
            this.Serial_Combo_FlowCon.Size = new System.Drawing.Size(76, 20);
            this.Serial_Combo_FlowCon.TabIndex = 13;
            this.Serial_Combo_FlowCon.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_FlowCon_SelectedIndexChanged);
            // 
            // Serial_Combo_StopBit
            // 
            this.Serial_Combo_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Combo_StopBit.FormattingEnabled = true;
            this.Serial_Combo_StopBit.Location = new System.Drawing.Point(70, 145);
            this.Serial_Combo_StopBit.Name = "Serial_Combo_StopBit";
            this.Serial_Combo_StopBit.Size = new System.Drawing.Size(76, 20);
            this.Serial_Combo_StopBit.TabIndex = 12;
            this.Serial_Combo_StopBit.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_StopBit_SelectedIndexChanged);
            // 
            // Serial_Combo_Parity
            // 
            this.Serial_Combo_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Combo_Parity.FormattingEnabled = true;
            this.Serial_Combo_Parity.Location = new System.Drawing.Point(70, 116);
            this.Serial_Combo_Parity.Name = "Serial_Combo_Parity";
            this.Serial_Combo_Parity.Size = new System.Drawing.Size(76, 20);
            this.Serial_Combo_Parity.TabIndex = 11;
            this.Serial_Combo_Parity.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Parity_SelectedIndexChanged);
            // 
            // Serial_Combo_Data
            // 
            this.Serial_Combo_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Combo_Data.FormattingEnabled = true;
            this.Serial_Combo_Data.Location = new System.Drawing.Point(70, 85);
            this.Serial_Combo_Data.Name = "Serial_Combo_Data";
            this.Serial_Combo_Data.Size = new System.Drawing.Size(76, 20);
            this.Serial_Combo_Data.TabIndex = 10;
            this.Serial_Combo_Data.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Data_SelectedIndexChanged);
            // 
            // Serial_Combo_Baud
            // 
            this.Serial_Combo_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Combo_Baud.FormattingEnabled = true;
            this.Serial_Combo_Baud.Location = new System.Drawing.Point(70, 54);
            this.Serial_Combo_Baud.Name = "Serial_Combo_Baud";
            this.Serial_Combo_Baud.Size = new System.Drawing.Size(76, 20);
            this.Serial_Combo_Baud.TabIndex = 9;
            this.Serial_Combo_Baud.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Baud_SelectedIndexChanged);
            // 
            // Serial_Combo_Port
            // 
            this.Serial_Combo_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Combo_Port.FormattingEnabled = true;
            this.Serial_Combo_Port.Location = new System.Drawing.Point(70, 22);
            this.Serial_Combo_Port.Name = "Serial_Combo_Port";
            this.Serial_Combo_Port.Size = new System.Drawing.Size(76, 20);
            this.Serial_Combo_Port.TabIndex = 8;
            this.Serial_Combo_Port.SelectedIndexChanged += new System.EventHandler(this.Serial_Combo_Port_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "흐름제어 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "스탑비트 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "패리티 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "데이터 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "속도 :";
            // 
            // Label_Se_Port
            // 
            this.Label_Se_Port.AutoSize = true;
            this.Label_Se_Port.Location = new System.Drawing.Point(32, 27);
            this.Label_Se_Port.Name = "Label_Se_Port";
            this.Label_Se_Port.Size = new System.Drawing.Size(37, 12);
            this.Label_Se_Port.TabIndex = 2;
            this.Label_Se_Port.Text = "포트 :";
            // 
            // Serial_Btn_OK
            // 
            this.Serial_Btn_OK.Location = new System.Drawing.Point(79, 219);
            this.Serial_Btn_OK.Name = "Serial_Btn_OK";
            this.Serial_Btn_OK.Size = new System.Drawing.Size(62, 23);
            this.Serial_Btn_OK.TabIndex = 0;
            this.Serial_Btn_OK.Text = "옵션적용";
            this.Serial_Btn_OK.UseVisualStyleBackColor = true;
            this.Serial_Btn_OK.Click += new System.EventHandler(this.Serial_Btn_OK_Click);
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
            this.UdpPanel.Location = new System.Drawing.Point(3, 3);
            this.UdpPanel.Name = "UdpPanel";
            this.UdpPanel.Size = new System.Drawing.Size(150, 276);
            this.UdpPanel.TabIndex = 15;
            this.UdpPanel.Visible = false;

            // F5
            // 
            this.F5.Location = new System.Drawing.Point(10, 219);
            this.F5.Name = "F5";
            this.F5.Size = new System.Drawing.Size(62, 23);
            this.F5.TabIndex = 14;
            this.F5.Text = "새로고침";
            this.F5.UseVisualStyleBackColor = true;
            // 
            // TcpPanel
            // 
            this.TcpPanel.Controls.Add(this.checkBox1);
            this.TcpPanel.Controls.Add(this.comboBox1);
            this.TcpPanel.Controls.Add(this.comboBox2);
            this.TcpPanel.Controls.Add(this.label1);
            this.TcpPanel.Controls.Add(this.label7);
            this.TcpPanel.Controls.Add(this.label8);
            this.TcpPanel.Controls.Add(this.button1);
            this.TcpPanel.Controls.Add(this.button3);
            this.TcpPanel.Location = new System.Drawing.Point(3, 3);
            this.TcpPanel.Name = "TcpPanel";
            this.TcpPanel.Size = new System.Drawing.Size(150, 276);
            this.TcpPanel.TabIndex = 14;
            this.TcpPanel.Visible = false;

            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 16);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "서버 활성화";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(59, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(87, 20);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(50, 59);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(96, 20);
            this.comboBox4.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "포트 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "IP :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 8);
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

            this.button1.Location = new System.Drawing.Point(9, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;

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
            this.UdpPanel.Location = new System.Drawing.Point(3, 3);
            this.UdpPanel.Name = "UdpPanel";
            this.UdpPanel.Size = new System.Drawing.Size(150, 276);
            this.UdpPanel.TabIndex = 15;
            this.UdpPanel.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 16);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "서버 활성화";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(59, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(87, 20);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(50, 59);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(96, 20);
            this.comboBox4.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "포트 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "IP :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 8);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_StopLog);
            this.panel2.Controls.Add(this.Btn_UseLog);
            this.panel2.Controls.Add(this.Btn_Clear);
            this.panel2.Controls.Add(this.Chk_AS);
            this.panel2.Controls.Add(this.Chk_AE);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.Chk_Hexa);
            this.panel2.Location = new System.Drawing.Point(585, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 309);
            this.panel2.TabIndex = 19;
            // 
            // Btn_StopLog
            // 
            this.Btn_StopLog.Location = new System.Drawing.Point(17, 91);
            this.Btn_StopLog.Name = "Btn_StopLog";
            this.Btn_StopLog.Size = new System.Drawing.Size(103, 29);
            this.Btn_StopLog.TabIndex = 26;
            this.Btn_StopLog.Text = "StopUsingFact";
            this.Btn_StopLog.UseVisualStyleBackColor = true;
            // 
            // Btn_UseLog
            // 
            this.Btn_UseLog.Location = new System.Drawing.Point(57, 47);
            this.Btn_UseLog.Name = "Btn_UseLog";
            this.Btn_UseLog.Size = new System.Drawing.Size(63, 23);
            this.Btn_UseLog.TabIndex = 25;
            this.Btn_UseLog.Text = "UseLog";
            this.Btn_UseLog.UseVisualStyleBackColor = true;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(58, 21);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(63, 23);
            this.Btn_Clear.TabIndex = 24;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Chk_AS
            // 
            this.Chk_AS.AutoSize = true;
            this.Chk_AS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_AS.Location = new System.Drawing.Point(6, 69);
            this.Chk_AS.Name = "Chk_AS";
            this.Chk_AS.Size = new System.Drawing.Size(46, 16);
            this.Chk_AS.TabIndex = 23;
            this.Chk_AS.Text = "A/S";
            this.Chk_AS.UseVisualStyleBackColor = true;
            this.Chk_AS.CheckStateChanged += new System.EventHandler(this.Chk_AS_CheckedChanged);
            // 
            // Chk_AE
            // 
            this.Chk_AE.AutoSize = true;
            this.Chk_AE.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_AE.Location = new System.Drawing.Point(6, 47);
            this.Chk_AE.Name = "Chk_AE";
            this.Chk_AE.Size = new System.Drawing.Size(46, 16);
            this.Chk_AE.TabIndex = 22;
            this.Chk_AE.Text = "A/E";
            this.Chk_AE.UseVisualStyleBackColor = true;
            this.Chk_AE.CheckStateChanged += new System.EventHandler(this.Chk_AE_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "수신옵션";
            // 
            // Chk_Hexa
            // 
            this.Chk_Hexa.AutoSize = true;
            this.Chk_Hexa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_Hexa.Location = new System.Drawing.Point(5, 25);
            this.Chk_Hexa.Name = "Chk_Hexa";
            this.Chk_Hexa.Size = new System.Drawing.Size(47, 16);
            this.Chk_Hexa.TabIndex = 8;
            this.Chk_Hexa.Text = "HeX";
            this.Chk_Hexa.UseVisualStyleBackColor = true;
            this.Chk_Hexa.CheckStateChanged += new System.EventHandler(this.Chk_Hexa_CheckedChanged);
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(this.metroLabel7);
            this.LogPanel.Controls.Add(this.ReceiveWindowBox);
            this.LogPanel.HorizontalScrollbarBarColor = true;
            this.LogPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LogPanel.HorizontalScrollbarSize = 10;
            this.LogPanel.Location = new System.Drawing.Point(170, 287);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(409, 309);
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
            this.metroLabel7.Text = "수신";
            // 
            // ReceiveWindowBox
            // 
            this.ReceiveWindowBox.AcceptsTab = true;
            this.ReceiveWindowBox.AutoWordSelection = true;
            this.ReceiveWindowBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ReceiveWindowBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReceiveWindowBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ReceiveWindowBox.Location = new System.Drawing.Point(5, 24);
            this.ReceiveWindowBox.Name = "ReceiveWindowBox";
            this.ReceiveWindowBox.ReadOnly = true;
            this.ReceiveWindowBox.Size = new System.Drawing.Size(400, 279);
            this.ReceiveWindowBox.TabIndex = 3;
            this.ReceiveWindowBox.TabStop = false;
            this.ReceiveWindowBox.Text = "";
            // 
            // UDP_Tile
            // 
            this.UDP_Tile.BackColor = System.Drawing.Color.White;
            this.UDP_Tile.ForeColor = System.Drawing.SystemColors.Control;
            this.UDP_Tile.Location = new System.Drawing.Point(5, 70);
            this.UDP_Tile.Name = "UDP_Tile";
            this.UDP_Tile.Size = new System.Drawing.Size(159, 24);
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
            this.TCP_Tile.Location = new System.Drawing.Point(5, 38);
            this.TCP_Tile.Name = "TCP_Tile";
            this.TCP_Tile.Size = new System.Drawing.Size(159, 26);
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.TCP_Tile.TabIndex = 8;
            this.TCP_Tile.Text = "TCP";
            this.TCP_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCP_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCP_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TCP_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TCP_Tile.Click += new System.EventHandler(this.TCP_Tile_Click);
            // 
            // UART_Tile
            // 
            this.UART_Tile.Location = new System.Drawing.Point(5, 6);
            this.UART_Tile.Name = "UART_Tile";
            this.UART_Tile.Size = new System.Drawing.Size(159, 26);
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.TabIndex = 5;
            this.UART_Tile.Text = "UART";
            this.UART_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UART_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UART_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UART_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.UART_Tile.Click += new System.EventHandler(this.UART_Tile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.checkBox3);

            this.panel3.Controls.Add(this.Btn_ASCII4);
            this.panel3.Controls.Add(this.Btn_AEAS4);
            this.panel3.Controls.Add(this.Btn_ASCII3);
            this.panel3.Controls.Add(this.Btn_AEAS3);
            this.panel3.Controls.Add(this.Btn_ASCII2);
            this.panel3.Controls.Add(this.Btn_AEAS2);
            this.panel3.Controls.Add(this.Btn_ASCII1);
            this.panel3.Controls.Add(this.Btn_AEAS1);
            this.panel3.Controls.Add(this.Btn_Send3);
            this.panel3.Controls.Add(this.SendBox3);
            this.panel3.Controls.Add(this.Btn_Send4);
            this.panel3.Controls.Add(this.Btn_Send2);
            this.panel3.Controls.Add(this.SendBox4);
            this.panel3.Controls.Add(this.Btn_Send1);
            this.panel3.Controls.Add(this.SendBox2);

            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.SendBox1);
            this.panel3.Location = new System.Drawing.Point(170, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 267);
            this.panel3.TabIndex = 21;
            // 

            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 40;
            this.label16.Text = "반복";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(158, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 39;

            this.label15.Text = "초";
            // 
            // textBox3
            // 

            this.textBox3.Location = new System.Drawing.Point(192, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 21);
            this.textBox3.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 21);
            this.textBox2.TabIndex = 37;

            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;

            this.checkBox3.Location = new System.Drawing.Point(21, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 16);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "매크로";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // Btn_ASCII4
            // 
            this.Btn_ASCII4.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_ASCII4.Location = new System.Drawing.Point(496, 206);
            this.Btn_ASCII4.Name = "Btn_ASCII4";
            this.Btn_ASCII4.Size = new System.Drawing.Size(39, 47);
            this.Btn_ASCII4.TabIndex = 35;
            this.Btn_ASCII4.Text = "ASCII";
            this.Btn_ASCII4.UseVisualStyleBackColor = true;
            this.Btn_ASCII4.Click += new System.EventHandler(this.Btn_ASCII4_Click);
            // 
            // Btn_AEAS4
            // 
            this.Btn_AEAS4.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_AEAS4.Location = new System.Drawing.Point(459, 206);
            this.Btn_AEAS4.Name = "Btn_AEAS4";
            this.Btn_AEAS4.Size = new System.Drawing.Size(31, 47);
            this.Btn_AEAS4.TabIndex = 34;
            this.Btn_AEAS4.Text = "No";
            this.Btn_AEAS4.UseVisualStyleBackColor = true;
            this.Btn_AEAS4.Click += new System.EventHandler(this.Btn_AEAS4_Click);
            // 
            // Btn_ASCII3
            // 
            this.Btn_ASCII3.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_ASCII3.Location = new System.Drawing.Point(496, 177);
            this.Btn_ASCII3.Name = "Btn_ASCII3";
            this.Btn_ASCII3.Size = new System.Drawing.Size(39, 25);
            this.Btn_ASCII3.TabIndex = 33;
            this.Btn_ASCII3.Text = "ASCII";
            this.Btn_ASCII3.UseVisualStyleBackColor = true;
            this.Btn_ASCII3.Click += new System.EventHandler(this.Btn_ASCII3_Click);
            // 
            // Btn_AEAS3
            // 
            this.Btn_AEAS3.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_AEAS3.Location = new System.Drawing.Point(459, 177);
            this.Btn_AEAS3.Name = "Btn_AEAS3";
            this.Btn_AEAS3.Size = new System.Drawing.Size(31, 25);
            this.Btn_AEAS3.TabIndex = 32;
            this.Btn_AEAS3.Text = "No";
            this.Btn_AEAS3.UseVisualStyleBackColor = true;
            this.Btn_AEAS3.Click += new System.EventHandler(this.Btn_AEAS3_Click);
            // 
            // Btn_ASCII2
            // 
            this.Btn_ASCII2.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_ASCII2.Location = new System.Drawing.Point(496, 147);
            this.Btn_ASCII2.Name = "Btn_ASCII2";
            this.Btn_ASCII2.Size = new System.Drawing.Size(39, 25);
            this.Btn_ASCII2.TabIndex = 31;
            this.Btn_ASCII2.Text = "ASCII";
            this.Btn_ASCII2.UseVisualStyleBackColor = true;
            this.Btn_ASCII2.Click += new System.EventHandler(this.Btn_ASCII2_Click);
            // 
            // Btn_AEAS2
            // 
            this.Btn_AEAS2.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_AEAS2.Location = new System.Drawing.Point(459, 147);
            this.Btn_AEAS2.Name = "Btn_AEAS2";
            this.Btn_AEAS2.Size = new System.Drawing.Size(31, 25);
            this.Btn_AEAS2.TabIndex = 30;
            this.Btn_AEAS2.Text = "No";
            this.Btn_AEAS2.UseVisualStyleBackColor = true;
            this.Btn_AEAS2.Click += new System.EventHandler(this.Btn_AEAS2_Click);
            // 
            // Btn_ASCII1
            // 
            this.Btn_ASCII1.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_ASCII1.Location = new System.Drawing.Point(496, 117);
            this.Btn_ASCII1.Name = "Btn_ASCII1";
            this.Btn_ASCII1.Size = new System.Drawing.Size(39, 25);
            this.Btn_ASCII1.TabIndex = 29;
            this.Btn_ASCII1.Text = "ASCII";
            this.Btn_ASCII1.UseVisualStyleBackColor = true;
            this.Btn_ASCII1.Click += new System.EventHandler(this.Btn_ASCII1_Click);
            // 
            // Btn_AEAS1
            // 
            this.Btn_AEAS1.Font = new System.Drawing.Font("굴림", 7F);
            this.Btn_AEAS1.Location = new System.Drawing.Point(459, 117);
            this.Btn_AEAS1.Name = "Btn_AEAS1";
            this.Btn_AEAS1.Size = new System.Drawing.Size(31, 25);
            this.Btn_AEAS1.TabIndex = 28;
            this.Btn_AEAS1.Text = "No";
            this.Btn_AEAS1.UseVisualStyleBackColor = true;
            this.Btn_AEAS1.Click += new System.EventHandler(this.Btn_AEAS1_Click);
            // 
            // Btn_Send3
            // 
            this.Btn_Send3.Location = new System.Drawing.Point(399, 176);
            this.Btn_Send3.Name = "Btn_Send3";
            this.Btn_Send3.Size = new System.Drawing.Size(53, 25);
            this.Btn_Send3.TabIndex = 27;
            this.Btn_Send3.Text = "송신";
            this.Btn_Send3.UseVisualStyleBackColor = true;
            this.Btn_Send3.Click += new System.EventHandler(this.Btn_Send3_Click);
            // 
            // SendBox3
            // 
            this.SendBox3.AcceptsTab = true;
            this.SendBox3.AutoWordSelection = true;
            this.SendBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SendBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SendBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SendBox3.Location = new System.Drawing.Point(6, 177);
            this.SendBox3.Name = "SendBox3";
            this.SendBox3.Size = new System.Drawing.Size(395, 24);
            this.SendBox3.TabIndex = 26;
            this.SendBox3.TabStop = false;
            this.SendBox3.Text = "";
            // 
            // Btn_Send4
            // 
            this.Btn_Send4.Location = new System.Drawing.Point(399, 205);
            this.Btn_Send4.Name = "Btn_Send4";
            this.Btn_Send4.Size = new System.Drawing.Size(53, 48);
            this.Btn_Send4.TabIndex = 25;
            this.Btn_Send4.Text = "송신";
            this.Btn_Send4.UseVisualStyleBackColor = true;
            this.Btn_Send4.Click += new System.EventHandler(this.Btn_Send4_Click);
            // 
            // Btn_Send2
            // 
            this.Btn_Send2.Location = new System.Drawing.Point(399, 146);
            this.Btn_Send2.Name = "Btn_Send2";
            this.Btn_Send2.Size = new System.Drawing.Size(53, 25);
            this.Btn_Send2.TabIndex = 24;
            this.Btn_Send2.Text = "송신";
            this.Btn_Send2.UseVisualStyleBackColor = true;
            this.Btn_Send2.Click += new System.EventHandler(this.Btn_Send2_Click);
            // 
            // SendBox4
            // 
            this.SendBox4.AcceptsTab = true;
            this.SendBox4.AutoWordSelection = true;
            this.SendBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SendBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SendBox4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SendBox4.Location = new System.Drawing.Point(6, 206);
            this.SendBox4.Name = "SendBox4";
            this.SendBox4.Size = new System.Drawing.Size(395, 47);
            this.SendBox4.TabIndex = 23;
            this.SendBox4.TabStop = false;
            this.SendBox4.Text = "";
            // 
            // Btn_Send1
            // 
            this.Btn_Send1.Location = new System.Drawing.Point(399, 117);
            this.Btn_Send1.Name = "Btn_Send1";
            this.Btn_Send1.Size = new System.Drawing.Size(53, 25);
            this.Btn_Send1.TabIndex = 1;
            this.Btn_Send1.Text = "송신";
            this.Btn_Send1.UseVisualStyleBackColor = true;
            this.Btn_Send1.Click += new System.EventHandler(this.Btn_Send1_Click);
            // 
            // SendBox2
            // 
            this.SendBox2.AcceptsTab = true;
            this.SendBox2.AutoWordSelection = true;
            this.SendBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SendBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SendBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SendBox2.Location = new System.Drawing.Point(6, 147);
            this.SendBox2.Name = "SendBox2";
            this.SendBox2.Size = new System.Drawing.Size(395, 24);
            this.SendBox2.TabIndex = 22;
            this.SendBox2.TabStop = false;
            this.SendBox2.Text = "";

            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "송신";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // SendBox1
            // 
            this.SendBox1.AcceptsTab = true;
            this.SendBox1.AutoWordSelection = true;
            this.SendBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SendBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SendBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SendBox1.Location = new System.Drawing.Point(6, 118);
            this.SendBox1.Name = "SendBox1";
            this.SendBox1.Size = new System.Drawing.Size(395, 24);
            this.SendBox1.TabIndex = 2;
            this.SendBox1.TabStop = false;
            this.SendBox1.Text = "";
            // 
            // Zigbee_Tile
            // 
            this.Zigbee_Tile.BackColor = System.Drawing.Color.White;
            this.Zigbee_Tile.ForeColor = System.Drawing.SystemColors.Control;
            this.Zigbee_Tile.Location = new System.Drawing.Point(422, 26);
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
            this.WIFI_Tile.Location = new System.Drawing.Point(301, 26);
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
            // RF_Tile
            // 
            this.RF_Tile.Location = new System.Drawing.Point(180, 26);
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
            this.menuStrip1.Size = new System.Drawing.Size(737, 19);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(273, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "반복";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 697);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.Zigbee_Tile);
            this.Controls.Add(this.RF_Tile);
            this.Controls.Add(this.WIFI_Tile);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MultiTerminal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);

            this.SerialPanel.ResumeLayout(false);
            this.SerialPanel.PerformLayout();
            this.TcpPanel.ResumeLayout(false);
            this.TcpPanel.PerformLayout();

            this.UdpPanel.ResumeLayout(false);
            this.UdpPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.RichTextBox SendBox1;
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
        private System.Windows.Forms.Button Btn_Send1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;



        private System.Windows.Forms.RichTextBox SendBox4;
        private System.Windows.Forms.RichTextBox SendBox2;
        private System.Windows.Forms.Button F5;
        private System.Windows.Forms.Button Btn_Send2;
        private System.Windows.Forms.Button Btn_Send3;
        private System.Windows.Forms.RichTextBox SendBox3;
        private System.Windows.Forms.Button Btn_Send4;
        private System.Windows.Forms.CheckBox Chk_AS;
        private System.Windows.Forms.CheckBox Chk_AE;
        private System.Windows.Forms.Button Btn_AEAS3;
        private System.Windows.Forms.Button Btn_AEAS2;
        private System.Windows.Forms.Button Btn_AEAS1;
        private System.Windows.Forms.Button Btn_AEAS4;
        private System.Windows.Forms.Button Btn_StopLog;
        private System.Windows.Forms.Button Btn_UseLog;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_ASCII4;
        private System.Windows.Forms.Button Btn_ASCII3;
        private System.Windows.Forms.Button Btn_ASCII2;
        private System.Windows.Forms.Button Btn_ASCII1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox3;

    }
}

