import java.io.*;
import java.net.*;
import java.util.*;
import javax.swing.*;
import java.awt.*;



class Multithreading implements Runnable
{	String name;
	Thread t;
	Download d;
	
	
	
	 Multithreading(String threadname)
	 {	
		name=threadname;
		t=new Thread(this,name);
		t.start();
	 }
	 public void run()
	 {
	 	//Download d=new Download();
	 	d.run();
	 	System.out.println((Thread.currentThread()).getName()
+" thread here...");

	 }
	 public static void main(String args[])
	 {
	 		Multithreading obj1=new Multithreading("one");
	 		Multithreading obj2=new Multithreading("two");
	 		Multithreading obj3=new Multithreading("three");
	 	
	 }
}
