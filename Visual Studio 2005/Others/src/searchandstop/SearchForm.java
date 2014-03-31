package searchandstop;

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
import javax.swing.SwingUtilities;

/**
 * Implementation of Iteration 2
 */
public class SearchForm extends JFrame implements ActionListener {

    private JButton dirButton = new JButton("Choose Directory");
    private JButton searchButton = new JButton("Search");
    private JButton cancelButton = new JButton("Cancel");
    private JTextArea area = new JTextArea();
    private JTextField tokenField = new JTextField("");
    private JLabel statusLabel = new JLabel("");
    private SearchThread sThread = null;

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
        cancelButton.addActionListener(this);
        cancelButton.setEnabled(false);
        JPanel southPanel = new JPanel();
        southPanel.setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
        southPanel.add(searchButton);
        southPanel.add(cancelButton);
        southPanel.add(statusLabel);

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

                searchButton.setEnabled(false);
                cancelButton.setEnabled(true);
                dirButton.setEnabled(false);
                tokenField.setEnabled(false);
                statusLabel.setText("Working ....");

                // Invoke the search on a different Thread
                File dirFile = new File(dirName);
                String token = tokenField.getText();
                sThread = new SearchThread(dirFile, token, this);
                sThread.start();
            }
        } else if (source == cancelButton) {
            sThread.interrupt();
        }

    }

    public void setTextArea(List javaFiles) {
        StringBuffer areaBuffer = new StringBuffer();
        Iterator fileIter = javaFiles.iterator();
        while (fileIter.hasNext()) {
            File file = (File) fileIter.next();
            areaBuffer.append(file.getAbsolutePath()).append('\n');
        }

        if ("".equals(areaBuffer.toString())) {
            areaBuffer.append("No Files Found !!!");
        }

        SwingUtilities.invokeLater(new SetAreaRunner(area, areaBuffer
                .toString()));
    }

    private class SetAreaRunner implements Runnable {
        private JTextArea area;

        private String text;

        public SetAreaRunner(JTextArea area, String text) {
            this.area = area;
            this.text = text;
        }

        public void run() {
            area.setText(text);

            searchButton.setEnabled(true);
            cancelButton.setEnabled(false);
            dirButton.setEnabled(true);
            tokenField.setEnabled(true);
            statusLabel.setText("");
            sThread = null;
        }
    }

}