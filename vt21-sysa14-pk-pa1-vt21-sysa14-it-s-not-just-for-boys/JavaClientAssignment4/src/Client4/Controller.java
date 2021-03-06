package Client4;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import org.tempuri.Account;
import org.tempuri.Assignment4ServiceSoap;
import org.tempuri.Assignment4ServiceSoapProxy;
import org.tempuri.SavingSchedule;


public class Controller {
	
	private Assignment4ServiceSoap proxy;
	private ApplicationWindow aw;
	Errorhandler errorhandler = new Errorhandler();
	
	
	public Controller(ApplicationWindow aw) {
		this.aw = aw;
		proxy = new Assignment4ServiceSoapProxy();
		declareEvents();
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
						
					aw.getErrorMessageLbl().setText("");
					Account[] accounts = proxy.getAccounts();
					String message = "";
					
					for(Account account : accounts) {
							
						String information = "Username: " + account.getUsername() + " Name: " + account.getName() + " Surname: " + account.getSurename() + "\n";
						message += information;
					
					}
					
					aw.getMessageTextArea().setText(message);
					
					}
					
					catch(Exception ex) {
						aw.getErrorMessageLbl().setText(errorhandler.handleException(ex));
					}
			}
		});
		
		
		aw.getShowAllSavingSchedulesBtn().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					
				aw.getErrorMessageLbl().setText("");
				SavingSchedule[] schedules = proxy.getSavingSchedules();
				String message = "";
				
				for(SavingSchedule a : schedules) {
						
					String information = "Username: " + a.getAccountUsername() + " Total Income: " + a.getTotalIncome() + " Fixed Cost: " + a.getFixedCost() + " Variable Cost: " + a.getVariableCost() + " Saving Goal: " + a.getSavingGoal() + " Saving Duration: " + a.getSavingDuration() + "\r\n";
					message += information;
				
				}
				
				aw.getMessageTextArea().setText(message);
				
				}
				
				catch(Exception ex) {
					aw.getErrorMessageLbl().setText(errorhandler.handleException(ex));
				}
				
				
				
			}
		});
	}
}
