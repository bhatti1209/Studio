 import java.awt.*;
import java.awt.event.*;
import java.net.*;
import java.util.*;
import javax.swing.*;
import javax.swing.event.*;
import java.sql.*;
import javax.sql.*;
import java.util.*;
import java.text.*;
import java.util.Random;
import java.io.*;
import java.io.*;
import java.net.*;
import java.util.*;
import javax.swing.*;
import java.awt.*;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Rectangle;

// The Download Manager.
 

public class DownloadManager extends JFrame implements Observer
{	
   Menuu mb =new Menuu();

    // Add download text field.
   static JTextField addTextField = new JTextField(30);;

    // Download table's data model.
    private DownloadsTableModel tableModel;

    // Table listing downloads.
    private JTable table;

    // These are the buttons for managing the selected download.
    private JButton pauseButton, resumeButton;
    private JButton cancelButton, clearButton;

    // Currently selected download.
    private Download selectedDownload;

    // Flag for whether or not table selection is being cleared.
    private boolean clearing;

    // Constructor for Download Manager.
    public DownloadManager()
    {
        // Set application title.
        setTitle("Download Manager");
 		//SplashIcon si = new SplashIcon();
        // Set window size.
        setSize(780, 480);


     
     setJMenuBar(mb);

        // Set up add panel.
        JPanel addPanel = new JPanel();
        JLabel title = new JLabel();
         title.setFont(new Font("Tahoma", 0, 14));
        title.setForeground(new Color(80, 20, 220));
         title.setText("Enter URL");
         addPanel.add(title,"North");

        addPanel.add(addTextField);
        addPanel.setBackground(new Color(10,180,60,30));

        JButton addButton = new JButton("Download");
        addButton.addActionListener(new ActionListener()
            {
            public void actionPerformed(ActionEvent e) {
                actionAdd();
            }
        });
        addPanel.add(addButton);

        // Set up Downloads table.
        tableModel = new DownloadsTableModel();
        table = new JTable(tableModel);
        table.getSelectionModel().addListSelectionListener(new
                ListSelectionListener() {
            public void valueChanged(ListSelectionEvent e) {
                tableSelectionChanged();
            }
        });
        // Allow only one row at a time to be selected.
        table.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

        // Set up ProgressBar as renderer for progress column.
        ProgressRenderer renderer = new ProgressRenderer(0, 100);
        renderer.setStringPainted(true); // show progress text
        table.setDefaultRenderer(JProgressBar.class, renderer);

        // Set table's row height large enough to fit JProgressBar.
        table.setRowHeight(
                (int) renderer.getPreferredSize().getHeight());

        // Set up downloads panel.
        JPanel downloadsPanel = new JPanel();
        downloadsPanel.setBorder(
                BorderFactory.createTitledBorder("Downloads"));

        downloadsPanel.setLayout(new BorderLayout());
        downloadsPanel.add(new JScrollPane(table),
                BorderLayout.CENTER);

        // Set up buttons panel.
        JPanel buttonsPanel = new JPanel();

        pauseButton = new JButton("Pause");
        resumeButton = new JButton("Resume");
        cancelButton = new JButton("Cancel");
        clearButton = new JButton("Clear");
        
        
        pauseButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) { 
                //actionPause(e);
                if(selectedDownload != null)
                {
                	selectedDownload.paused();
                	pauseButton.setEnabled(false);
               		resumeButton.setEnabled(true);
                }
            }
        });
       // pauseButton.setEnabled(true);
        buttonsPanel.add(pauseButton);
        
        resumeButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                //actionResume();
                if(selectedDownload != null)
                {
                	selectedDownload.resumed();
                	pauseButton.setEnabled(true);
               		resumeButton.setEnabled(false);
                }
            }
        });
        //resumeButton.setEnabled(true);
        buttonsPanel.add(resumeButton);
        
        cancelButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                actionCancel();
            }
        });
        cancelButton.setEnabled(true);
        buttonsPanel.add(cancelButton);
        
        clearButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
               // actionClear();
            }
        });
        clearButton.setEnabled(true);
        //buttonsPanel.add(clearButton);
// JPanel speedPanel = new JPanel();

// jtf.setText();
        // Add panels to display.
        getContentPane().setLayout(new BorderLayout());
         getContentPane().add(buttonsPanel, BorderLayout.WEST);
        getContentPane().add(addPanel, BorderLayout.NORTH);
        getContentPane().add(downloadsPanel, BorderLayout.CENTER);
        getContentPane().add(buttonsPanel, BorderLayout.SOUTH);

    }

    // Exit this program.
    private void actionExit() {
        System.exit(0);
    }

    // Add a new download.
    private void actionAdd() {
        URL verifiedUrl = verifyUrl(addTextField.getText());
         SimpleDateFormat sdf6 = new SimpleDateFormat("EEEE dd MMMM yyyy H m");
           Calendar cal =new GregorianCalendar();
        if (verifiedUrl != null) {
        try
        {   String fname = verifiedUrl.toString();
            String name = fname.substring(fname.lastIndexOf("/")+1);
            System.out.println("Name "+name);

        	Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");

        Connection conn = MyConnection.getConnection();
        	System.out.println("Connection Established");
        	String h = "History";
        	String query = "insert into Table1 values('"+name+"','"+verifiedUrl.toString()+"','"+sdf6.format(cal.getTime())+"','"+h+"')";
        	 Statement stmt = conn.createStatement();

             stmt.executeUpdate(query);

        }
        catch(Exception e){
        	e.printStackTrace();
        }
        	selectedDownload = new Download(verifiedUrl);
        	//selectedDownload.run();
        	Thread th = new Thread(selectedDownload);
        	th.start();
            tableModel.addDownload(selectedDownload);
            addTextField.setText(""); // reset add text field
            //selectedDownload.run();
            //selectedDownload.start();
        } else {
            JOptionPane.showMessageDialog(this,
                    "Invalid Download URL", "Error",
                    JOptionPane.ERROR_MESSAGE);
        }
    }

    public  void actionAdd2(String sch_url) {
	        URL verifiedUrl = verifyUrl(sch_url);
	        if (verifiedUrl != null) {
	            tableModel.addDownload(new Download(verifiedUrl));
	            addTextField.setText(""); // reset add text field
	        } else {
	            JOptionPane.showMessageDialog(this,
	                    "Invalid Download URL", "Error",
	                    JOptionPane.ERROR_MESSAGE);
	        }
    }


    // Verify download URL.
    private URL verifyUrl(String url) {
        // Only allow HTTP URLs.
        if (!url.toLowerCase().startsWith("http://"))
            return null;

        // Verify format of URL.
        URL verifiedUrl = null;
        try {
            verifiedUrl = new URL(url);
        } catch (Exception e) {
            return null;
        }

        // Make sure URL specifies a file.
        if (verifiedUrl.getFile().length() < 2)
            return null;

        return verifiedUrl;
    }

    // Called when table row selection changes.
    private void tableSelectionChanged() {
    /* Unregister from receiving notifications
       from the last selected download. */
        if (selectedDownload != null)
            selectedDownload.deleteObserver(DownloadManager.this);

    /* If not in the middle of clearing a download,
       set the selected download and register to
       receive notifications from it. */
        if (!clearing) {
            selectedDownload =
                    tableModel.getDownload(table.getSelectedRow());
            selectedDownload.addObserver(DownloadManager.this);
            updateButtons();
        }
    }

    // Pause the selected download.
    private void actionPause(ActionEvent e) {
       
    selectedDownload.paused();
      updateButtons();
    }

    // Resume the selected download.
    private void actionResume() {
        selectedDownload.resumed();
        updateButtons();
    }

    // Cancel the selected download.
   
    private void actionCancel()
   	   {try{
   	   this.setVisible(false);
        selectedDownload.canceled();
        updateButtons();
       }
       catch(Exception e){System.out.println("error");} 
      }


    // Clear the selected download.
   /* private void actionClear() {
        clearing = true;
        tableModel.clearDownload(table.getSelectedRow());
        clearing = true;
        selectedDownload = null;
        updateButtons();
    }*/

  /* Update each button's state based off of the
     currently selected download's status. */
    private void updateButtons() {
        if (selectedDownload != null) {
            int status = selectedDownload.getStatus();
            switch (status) {
                case Download.DOWNLOADING:
                    pauseButton.setEnabled(true);
                    resumeButton.setEnabled(true);
                    cancelButton.setEnabled(true);
                    clearButton.setEnabled(true);
                    break;
                case Download.PAUSED:
                    pauseButton.setEnabled(false);
                    resumeButton.setEnabled(true);
                    cancelButton.setEnabled(true);
                    clearButton.setEnabled(true);
                    break;
                case Download.ERROR:
                    pauseButton.setEnabled(false);
                    resumeButton.setEnabled(true);
                    cancelButton.setEnabled(true);
                    clearButton.setEnabled(true);
                    break;
                default: // COMPLETE or CANCELLED
                    pauseButton.setEnabled(true);
                    resumeButton.setEnabled(true);
                    cancelButton.setEnabled(true);
                    clearButton.setEnabled(true);
            }
        } else {
            // No download is selected in table.
            pauseButton.setEnabled(true);
            resumeButton.setEnabled(true);
            cancelButton.setEnabled(true);
            clearButton.setEnabled(true);
        }
    }

  /* Update is called when a Download notifies its
     observers of any changes. */
    public void update(Observable o, Object arg) {
        // Update buttons if the selected download has changed.
        if (selectedDownload != null && selectedDownload.equals(o))
            updateButtons();
    }





    // Run the Download Manager.
    public static void main(String[] args) {
        DownloadManager manager = new DownloadManager();
        manager.show();
    }

}

class MyConnection {
  public static Connection getConnection() throws Exception {
    Driver d = (Driver)Class.forName
     ("sun.jdbc.odbc.JdbcOdbcDriver").newInstance();
    Connection c = DriverManager.getConnection("jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=./TS.mdb"
      );
    return c;
    /*
     To use an already defined ODBC Datasource :

        String URL = "jdbc:odbc:myDSN";
        Connection c = DriverManager.getConnection(URL, "user", "pwd");

    */
    }
}