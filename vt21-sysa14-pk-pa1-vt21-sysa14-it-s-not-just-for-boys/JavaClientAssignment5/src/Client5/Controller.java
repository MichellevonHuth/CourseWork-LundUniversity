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
			
			if(aw.getNumberTextField().getText().isEmpty() || aw.getFirstNameTextField().getText().isEmpty() || aw.getLastNameTextField().getText().isEmpty() || aw.getJobTitleTextField().getText().isEmpty()) {
				
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
					aw.getNumberTextField().setText("");
					aw.getFirstNameTextField().setText("");
					aw.getLastNameTextField().setText("");
					aw.getJobTitleTextField().setText("");
				}
				else if(ifExist == false) {
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
			
			if(aw.getNumberTextField().getText().isEmpty() || aw.getFirstNameTextField().getText().isEmpty() || aw.getLastNameTextField().getText().isEmpty() || aw.getJobTitleTextField().getText().isEmpty()) {
				
				aw.getErrorLbl().setText("Please fill in all the fields");
			}
			else {		
			
				try {
					
					String number = aw.getNumberTextField().getText();
					String firstname = aw.getFirstNameTextField().getText();
					String lastname = aw.getLastNameTextField().getText();
					String jobTitle = aw.getJobTitleTextField().getText();
					boolean exist = proxy.updateEmployee(number, firstname, lastname, jobTitle);
					
					if(exist == true) {
						aw.getTextArea().setText(number +  " just got updated in the database!");
						aw.getErrorLbl().setText("");
					}
					else {
						aw.getErrorLbl().setText(number +  " does not exists, please create this employee number.");
						aw.getTextArea().setText("");
					}
					
				
				} 
				catch (RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		}
	});
	
	aw.getDeleteBtn().addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			
			if(aw.getNumberTextField().getText().isEmpty()) {
				aw.getErrorLbl().setText("Please fill in the employee number!");
			}
			
			else {
				
				try {
				String number = aw.getNumberTextField().getText();;
				boolean exist = proxy.deleteEmployee(number);
					
				if(exist == true) {
					aw.getErrorLbl().setText("");
					aw.getTextArea().setText(number +  " just got deleted from the database!");
				}
				else {
					aw.getErrorLbl().setText(number +  " does not exists, please use another employee number.");
					aw.getTextArea().setText("");
				}
					
				} 
				catch (RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		
		}
	});
	
	aw.getFindBtn().addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			
			try {
				String[] employees = proxy.readEmployees();
				String message = "";
				
				for(int i = 0; i < employees.length; i++){
					
					String a = employees[i];
					message += a + "\r\n";
					
				}
				
				aw.getTextArea().setText(message);
				aw.getErrorLbl().setText("");
				
			}
			catch (RemoteException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
			
		}
	});
	}

	
}

