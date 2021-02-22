package Client4;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import org.tempuri.Account;
import org.tempuri.Assignment4ServiceSoap;
import org.tempuri.Assignment4ServiceSoapProxy;


public class Controller {
	
	private Assignment4ServiceSoap proxy;
	private ApplicationWindow aw;
	private Errorhandler eh;
	
	
	public Controller(ApplicationWindow aw) {
		this.aw = aw;
		proxy = new Assignment4ServiceSoapProxy();
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
	
		aw.getShowAllAccounts().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
					try {
					
					Account[] accounts = proxy.getAccounts();
					String message = "";
					
					for(Account account : accounts) {
							
						String information = "Username: " + account.getUsername() + " Name: " + account.getName() + " Surname: " + account.getSurename() + "\n";
						message += information;
					
					}
					
					aw.getMessageTextArea().setText(message);
					
					}
					
					catch(RemoteException ex) {
						String errormessage = eh.handleException(ex);
						aw.getErrorMessageLbl().setText(errormessage);
					}
			}
		});
	}
}
