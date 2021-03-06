package Client3;
import java.awt.event.ActionEvent;
import org.tempuri.*;

import java.awt.event.ActionListener;
import java.io.File;
import java.rmi.RemoteException;

public class Controller {
	
	private Assignment3ServiceSoap proxy;
	private ApplicationWindow aw;
	private Errorhandler eh;
	

	public Controller(ApplicationWindow aw) {
		this.aw = aw;
		proxy = new Assignment3ServiceSoapProxy();
		declareEvents();
	} 
	
	public Errorhandler getEh() {
		return eh;
	}

	public void setEh(Errorhandler eh) {
		this.eh = eh;
	}
	
	public ApplicationWindow getAw() {
		return aw;
	}

	public void setAw(ApplicationWindow aw) {
		this.aw = aw;
	}

	
	public void declareEvents() {
	
		aw.getShowTextFileBtn().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					
					aw.getErrorMessageLbl().setText("");
					String messageString;
					messageString = proxy.txtFile("C:\\Users\\Administrator\\Desktop\\HelloWorld.txt");
					aw.getMessageTextField().setText(messageString);
					}
					
					catch(Exception ex) {
						String errormessage = eh.handleException(ex);
						aw.getErrorMessageLbl().setText(errormessage);
					}
			}
		});
	}

}




