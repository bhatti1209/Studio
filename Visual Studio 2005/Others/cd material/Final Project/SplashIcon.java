import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
public class SplashIcon extends JFrame implements MouseMotionListener
{

    static JButton jb = new JButton(new ImageIcon("1.gif"));
    static int speed=0;
	public SplashIcon()
{
//	JFrame.setDefaultLookAndFeelDecorated(false);
	this.setAlwaysOnTop(false);
	this.setBackground(new Color(150,0,0,250));
    this.setAlwaysOnTop(false);
    // SplashIcon.setDefaultLookAndFeelDecorated(false);
    this.setUndecorated(true);
    jb.addMouseMotionListener(this);
//    jb.addMouseListener(this);



    jb.setToolTipText(speed+"bytes/sec");
    this.getContentPane().setLayout(null);
    jb.setBounds(0,0,40,40);
    this.getContentPane().add(jb);
    this.setSize(40,40);
    this.setVisible(true);
    this.setLocation(20,700);
}

public static void main(String args[])
{
	new SplashIcon();
}

public void mouseDragged(MouseEvent me)
{
    this.setLocation(me.getX()+100,me.getY()+100);
}

public void mouseMoved(MouseEvent e) {
}

}
