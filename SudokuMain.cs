using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace SudokuQuickSolver1_5
{
	/// <summary>
	/// Summary description for SodukoMain.
	/// </summary>
	public class SudokuMain : System.Windows.Forms.Form
	{
		private Thread runner;
		private SudokuGame mSudokuGame;
        private ControlInvoker controlInvoker;


		private System.Windows.Forms.Button cmdGo;
		private System.Windows.Forms.TextBox textBox00;
		private System.Windows.Forms.TextBox textBox01;
		private System.Windows.Forms.TextBox textBox02;
		private System.Windows.Forms.TextBox textBox03;
		private System.Windows.Forms.TextBox textBox04;
		private System.Windows.Forms.TextBox textBox05;
		private System.Windows.Forms.TextBox textBox08;
		private System.Windows.Forms.TextBox textBox07;
		private System.Windows.Forms.TextBox textBox06;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox58;
		private System.Windows.Forms.TextBox textBox57;
		private System.Windows.Forms.TextBox textBox56;
		private System.Windows.Forms.TextBox textBox55;
		private System.Windows.Forms.TextBox textBox54;
		private System.Windows.Forms.TextBox textBox53;
		private System.Windows.Forms.TextBox textBox52;
		private System.Windows.Forms.TextBox textBox51;
		private System.Windows.Forms.TextBox textBox50;
		private System.Windows.Forms.TextBox textBox48;
		private System.Windows.Forms.TextBox textBox47;
		private System.Windows.Forms.TextBox textBox46;
		private System.Windows.Forms.TextBox textBox45;
		private System.Windows.Forms.TextBox textBox44;
		private System.Windows.Forms.TextBox textBox43;
		private System.Windows.Forms.TextBox textBox42;
		private System.Windows.Forms.TextBox textBox41;
		private System.Windows.Forms.TextBox textBox40;
		private System.Windows.Forms.TextBox textBox38;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.TextBox textBox88;
		private System.Windows.Forms.TextBox textBox87;
		private System.Windows.Forms.TextBox textBox86;
		private System.Windows.Forms.TextBox textBox85;
		private System.Windows.Forms.TextBox textBox84;
		private System.Windows.Forms.TextBox textBox83;
		private System.Windows.Forms.TextBox textBox82;
		private System.Windows.Forms.TextBox textBox81;
		private System.Windows.Forms.TextBox textBox80;
		private System.Windows.Forms.TextBox textBox78;
		private System.Windows.Forms.TextBox textBox77;
		private System.Windows.Forms.TextBox textBox76;
		private System.Windows.Forms.TextBox textBox75;
		private System.Windows.Forms.TextBox textBox74;
		private System.Windows.Forms.TextBox textBox73;
		private System.Windows.Forms.TextBox textBox72;
		private System.Windows.Forms.TextBox textBox71;
		private System.Windows.Forms.TextBox textBox70;
		private System.Windows.Forms.TextBox textBox68;
		private System.Windows.Forms.TextBox textBox67;
		private System.Windows.Forms.TextBox textBox66;
		private System.Windows.Forms.TextBox textBox65;
		private System.Windows.Forms.TextBox textBox64;
		private System.Windows.Forms.TextBox textBox63;
		private System.Windows.Forms.TextBox textBox62;
		private System.Windows.Forms.TextBox textBox61;
		private System.Windows.Forms.TextBox textBox60;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private CheckBox chkDiagonals;
        private IContainer components;

		public SudokuMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			runner = null;
            controlInvoker = new ControlInvoker(this);
            mSudokuGame = new SudokuGame();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.cmdGo = new System.Windows.Forms.Button();
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.textBox05 = new System.Windows.Forms.TextBox();
            this.textBox08 = new System.Windows.Forms.TextBox();
            this.textBox07 = new System.Windows.Forms.TextBox();
            this.textBox06 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chkDiagonals = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(232, 280);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(88, 23);
            this.cmdGo.TabIndex = 0;
            this.cmdGo.Text = "Go!";
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // textBox00
            // 
            this.textBox00.Location = new System.Drawing.Point(24, 40);
            this.textBox00.MaxLength = 1;
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(32, 20);
            this.textBox00.TabIndex = 2;
            this.textBox00.Tag = "0";
            this.textBox00.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(64, 40);
            this.textBox01.MaxLength = 1;
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(32, 20);
            this.textBox01.TabIndex = 3;
            this.textBox01.Tag = "1";
            this.textBox01.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox02
            // 
            this.textBox02.Location = new System.Drawing.Point(104, 40);
            this.textBox02.MaxLength = 1;
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(32, 20);
            this.textBox02.TabIndex = 4;
            this.textBox02.Tag = "2";
            this.textBox02.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox03
            // 
            this.textBox03.Location = new System.Drawing.Point(160, 40);
            this.textBox03.MaxLength = 1;
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(32, 20);
            this.textBox03.TabIndex = 5;
            this.textBox03.Tag = "3";
            this.textBox03.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox04
            // 
            this.textBox04.Location = new System.Drawing.Point(200, 40);
            this.textBox04.MaxLength = 1;
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(32, 20);
            this.textBox04.TabIndex = 6;
            this.textBox04.Tag = "4";
            this.textBox04.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox05
            // 
            this.textBox05.Location = new System.Drawing.Point(240, 40);
            this.textBox05.MaxLength = 1;
            this.textBox05.Name = "textBox05";
            this.textBox05.Size = new System.Drawing.Size(32, 20);
            this.textBox05.TabIndex = 7;
            this.textBox05.Tag = "5";
            this.textBox05.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox08
            // 
            this.textBox08.Location = new System.Drawing.Point(376, 40);
            this.textBox08.MaxLength = 1;
            this.textBox08.Name = "textBox08";
            this.textBox08.Size = new System.Drawing.Size(32, 20);
            this.textBox08.TabIndex = 10;
            this.textBox08.Tag = "8";
            this.textBox08.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox07
            // 
            this.textBox07.Location = new System.Drawing.Point(336, 40);
            this.textBox07.MaxLength = 1;
            this.textBox07.Name = "textBox07";
            this.textBox07.Size = new System.Drawing.Size(32, 20);
            this.textBox07.TabIndex = 9;
            this.textBox07.Tag = "7";
            this.textBox07.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox06
            // 
            this.textBox06.Location = new System.Drawing.Point(296, 40);
            this.textBox06.MaxLength = 1;
            this.textBox06.Name = "textBox06";
            this.textBox06.Size = new System.Drawing.Size(32, 20);
            this.textBox06.TabIndex = 8;
            this.textBox06.Tag = "6";
            this.textBox06.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(376, 64);
            this.textBox18.MaxLength = 1;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(32, 20);
            this.textBox18.TabIndex = 19;
            this.textBox18.Tag = "17";
            this.textBox18.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(336, 64);
            this.textBox17.MaxLength = 1;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(32, 20);
            this.textBox17.TabIndex = 18;
            this.textBox17.Tag = "16";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(296, 64);
            this.textBox16.MaxLength = 1;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(32, 20);
            this.textBox16.TabIndex = 17;
            this.textBox16.Tag = "15";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(240, 64);
            this.textBox15.MaxLength = 1;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(32, 20);
            this.textBox15.TabIndex = 16;
            this.textBox15.Tag = "14";
            this.textBox15.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(200, 64);
            this.textBox14.MaxLength = 1;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(32, 20);
            this.textBox14.TabIndex = 15;
            this.textBox14.Tag = "13";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(160, 64);
            this.textBox13.MaxLength = 1;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(32, 20);
            this.textBox13.TabIndex = 14;
            this.textBox13.Tag = "12";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(104, 64);
            this.textBox12.MaxLength = 1;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(32, 20);
            this.textBox12.TabIndex = 13;
            this.textBox12.Tag = "11";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(64, 64);
            this.textBox11.MaxLength = 1;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(32, 20);
            this.textBox11.TabIndex = 12;
            this.textBox11.Tag = "10";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(24, 64);
            this.textBox10.MaxLength = 1;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(32, 20);
            this.textBox10.TabIndex = 11;
            this.textBox10.Tag = "9";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(376, 88);
            this.textBox28.MaxLength = 1;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(32, 20);
            this.textBox28.TabIndex = 28;
            this.textBox28.Tag = "26";
            this.textBox28.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(336, 88);
            this.textBox27.MaxLength = 1;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(32, 20);
            this.textBox27.TabIndex = 27;
            this.textBox27.Tag = "25";
            this.textBox27.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(296, 88);
            this.textBox26.MaxLength = 1;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(32, 20);
            this.textBox26.TabIndex = 26;
            this.textBox26.Tag = "24";
            this.textBox26.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(240, 88);
            this.textBox25.MaxLength = 1;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(32, 20);
            this.textBox25.TabIndex = 25;
            this.textBox25.Tag = "23";
            this.textBox25.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(200, 88);
            this.textBox24.MaxLength = 1;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(32, 20);
            this.textBox24.TabIndex = 24;
            this.textBox24.Tag = "22";
            this.textBox24.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(160, 88);
            this.textBox23.MaxLength = 1;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(32, 20);
            this.textBox23.TabIndex = 23;
            this.textBox23.Tag = "21";
            this.textBox23.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(104, 88);
            this.textBox22.MaxLength = 1;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(32, 20);
            this.textBox22.TabIndex = 22;
            this.textBox22.Tag = "20";
            this.textBox22.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(64, 88);
            this.textBox21.MaxLength = 1;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(32, 20);
            this.textBox21.TabIndex = 21;
            this.textBox21.Tag = "19";
            this.textBox21.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(24, 88);
            this.textBox20.MaxLength = 1;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(32, 20);
            this.textBox20.TabIndex = 20;
            this.textBox20.Tag = "18";
            this.textBox20.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(376, 168);
            this.textBox58.MaxLength = 1;
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(32, 20);
            this.textBox58.TabIndex = 55;
            this.textBox58.Tag = "53";
            this.textBox58.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(336, 168);
            this.textBox57.MaxLength = 1;
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(32, 20);
            this.textBox57.TabIndex = 54;
            this.textBox57.Tag = "52";
            this.textBox57.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(296, 168);
            this.textBox56.MaxLength = 1;
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(32, 20);
            this.textBox56.TabIndex = 53;
            this.textBox56.Tag = "51";
            this.textBox56.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(240, 168);
            this.textBox55.MaxLength = 1;
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(32, 20);
            this.textBox55.TabIndex = 52;
            this.textBox55.Tag = "50";
            this.textBox55.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(200, 168);
            this.textBox54.MaxLength = 1;
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(32, 20);
            this.textBox54.TabIndex = 51;
            this.textBox54.Tag = "49";
            this.textBox54.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(160, 168);
            this.textBox53.MaxLength = 1;
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(32, 20);
            this.textBox53.TabIndex = 50;
            this.textBox53.Tag = "48";
            this.textBox53.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(104, 168);
            this.textBox52.MaxLength = 1;
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(32, 20);
            this.textBox52.TabIndex = 49;
            this.textBox52.Tag = "47";
            this.textBox52.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(64, 168);
            this.textBox51.MaxLength = 1;
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(32, 20);
            this.textBox51.TabIndex = 48;
            this.textBox51.Tag = "46";
            this.textBox51.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(24, 168);
            this.textBox50.MaxLength = 1;
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(32, 20);
            this.textBox50.TabIndex = 47;
            this.textBox50.Tag = "45";
            this.textBox50.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(376, 144);
            this.textBox48.MaxLength = 1;
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(32, 20);
            this.textBox48.TabIndex = 46;
            this.textBox48.Tag = "44";
            this.textBox48.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(336, 144);
            this.textBox47.MaxLength = 1;
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(32, 20);
            this.textBox47.TabIndex = 45;
            this.textBox47.Tag = "43";
            this.textBox47.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(296, 144);
            this.textBox46.MaxLength = 1;
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(32, 20);
            this.textBox46.TabIndex = 44;
            this.textBox46.Tag = "42";
            this.textBox46.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(240, 144);
            this.textBox45.MaxLength = 1;
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(32, 20);
            this.textBox45.TabIndex = 43;
            this.textBox45.Tag = "41";
            this.textBox45.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(200, 144);
            this.textBox44.MaxLength = 1;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(32, 20);
            this.textBox44.TabIndex = 42;
            this.textBox44.Tag = "40";
            this.textBox44.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(160, 144);
            this.textBox43.MaxLength = 1;
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(32, 20);
            this.textBox43.TabIndex = 41;
            this.textBox43.Tag = "39";
            this.textBox43.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(104, 144);
            this.textBox42.MaxLength = 1;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(32, 20);
            this.textBox42.TabIndex = 40;
            this.textBox42.Tag = "38";
            this.textBox42.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(64, 144);
            this.textBox41.MaxLength = 1;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(32, 20);
            this.textBox41.TabIndex = 39;
            this.textBox41.Tag = "37";
            this.textBox41.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(24, 144);
            this.textBox40.MaxLength = 1;
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(32, 20);
            this.textBox40.TabIndex = 38;
            this.textBox40.Tag = "36";
            this.textBox40.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(376, 120);
            this.textBox38.MaxLength = 1;
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(32, 20);
            this.textBox38.TabIndex = 37;
            this.textBox38.Tag = "35";
            this.textBox38.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(336, 120);
            this.textBox37.MaxLength = 1;
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(32, 20);
            this.textBox37.TabIndex = 36;
            this.textBox37.Tag = "34";
            this.textBox37.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(296, 120);
            this.textBox36.MaxLength = 1;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(32, 20);
            this.textBox36.TabIndex = 35;
            this.textBox36.Tag = "33";
            this.textBox36.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(240, 120);
            this.textBox35.MaxLength = 1;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(32, 20);
            this.textBox35.TabIndex = 34;
            this.textBox35.Tag = "32";
            this.textBox35.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(200, 120);
            this.textBox34.MaxLength = 1;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(32, 20);
            this.textBox34.TabIndex = 33;
            this.textBox34.Tag = "31";
            this.textBox34.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(160, 120);
            this.textBox33.MaxLength = 1;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(32, 20);
            this.textBox33.TabIndex = 32;
            this.textBox33.Tag = "30";
            this.textBox33.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(104, 120);
            this.textBox32.MaxLength = 1;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(32, 20);
            this.textBox32.TabIndex = 31;
            this.textBox32.Tag = "29";
            this.textBox32.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(64, 120);
            this.textBox31.MaxLength = 1;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(32, 20);
            this.textBox31.TabIndex = 30;
            this.textBox31.Tag = "28";
            this.textBox31.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(24, 120);
            this.textBox30.MaxLength = 1;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(32, 20);
            this.textBox30.TabIndex = 29;
            this.textBox30.Tag = "27";
            this.textBox30.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox88
            // 
            this.textBox88.Location = new System.Drawing.Point(376, 248);
            this.textBox88.MaxLength = 1;
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(32, 20);
            this.textBox88.TabIndex = 82;
            this.textBox88.Tag = "80";
            this.textBox88.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox87
            // 
            this.textBox87.Location = new System.Drawing.Point(336, 248);
            this.textBox87.MaxLength = 1;
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(32, 20);
            this.textBox87.TabIndex = 81;
            this.textBox87.Tag = "79";
            this.textBox87.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox86
            // 
            this.textBox86.Location = new System.Drawing.Point(296, 248);
            this.textBox86.MaxLength = 1;
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(32, 20);
            this.textBox86.TabIndex = 80;
            this.textBox86.Tag = "78";
            this.textBox86.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox85
            // 
            this.textBox85.Location = new System.Drawing.Point(240, 248);
            this.textBox85.MaxLength = 1;
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(32, 20);
            this.textBox85.TabIndex = 79;
            this.textBox85.Tag = "77";
            this.textBox85.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox84
            // 
            this.textBox84.Location = new System.Drawing.Point(200, 248);
            this.textBox84.MaxLength = 1;
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(32, 20);
            this.textBox84.TabIndex = 78;
            this.textBox84.Tag = "76";
            this.textBox84.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox83
            // 
            this.textBox83.Location = new System.Drawing.Point(160, 248);
            this.textBox83.MaxLength = 1;
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(32, 20);
            this.textBox83.TabIndex = 77;
            this.textBox83.Tag = "75";
            this.textBox83.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox82
            // 
            this.textBox82.Location = new System.Drawing.Point(104, 248);
            this.textBox82.MaxLength = 1;
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(32, 20);
            this.textBox82.TabIndex = 76;
            this.textBox82.Tag = "74";
            this.textBox82.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox81
            // 
            this.textBox81.Location = new System.Drawing.Point(64, 248);
            this.textBox81.MaxLength = 1;
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(32, 20);
            this.textBox81.TabIndex = 75;
            this.textBox81.Tag = "73";
            this.textBox81.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox80
            // 
            this.textBox80.Location = new System.Drawing.Point(24, 248);
            this.textBox80.MaxLength = 1;
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(32, 20);
            this.textBox80.TabIndex = 74;
            this.textBox80.Tag = "72";
            this.textBox80.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox78
            // 
            this.textBox78.Location = new System.Drawing.Point(376, 224);
            this.textBox78.MaxLength = 1;
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(32, 20);
            this.textBox78.TabIndex = 73;
            this.textBox78.Tag = "71";
            this.textBox78.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox77
            // 
            this.textBox77.Location = new System.Drawing.Point(336, 224);
            this.textBox77.MaxLength = 1;
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(32, 20);
            this.textBox77.TabIndex = 72;
            this.textBox77.Tag = "70";
            this.textBox77.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox76
            // 
            this.textBox76.Location = new System.Drawing.Point(296, 224);
            this.textBox76.MaxLength = 1;
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(32, 20);
            this.textBox76.TabIndex = 71;
            this.textBox76.Tag = "69";
            this.textBox76.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox75
            // 
            this.textBox75.Location = new System.Drawing.Point(240, 224);
            this.textBox75.MaxLength = 1;
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(32, 20);
            this.textBox75.TabIndex = 70;
            this.textBox75.Tag = "68";
            this.textBox75.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox74
            // 
            this.textBox74.Location = new System.Drawing.Point(200, 224);
            this.textBox74.MaxLength = 1;
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(32, 20);
            this.textBox74.TabIndex = 69;
            this.textBox74.Tag = "67";
            this.textBox74.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox73
            // 
            this.textBox73.Location = new System.Drawing.Point(160, 224);
            this.textBox73.MaxLength = 1;
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(32, 20);
            this.textBox73.TabIndex = 68;
            this.textBox73.Tag = "66";
            this.textBox73.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox72
            // 
            this.textBox72.Location = new System.Drawing.Point(104, 224);
            this.textBox72.MaxLength = 1;
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(32, 20);
            this.textBox72.TabIndex = 67;
            this.textBox72.Tag = "65";
            this.textBox72.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox71
            // 
            this.textBox71.Location = new System.Drawing.Point(64, 224);
            this.textBox71.MaxLength = 1;
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(32, 20);
            this.textBox71.TabIndex = 66;
            this.textBox71.Tag = "64";
            this.textBox71.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox70
            // 
            this.textBox70.Location = new System.Drawing.Point(24, 224);
            this.textBox70.MaxLength = 1;
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(32, 20);
            this.textBox70.TabIndex = 65;
            this.textBox70.Tag = "63";
            this.textBox70.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox68
            // 
            this.textBox68.Location = new System.Drawing.Point(376, 200);
            this.textBox68.MaxLength = 1;
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(32, 20);
            this.textBox68.TabIndex = 64;
            this.textBox68.Tag = "62";
            this.textBox68.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox67
            // 
            this.textBox67.Location = new System.Drawing.Point(336, 200);
            this.textBox67.MaxLength = 1;
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(32, 20);
            this.textBox67.TabIndex = 63;
            this.textBox67.Tag = "61";
            this.textBox67.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox66
            // 
            this.textBox66.Location = new System.Drawing.Point(296, 200);
            this.textBox66.MaxLength = 1;
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(32, 20);
            this.textBox66.TabIndex = 62;
            this.textBox66.Tag = "60";
            this.textBox66.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox65
            // 
            this.textBox65.Location = new System.Drawing.Point(240, 200);
            this.textBox65.MaxLength = 1;
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(32, 20);
            this.textBox65.TabIndex = 61;
            this.textBox65.Tag = "59";
            this.textBox65.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox64
            // 
            this.textBox64.Location = new System.Drawing.Point(200, 200);
            this.textBox64.MaxLength = 1;
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(32, 20);
            this.textBox64.TabIndex = 60;
            this.textBox64.Tag = "58";
            this.textBox64.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox63
            // 
            this.textBox63.Location = new System.Drawing.Point(160, 200);
            this.textBox63.MaxLength = 1;
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(32, 20);
            this.textBox63.TabIndex = 59;
            this.textBox63.Tag = "57";
            this.textBox63.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox62
            // 
            this.textBox62.Location = new System.Drawing.Point(104, 200);
            this.textBox62.MaxLength = 1;
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(32, 20);
            this.textBox62.TabIndex = 58;
            this.textBox62.Tag = "56";
            this.textBox62.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(64, 200);
            this.textBox61.MaxLength = 1;
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(32, 20);
            this.textBox61.TabIndex = 57;
            this.textBox61.Tag = "55";
            this.textBox61.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(24, 200);
            this.textBox60.MaxLength = 1;
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(32, 20);
            this.textBox60.TabIndex = 56;
            this.textBox60.Tag = "54";
            this.textBox60.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Clear";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuItem2.Text = "&Open...";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuItem3.Text = "&Save...";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItem4.Text = "E&xit";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(257, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 24);
            this.checkBox1.TabIndex = 84;
            this.checkBox1.Text = "Use Number Guess";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 85;
            this.textBox1.Text = "2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(249, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Max search depth:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 87;
            this.button2.Text = "Abort";
            this.button2.Click += new System.EventHandler(this.Abort);
            // 
            // chkDiagonals
            // 
            this.chkDiagonals.AutoSize = true;
            this.chkDiagonals.Location = new System.Drawing.Point(24, 317);
            this.chkDiagonals.Name = "chkDiagonals";
            this.chkDiagonals.Size = new System.Drawing.Size(154, 17);
            this.chkDiagonals.TabIndex = 88;
            this.chkDiagonals.Text = "Check diagonals constraint";
            this.chkDiagonals.UseVisualStyleBackColor = true;
            // 
            // SudokuMain
            // 
            this.AcceptButton = this.cmdGo;
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(434, 403);
            this.Controls.Add(this.chkDiagonals);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox88);
            this.Controls.Add(this.textBox87);
            this.Controls.Add(this.textBox86);
            this.Controls.Add(this.textBox85);
            this.Controls.Add(this.textBox84);
            this.Controls.Add(this.textBox83);
            this.Controls.Add(this.textBox82);
            this.Controls.Add(this.textBox81);
            this.Controls.Add(this.textBox80);
            this.Controls.Add(this.textBox78);
            this.Controls.Add(this.textBox77);
            this.Controls.Add(this.textBox76);
            this.Controls.Add(this.textBox75);
            this.Controls.Add(this.textBox74);
            this.Controls.Add(this.textBox73);
            this.Controls.Add(this.textBox72);
            this.Controls.Add(this.textBox71);
            this.Controls.Add(this.textBox70);
            this.Controls.Add(this.textBox68);
            this.Controls.Add(this.textBox67);
            this.Controls.Add(this.textBox66);
            this.Controls.Add(this.textBox65);
            this.Controls.Add(this.textBox64);
            this.Controls.Add(this.textBox63);
            this.Controls.Add(this.textBox62);
            this.Controls.Add(this.textBox61);
            this.Controls.Add(this.textBox60);
            this.Controls.Add(this.textBox58);
            this.Controls.Add(this.textBox57);
            this.Controls.Add(this.textBox56);
            this.Controls.Add(this.textBox55);
            this.Controls.Add(this.textBox54);
            this.Controls.Add(this.textBox53);
            this.Controls.Add(this.textBox52);
            this.Controls.Add(this.textBox51);
            this.Controls.Add(this.textBox50);
            this.Controls.Add(this.textBox48);
            this.Controls.Add(this.textBox47);
            this.Controls.Add(this.textBox46);
            this.Controls.Add(this.textBox45);
            this.Controls.Add(this.textBox44);
            this.Controls.Add(this.textBox43);
            this.Controls.Add(this.textBox42);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.textBox40);
            this.Controls.Add(this.textBox38);
            this.Controls.Add(this.textBox37);
            this.Controls.Add(this.textBox36);
            this.Controls.Add(this.textBox35);
            this.Controls.Add(this.textBox34);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox08);
            this.Controls.Add(this.textBox07);
            this.Controls.Add(this.textBox06);
            this.Controls.Add(this.textBox05);
            this.Controls.Add(this.textBox04);
            this.Controls.Add(this.textBox03);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.textBox00);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Menu = this.mainMenu1;
            this.Name = "SudokuMain";
            this.Text = "Quick Sudoku Solver";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SodukoMain_DragDrop);
            this.Closed += new System.EventHandler(this.SodukoMain_Closed);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SodukoMain_DragOver);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SodukoMain_DragEnter);
            this.Load += new System.EventHandler(this.SodukoMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void cmdGo_Click(object sender, System.EventArgs e)
		{
			runner = new Thread(new ThreadStart(this.WorkMethod));
			runner.Start();
		}

		private void WorkMethod()
		{
		
			Board board = new Board();
			InitBoard(board);
			mSudokuGame.DepthLimit = Int32.Parse(textBox1.Text);
            int didSolve = mSudokuGame.Solve(board, !checkBox1.Checked, chkDiagonals.Checked);
			ShowResult(
				didSolve,
				board,
                mSudokuGame.TotalTriedGuesses,
                mSudokuGame.MaxReachedDepth,
                mSudokuGame.TotalFailedGuesses
			);
		}



		void InitBoard(Board inBoard)
		{
			AddNumber(textBox00,inBoard);
			AddNumber(textBox01,inBoard);
			AddNumber(textBox02,inBoard);
			AddNumber(textBox03,inBoard);
			AddNumber(textBox04,inBoard);
			AddNumber(textBox05,inBoard);
			AddNumber(textBox06,inBoard);
			AddNumber(textBox07,inBoard);
			AddNumber(textBox08,inBoard);
			AddNumber(textBox10,inBoard);
			AddNumber(textBox11,inBoard);
			AddNumber(textBox12,inBoard);
			AddNumber(textBox13,inBoard);
			AddNumber(textBox14,inBoard);
			AddNumber(textBox15,inBoard);
			AddNumber(textBox16,inBoard);
			AddNumber(textBox17,inBoard);
			AddNumber(textBox18,inBoard);
			AddNumber(textBox20,inBoard);
			AddNumber(textBox21,inBoard);
			AddNumber(textBox22,inBoard);
			AddNumber(textBox23,inBoard);
			AddNumber(textBox24,inBoard);
			AddNumber(textBox25,inBoard);
			AddNumber(textBox26,inBoard);
			AddNumber(textBox27,inBoard);
			AddNumber(textBox28,inBoard);
			AddNumber(textBox30,inBoard);
			AddNumber(textBox31,inBoard);
			AddNumber(textBox32,inBoard);
			AddNumber(textBox33,inBoard);
			AddNumber(textBox34,inBoard);
			AddNumber(textBox35,inBoard);
			AddNumber(textBox36,inBoard);
			AddNumber(textBox37,inBoard);
			AddNumber(textBox38,inBoard);
			AddNumber(textBox40,inBoard);
			AddNumber(textBox41,inBoard);
			AddNumber(textBox42,inBoard);
			AddNumber(textBox43,inBoard);
			AddNumber(textBox44,inBoard);
			AddNumber(textBox45,inBoard);
			AddNumber(textBox46,inBoard);
			AddNumber(textBox47,inBoard);
			AddNumber(textBox48,inBoard);
			AddNumber(textBox50,inBoard);
			AddNumber(textBox51,inBoard);
			AddNumber(textBox52,inBoard);
			AddNumber(textBox53,inBoard);
			AddNumber(textBox54,inBoard);
			AddNumber(textBox55,inBoard);
			AddNumber(textBox56,inBoard);
			AddNumber(textBox57,inBoard);
			AddNumber(textBox58,inBoard);
			AddNumber(textBox60,inBoard);
			AddNumber(textBox61,inBoard);
			AddNumber(textBox62,inBoard);
			AddNumber(textBox63,inBoard);
			AddNumber(textBox64,inBoard);
			AddNumber(textBox65,inBoard);
			AddNumber(textBox66,inBoard);
			AddNumber(textBox67,inBoard);
			AddNumber(textBox68,inBoard);
			AddNumber(textBox70,inBoard);
			AddNumber(textBox71,inBoard);
			AddNumber(textBox72,inBoard);
			AddNumber(textBox73,inBoard);
			AddNumber(textBox74,inBoard);
			AddNumber(textBox75,inBoard);
			AddNumber(textBox76,inBoard);
			AddNumber(textBox77,inBoard);
			AddNumber(textBox78,inBoard);
			AddNumber(textBox80,inBoard);
			AddNumber(textBox81,inBoard);
			AddNumber(textBox82,inBoard);
			AddNumber(textBox83,inBoard);
			AddNumber(textBox84,inBoard);
			AddNumber(textBox85,inBoard);
			AddNumber(textBox86,inBoard);
			AddNumber(textBox87,inBoard);
			AddNumber(textBox88,inBoard);
		}

		void AddNumber(TextBox inTextBox,Board inBoard)
		{
			if(inTextBox.Text.Length == 1)
			{
				try
				{
					int tagNumber = Int32.Parse((string)(inTextBox.Tag));
					inBoard.Set(tagNumber / 9, tagNumber % 9,Int32.Parse(inTextBox.Text));
				}
				catch(Exception)
				{
				}
			}
		}

		private void ShowResult(int inDidSolve,Board inBoard,int inTotalGuesses,int inMaximumDepth,int inFailedGuesses)
		{
			switch(inDidSolve)
			{
				case -1:
					MessageBox.Show("Puzzle Contains Conflicts");
					break;
				case 0: 
					MessageBox.Show(
						string.Format(
						"Puzzle Solved.\ntotal guesses tried : {0}\nmaximum guesses depth reached : {1}\nfailed guesses : {2}",
						inTotalGuesses,inMaximumDepth,inFailedGuesses
						)
						);
                    controlInvoker.Invoke(new MethodCallInvoker(ShowBoard), inBoard);
 					break;
				case 1:
					MessageBox.Show("Not Succesfull in Solving Puzzle. try a larger depth maxim");
                    controlInvoker.Invoke(new MethodCallInvoker(ShowBoard), inBoard);
                    break;
				case -2:
					MessageBox.Show("Aborted");
					break;
			}
		}

        public void ShowBoard(object[] arguments)
        {
            ShowBoard((Board)arguments[0]);
        }

		private void ShowBoard(Board inBoard)
		{
			ShowNumber(textBox00,inBoard);
			ShowNumber(textBox01,inBoard);
			ShowNumber(textBox02,inBoard);
			ShowNumber(textBox03,inBoard);
			ShowNumber(textBox04,inBoard);
			ShowNumber(textBox05,inBoard);
			ShowNumber(textBox06,inBoard);
			ShowNumber(textBox07,inBoard);
			ShowNumber(textBox08,inBoard);
			ShowNumber(textBox10,inBoard);
			ShowNumber(textBox11,inBoard);
			ShowNumber(textBox12,inBoard);
			ShowNumber(textBox13,inBoard);
			ShowNumber(textBox14,inBoard);
			ShowNumber(textBox15,inBoard);
			ShowNumber(textBox16,inBoard);
			ShowNumber(textBox17,inBoard);
			ShowNumber(textBox18,inBoard);
			ShowNumber(textBox20,inBoard);
			ShowNumber(textBox21,inBoard);
			ShowNumber(textBox22,inBoard);
			ShowNumber(textBox23,inBoard);
			ShowNumber(textBox24,inBoard);
			ShowNumber(textBox25,inBoard);
			ShowNumber(textBox26,inBoard);
			ShowNumber(textBox27,inBoard);
			ShowNumber(textBox28,inBoard);
			ShowNumber(textBox30,inBoard);
			ShowNumber(textBox31,inBoard);
			ShowNumber(textBox32,inBoard);
			ShowNumber(textBox33,inBoard);
			ShowNumber(textBox34,inBoard);
			ShowNumber(textBox35,inBoard);
			ShowNumber(textBox36,inBoard);
			ShowNumber(textBox37,inBoard);
			ShowNumber(textBox38,inBoard);
			ShowNumber(textBox40,inBoard);
			ShowNumber(textBox41,inBoard);
			ShowNumber(textBox42,inBoard);
			ShowNumber(textBox43,inBoard);
			ShowNumber(textBox44,inBoard);
			ShowNumber(textBox45,inBoard);
			ShowNumber(textBox46,inBoard);
			ShowNumber(textBox47,inBoard);
			ShowNumber(textBox48,inBoard);
			ShowNumber(textBox50,inBoard);
			ShowNumber(textBox51,inBoard);
			ShowNumber(textBox52,inBoard);
			ShowNumber(textBox53,inBoard);
			ShowNumber(textBox54,inBoard);
			ShowNumber(textBox55,inBoard);
			ShowNumber(textBox56,inBoard);
			ShowNumber(textBox57,inBoard);
			ShowNumber(textBox58,inBoard);
			ShowNumber(textBox60,inBoard);
			ShowNumber(textBox61,inBoard);
			ShowNumber(textBox62,inBoard);
			ShowNumber(textBox63,inBoard);
			ShowNumber(textBox64,inBoard);
			ShowNumber(textBox65,inBoard);
			ShowNumber(textBox66,inBoard);
			ShowNumber(textBox67,inBoard);
			ShowNumber(textBox68,inBoard);
			ShowNumber(textBox70,inBoard);
			ShowNumber(textBox71,inBoard);
			ShowNumber(textBox72,inBoard);
			ShowNumber(textBox73,inBoard);
			ShowNumber(textBox74,inBoard);
			ShowNumber(textBox75,inBoard);
			ShowNumber(textBox76,inBoard);
			ShowNumber(textBox77,inBoard);
			ShowNumber(textBox78,inBoard);
			ShowNumber(textBox80,inBoard);
			ShowNumber(textBox81,inBoard);
			ShowNumber(textBox82,inBoard);
			ShowNumber(textBox83,inBoard);
			ShowNumber(textBox84,inBoard);
			ShowNumber(textBox85,inBoard);
			ShowNumber(textBox86,inBoard);
			ShowNumber(textBox87,inBoard);
			ShowNumber(textBox88,inBoard);
		}

		void ShowNumber(TextBox inTextBox,Board inBoard)
		{
			int tagNumber = Int32.Parse((string)(inTextBox.Tag));
			int result = inBoard.Get(tagNumber / 9, tagNumber % 9);
			if(result != Board.EMPTY_CELL_VALUE)
				inTextBox.Text = result.ToString();
			else
				inTextBox.Text = String.Empty;
		}

		private void cmdClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Board board = new Board();
			ShowBoard(board);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			openFileDialog.Filter = "Soduko files (*.sod)|*.sod";
			if(openFileDialog.ShowDialog(this) == DialogResult.OK) 
				ShowBoardFromFile(openFileDialog.FileName);
		}

		private void ShowBoardFromFile(string inFilePath)
		{
			Board board = new Board();
			SudokuSerializer serializer = new SudokuSerializer();
			serializer.Read(inFilePath,board);
			ShowBoard(board);

		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			saveFileDialog.Filter = "Soduko files (*.sod)|*.sod";
			saveFileDialog.AddExtension = true;
			if(saveFileDialog.ShowDialog(this) == DialogResult.OK) 
			{
				Board board = new Board();
				SudokuSerializer serializer = new SudokuSerializer();
				InitBoard(board);
				serializer.Write(saveFileDialog.FileName,board);
			}		
		
		}

		private void SodukoMain_Load(object sender, System.EventArgs e)
		{
			// do nothing
		}

		private void SodukoMain_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
		}

		private void SodukoMain_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			
			string[] path = (string[])(e.Data.GetData("FileDrop"));
			ShowBoardFromFile(path[0]);

		}

		private void SodukoMain_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] formats = e.Data.GetFormats();

			
			if(e.Data.GetDataPresent("FileDrop"))
			{
				string[] path = (string[])(e.Data.GetData("FileDrop"));
				int length = path.Length;
				if(1 == length)
					e.Effect = DragDropEffects.Copy;	
				else
					e.Effect = DragDropEffects.None;
			}
			else 
				e.Effect = DragDropEffects.None;
		}

		private void textBox_TextChanged(object sender, System.EventArgs e)
		{
			if(IsValidBoxInput(((TextBox)sender).Text))
				SelectNextControl((Control)sender,true,true,true,true);
			else
				((TextBox)sender).Text = "";

		}

		private static char scOne = '1';
		private static char scNine = '9';
		private static char scSpace = ' ';
		
		bool IsValidBoxInput(string inText)
		{
			if(inText.Length == 1)
			{
				char aChar = inText.ToCharArray(0,1)[0];
				if(aChar <= scNine && aChar >= scOne)
					return true;
				else
					if(scSpace == aChar)
					return true;
				else 
					return false;
			}
			else
				return false;
		}

		private void SodukoMain_Closed(object sender, System.EventArgs e)
		{
			if(runner!= null)
				if(runner.IsAlive) 
				{
					Abort();
					runner.Join();
				}		
		}

		private void Abort()
		{
			mSudokuGame.Abort();
		}

		private void Abort(object sender, System.EventArgs e)
		{
			Abort();
		}

	}
}
