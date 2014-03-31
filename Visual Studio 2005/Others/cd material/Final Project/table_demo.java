import java.awt.*;
import javax.swing.*;


public class table_demo extends JPanel
{

	public table_demo()
	{
		final String[] colheads={"Name","Size","Completed","Percent","Elasped","Left","Speed","URL"};

		final Object[][] data={{"swades1.zip","250","","70%","10min","2min","320kbps","www.svra.com"},
		                       {"swades2.zip","350","","20%","15min","22min","20kbps","www.svra.com"},
		                       {"TutorialonJAVA.zip","150","","30%","18min","5min","160kbps","www.w3schools.com"}
						      };

        JTable table=new JTable(data,colheads);

        int v=ScrollPaneConstants.VERTICAL_SCROLLBAR_AS_NEEDED;
        int h=ScrollPaneConstants.HORIZONTAL_SCROLLBAR_AS_NEEDED;

      JScrollPane jsp=new JScrollPane(table,v,h);
      add(jsp,BorderLayout.CENTER);
      setSize(600,600);
      setVisible(true);
	}
	public static void main(String args[])
	{
		table_demo td = new table_demo();
	}
}