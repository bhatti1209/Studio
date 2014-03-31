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

public class Scheduler extends JFrame 
{
	
	//code added
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


	private Thread thread;

    public  int speed =3072;
    URL url; // download URL
    int size; // size of download in bytes
    int downloaded; // number of bytes downloaded
    int status; // current status of download
    int timeleft;//total time taken for the download
    int timereq;//time left for the download
    

	//code ended
    private JTextField jTextField1 = new JTextField();

    SimpleDateFormat sdf2 = new SimpleDateFormat("H");
    SimpleDateFormat sdf3 = new SimpleDateFormat("m");
    SimpleDateFormat sdf4 = new SimpleDateFormat("d") ;
    SimpleDateFormat sdf5 = new SimpleDateFormat("MMMM");
    SimpleDateFormat sdf6 = new SimpleDateFormat("yyyy");
    //Calendar cal =new GregorianCalendar(TimeZone.getTimeZone("India"));
    Calendar cal =new GregorianCalendar();
    String Hours=sdf2.format(cal.getTime());
    String Minutes = sdf3.format(cal.getTime());


     String d = sdf4.format(cal.getTime())+" "+sdf5.format(cal.getTime())+" "+sdf6.format(cal.getTime());
      public static String DATESTRING="";


    private JLabel jLabel1 = new JLabel();

    private JTextField jTextField2 = new JTextField();

    private JLabel jLabel2 = new JLabel();

    private JLabel jLabel3 = new JLabel();

    private JLabel jLabel4 = new JLabel();

    private JButton jButton1 = new JButton();


    static JTextField jTextField3 = new JTextField(30);

    private JLabel jLabel5 = new JLabel();

    private JLabel jLabel6 = new JLabel();

    private JLabel jLabel7 = new JLabel();


    private JComboBox jComboBox1 = new JComboBox();

    private JComboBox jComboBox2 = new JComboBox();

    private JButton jButton2 = new JButton();

    private JButton jButton3 = new JButton();

    public Scheduler()
    {
        try
        {
            jbInit();
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }
	public Scheduler(int x)
	{

    }
    public static void main(String[] args)
    {
        Scheduler scheduler = new Scheduler();
    }

    private void jbInit() throws Exception
    {
        this.getContentPane().setLayout(null);
        this.setSize(new Dimension(480, 350));
        this.setTitle("Schedule Download");
        jTextField1.setBounds(new Rectangle(95, 50, 260, 25));
        jLabel1.setText("URL");
        jLabel1.setBounds(new Rectangle(15, 50, 70, 25));
        jTextField2.setBounds(new Rectangle(95, 90, 260, 25));
        jLabel2.setText("Description");
        jLabel2.setBounds(new Rectangle(15, 90, 70, 25));
        jLabel3.setText("Schedule Download");
        jLabel3.setBounds(new Rectangle(110, 5, 235, 35));
        jLabel3.setFont(new Font("Tahoma", 1, 14));
        jLabel3.setForeground(new Color(80, 20, 220));
        jLabel4.setText("Select Date and Time To Launch Download");
        jLabel4.setBounds(new Rectangle(20, 145, 395, 50));
        jLabel4.setForeground(new Color(80, 20, 220));
        jLabel4.setFont(new Font("Tahoma", 0, 12));
        jButton1.setText("Date Picker");
        jButton1.setBounds(new Rectangle(20, 210, 100, 25));
        jButton1.setToolTipText("Click Here To Pick Date");
        jButton1.addActionListener(new ActionListener()
        {
        	public void actionPerformed(ActionEvent e)
            {
                 jButton1_actionPerformed(e);
            }
        }
        );
        jTextField3.setBounds(new Rectangle(160, 210, 100, 25));
        jLabel5.setText("Time");
        jLabel5.setBounds(new Rectangle(300, 205, 40, 30));
        jLabel5.setFont(new Font("Tahoma", 1, 12));
        jLabel6.setText("Hours");
        jLabel6.setBounds(new Rectangle(355, 180, 45, 30));
        jLabel6.setFont(new Font("Tahoma", 0, 12));
        jLabel7.setText("Minutes");
        jLabel7.setBounds(new Rectangle(420, 180, 55, 30));
        jLabel7.setFont(new Font("Tahoma", 0, 12));
        jTextField3.setEnabled(false);
        jTextField3.setText(d);
        jComboBox1.setBounds(new Rectangle(350, 210, 40, 20));



        jComboBox1.setToolTipText("Enter Hours");
        jComboBox1.addItem("0");
        jComboBox1.addItem("1");
        jComboBox1.addItem("2");
        jComboBox1.addItem("3");
        jComboBox1.addItem("4");
        jComboBox1.addItem("5");
        jComboBox1.addItem("6");
        jComboBox1.addItem("7");
        jComboBox1.addItem("8");
        jComboBox1.addItem("9");
        jComboBox1.addItem("10");
        jComboBox1.addItem("11");
        jComboBox1.addItem("12");
        jComboBox1.addItem("13");
        jComboBox1.addItem("14");
        jComboBox1.addItem("15");
        jComboBox1.addItem("16");
        jComboBox1.addItem("17");
        jComboBox1.addItem("18");
        jComboBox1.addItem("19");
        jComboBox1.addItem("20");
        jComboBox1.addItem("21");
        jComboBox1.addItem("22");
        jComboBox1.addItem("23");
         jComboBox1.setSelectedItem(this.Hours);

        jComboBox2.setBounds(new Rectangle(420, 210, 40, 20));
        jComboBox2.setAutoscrolls(true);
        //jComboBox2.setEditable(true);
        jComboBox2.setToolTipText("Enter Minutes ");
        jComboBox2.addItem("0");
        jComboBox2.addItem("1");
        jComboBox2.addItem("2");
        jComboBox2.addItem("3");
        jComboBox2.addItem("4");
        jComboBox2.addItem("5");
        jComboBox2.addItem("6");
        jComboBox2.addItem("7");
        jComboBox2.addItem("8");
        jComboBox2.addItem("9");
        jComboBox2.addItem("10");
        jComboBox2.addItem("11");
        jComboBox2.addItem("12");
        jComboBox2.addItem("13");
        jComboBox2.addItem("14");
        jComboBox2.addItem("15");
        jComboBox2.addItem("16");
        jComboBox2.addItem("17");
        jComboBox2.addItem("18");
        jComboBox2.addItem("19");
        jComboBox2.addItem("20");
        jComboBox2.addItem("21");
        jComboBox2.addItem("22");
        jComboBox2.addItem("23");

        jComboBox2.addItem("24");
        jComboBox2.addItem("25");
        jComboBox2.addItem("26");
        jComboBox2.addItem("27");

        jComboBox2.addItem("28");
        jComboBox2.addItem("29");
        jComboBox2.addItem("30");
        jComboBox2.addItem("31");
        jComboBox2.addItem("32");
        jComboBox2.addItem("33");
        jComboBox2.addItem("34");
        jComboBox2.addItem("35");
        jComboBox2.addItem("36");
        jComboBox2.addItem("37");
        jComboBox2.addItem("38");
        jComboBox2.addItem("39");
        jComboBox2.addItem("40");
        jComboBox2.addItem("41");
        jComboBox2.addItem("42");
        jComboBox2.addItem("43");
        jComboBox2.addItem("44");
        jComboBox2.addItem("45");
        jComboBox2.addItem("46");
        jComboBox2.addItem("47");
        jComboBox2.addItem("48");
        jComboBox2.addItem("49");
        jComboBox2.addItem("50");
        jComboBox2.addItem("51");
        jComboBox2.addItem("52");
        jComboBox2.addItem("53");
        jComboBox2.addItem("54");
        jComboBox2.addItem("55");
        jComboBox2.addItem("56");
        jComboBox2.addItem("57");
        jComboBox2.addItem("58");
        jComboBox2.addItem("59");
        jComboBox2.setSelectedItem(this.Minutes);
           jButton2.setText("Schedule");
        jButton2.setBounds(new Rectangle(75, 260, 90, 25));
        jButton2.addActionListener(new ActionListener() {
                                       public void actionPerformed(ActionEvent e) {
                                           jButton2_actionPerformed(e);
                                       }
                                   }
        );
        jButton3.setText("Close");
        jButton3.setBounds(new Rectangle(250, 260,90, 25));
        jButton3.addActionListener(new ActionListener() {
                                       public void actionPerformed(ActionEvent e) {
                                           jButton3_actionPerformed(e);
                                       }
                                   }
        );
        this.getContentPane().add(jButton3, null);
        this.getContentPane().add(jButton2, null);
        this.getContentPane().add(jComboBox2, null);
        this.getContentPane().add(jComboBox1, null);
        this.getContentPane().add(jLabel7, null);
        this.getContentPane().add(jLabel6, null);
        this.getContentPane().add(jLabel5, null);
        this.getContentPane().add(jTextField3, null);
        this.getContentPane().add(jButton1, null);
        this.getContentPane().add(jLabel4, null);
        this.getContentPane().add(jLabel3, null);
        this.getContentPane().add(jLabel2, null);
        this.getContentPane().add(jTextField2, null);
        this.getContentPane().add(jLabel1, null);
        this.getContentPane().add(jTextField1, null);
        this.setVisible(true);
    }

    private void jButton1_actionPerformed(ActionEvent e) 
    {

    DatePickerSimple dp = new DatePickerSimple();
    dp.setSize(400,270);
    dp.setVisible(true);


    }



    private void jButton2_actionPerformed(ActionEvent e)
     {

try
{

       String url = jTextField1.getText();
       String desc =  jTextField2.getText();
       String s_date =   jTextField3.getText();

       String hr = jComboBox1.getSelectedItem().toString();
       String min = jComboBox2.getSelectedItem().toString();
    System.out.println("Url= "+url);
    System.out.println("Desc= "+desc);
    System.out.println("date= "+s_date);
    System.out.println("hour "+hr);
    System.out.println("min "+min);
    StringTokenizer st = new StringTokenizer(s_date," ");
     String[] dt = new String[3];
    for(int i =0;i<3; i++)
    	{
    		dt[i] = st.nextToken();
    		System.out.println(dt[i]);
    	}
    int dayofmonth = Integer.parseInt(dt[0]);
    int month =1;
    if(dt[1].equals("January"))
    month=0;
       if(dt[1].equals("Febuary"))
    month=1;
        if(dt[1].equals("March"))
    month=2;
        if(dt[1].equals("April"))
    month=3;
        if(dt[1].equals("May"))
    month=4;
        if(dt[1].equals("June"))
    month=5;
        if(dt[1].equals("July"))
    month=6;
        if(dt[1].equals("August"))
    month=7;
        if(dt[1].equals("September"))
    month=8;
        if(dt[1].equals("October"))
    month=9;
        if(dt[1].equals("November"))

    month=10;
        if(dt[1].equals("December"))
        

    month=11;
    
    System.out.println("Month ="+ month);
    int year = Integer.parseInt(dt[2]);
    int hour = Integer.parseInt(hr);
    int minute =Integer.parseInt(min);
    Timer timer = new Timer();
    System.out.println("day of month "+dayofmonth+"Month "+month+"Year "+year+"hour "+hour+"minute "+minute);
   // Calendar date = new GregorianCalendar(TimeZone.getTimeZone("GMT-5"));
   Calendar date = new GregorianCalendar();
    date.set(Calendar.DAY_OF_MONTH,dayofmonth);
    date.set(Calendar.MONTH,month);
    date.set(Calendar.YEAR,year);
    date.set(Calendar.HOUR, hour);
    date.set(Calendar.MINUTE, minute);

   // Calendar date2 = new GregorianCalendar();
     Calendar date2 = new GregorianCalendar();
   //  date2.setTimeZone(new  )

    ReminderBeep.add=url;
   // timer.schedule(new ScheduleTimer(url),date.getTime(),1000 * 60 * 60 * 24 * 7);
   System.out.println("date month "+date.get(Calendar.MONTH));
   System.out.println("date2 month "+date2.get(Calendar.MONTH));
    int yeardiff= date.get(Calendar.YEAR)-date2.get(Calendar.YEAR);
    int monthdiff=date.get(Calendar.MONTH)-date2.get(Calendar.MONTH);
    int daydiff=date.get(Calendar.DAY_OF_MONTH)-date2.get(Calendar.DAY_OF_MONTH);
    int hourdiff=date.get(Calendar.HOUR)-date2.get(Calendar.HOUR);
    int mindiff =date.get(Calendar.MINUTE)-date2.get(Calendar.MINUTE) ;
    int seconds = (mindiff*60)+(hourdiff*60*60)+(daydiff*24*60*60)+(monthdiff*30*24*60*60)+(yeardiff*360*24*60*60);
   //Date dat = date.getTime()-date2.getTime();

   System.out.println("Executing after "+yeardiff+" years "+monthdiff+" months "+(daydiff-1)+" days "+hourdiff+" hours "+mindiff+" minutes ");
  System.out.println("Executing after "+ seconds);
  if(yeardiff<0)
  {
JOptionPane.showMessageDialog(null,"Scheduling Failed..!! invalid Date", "Scheduling Failed", JOptionPane.ERROR_MESSAGE );

  	this.setVisible(false);
  return;
  }
  if(monthdiff<0)
  {
monthdiff =date2.get(Calendar.MONTH)-date.get(Calendar.MONTH);

  }
   if(daydiff<0)
  {
daydiff =date2.get(Calendar.DAY_OF_MONTH)-date.get(Calendar.DAY_OF_MONTH);

  }
 if(hourdiff<0)
  {
hourdiff =date2.get(Calendar.HOUR)-date.get(Calendar.HOUR);

  }
  if(mindiff<0)
  {
mindiff =date2.get(Calendar.MINUTE)-date.get(Calendar.MINUTE);

  }

   System.out.println("Executing after "+yeardiff+" years "+monthdiff+" months "+(daydiff-1)+" days "+hourdiff+" hours "+mindiff+" minutes ");

  new ReminderBeep(seconds);

     JOptionPane.showMessageDialog(null,"Scheduling Succesfull!"+" Executing after "+yeardiff+" years "+monthdiff+" months "+(daydiff-1)+" days "+hourdiff+" hours "+mindiff+" minutes ", "Scheduling Success", JOptionPane.INFORMATION_MESSAGE );
this.setVisible(false);
  //  timer.s

    }
    
    
    
    
    catch(Exception ex)
   {
   	JOptionPane.showMessageDialog(null,"Sorry ..Scheduling Failed..!!"+ex, "Scheduling Failed", JOptionPane.ERROR_MESSAGE );
   }
   
   
    private void jButton3_actionPerformed(ActionEvent e) {

this.setVisible(false);



    }
 
 
    //code added
public Scheduler(URL url)
    {
        this.url = url;
        size = -1;
        downloaded = 0;
        status = DOWNLOADING;

        // Begin the download.
        download();
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
    public void pause()
    {
    	
    	//error();
    	
    //	try
      //{
      
      // Thread thread = new Thread(this);
		//Thread.sleep(44000);
	//	}
//    	catch(InterruptedException e){ }
        status = PAUSED;
        stateChanged();
    }

    // Resume this download.
    public void resume()
    {
    	downloaded = 1;
    	
        status = DOWNLOADING;
        stateChanged();
        download();
    }

    // Cancel this download.
    public void cancel()
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


//code ended
   
    }

   
}


