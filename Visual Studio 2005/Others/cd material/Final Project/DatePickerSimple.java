import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.text.*;
import java.util.Date;
class DatePickerSimple extends JFrame
{
  JButton[] btn = new JButton[49];
  int month = java.util.Calendar.getInstance().get(java.util.Calendar.MONTH);
  int year = java.util.Calendar.getInstance().get(java.util.Calendar.YEAR);;
  JLabel lbl = new JLabel("",JLabel.CENTER);
   public String Hours="8";
   public String Minutes="10";


  public DatePickerSimple()
  {
    buildGUI();
    setDates();
  }
  public DatePickerSimple(int x)
    {

  }
  public void buildGUI()
  {
    setLocation(300,100);
    //setDefaultCloseOperation(EXIT_ON_CLOSE);
    String[] header = {"Sun","Mon","Tue","Wed","Thur","Fri","Sat"};
    JPanel midPanel = new JPanel(new GridLayout(7,7));
    midPanel.setPreferredSize(new Dimension(400,100));
    for(int x = 0; x < btn.length; x++)
    {
      final int selection = x;
      btn[x] = new JButton();
      btn[x].setFocusPainted(false);
      if(x>6)btn[x].addActionListener(new ActionListener(){
        public void actionPerformed(ActionEvent ae){
         displayDatePicked(btn[selection].getActionCommand());
          //  this.setVisible(false);
        //  Scheduler
          }});
      if(x < 7){btn[x].setFont(new Font("Lucida",Font.PLAIN,10)); btn[x].setText(header[x]);}
      midPanel.add(btn[x]);
    }
    JPanel lowPanel = new JPanel(new GridLayout(1,3));
    lowPanel.setPreferredSize(new Dimension(10,20));
    JButton prevBtn = new JButton("<< Previous");
    prevBtn.addActionListener(new ActionListener(){
      public void actionPerformed(ActionEvent ae){
        month--;setDates();}});
    lowPanel.add(prevBtn);
    lowPanel.add(lbl);
    JButton nextBtn = new JButton("Next >>");
    nextBtn.addActionListener(new ActionListener(){
      public void actionPerformed(ActionEvent ae){
        month++;setDates();}});
    lowPanel.add(nextBtn);
    getContentPane().add(midPanel,BorderLayout.CENTER);
    getContentPane().add(lowPanel,BorderLayout.SOUTH);
    pack();
  }
  public void setDates()
  {
    for(int x = 7; x < btn.length; x++)
    btn[x].setText("");
    java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("MMMM yyyy");
    java.util.Calendar cal = java.util.Calendar.getInstance();
    cal.set(year,month,1);
    int dayOfWeek = cal.get(java.util.Calendar.DAY_OF_WEEK);
    int daysInMonth = cal.getActualMaximum(java.util.Calendar.DAY_OF_MONTH);
    for(int x = 6+dayOfWeek,day = 1; day <= daysInMonth; x++,day++)
    btn[x].setText(""+day);
    lbl.setText(sdf.format(cal.getTime()));
    setTitle("Date Picker  - "+lbl.getText());
  }
  public void displayDatePicked(String day)
  {
    if(day.equals("") == false)
    {
      java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("d");
      java.text.SimpleDateFormat sdf1 = new java.text.SimpleDateFormat("MMMM");
      java.text.SimpleDateFormat sdf5 = new java.text.SimpleDateFormat("yyyy");
      java.text.SimpleDateFormat sdf2 = new java.text.SimpleDateFormat("H");
      java.text.SimpleDateFormat sdf3 = new java.text.SimpleDateFormat("m");
     // java.util.Calendar cal =new java.util.GregorianCalendar(java.util.TimeZone.getTimeZone("India"));
      java.util.Calendar cal =new java.util.GregorianCalendar();
      cal.set(year,month,Integer.parseInt(day));
   int da =Integer.parseInt(sdf.format(cal.getTime()))-0;
      JOptionPane.showMessageDialog(this,"You picked "+da+" "+sdf1.format(cal.getTime())+" "+sdf5.format(cal.getTime()));
this.setVisible(false);


      String xyz= da+" "+sdf1.format(cal.getTime())+" "+sdf5.format(cal.getTime());
      //Scheduler sch = new Scheduler(1);
     // sch.jTextField3.setText(sdf.format(cal.getTime())+"");
     Scheduler.DATESTRING = xyz;
     System.out.println(Scheduler.DATESTRING);
     String txt = Scheduler.DATESTRING;
     Scheduler.jTextField3.setText(txt);
      DatePickerSimple dps = new DatePickerSimple(1);
    this.setVisible(false);//dps.
    }
  }




  public static void main(String[] args){new DatePickerSimple().setVisible(true);}
}
