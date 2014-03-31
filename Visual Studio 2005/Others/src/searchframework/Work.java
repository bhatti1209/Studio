package searchframework;

import java.util.List;

public interface Work {

    public static class WorkKey {

        private int ID;
        private int percent;

        public WorkKey(int ID, int percent) {
            this.ID = ID;
            this.percent = percent;
        }

        public int getID() {
            return ID;
        }

        public void setID(int id) {
            ID = id;
        }

        public int getPercent() {
            return percent;
        }

        public void setPercent(int percent) {
            this.percent = percent;
        }
    }

    List scopeWork() throws InterruptedException;

    Object doWork(WorkKey key) throws InterruptedException;
}
