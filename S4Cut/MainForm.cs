/*
 * Erstellt mit SharpDevelop.
 * Benutzer: syscon
 * Datum: 3/11/2015
 * Zeit: 8:53 PM
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace S4Cut
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//int auswahl;
		float dimX;
		float dimY;
		float dimS;
		
		int greifVerschnitt = 40;
		
		int teileInX;
	    int teileInY;
	    int teileAnzahl=0;
	    
	    string TeilePie;
	    string TeileDes;
	    
	    string Lpath;
	    
	    string o1= "";
	    string o2= "";
	    string cutbTurn = "";
	    string triOption = "";
	    
	    
	    
	  	    
	    List<Rectangle> myRect = new List<Rectangle> ();
	    
	       	    
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
            System.Drawing.Pen myPen;
			System.Drawing.Brush myBrush;
			System.Drawing.Brush partBrush;
			partBrush = new SolidBrush(System.Drawing.Color.DarkGray);
			myBrush = new SolidBrush(System.Drawing.Color.Blue);
			myPen = new Pen(System.Drawing.Color.Black);
			System.Drawing.Graphics fGraphics = panel1.CreateGraphics();				
			fGraphics.FillRectangle(myBrush,30,20,int.Parse(textBox1.Text)/10,int.Parse(textBox2.Text)/10);
						
	        foreach(Rectangle rect in myRect)
	        {
	        	e.Graphics.FillRectangle(partBrush,rect);
	        	e.Graphics.DrawRectangle(myPen,rect);
	        }						
			myPen.Dispose();
			fGraphics.Dispose();
			//MessageBox.Show("JETZT");
		}
		
		void TextBox1Leave(object sender, EventArgs e)
		{				
			myRect.Clear();
			if (int.Parse(textBox1.Text)>3000)
			{
				textBox1.Text= "3000";
				MessageBox.Show("  Mass zu Gross !!\n   Max: 3000 ");				
			}
			panel1.Invalidate();
		}
		
		void TextBox2Leave(object sender, EventArgs e)
		{			
			myRect.Clear();
			if (int.Parse(textBox2.Text)>1500)
			{
				textBox2.Text= "1500";
				MessageBox.Show("  Mass zu Gross !!\n   Max: 1500 ");				
			}
			panel1.Invalidate();
		}

//------------------------------------------------------------------------Programm erstellen		
		
		void Button1Click(object sender, EventArgs e)
		{
			string matCode= "";
						
			if (checkBox1.Checked == true)
			{
				matCode = textBox10.Text;			
			}			
			
			o1 = (checkBox3.Checked)? "C1": "";
			o2 = (checkBox4.Checked)? "O87": "";
			cutbTurn = (checkBox5.Checked)? "-"+textBox12.Text  : "";
			triOption = (checkBox5.Checked)? "TRI: V"+textBox12.Text  : "";
			
			
			if (radioButton1.Checked)     // <------  Abfrage ob Zerstanzen
			{
				
				 dimX=int.Parse(textBox1.Text);
	             dimY=int.Parse(textBox2.Text);
		         dimS=float.Parse(textBox3.Text);
		
	    string lines = @"COD:ZERSTANZEN			 

DIM:X"+dimX+@" Y"+dimY+cutbTurn+@" S"+dimS+@" K40 """+matCode+@"""

;*******************************************************
; Firma             : TK Aufzugswerke GmbH
; Datum             : "+DateTime.Now.ToString()+@"
; Programmierer     : Marcus Tausend
;*******************************************************
PUN:2 P21 F50.00 G50.00 ""QUAD50.0""
PUN:2 P33 F29.50 G29.50 ""QUAD29.5""
PUN:2 P63 F22.00 G3.20 S90.00 E-1 U34.500 ""RECH03222""
PUN:2 P81 F40.80 G32.00 S90.00 ""RECH32408""

; Begrenzung max. Schrottschnitt ab def. Blechdicke:
IF (dims >= 0.50) THEN
MCM: N5 V200
MCM: N6 V200
ENDIF
;*******************************************************
VAR: T0 N O24 O9 O5 O54 O69 H "+o1+@" "+o2+@"
"+triOption+@"
;=====================================

PIE: X0 Y0 U"+dimX+@" V"+dimY+cutbTurn+@"-40 DES
PIE: X0 Y"+dimY+cutbTurn+@"-40 U"+dimX+@" V10 DES
END
";
                        
	                    if(!Directory.Exists(Lpath))
	                    {           
	                    	Directory.CreateDirectory(Lpath);
	                    }
	    
                        System.IO.StreamWriter freq;
                        freq = new StreamWriter(Lpath+"\\Zerstanzen.S4");
                        freq.WriteLine(lines);
                        freq.Close();
			}
			
			else if (radioButton2.Checked)   // <------  Abfrage ob Zuschnitt
			{
			 dimX=int.Parse(textBox1.Text)-10;
	         dimY=int.Parse(textBox2.Text)-20;
		     dimS=float.Parse(textBox3.Text);
		
	    string lines = @"COD:ZUSCHNITT			 

DIM:X"+dimX+@" Y"+dimY+@" S"+dimS+@" K40 """+matCode+@"""

;*******************************************************
; Firma             : TK Aufzugswerke GmbH
; Datum             : "+DateTime.Now.ToString()+@"
; Programmierer     : Marcus Tausend
;*******************************************************
PUN:2 P21 F50.00 G50.00 ""QUAD50.0""
PUN:2 P33 F29.50 G29.50 ""QUAD29.5""
PUN:2 P63 F22.00 G3.20 S90.00 E-1 U34.500 ""RECH03222""
PUN:2 P81 F40.80 G32.00 S90.00 ""RECH32408""

; Begrenzung max. Schrottschnitt ab def. Blechdicke:
IF (dims >= 0.50) THEN
MCM: N5 V200
MCM: N6 V200
ENDIF
;*******************************************************
VAR: T0 N O24 O9 O5 O54 O69 H "+o1+@" "+o2+@"
TRI: F10 G20
;*******************************************************

"+TeileDes+@"
"+TeilePie+@"

END
";
	                    if(!Directory.Exists(Lpath))
	                    {
	                    	MessageBox.Show(Lpath );
	                    	Directory.CreateDirectory(Lpath);
	                    }
	    
                        
                        System.IO.StreamWriter freq;
                        // MessageBox.Show(Lpath+"\\Zuschnitt.S4");
                        freq = new StreamWriter(Lpath+"\\Zuschnitt.S4");
                        //freq = new StreamWriter("C:\\usr2\\syscon\\S4_1444\\production\\5185\\Zerstanzen.S4");
                        freq.WriteLine(lines);
                        freq.Close();
			}
			
	   
		}

//--------------------------------------------------------------------------------------------------		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				groupBox2.Enabled= false;
				groupBox3.Enabled= false;
				groupBox4.Enabled= false;
			}
			
			if (File.Exists(@"S4Cut.xml"))
            {
                try
                {
                    XElement root = XElement.Load(@"S4Cut.xml");

                    XElement xmlFile = root.Element("Path");
                   
                    Lpath = (String)xmlFile.Element("Local");   
                   
                }
                catch
                {
                    MessageBox.Show("S4Cut.xml fehlerhaft,\nProgramm läuft nicht richtig");
                    Application.Exit();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("soll ein Grundgerüst erstellt werden ?",
                                                              "S4Cut.xml Datei fehlt",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:                 //  "[Main]\r\ncode="
                        string lines = 
                               @"<?xml version=""1.0"" encoding=""utf-8""?>
                                 <Settings>
                                <Path>                                
                                <Local>C:\usr2\syscon\S4_1444\production\</Local>
                                </Path>                                     
                                </Settings>";
                        
                        System.IO.StreamWriter freq;
                        freq = new StreamWriter(Environment.CurrentDirectory + "\\S4Cut.xml");
                        freq.WriteLine(lines);
                        freq.Close();
                        break;
                        case DialogResult.No:
                        Application.Exit();
                        break;
                }
	
            }
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				groupBox2.Enabled= false;
				groupBox3.Enabled= false;
				groupBox4.Enabled= false;
				groupBox5.Enabled= true;
				textBox5.Text="";
				textBox4.Text="";
				textBox9.Text="";
				textBox6.Text="";
				textBox7.Text="";
				textBox8.Text="";
				textBox10.Text="";
				textBox11.Text="";
				checkBox1.Checked = false;
				checkBox2.Checked = false;
				myRect.Clear();
				panel1.Invalidate();
			}
			else if (radioButton2.Checked)
			{
				groupBox2.Enabled= true;
				groupBox3.Enabled= true;
				groupBox4.Enabled= true;
				groupBox5.Enabled= false;
			}
			
		
			
			
		}

//-----------------------------------------------------------------------------------------
		
		void Button2Click(object sender, EventArgs e)
		{
			
			TeilePie = "";
			TeileDes = "";
			string teilEntsorgung = "PCT";
			string teilName= "Teil.S4";
			myRect.Clear();
			
			if (checkBox2.Checked == true)
			{
				teilName = "S4_P4\\" + textBox11.Text;
			}
		
			if ((textBox5.Text=="")  & (textBox4.Text == ""))
			{
				textBox4.Text= "100";
				textBox5.Text= "100";
				//MessageBox.Show("IST LEER");
			}
			
			float zuInX=float.Parse(textBox5.Text);  //Zuschnitt auslesen
			float zuInY=float.Parse(textBox4.Text);  //------------------
			float dimXteil = zuInX;
			float dimYteil = zuInY;
			
			dimX=int.Parse(textBox1.Text)-10;
	        dimY=int.Parse(textBox2.Text)-20;
		    dimS=float.Parse(textBox3.Text);
			
		    if (dimXteil < 251 && dimYteil < 201)
		    {
		    	teilEntsorgung = "DWN";
		    }
		    
			if (textBox9.Text=="")
			{			    		      
			//Teile in X ausrechnen
			teileInX = (int)(dimX / zuInX) ;
			teileInY = (int)((dimY-greifVerschnitt) / zuInY) ;
			//MessageBox.Show("Teile in X="+teileInX+" Teile in Y="+teileInY);
			teileAnzahl= teileInX*teileInY;
						
			textBox6.Text= teileInX.ToString();
			textBox7.Text= teileInY.ToString();
			textBox8.Text= (teileInY*teileInX).ToString();				
			}
			else
			{
					    		    		    		      
			//Teile in X ausrechnen
			teileInX = (int)(dimX / zuInX) ;
			teileInY = (int)((dimY-greifVerschnitt) / zuInY) ;
			teileAnzahl= int.Parse(textBox9.Text);
			//MessageBox.Show("Teile in "+ teileAnzahl.ToString());
			
			textBox6.Text= teileInX.ToString();
			textBox7.Text= teileInY.ToString();
			textBox8.Text= (teileInY*teileInX).ToString();	
			}
						
			//------------------------------ Variablen vor Schleife
			zuInX = zuInX/10;
			zuInY = zuInY/10;
		    float zX=0;
		    float zY=zuInY;
		    int teileCount=1;		    
		    //-----------------------------------------------------
		    
			for (int i=0;i <= (teileInX-1);i++)
			  {	
										
				for (int y=0;y<=(teileInY-1);y++)
				{				    
				  
				 if (teileCount <= teileAnzahl)
				 {				 	
				 	//formGraphics.FillRectangle(myBrush,zX+30,((dimY/10)+19)-zY,zuInX,zuInY);// rechteck zeichnen
				   // formGraphics.DrawRectangle(myPen,zX+30,((dimY/10)+19)-zY,zuInX,zuInY);	
				   				       
				    myRect.Add(new Rectangle((int)(zX+30),(int)(((dimY/10)+19)-zY),(int)zuInX,(int)zuInY));
				    	  
				    TeilePie += @"PIE:"""+teilName+@""" X"+zX*10+" Y"+((zY*10)-dimYteil)+" U"+dimXteil+" V"+dimYteil+" "+teilEntsorgung + System.Environment.NewLine;
				    
				    zY= zY+zuInY;
				    teileCount++;
				 }
				 else
				 {				 
				    TeilePie += @"PIE:""TEIL.S4"" X"+zX*10+" Y"+((zY*10)-dimYteil)+" U"+dimXteil+" V"+dimYteil+" DES" + System.Environment.NewLine;
				    		
				    zY= zY+zuInY;
				    teileCount++;
				 }
				 
				}
				zY= zuInY;
				zX= zX+zuInX;
			  }
			
			if ((dimX-(teileInX*dimXteil))>0)
			{
			TeileDes += @"PIE: X"+(teileInX*dimXteil)+@" Y0 U"+(dimX-(teileInX*dimXteil))+@" V"+(teileInY*dimYteil)+@" DES" + System.Environment.NewLine;
			}
			
			TeileDes += @"PIE: X0 Y"+(teileInY*dimYteil)+@" U"+dimX+@" V"+((dimY-40)-(teileInY*dimYteil))+@" DES" + System.Environment.NewLine;
			
			panel1.Invalidate();
			
			//--------------------------------------------------------------------------------
		}
				
	
		
		
		void CheckTextKeyChar(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& !(e.KeyChar== '.') )
                e.Handled = true; 
		}
		void CheckTextKeyCharNoPoint(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; 
		}
		
		void TextBox11Leave(object sender, EventArgs e)
		{
			button2.PerformClick();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Hilfe hilfeform = new Hilfe();
			
			hilfeform.ShowDialog();
		}
		
		void TextBox12Leave(object sender, EventArgs e)
		{
			if (int.Parse(textBox12.Text)>500)
			{
				textBox12.Text= "500";
				MessageBox.Show("  Mass zu Gross !!\n   Max: 500 ");				
			}
		}
	}
}
