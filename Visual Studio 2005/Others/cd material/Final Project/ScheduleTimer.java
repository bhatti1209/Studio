import java.util.Calendar;
import java.util.Date;
import java.util.Timer;
import java.util.TimerTask;

public class ScheduleTimer extends TimerTask {
String url2="";
public ScheduleTimer(String url)
{   System.out.println("Running");
	url2=url;
	System.out.println(url2);
}

  public void run() {
  	System.out.println("Scheduled Task Running");
    DownloadManager dm = new DownloadManager();
    dm.setSize(600,400);
    dm.setVisible(true);
    dm.actionAdd2(url2);
   
  }

}