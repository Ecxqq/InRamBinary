using System;
using System.Drawing;
using System.Windows.Forms;


namespace Kursovaya7a
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (byte1.Checked==true)
			{
                try 
                { 
                	Convert.ToByte(textBox1.Text);
                    unsafe 
                    {  
                    	string st=""; 
                    	richTextBox1.Clear();
                        byte y = Convert.ToByte(textBox1.Text);
                        byte* x = &y;
                        uint adres = (uint)x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<1; count++) //количество байт
                        {
                        	string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                    }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (sbyte1.Checked==true) 
            {
                try 
                { 
                	Convert.ToSByte(textBox1.Text);
                    unsafe 
                    {  
                    	string st=""; 
                    	richTextBox1.Clear();
                        sbyte y = Convert.ToSByte(textBox1.Text);
                        sbyte *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<1; count++) //количество байт
                        {
                        	string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                    }
                    
                } 
                catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (short1.Checked==true) 
            {
                try 
                { 
                	Convert.ToInt16(textBox1.Text);
                    unsafe 
                    {  
                    	string st=""; 
                    	richTextBox1.Clear();
                        short y = Convert.ToInt16(textBox1.Text);
                        short *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<2; count++) //количество байт
                        {
                        	string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                    }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (ushort1.Checked==true) 
            {
                try 
                { 
                	Convert.ToUInt16(textBox1.Text);
                    unsafe 
                    {
                    	string st=""; 
                    	richTextBox1.Clear();
                        ushort y = Convert.ToUInt16(textBox1.Text);
                        ushort *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<2; count++) //количество байт
                        {
                            string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                    }
                    
                } catch
                {
                   	MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (int1.Checked==true) 
            {
                try 
                {
					Convert.ToInt32(textBox1.Text);
                    unsafe 
                    {
                    	string st="";
                    	richTextBox1.Clear();
                        int y = Convert.ToInt16(textBox1.Text);
                        int *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<4; count++) //количество байт
                        {
                            string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2; 
                    }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (uint1.Checked==true) 
            {
                try 
                { 
                	Convert.ToUInt32(textBox1.Text);
                    unsafe 
                    {
                    	string st="";
                    	richTextBox1.Clear();
                        uint y = Convert.ToUInt32(textBox1.Text);
                        uint *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<4; count++) //количество байт
                        {
                            string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                    }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (long1.Checked==true) 
            {
                try 
                {
					Convert.ToInt64(textBox1.Text);
                    unsafe 
                    {
                    	string st="";
                    	richTextBox1.Clear();
                        long y = Convert.ToInt64(textBox1.Text);
                        long *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<8; count++) //количество байт
                        {
                            string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+=" "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;  
                    }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (ulong1.Checked==true) 
            {
                try 
                {
					Convert.ToUInt64(textBox1.Text);
                    unsafe 
                    {  
                    	string st="";
                    	richTextBox1.Clear();
                        ulong y = Convert.ToUInt64(textBox1.Text);
                        ulong *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<8; count++) //количество байт
                        {
                        	string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+=" "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                    }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (float1.Checked==true) { 
                try 
                { 
                	Convert.ToSingle(textBox1.Text);
                    unsafe 
                    {  
                    	string st=""; 
                    	richTextBox1.Clear();
                        float y = Convert.ToSingle(textBox1.Text);
                        float *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<4; count++) //количество байт
                        {
                        	string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                     }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (double1.Checked==true) 
            {
                try 
                { 
                	Convert.ToSingle(textBox1.Text);
                    unsafe 
                    {  
                    	string st=""; 
                    	richTextBox1.Clear();
                        double y = Convert.ToSingle(textBox1.Text);
                        double *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<8; count++) //количество байт
                        {
                        	string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                     }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
            if (decimal1.Checked==true) 
            {
                try 
                { 
                	Convert.ToDecimal(textBox1.Text);
                    unsafe 
                    {  
                    	string st=""; 
                    	richTextBox1.Clear();
                        decimal y = Convert.ToDecimal(textBox1.Text);
                        decimal *x = &y;
                        void* adres = x;
                        byte* znach = (byte*)adres;
                        for (int count =0; count<10; count++) //количество байт
                        {
                        	string    g = Convert.ToString(*(znach+count),2);
                        	char [] g1 = g.ToCharArray();
                        	Array.Reverse(g1);
                        	string g2=new string (g1);
                        	while (g2.Length<8){g2=g2+'0';}
                        	st+="  "+g2;
                        }
                        char [] st1 = st.ToCharArray();
                        Array.Reverse(st1);
                        string st2 = new string(st1);
                        richTextBox1.Text=""+st2;
                    }
                    
                } catch
                {
                    MessageBox.Show("Ошибка во введенных данных");
                }
            }
        }
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8 && number != 44 && number != '-') 
			{
    			e.Handled = true;
			}
		}
    }
}
