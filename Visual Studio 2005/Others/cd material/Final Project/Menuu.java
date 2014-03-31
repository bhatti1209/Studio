import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.filechooser.*;
import java.util.*;
import java.io.*;
import java.awt.datatransfer.*;
public class Menuu extends JMenuBar implements ActionListener
{

  JFrame f;
  JMenuBar mbr;
  JMenu file,view,toolbar ,skin,jobs,help,edit,tools,slm;
  Container c;
  JMenuItem item1,item2,item3,item4,item5,item6;


  public Menuu()
  {

	  mbr=new JMenuBar();


	  file=new JMenu("File");


	   item1=new JMenuItem("Import List");
	   item1.setActionCommand("save");
	   item1.addActionListener(this);


	   item2=new JMenuItem("Exit");
       item2.addActionListener(this);

	   file.add(item1);

	   file.add(item2);
       mbr.add(file);

       edit=new JMenu("Edit");

	   item3=new JMenuItem("Paste URL")	;
	   item3.addActionListener(this);
	   item3.setActionCommand("paste");

       edit.add(item3);

       mbr.add(edit);




      tools=new JMenu("Tools");

	  item4=new JMenuItem("Connect/Disconnect") ;
	  item4.setActionCommand("connect");
	  item4.addActionListener(this);
	  item5=new JMenuItem("Schedule Download") ;
	  item5.setActionCommand("schedule");
	  item5.addActionListener(this);

      tools.add(item4);
      tools.add(item5);


      mbr.add(tools);



      help=new JMenu("Help");
      item6=new JMenuItem("About Download Manager");
      item6.setActionCommand("AboutDownloadManager");
      item6.addActionListener(this);
      help.add(item6);
      mbr.add(help);

	   this.add(mbr);

		//Color c1=new Color(30,80,60,10);
	  //mbr.setBackground(c1);
	  //mbr.setVisible(true);
  }


  public void actionPerformed(ActionEvent ae)
  {
	  String arg =ae.getActionCommand() ;
	  System.out.print(arg);
	  if(arg.equals("save"))
	  {
	  		TableFromDatabase tfd = new TableFromDatabase();
      }
        if(arg.equals("paste"))
	  {
	  	DownloadManager.addTextField.setText(getClipboard());

	  	}
        if(arg.equals("schedule"))
	  {
	  Scheduler fd = new Scheduler();
       }
      if(arg.equals("connect"))
      {
	   JTabbedPaneDemo jtd = new JTabbedPaneDemo();
      }
      if(arg.equals("AboutDownloadManager"))
      {
		About_DM1 dm=new About_DM1();
	  }
	  if(arg.equals("Exit"))
	        {
	  	   System.exit(0);
      }

  }
public static String getClipboard()
{
        Transferable t = Toolkit.getDefaultToolkit().getSystemClipboard().getContents(null);

        try
        {
            if (t != null && t.isDataFlavorSupported(DataFlavor.stringFlavor))
            {
                String text = (String)t.getTransferData(DataFlavor.stringFlavor);
                return text;
            }
        }
        catch (UnsupportedFlavorException e)
        {
        }
        catch (IOException e)
        {
        }
        return null;
    }
  public static void main(String s[])
  {
	 JFrame f = new JFrame("Download");
	  Menuu nu =  new Menuu();
	  f.add(nu);


	  f.setSize(600,400);
      f.setVisible(true);

  }
}


