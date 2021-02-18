import java.awt.event.ActionEvent;
import org.tempuri.*;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

public class Controller {
	
	private ApplicationWindow frame;
	private Assignment3ServiceSoap proxy;
	
	public Controller(ApplicationWindow frame) {
		this.frame = frame;
		proxy = new Assignment3ServiceSoapProxy();
		declareEvents();
	} 
	
	public void setFrame(ApplicationWindow frame) {
		this.frame = frame;
	}
		
	public ApplicationWindow getFrame() {
		return frame;
	}
	
	public void declareEvents() {
	
		frame.getShowTextFieldBtn().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					
					String messageString;
					
					messageString = proxy.txtFile("file:///Users/Administrator/Desktop/HelloWorld.txt");
					frame.getMessageTextField().setText(messageString);
					}
					
					catch(RemoteException ex) {
						ex.printStackTrace();
					}
			}
		});
	
	}

}




