package Client4;

public class Main {

	public static void main(String[] args) {
		
		ApplicationWindow frame = new ApplicationWindow();
		Controller controller = new Controller(frame);
		frame.setController(controller);
		frame.getFrame().setVisible(true);
	}

}
