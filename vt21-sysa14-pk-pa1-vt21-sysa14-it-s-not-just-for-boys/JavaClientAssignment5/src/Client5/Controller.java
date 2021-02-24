package Client5;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import org.tempuri.Assignment5ServiceSoap;
import org.tempuri.Assignment5ServiceSoapProxy;

public class Controller {

	private Assignment5ServiceSoap proxy;
	private ApplicationWindow aw;


	public ApplicationWindow getAw() {
		return aw;
	}

	public Controller(ApplicationWindow aw) {
		this.aw = aw;
		proxy = new Assignment5ServiceSoapProxy();
		declareEvents();
	} 

	public void setAw(ApplicationWindow aw) {
		this.aw = aw;
	}
	
	public void declareEvents() {
		
	aw.getCreateBtn().addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			
			if(aw.getNumberTextField().getText() == "" || aw.getFirstNameTextField().getText() == "" || aw.getLastNameTextField().getText() == "" || aw.getJobTitleTextField().getText() == "") {
				
				aw.getErrorLbl().setText("Please fill in all the fields");
			}
			
			else {
				try {
				String number = aw.getNumberTextField().getText();
				String firstname = aw.getFirstNameTextField().getText();
				String lastname = aw.getLastNameTextField().getText();
				String jobTitle = aw.getJobTitleTextField().getText();
				
				boolean ifExist = proxy.createEmployee(number, firstname, lastname, jobTitle);
				
				if(ifExist == true) {
					aw.getErrorLbl().setText("");
					aw.getTextArea().setText(number + " is now added in the database!");
				}
				else {
					aw.getErrorLbl().setText(number + " already exists, please use another employee number.");
				}
				
				
				} catch (RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
			}
			}
		}
	});
	
	aw.getUpdateBtn().addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			
			String number = aw.getNumberTextField().getText();
			String firstname = aw.getFirstNameTextField().getText();
			String lastname = aw.getLastNameTextField().getText();
			String jobTitle = aw.getJobTitleTextField().getText();
			
			try {
				proxy.updateEmployee(number, firstname, lastname, jobTitle);
			} catch (RemoteException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		}
	});
	
	aw.getDeleteBtn().addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			
			String number = aw.getNumberTextField().getText();;
			try {
				proxy.deleteEmployee(number);
			} catch (RemoteException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		
		}
	});
	
	aw.getFindBtn().addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			
			try {
				String[] employees = proxy.readEmployees();
			} catch (RemoteException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
			
		}
	});
	}

	
}

