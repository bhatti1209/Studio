import java.awt.*;
import java.awt.event.*;

class file_dialog extends Frame
{
   public file_dialog(String title)
   {
     super(title);
     MyWindowAdapter ad=new MyWindowAdapter(this);
     addWindowListener(ad);
   }
 }

 class MyWindowAdapter extends WindowAdapter
 {
	 file_dialog fd;

	 public MyWindowAdapter(file_dialog fd)
	 {
		 this.fd=fd;
	 }

	 public void windowClosing(WindowEvent we)
	 {
         fd.setVisible(false);
	 }
 }

 class fd_demo
 {
	 public static void main(String s[])
	 {
		   Frame f=new file_dialog("File Dialog Demo");

		   f.setVisible(true);
		   f.setSize(200,200);

		   FileDialog x=new FileDialog(f,"My_Magic");
		   x.setVisible(true);
	   }
   }