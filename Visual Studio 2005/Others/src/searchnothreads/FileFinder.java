package searchnothreads;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileFilter;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.List;

public class FileFinder {

    private File dir;

    public FileFinder(File dir) {
        this.dir = dir;
    }

    public List findFiles(String token) {
        return findFilesRecursively(dir, token);
    }

    private List findFilesRecursively(File directory, String token) {
        List foundFiles = new ArrayList();

        System.out.println("Handling directory :: "
                + directory.getAbsolutePath());

        FileFilter dirFilter = new FileFilter() {
            public boolean accept(File file) {
                return file.isDirectory();
            }
        };

        File[] directories = directory.listFiles(dirFilter);
        if (directories != null) {
            for (int j = 0; j < directories.length; j++) {
                List files = findFilesRecursively(directories[j], token);
                foundFiles.addAll(files);
            }
        }

        List files = findFilesInDirectory(directory, token);
        foundFiles.addAll(files);

        return foundFiles;
    }

    private List findFilesInDirectory(File directory, String token) {
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

}
