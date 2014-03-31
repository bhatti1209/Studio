package searchframework;

import java.util.List;

public interface WorkListener {

    void handleProgress(List output, int percent, boolean done);
}
