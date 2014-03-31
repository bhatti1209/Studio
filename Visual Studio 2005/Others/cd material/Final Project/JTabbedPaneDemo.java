import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class JTabbedPaneDemo extends JFrame
{
    public JTabbedPaneDemo()
    { 
     super("Proxy Settings");
      Container c  = getContentPane();
	    c.setLayout(new GridLayout(0,1));
       
        c.add(new proxy());
        setSize(600,310);
        setLocation(400,300);
        setVisible(true);

	}
	 public static void main(String args[])
	 {
        JTabbedPaneDemo jtpd = new JTabbedPaneDemo();
   	 }

}

 class dun extends JPanel
{
	public dun()
	{
		this.setLayout(null);

		JLabel jl1,jl2;
		jl1=new JLabel("Retry failed connection",JLabel.LEFT);
		jl1.setBounds(40,40,200,22);
		add(jl1);
		jl2=new JLabel("Between retry wait",JLabel.LEFT);
		jl2.setBounds(40,80,200,22);
		add(jl2);

		JButton jb1,jb2;
		jb1=new JButton("OK");
		jb1.setBounds(180,190,90,22);
		add(jb1);
		jb2=new JButton("Cancel");
		jb2.setBounds(320,190,90,22);
        add(jb2);
    }
 }

 class sch extends JPanel
{
	public sch()
	{
       this.setLayout(null);

       JLabel jl=new JLabel("Start downloading file at",JLabel.LEFT);
       jl.setBounds(40,30,180,22);
       add(jl);

       JCheckBox cb1,cb2,cb3,cb4,cb5,cb6,cb7,cb8;
       cb1=new JCheckBox("Monday");
       cb2=new JCheckBox("Tuesday");
       cb3=new JCheckBox("Wednesday");
       cb4=new JCheckBox("Thursday");
       cb5=new JCheckBox("Friday");
       cb6=new JCheckBox("Saturday");
       cb7=new JCheckBox("Sunday");
       cb1.setBounds(40,60,80,22);
       add(cb1);
       cb2.setBounds(160,60,80,22);
       add(cb2);
       cb3.setBounds(280,60,95,22);
       add(cb3);
       cb4.setBounds(400,60,80,22);
       add(cb4);
       cb5.setBounds(40,90,80,22);
       add(cb5);
       cb6.setBounds(160,90,80,22);
       add(cb6);
       cb7.setBounds(280,90,80,22);
       add(cb7);

       cb8=new JCheckBox("Stop downloading files at");
       cb8.setBounds(40,160,180,22);
       add(cb8);

       JButton jb1,jb2;
	   		jb1=new JButton("OK");
	   		jb1.setBounds(180,210,90,22);
	   		add(jb1);
	   		jb2=new JButton("Cancel");
	   		jb2.setBounds(320,210,90,22);
        add(jb2);
     }
 }

 class proxy extends JPanel implements ActionListener
 {
	 public proxy()
	 {
		this.setLayout(null);

        JCheckBox cb1,cb2;
        cb1=new JCheckBox("Http Default");
        cb1.setBounds(40,40,120,22);
        add(cb1);
        cb2=new JCheckBox("Ftp Default");
        cb2.setBounds(40,70,120,22);
        //add(cb2);

        JButton b1,b2;
        b1=new JButton("Set Proxy");
        b2=new JButton("Close");

        b1.setActionCommand("ADD");
        b1.addActionListener(this);
        b1.setBounds(40,130,180,22);
        add(b1);
        b2.setBounds(250,130,80,22);
        add(b2);

        JCheckBox cb=new JCheckBox("Use default proxy in all jobs");
        cb.setBounds(40,190,200,22);
        add(cb);
	 }

	 public void actionPerformed(ActionEvent ae)
	 {
		 String arg=ae.getActionCommand();
		 System.out.println(arg);

		 if(arg.equals("ADD"))
		 {
			 Proxysettings ps=new Proxysettings();
		 }
		 if(arg.equals("ADD"))
		 {
			this.setVisible(false);
		 }
		 
	 }
}
