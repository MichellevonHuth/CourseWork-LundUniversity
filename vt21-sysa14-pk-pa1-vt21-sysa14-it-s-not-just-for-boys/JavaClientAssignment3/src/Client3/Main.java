package Client3;
import java.rmi.RemoteException;
import org.tempuri.Assignment3ServiceSoap;
import org.tempuri.Assignment3ServiceSoapProxy;

public class Main {

	public static void main(String[] args) {
	
		ApplicationWindow frame = new ApplicationWindow();
		Controller controller = new Controller(frame);
		frame.setController(controller);
		frame.getFrame().setVisible(true);
	
	}

}
