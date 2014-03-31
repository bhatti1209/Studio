package searchpauseresume;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

public class SearchThread extends Thread {

    private static final int NORMAL = 0;
    private static final int PAUSE  = 1;
    private static final int RESUME = 2;

    private File rootDir;
    private String token;
    private SearchForm form;

    private int request = NORMAL; // 1- Pause, 2 - Resume

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

                waitIfPauseRequest();

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

    private void waitIfPauseRequest() throws InterruptedException {
        synchronized (this) {
            if (request == PAUSE) {
                while (request != RESUME) {
                    wait();
                }

                request = NORMAL;
            }
        }
    }

    public synchronized void pauseWork() {
        request = PAUSE;
        notify();
    }

    public synchronized void resumeWork() {
        if (request == PAUSE) {
            request = RESUME;
            notify();
        }
    }

}
