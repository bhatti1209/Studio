import java.awt.*;
import java.io.*;
import java.sql.*;
import java.util.*;
import javax.swing.*;
import javax.swing.table.*;

public class TableFromDatabase
{

    public TableFromDatabase()
    {
        JFrame f =  new JFrame();
        Container c = f.getContentPane();

        Vector columnNames = new Vector();
        Vector data = new Vector();

        try
        {
            Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");	
        	Connection connection = MyConnection.getConnection();
/*
 						DriverManager.registerDriver (new oracle.jdbc.driver.OracleDriver ());
						Connection connection = DriverManager.getConnection ("jdbc:oracle:oci8:@" + "","scott","tiger");
*/



            String sql = "Select * from Table1";
            Statement stmt = connection.createStatement();
            ResultSet rs = stmt.executeQuery( sql );
            ResultSetMetaData md = rs.getMetaData();
            int columns = md.getColumnCount();

            //  Get column names

            for (int i = 1; i <= columns; i++)
            {
                columnNames.addElement( md.getColumnName(i) );
            }

            //  Get row data

            while (rs.next())
            {
                Vector row = new Vector(columns);

                for (int i = 1; i <= columns; i++)
                {
                    row.addElement( rs.getObject(i) );
                }

                data.addElement( row );
            }

            rs.close();
            stmt.close();
        }
        catch(Exception e)
        {
            System.out.println( e );
        }

        //  Create table with database data

        JTable table = new JTable(data, columnNames);

        JScrollPane scrollPane = new JScrollPane( table );
        c.add( scrollPane );

        JPanel buttonPanel = new JPanel();
        c.add( buttonPanel, BorderLayout.SOUTH );
        f.pack();
        f.setVisible(true);
    }

    public static void main(String[] args)
    {
        TableFromDatabase frame = new TableFromDatabase();
        //frame.setDefaultCloseOperation( EXIT_ON_CLOSE );

    }
}

