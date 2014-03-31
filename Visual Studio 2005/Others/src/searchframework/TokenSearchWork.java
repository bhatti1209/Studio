package searchframework;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileFilter;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.List;

import searchframework.Work.WorkKey;

public class TokenSearchWork implements Work {

    private File rootDir;
    private String token;
    private List allWork = new ArrayList();

    public TokenSearchWork(File rootDir, String token) {
        this.rootDir = rootDir;
        this.token = token;
    }

    public List scopeWork() throws InterruptedException {
        List workKeys = new ArrayList();

        this.allWork = findDirs(rootDir);
        int totalWork = this.allWork.size();
        for (int j = 0; j < totalWork; j++) {
            workKeys.add(new WorkKey(j, (j + 1) * 100 / totalWork));
        }

        return workKeys;
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

    public Object doWork(WorkKey key) throws InterruptedException {
        int workIndex = key.getID();
        File dirPath = (File) allWork.get(workIndex);
        List files = findFilesInDirectory(dirPath);
        return files;
    }

    private List findFilesInDirectory(File directory)
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
