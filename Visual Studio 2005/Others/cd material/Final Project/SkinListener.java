import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.filechooser.*;
import java.util.*;
import java.io.*;


class SkinListener implements ActionListener
 {
 	Component dm;
 
  
 	public SkinListener(DownloadManager dme)
 	{
 	dm=dme;
 
 	}
  
 	public void actionPerformed(ActionEvent ae) {
 		String ac = ae.getActionCommand();
 		if(ac.equals("javalaf"))
 		{
 	  		try
 	  		{
 	  				dm.setVisible(false);
 	dm.setVisible(true);
 		 	System.out.println ("ac = " + ac);
 		   	UIManager.setLookAndFeel("javax.swing.plaf.metal.MetalLookAndFeel");
 	    		SwingUtilities.updateComponentTreeUI(dm);
 	  		} catch(Exception e)
 	  		{
 	
 	  		}
 		}
 		else if(ac.equals("liquidlaf"))
 		{
 	 		 try
 	  		{
 	    		UIManager.setLookAndFeel("com.birosoft.liquid.LiquidLookAndFeel");
 	    		SwingUtilities.updateComponentTreeUI(dm);
 	  		}catch(Exception e)
 	  		{
 	
 	  		}
 		}
 		else if(ac.equals(dm))
 		{
 	  		try
 	  		{
 	    		UIManager.setLookAndFeel(
 				"com.sun.java.swing.plaf.motif.MotifLookAndFeel");
 	    		SwingUtilities.updateComponentTreeUI(dm);
 	  		}
 	  		catch(Exception e){}
 		}
 		else if(ac.equals("windowlaf"))
 		{
 	  		try
 	  		{
 	    		UIManager.setLookAndFeel(
 				"com.sun.java.swing.plaf.windows.WindowsLookAndFeel");
 	    		SwingUtilities.updateComponentTreeUI(dm);
 	  		}
 	  		catch(Exception e){}
 		}
 		else if(ac.equals("threedlaf"))
 		{
 	 		try
 	  		{
 	    		UIManager.setLookAndFeel("swing.addon.plaf.threeD.ThreeDLookAndFeel");
 	    		SwingUtilities.updateComponentTreeUI(dm);
 	  		}
 	  		catch(Exception e){}
 	  	}
 	}
 }