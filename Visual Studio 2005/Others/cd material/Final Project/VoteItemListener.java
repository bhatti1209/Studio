
import java.applet.*;
import javax.swing.UIManager;
import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

class VoteItemListener implements ItemListener{
  public void itemStateChanged(ItemEvent ev){
  boolean selected = (ev.getStateChange()== ItemEvent.SELECTED);
  AbstractButton button = (AbstractButton)ev.getItemSelectable();
  System.out.println("ITEM Choice Selected :"+selected+",Selection:"+button.getActionCommand());
	}
 }