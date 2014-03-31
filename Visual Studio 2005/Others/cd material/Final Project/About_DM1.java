import javax.swing.*;
import java.awt.*;
import java.applet.*;
import java.awt.event.*;

public class About_DM1
{
	JFrame jf;
	Container c;
	JLabel jl1,jl2,jl3,jl4,jl5,jl6;
	JTextArea jta;
	TextField tf;
	String val;

	public About_DM1()
	{
	   jf=new JFrame("About DownLoad Manager");
	   c=jf.getContentPane();
	   c.setLayout(new FlowLayout(FlowLayout.LEFT));



	   jl1=new JLabel("Download Manager",JLabel.CENTER);
	  // jl1.setBounds(245,20,200,40);
	   c.add(jl1);
       jl2=new JLabel(" GUI Components");
      
      c.add(jl2);
      val=" Following are the predefined classes defined in"+
      " javax.swing package where javax satnds for Java Extension that are used in making the GUI Compoments:\n"+
"	1.  JMenuBar		    : Creates a menu bar.\n"+
"	2.  JMenu		    : Creates a pull-down menu.\n"+
"	3.  JMenyItem		    : Creates a menu item.\n"+
"	4.  JCheckBoxMenuItem: Creates an on/off menu item.\n"+
"	5.  JComponent	    : A subclass of component that can hold other  components.\n"+
"	6.  JTable		    : Creates a table.\n"+
"	7.  JPanel		    : Provides general purpose containers for lightweight components.\n"+
"	8.  JScrollPane		    : A container that provides horizontal and/ or vertical scroll bar for another component.\n"+ 
"	9.  JLabel		    : Creates a label that displays a string or image or both.\n"+
"	10.JTextField		    : Creates a single-line edit control.\n"+
"	11.JButton		    : Creates a push button control.\n"+
"	12.JCheckBox		    : Creates a check box control.\n"+
"	13.JFrame		    : Creates a standard window that has a title bar,resize corners and a menu bar.\n"
	;
	TextArea text=new TextArea(val,150,250);
	c.add(text);
       
        jl3=new JLabel(" ");
       c.add(jl3);
       jl4=new JLabel("");
       c.add(jl4);
        jl5=new JLabel("");
       c.add(jl5);
        jl6=new JLabel("");
       c.add(jl6);

	   jta=new JTextArea();
	   jta.setLocation(40,60);
	   c.add(jta);
	   jf.setSize(1000,500);
	   jf.setLocation(400,200);
	   jf.setVisible(true);
   }

   public static void main(String s[])
   {
	   About_DM1 dm=new About_DM1();
   }
}