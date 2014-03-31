package searchandstop;

import java.io.File;
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
        FileFinder finder = new FileFinder(rootDir);
        List javaFiles = finder.findFiles(token);
        form.setTextArea(javaFiles);
    }

}
