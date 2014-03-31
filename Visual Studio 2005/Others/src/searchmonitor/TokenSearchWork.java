package searchmonitor;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileFilter;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.List;

public class TokenSearchWork {

    private File rootDir;

    public TokenSearchWork(File rootDir) {
        this.rootDir = rootDir;
    }

    public List getAllDirectories() throws InterruptedException {
        return findDirs(rootDir);
    }

    private List findDirs(File directory) throws InterruptedException {

        checkForInterrupt();

        List foundDirs = new ArrayList();
        FileFilter dirFilter = new FileFilter() {
            public boolean accept(File file) {
                return file.isDirectory();
            }
        };

        File[] directories = directory.listFiles(dirFilter);
        if (directories != null) {
            for (int j = 0; j < directories.length; j++) {
                foundDirs.addAll(findDirs(directories[j]));
                foundDirs.add(directories[j]);
            }
        }

        return foundDirs;
    }

    public List findFilesInDirectory(File directory, String token)
            throws InterruptedException {
        List foundFiles = new ArrayList();
        FileFilter filter = new FileFilter() {
            public boolean accept(File file) {
                String fullPath = file.getAbsolutePath();
                return (file.isFile() && fullPath.endsWith(".java"));
            }
        };

        File[] javaFiles = directory.listFiles(filter);
        if (javaFiles != null) {
            for (int j = 0; j < javaFiles.length; j++) {

                checkForInterrupt();

                File javaFile = javaFiles[j];
                if (tokenInFile(javaFile, token)) {
                    foundFiles.add(javaFile);
                }
            }
        }

        return foundFiles;
    }

    private boolean tokenInFile(File javaFile, String token) {

        BufferedReader reader = null;
        try {
            reader = new BufferedReader(new FileReader(javaFile));
            String line = null;
            while ((line = reader.readLine()) != null) {
                if (line.indexOf(token) != -1) {
                    return true;
                }
            }
        } catch (Exception anyExp) {
            return false;
        } finally {
            if (reader != null) {
                try {
                    reader.close();
                } catch (Exception exp) {
                }
            }
        }

        return false;
    }

    private void checkForInterrupt() throws InterruptedException {
        if (Thread.currentThread().isInterrupted()) {
            throw new InterruptedException("Interrupted !!!");
        }
    }

}
