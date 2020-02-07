/*
 * Erstellt mit SharpDevelop.
 * Benutzer: syscon
 * Datum: 3/11/2015
 * Zeit: 8:53 PM
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace S4Cut
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Blech Dimension eingeben";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(102, 33);
			this.textBox1.Name = "textBox1";
			this.textBox1.ShortcutsEnabled = false;
			this.textBox1.Size = new System.Drawing.Size(80, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "3000";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox1.WordWrap = false;
			this.textBox1.Leave += new System.EventHandler(this.TextBox1Leave);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyCharNoPoint);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(102, 59);
			this.textBox2.Name = "textBox2";
			this.textBox2.ShortcutsEnabled = false;
			this.textBox2.Size = new System.Drawing.Size(80, 23);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "1500";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox2.WordWrap = false;
			this.textBox2.Leave += new System.EventHandler(this.TextBox2Leave);
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyCharNoPoint);
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(102, 85);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(80, 23);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "1.0";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyChar);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(66, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "X :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(66, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Y :";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(66, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "S :";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Location = new System.Drawing.Point(249, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(358, 187);
			this.panel1.TabIndex = 7;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(420, 425);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 33);
			this.button1.TabIndex = 8;
			this.button1.Text = "Programm erstellen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(25, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(204, 82);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Auswaehlen";
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(16, 46);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(154, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Zuschnitte erstellen";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(16, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(140, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Tafel zerstanzen";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.textBox9);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Enabled = false;
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.groupBox2.Location = new System.Drawing.Point(25, 303);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(202, 155);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Zuschnitte berrechnen";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(39, 87);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 19);
			this.label10.TabIndex = 12;
			this.label10.Text = "Anzahl :";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(114, 86);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(40, 23);
			this.textBox9.TabIndex = 11;
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyCharNoPoint);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(43, 117);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(111, 28);
			this.button2.TabIndex = 10;
			this.button2.Text = "berechnen";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(38, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "Y :";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 19);
			this.label6.TabIndex = 8;
			this.label6.Text = "X :";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(74, 50);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(80, 23);
			this.textBox4.TabIndex = 7;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyChar);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(74, 24);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(80, 23);
			this.textBox5.TabIndex = 6;
			this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyChar);
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(120, 12);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(29, 23);
			this.textBox6.TabIndex = 11;
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(4, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 19);
			this.label7.TabIndex = 12;
			this.label7.Text = "Zuschnitte in X :";
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(206, 12);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(30, 23);
			this.textBox7.TabIndex = 13;
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(162, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "in Y :";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(245, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Gesamt :";
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox8.Location = new System.Drawing.Point(314, 12);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(40, 23);
			this.textBox8.TabIndex = 16;
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.textBox6);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Enabled = false;
			this.groupBox3.Location = new System.Drawing.Point(249, 305);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 41);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(5, 13);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(124, 24);
			this.checkBox1.TabIndex = 18;
			this.checkBox1.Text = "Material Code :";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(125, 13);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 20);
			this.textBox10.TabIndex = 19;
			this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyCharNoPoint);
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(125, 39);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(227, 20);
			this.textBox11.TabIndex = 21;
			this.textBox11.Leave += new System.EventHandler(this.TextBox11Leave);
			// 
			// checkBox2
			// 
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(5, 39);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(124, 24);
			this.checkBox2.TabIndex = 20;
			this.checkBox2.Text = "P4 Programm :";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox11);
			this.groupBox4.Controls.Add(this.checkBox2);
			this.groupBox4.Controls.Add(this.textBox10);
			this.groupBox4.Controls.Add(this.checkBox1);
			this.groupBox4.Enabled = false;
			this.groupBox4.Location = new System.Drawing.Point(249, 346);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(358, 66);
			this.groupBox4.TabIndex = 22;
			this.groupBox4.TabStop = false;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(1, 471);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(132, 20);
			this.label11.TabIndex = 24;
			this.label11.Text = "by Marcus Tausend(c)";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(249, 425);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(86, 33);
			this.button3.TabIndex = 25;
			this.button3.Text = "Hilfe";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label12);
			this.groupBox5.Controls.Add(this.textBox12);
			this.groupBox5.Controls.Add(this.checkBox5);
			this.groupBox5.Controls.Add(this.checkBox4);
			this.groupBox5.Controls.Add(this.checkBox3);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(25, 203);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(582, 94);
			this.groupBox5.TabIndex = 23;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Optionen";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(528, 28);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 23);
			this.label12.TabIndex = 4;
			this.label12.Text = "mm";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(453, 24);
			this.textBox12.Name = "textBox12";
			this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox12.Size = new System.Drawing.Size(69, 23);
			this.textBox12.TabIndex = 3;
			this.textBox12.Text = "100";
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox12.Leave += new System.EventHandler(this.TextBox12Leave);
			this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextKeyCharNoPoint);
			// 
			// checkBox5
			// 
			this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox5.Location = new System.Drawing.Point(234, 25);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(215, 24);
			this.checkBox5.TabIndex = 2;
			this.checkBox5.Text = "Tafel vor Drehung schneiden";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(15, 57);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(186, 24);
			this.checkBox4.TabIndex = 1;
			this.checkBox4.Text = "O87 Blech messen aus";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(15, 25);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(170, 24);
			this.checkBox3.TabIndex = 0;
			this.checkBox3.Text = "Mechanisch messen";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(632, 485);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.Text = "S4Cut";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}