package searchframework;

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
 * Implementation of Iteration 5
 */
public class SearchForm extends JFrame implements ActionListener, WorkListener {

    private JButton dirButton = new JButton("Choose Directory");
    private JTextField tokenField = new JTextField("");
    private JTextArea area = new JTextArea();

    private JButton searchButton = new JButton("Search");
    private JButton cancelButton = new JButton("Cancel");
    private JButton pauseButton = new JButton("Pause");
    private JButton resumeButton = new JButton("Resume");

    private JLabel statusLabel = new JLabel("");
    private WorkerThread sThread = null;

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
        pauseButton.addActionListener(this);
        resumeButton.addActionListener(this);

        initializeFieldsToStart();

        JPanel southPanel = new JPanel();
        southPanel.setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
        southPanel.add(searchButton);
        southPanel.add(cancelButton);
        southPanel.add(pauseButton);
        southPanel.add(resumeButton);
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

    private void initializeFieldsToStart() {
        searchButton.setEnabled(true);
        cancelButton.setEnabled(false);
        pauseButton.setEnabled(false);
        resumeButton.setEnabled(false);
        dirButton.setEnabled(true);
        tokenField.setEnabled(true);
    }

    private void initializeFieldsToStop() {
        searchButton.setEnabled(false);
        resumeButton.setEnabled(false);
        cancelButton.setEnabled(true);
        pauseButton.setEnabled(true);
        dirButton.setEnabled(false);
        tokenField.setEnabled(false);
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

                initializeFieldsToStop();
                statusLabel.setText("Working ....");

                // Invoke the search on a different Thread
                File dirFile = new File(dirName);
                String token = tokenField.getText();

                Work searchWork = new TokenSearchWork(dirFile, token);
                sThread = new WorkerThread(searchWork, this);
                sThread.start();
            }
        } else if (source == cancelButton) {
            if (sThread != null) {
                sThread.interrupt();
            }
        } else if (source == pauseButton) {
            if (sThread != null) {
                sThread.pauseWork();
                pauseButton.setEnabled(false);
                resumeButton.setEnabled(true);
            }
        } else if (source == resumeButton) {
            if (sThread != null) {
                sThread.resumeWork();
                pauseButton.setEnabled(true);
                resumeButton.setEnabled(false);
            }
        }

    }

    public void handleProgress(List output, int percentDone, boolean done) {
        StringBuffer areaBuffer = new StringBuffer();
        Iterator fileIter = output.iterator();
        while (fileIter.hasNext()) {
            List files = (List) fileIter.next();
            for (int j = 0; j < files.size(); j++) {
                areaBuffer.append(((File) files.get(j)).getAbsolutePath())
                        .append('\n');
            }
        }

        SwingUtilities.invokeLater(new SetAreaRunner(area, areaBuffer
                .toString(), percentDone, done));
    }

    private class SetAreaRunner implements Runnable {
        private JTextArea area;

        private String text;

        private int percent;

        private boolean done;

        public SetAreaRunner(JTextArea area, String text, int percent,
                boolean done) {
            this.area = area;
            this.text = text;
            this.percent = percent;
            this.done = done;
        }

        public void run() {
            area.setText(text);
            statusLabel.setText("    Working ... " + percent + "%");

            if (done) {
                initializeFieldsToStart();
                if (percent == 100)
                    statusLabel.setText("");
                else
                    statusLabel.setText("   Cancelled at " + percent + "%");

                sThread = null;
            }
        }

    }

}