/**
 * @(#)Theme.java 1.0 02/06/26
 *
 *
 */

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.plaf.metal.*;
import java.io.*;
import java.util.Properties;

class Theme extends JFrame implements ActionListener 
{
		// property file and help files
	public static final String THEME_HELP  = "help/theme.html";
	private static final String THEME_PROP = "theme.properties";
		// the HTML display area	
	private HTMLDisplay display;
		// theme last selected
	private int iThemeID = 0;
		// theme file last selected
	private String szCustomThemeFile;
		//menus
	private JMenuItem mnuDefTheme, mnuWSTheme, mnuMBTheme, mnuCustomTheme;
	private JMenuItem mnuOpen, mnuQuit;
	private JMenuItem mnuHelp, mnuAbout;
	
	
//******************************************************************************************	
// Function Name : Theme() => the default constructor
// Parameter : None	
//	
// Adds menu, HTML display and loads the user preferences (Theme last selected)
//	
//******************************************************************************************
		
	public Theme()
	{
		super("Themes for Swing Look and Feel");
		
		display = new HTMLDisplay();
		setContentPane(display);
		makeMenu();
		loadPreferences();
	
		addWindowListener(new WindowAdapter()
		{
			public void windowClosing(WindowEvent e)
			{
				savePreferences();
				dispose();
				System.exit(0);
			}
		});
	}
	

//******************************************************************************************	
// Function Name : makeMenu() 
// Parameter : None	
// Returns : None
//	
// Creates and attaches menu to the application frame
//	
//******************************************************************************************

	
	private void makeMenu()
	{
		JMenuBar menuBar 	= new JMenuBar();
		menuBar.setOpaque(true);
		
		JMenu themeMenu		= new JMenu("Themes");
		mnuDefTheme			= new JMenuItem("Default Theme");
		mnuWSTheme			= new JMenuItem("White Satin");
		mnuMBTheme			= new JMenuItem("Moody Blues");
		mnuCustomTheme		= new JMenuItem("Custom Theme...");
		
		mnuDefTheme.addActionListener(this);
		mnuWSTheme.addActionListener(this);
		mnuMBTheme.addActionListener(this);
		mnuCustomTheme.addActionListener(this);
		
		
		themeMenu.add(mnuDefTheme);
		themeMenu.add(mnuWSTheme);	
		themeMenu.add(mnuMBTheme);	
		themeMenu.addSeparator();
		themeMenu.add(mnuCustomTheme);	
		
		
		JMenu fileMenu		= new JMenu("File");
		mnuOpen 			= new JMenuItem("Open...");
		mnuQuit				= new JMenuItem("Quit");
		
		mnuOpen.addActionListener(this);
		mnuQuit.addActionListener(this);
		
		fileMenu.add(mnuOpen);
		fileMenu.add(mnuQuit);
		
		JMenu helpMenu		= new JMenu("Help");
		mnuHelp				= new JMenuItem("Show Help");
		mnuAbout			= new JMenuItem("About...");
		
		mnuHelp.addActionListener(this);
		mnuAbout.addActionListener(this);
		helpMenu.add(mnuHelp);
		helpMenu.add(mnuAbout);
		
		menuBar.add(fileMenu);					  	
		menuBar.add(themeMenu);	  
		menuBar.add(helpMenu);              
		setJMenuBar(menuBar);
	}


//******************************************************************************************	
// Function Name : actionPerformed(ActionEvent evt)
// Parameter : ActionEvent evt
// Returns : None
//	
// Handles menu selection, the only function from interface ActionListener
//	
//******************************************************************************************
	
	
	public void actionPerformed(ActionEvent evt)
	{
			// ensure that action event is caused by the menu item only
	
		if(!(evt.getSource() instanceof JMenuItem)) 
		{
			return;
		}

			// default metal steel theme
		if(mnuDefTheme == evt.getSource())
		{
			iThemeID = 0; 
			applyTheme();
		}
			// White Satin
		else if(mnuWSTheme == evt.getSource())
		{
			iThemeID = 1; 
			applyTheme();
		}
			// Moody Blues
		else if(mnuMBTheme == evt.getSource())
		{	
			iThemeID = 2; 
			applyTheme();
		}
			// Custom Theme, will be selected from a file 
		else if(mnuCustomTheme == evt.getSource())
		{	
			getThemeFile();
			if(-1 == iThemeID)
			{
				applyTheme();
			}
		}
			// open file open dialog
		else if(mnuOpen == evt.getSource())
		{
			JFileChooser fc = new JFileChooser(System.getProperty("user.dir"));
			fc.addChoosableFileFilter(new ExtFileFilter("txt", "Text files"));
			fc.addChoosableFileFilter(new ExtFileFilter(new String[]{"htm", "html"}, "HTML files"));
			
			if(JFileChooser.APPROVE_OPTION == fc.showOpenDialog(this))
			{
				File file = fc.getSelectedFile();
				display.showURL("file:"+file.getAbsolutePath());
			}
		}
			// quit
		else if(mnuQuit == evt.getSource())
		{
			savePreferences();
			dispose();
			System.exit(0);
		}
			// Display HELP files in the app
		else if(mnuHelp == evt.getSource())
		{
			File file = new File(THEME_HELP);
			display.showURL("file:"+file.getAbsolutePath());
		}
			// Show about box
		else if(mnuAbout == evt.getSource())
		{
			JOptionPane.showMessageDialog(this, "Copyright (c) 2002, Manish Hatwalne",
						"About Themes...", JOptionPane.INFORMATION_MESSAGE, 
						new ImageIcon("images/tf.gif"));
		}
	
	}

//******************************************************************************************	
// Function Name : getThemeFile()
// Parameter : None
// Returns : None
//	
// Shows a file open dialog and gets the "ustom theme" file selected by the user
// Value is stored in the variable - szCustomThemeFile
//	
//******************************************************************************************	
	
	private void getThemeFile()
	{
		InputStream in = null;
		JFileChooser fc = new JFileChooser(System.getProperty("user.dir"));
		fc.addChoosableFileFilter(new ExtFileFilter(new String[]{"thm", "theme"}, "Theme files"));
		
		if(JFileChooser.APPROVE_OPTION == fc.showOpenDialog(this))
		{
			szCustomThemeFile = fc.getSelectedFile().getAbsolutePath();
			iThemeID = -1; 
		}
	}
	
//******************************************************************************************	
// Function Name : applyTheme()
// Parameter : None
// Returns : None
//	
// reflects theme chosen by the user in the application GUI
//	
//******************************************************************************************	
		
	private void applyTheme()
	{
		MetalTheme theme = null;
		InputStream in = null;
		
		switch(iThemeID)
    	{
    		case 1:
    				theme = new WhiteSatinTheme();
    				break;
    		case 2:
    				theme = new MoodyBlueTheme();
    				break;
    		case -1:
    				try{
							in = new FileInputStream(szCustomThemeFile);
					}catch(IOException e)
					{
						System.out.println(e); 
					}
    				theme = new CustomTheme(in);
    				break;
    		default:
    				theme = new DefaultMetalTheme();
    				break;
    	}
		
			//set the chosen theme
		MetalLookAndFeel.setCurrentTheme(theme);
		this.setTitle(theme.getName());
		try{
				UIManager.setLookAndFeel("javax.swing.plaf.metal.MetalLookAndFeel");
				SwingUtilities.updateComponentTreeUI(this);
		}catch(Exception e)
		{
			System.out.println(e);
		}
		
	}

//******************************************************************************************	
// Function Name : loadPreferences()
// Parameter : None
// Returns : None
//	
// Loads the user preferences at the application start up. Reads the last theme selected by
// the user from the property file, and path of that theme; if any.
//	
//******************************************************************************************	
	
	private void loadPreferences()
	{
		Properties pref = new Properties();
		InputStream is = null;
		
		try{
					// get input stream of the preferences property file
				is = new FileInputStream(THEME_PROP);
				pref.load(is);
		}catch(IOException e)
		{
			System.out.println(e);
		}
			//get ID of the last theme
		String szTemp = pref.getProperty("Theme.ID");
    	if(null != szTemp)
    	{
    		try{
    				iThemeID = Integer.parseInt(szTemp);
    		}catch(Exception e)
    		{
    			System.out.println(e);
    			System.out.println("Couldn't retrieve theme ID : " + szTemp);
    			return;
    		}
    	}
    		// if it is the custom ID, read the p[ath of the theme file as well
    	if(-1 == iThemeID)
    	{
    		szTemp = pref.getProperty("Theme.File");
    		szCustomThemeFile = szTemp;
    	}
    		// if not default
    	if(0 != iThemeID)
    	{
			applyTheme();
		}
		if(null != is)
		{
			try{
					is.close();
			}catch(IOException e)
			{
				System.out.println(e);
			}
		}
	}


//******************************************************************************************	
// Function Name : savePreferences()
// Parameter : None
// Returns : None
//	
// Saves user preferences (theme last selected) before quiting the app, in a property file
//	
//******************************************************************************************


	private void savePreferences()
	{
		Properties pref = new Properties();
		pref.setProperty("Theme.ID", ""+iThemeID);

		if(-1 == iThemeID)
		{
			pref.setProperty("Theme.File", szCustomThemeFile);
		}
		try{
				OutputStream os = new FileOutputStream(THEME_PROP);
				pref.store(os,"Preferences for themes");
				os.close();
		}catch(IOException e)
		{
			System.out.println(e);
		}
	}
	
//******************************************************************************************	
// Function Name : main(String args[])
// Parameter : String args[] , command line args
// Returns : None
//	
// The entry point of the application
//	
//******************************************************************************************	

	public static void main(String args[])
	{
		System.out.println("Starting Theme...");
				
			//****** JDK 1.4 only *********
			// comment these lines for JDK 1.2 & 1.3
				
		JFrame.setDefaultLookAndFeelDecorated(true);
		JDialog.setDefaultLookAndFeelDecorated(true);
    	
    		//****** END JDK 1.4 only *********
        
		Theme mainFrame = new Theme();
		final int iInset = 50;
        Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
		mainFrame.setBounds ( iInset, iInset, screenSize.width - iInset*2, screenSize.height - iInset*2 );
		mainFrame.setVisible(true);
	}
	
}
