package searchframework;

import java.util.ArrayList;
import java.util.List;

import searchframework.Work.WorkKey;

public class WorkerThread extends Thread {

    private static final int NORMAL = 0;
    private static final int PAUSE  = 1;
    private static final int RESUME = 2;

    private Work work;
    private WorkListener listener;

    private int request = 0; // 1- Pause, 2 - Resume

    public WorkerThread(Work work, WorkListener listener) {
        this.work = work;
        this.listener = listener;
    }

    public void setWorkListener(WorkListener listener) {
        this.listener = listener;
    }

    public void run() {

        List allOutput = new ArrayList();
        int percentDone = 0;
        try {
            List keys = work.scopeWork();
            int sizeWork = keys.size();

            for (int j = 0; j < keys.size(); j++) {

                waitIfPauseRequest();

                WorkKey wKey = (WorkKey) keys.get(j);
                allOutput.add(work.doWork(wKey));

                percentDone = wKey.getPercent();
                listener.handleProgress(allOutput, percentDone, false);
            }
        } catch (InterruptedException intExp) {
            // The Task was interrupted
        }

        listener.handleProgress(allOutput, percentDone, true);

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
