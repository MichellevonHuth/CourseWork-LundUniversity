package Client5;

import Client5.ApplicationWindow;
import Client5.Controller;

public class Main {

	public static void main(String[] args) {
		ApplicationWindow frame = new ApplicationWindow();
		Controller controller = new Controller(frame);
		frame.setController(controller);
		frame.getFrame().setVisible(true);

	}

}
