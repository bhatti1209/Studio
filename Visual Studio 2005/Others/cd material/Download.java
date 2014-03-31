import java.io.*;
import java.net.*;
import java.util.*;
import javax.swing.*;
import java.awt.*;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Rectangle;
import java.text.*;
import java.util.Date;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.*;
import java.util.*;
import javax.swing.JButton;
import javax.swing.JOptionPane;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;


// This class downloads a file from a URL.
class Download extends Observable implements Runnable  {

	//
	
    // Max size of download buffer.
    private static final int MAX_BUFFER_SIZE = 1024;


    // These are the status names.
    public static final String STATUSES[] = {"Downloading",
    "Paused", "Complete", "Cancelled", "Error"};
 public static String Server ="172.16.73.12";
  public static  String Port ="3128";
    // These are the status codes.
    public static final int DOWNLOADING = 0;
    public static final int PAUSED = 1;
    public static final int COMPLETE = 2;
    public static final int CANCELLED = 3;
    public static final int ERROR = 4;
	public static final int RESUME = 5;

	private Thread thread;

    public  int speed =3072;
    URL url; // download URL
    int size; // size of download in bytes
    int downloaded; // number of bytes downloaded
    int status; // current status of download
    int timeleft;//total time taken for the download
    int timereq;//time left for the download

    // Constructor for Download.
    public Download(URL url)
    {
        this.url = url;
        size = -1;
        downloaded = 0;
        status = DOWNLOADING;
        
        // Begin the download.
        //download();
       // f.setVisible(true);
    }

    // Get this download's URL.
    public String getUrl()
    {
        return url.toString();
    }

    // Get this download's size.
    public int getSize()
    {
        return size;
    }

    // Get this download's progress.
    public float getProgress()
    {
       //SplashIcon.speed=speed;
        //SplashIcon.jb.setToolTipText(speed+"bytes/sec") ;
       

        int i = downloaded;
      


      try
      {
      
        Thread.sleep(2000);
        speed =(i+downloaded)/(2*1024);
        
        //SplashIcon.speed=speed;
        // SplashIcon.jb.setToolTipText(speed+"Kbps");
          
       
      }
      catch(Exception e){
      }
        return ((float) downloaded / size) * 100;
    }

	public float getSpeed()
	{
        return ((float) downloaded / size) ;
    }
    // Get this download's status.
    public int getStatus()
    {
        return status;
    }


    // Pause this download.
    public synchronized void paused()
    {
        status = PAUSED;
        //stateChanged();
        notify();
    }

    // Resume this download.
    public synchronized void resumed()
    {    
    downloaded=1;	
        status = DOWNLOADING;
        //stateChanged();
        
        
        notify();
        download();
    }

    // Cancel this download.
    public void canceled()
    {
        status = CANCELLED;
        stateChanged();
    }

    // Mark this download as having an error.
    private void error()
    {
        status = ERROR;
        stateChanged();
    }
    public int getTimerequired()
    {
			
       
       		int speed1=3072;	
				
    	timereq=size/speed1;

        return timereq;
    }

	public int getTimeleft()
    {
			int sizeleft=0;
       int speed1=3072;
       				sizeleft=size-downloaded;
				timeleft=sizeleft/speed1;
    	

        return timeleft;
    }
    // Start or resume downloading.
    private void download()
    {
        Thread thread = new Thread(this);
        thread.start();
    }

    // Get file name portion of URL.
    private String getFileName(URL url)
    {
        String fileName = url.getFile();
        return fileName.substring(fileName.lastIndexOf('/') + 1);
    }

    // Download file.
    public void run()
    {
        RandomAccessFile file = null;
        InputStream stream = null;

        try {
			System.getProperties().put("proxySet","true");
			System.getProperties().put("proxyPort",Download.Port);
           System.getProperties().put("proxyHost",Download.Server);
            // Open connection to URL.
            HttpURLConnection connection =
                    (HttpURLConnection) url.openConnection();

            // Specify what portion of file to download.
            connection.setRequestProperty("Range",
                    "bytes=" + downloaded + "-");

            // Connect to server.
            connection.connect();

            // Make sure response code is in the 200 range.
            if (connection.getResponseCode() / 100 != 2)
            {
                error();
            }

            // Check for valid content length.
            int contentLength = connection.getContentLength();
            if (contentLength < 1)
            {
                error();
            }

      /* Set the size for this download if it
         hasn't been already set. */
            if (size == -1)
            {
                size = contentLength;
                stateChanged();
            }

            // Open file and seek to the end of it.
            file = new RandomAccessFile(getFileName(url), "rw");
            file.seek(downloaded);

            stream = connection.getInputStream();
            while (status == DOWNLOADING)
            {
        /* Size buffer according to how much of the
           file is left to download. */
           		
           		waitIfPauseRequest();
           		
           		byte buffer[];
                if (size - downloaded > MAX_BUFFER_SIZE)
                {
                    buffer = new byte[MAX_BUFFER_SIZE];
                }
                else
                {
                    buffer = new byte[size - downloaded];
                }

                // Read from server into buffer.
                int read = stream.read(buffer);
                if (read == -1)
                    break;

                // Write buffer to file.
                file.write(buffer, 0, read);
                downloaded += read;
                stateChanged();
            }

      /* Change status to complete if this point was
         reached because downloading has finished. */
            if (status == DOWNLOADING)
            {
                status = COMPLETE;
                stateChanged();
            }
        } catch (Exception e) {
            error();
        }
        finally
        {
            // Close file.
            if (file != null) {
                try {
                    file.close();
                } catch (Exception e) {}
            }

            // Close connection to server.
            if (stream != null) {
                try {
                    stream.close();
                } catch (Exception e) {}
            }
        }
    }

    // Notify observers that this download's status has changed.
    private void stateChanged() {
        //setChanged();
      //  notifyObservers();
    }
    
    private void waitIfPauseRequest() throws InterruptedException {
        synchronized (this) {
            if (status == PAUSED) {
                while (status != DOWNLOADING) {
                    wait();
                }

                status = DOWNLOADING;
                //download();
            }
        }
    }

}





