package Client6;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import org.tempuri.Assignment6ServiceSoap;
import org.tempuri.Assignment6ServiceSoapProxy;

import Client6.ApplicationWindow;

public class Controller {

	private Assignment6ServiceSoap proxy;
	private ApplicationWindow aw;


	public ApplicationWindow getAw() {
		return aw;
	}

	public Controller(ApplicationWindow aw) {
		this.aw = aw;
		proxy = new Assignment6ServiceSoapProxy();
		declareEvents();
	} 

	public void setAw(ApplicationWindow aw) {
		this.aw = aw;
	}
	
	public void declareEvents() {
	
		aw.getBtnEmployeeTables().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					String[][] table = proxy.metaDataForEmployeeTable();
					for (int row = 0; row < table.length; row++) { 
						for (int col = 0; col < table[row].length; col++) {
							System.out.print(table[row][col] + "\t");
							} 
						} 

				} catch (RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		
		aw.getBtnEmployeesRelatives().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		

		aw.getBtnEmpAbs().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		
		aw.getBtnMostAbsEmp().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		
		aw.getBtnAllKeys().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});

		aw.getBtnAllIndexes().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});

		aw.getBtnAllTablesConstraint().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		

		aw.getBtnAllTablesAlt1().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});

		aw.getBtnAllTablesAlt2().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});

		aw.getBtnAllColumns1().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});

		aw.getBtnAllColumn2().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
	}

}
