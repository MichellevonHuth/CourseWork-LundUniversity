import java.awt.event.ActionEvent;
import org.tempuri.*;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

public class Controller {
	
	private Frame frame;
	private Assignment3ServiceSoap proxy;
	private ApplicationWindow aw;
	
	public Controller(ApplicationWindow aw) {
		this.aw = aw;
		proxy = new Assignment3ServiceSoapProxy();
		declareEvents();
	} 
	
	public void setFrame(Frame frame) {
		this.frame = frame;
	}
		
	public Frame getFrame() {
		return frame;
	}
	public ApplicationWindow getAw() {
		return aw;
	}

	public void setAw(ApplicationWindow aw) {
		this.aw = aw;
	}

	
	public void declareEvents() {
	
		aw.getBtnNewButton().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.out.println("h");
			}
		});
	}

}




