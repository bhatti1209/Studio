package searchnothreads;

import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.util.Iterator;
import java.util.List;

import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;

/**
 * Implementation of Iteration1 
 */
public class SearchForm extends JFrame implements ActionListener {

    private JButton dirButton = new JButton("Choose Directory");
    private JButton searchButton = new JButton("Search");
    private JTextArea area = new JTextArea();
    private JTextField tokenField = new JTextField("");

    public SearchForm() {

        // set the initial size
        setSize(600, 300);

        // Exit the application on window close
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        ((JPanel) getContentPane()).setBorder(BorderFactory.createEmptyBorder(
                5, 5, 5, 5));

        // Construct the north panel with a titled border
        JPanel northPanel = new JPanel();
        northPanel.setBorder(BorderFactory.createCompoundBorder(BorderFactory
                .createTitledBorder("Choose a Directory and token"),
                BorderFactory.createEmptyBorder(5, 5, 5, 5)));
        northPanel.setLayout(new GridLayout(2, 2));
        dirButton.addActionListener(this);
        northPanel.add(new JLabel("Directory"));
        northPanel.add(dirButton);

        northPanel.add(new JLabel("Token"));
        northPanel.add(tokenField);

        // construct the label and set the border
        searchButton.addActionListener(this);
        JPanel southPanel = new JPanel();
        southPanel.setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
        southPanel.add(searchButton);

        // Add textarea to the center
        area.setEditable(false);

        // add the panels to the frame
        getContentPane().add("North", northPanel);
        getContentPane().add("Center", new JScrollPane(area));
        getContentPane().add("South", southPanel);
    }

    public static void main(String[] args) {
        SearchForm form = new SearchForm();
        form.setVisible(true);
    }

    /**
     * Act on the button click from the user
     */
    public void actionPerformed(ActionEvent e) {
        // open a file dialog and let the user choose a file
        Object source = e.getSource();

        if (source == dirButton) {
            JFileChooser chooser = new JFileChooser();
            chooser.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
            int value = chooser.showOpenDialog(this);
            if (value == JFileChooser.APPROVE_OPTION) {
                File file = chooser.getSelectedFile();
                dirButton.setText(file.getAbsolutePath());
            }
        } else if (source == searchButton) {

            String dirName = dirButton.getText();
            if (!"Choose Directory".equals(dirName)) {
                File dirFile = new File(dirName);
                FileFinder finder = new FileFinder(dirFile);
                List javaFiles = finder.findFiles(tokenField.getText());
                setTextArea(area, javaFiles);
            }
        }

    }

    private void setTextArea(JTextArea area, List javaFiles) {
        StringBuffer areaBuffer = new StringBuffer();
        Iterator fileIter = javaFiles.iterator();
        while (fileIter.hasNext()) {
            File file = (File) fileIter.next();
            areaBuffer.append(file.getName()).append('\n');
        }

        if ("".equals(areaBuffer.toString())) {
            areaBuffer.append("No Files Found !!!");
        }

        area.setText(areaBuffer.toString());

    }
}