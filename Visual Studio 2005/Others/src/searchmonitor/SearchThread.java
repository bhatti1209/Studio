package searchmonitor;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

public class SearchThread extends Thread {

    private File rootDir;
    private String token;
    private SearchForm form;

    public SearchThread(File rootDir, String token, SearchForm form) {
        this.rootDir = rootDir;
        this.token = token;
        this.form = form;
    }

    public void run() {

        List allFiles = new ArrayList();
        TokenSearchWork work = new TokenSearchWork(rootDir);
        int percentDone = 0;
        try {
            List allDirs = work.getAllDirectories();
            int sizeWork = allDirs.size();

            for (int j = 0; j < allDirs.size(); j++) {

                File directory = (File) allDirs.get(j);
                allFiles.addAll(work.findFilesInDirectory(directory, token));

                percentDone = 100 * (j + 1) / sizeWork;
                form.setTextArea(allFiles, percentDone, false);
            }
        } catch (InterruptedException intExp) {
            // The Task was interrupted
        }

        form.setTextArea(allFiles, percentDone, true);

    }

}
