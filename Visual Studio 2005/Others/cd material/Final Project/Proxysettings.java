import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Proxysettings extends JFrame implements ActionListener
{
	JFrame jf;
    Container c;
    JLabel jl1,jl2,jl3,jl4;
    JButton jb1,jb2;
    JCheckBox jcb1,jcb2,jcb3,jcb4,jcb5,jcb6;
    JTextField jtf1,jtf2,jtf3;

   public Proxysettings()
   {
	    jf=new JFrame("Proxy settings");
	    c=jf.getContentPane();
 c.setLayout(null);
	    jl1=new JLabel("Title :",JLabel.LEFT);
	    jl1.setBounds(30,20,80,22);
	    c.add(jl1);

	    jtf1=new JTextField(45);
	    jtf1.setBounds(120,20,200,22);
	    c.add(jtf1);

	    jl2=new JLabel("Server :",JLabel.LEFT);
	    jl2.setBounds(30,60,80,22);
	    c.add(jl2);

	    jtf2=new JTextField(15);
	    jtf2.setText("172.16.73.12");
	    jtf2.setBounds(120,60,200,22);
	    c.add(jtf2);

	    jl3=new JLabel("Port :",JLabel.LEFT);
	    jl3.setBounds(30,100,50,22);
	    c.add(jl3);

	    jtf3=new JTextField(15);
	    jtf3.setText("3128");
	    jtf3.setBounds(120,100,50,22);
	    c.add(jtf3);

        jl4=new JLabel("Type",JLabel.LEFT);
        jl4.setBounds(30,140,50,22);
        //c.add(jl4);

        jcb1=new JCheckBox("Direct connection");
        jcb1.setBounds(30,170,150,22);
       // c.add(jcb1);

        jcb2=new JCheckBox("HTTP <Get>");
        jcb2.setBounds(30,200,150,22);
       // c.add(jcb2);

        jcb3=new JCheckBox("HTTP <Connect>");
        jcb3.setBounds(30,230,150,22);
    //    c.add(jcb3);

        jcb4=new JCheckBox("FTP <User user@host:port>");
        jcb4.setBounds(30,260,200,22);
       // c.add(jcb4);

        jcb5=new JCheckBox("FTP <Open Host>");
        jcb5.setBounds(30,290,150,22);
       // c.add(jcb5);

        jcb6=new JCheckBox("FTP <Site Host>");
        jcb6.setBounds(30,320,150,22);
      //  c.add(jcb6);

        jb1=new JButton("OK");
        jb1.addActionListener(this);
        jb1.setBounds(90,390,90,22);
        c.add(jb1);

        jb2=new JButton("Cancel");
        jb2.addActionListener(this);
        jb2.setBounds(230,390,90,22);
        c.add(jb2);
        jf.setSize(400,470);
        jf.setVisible(true);
        jf.setLocation(400,200);
	}
	public void actionPerformed(ActionEvent ae)
	{
		String arg = ae.getActionCommand();
		if(arg.equals("OK"))
		{
			Download.Server = jtf2.getText();
			Download.Port = jtf2.getText();
			jf.setVisible(false);
		}
		if(arg.equals("Cancel"))
				{
					jf.setVisible(false);
		}
	}

	public static void main(String s[])
	{
		Proxysettings ps=new Proxysettings();
	}
}