package Client6;

import java.awt.event.ActionEvent;

import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.util.Vector;

import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import org.tempuri.Assignment6ServiceSoap;
import org.tempuri.Assignment6ServiceSoapProxy;

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
	
	public void displayData(String[][] table, String[] columnNames) {
		
		DefaultTableModel model = new DefaultTableModel(table, columnNames);
		aw.getTable().setModel(model);	
		    
	}
	
	
	public void declareEvents() {
	
		aw.getBtnEmployeeTables().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					String[][] table = proxy.metaDataForEmployeeTable();
					String[] columnNames = new String[6];
					columnNames[0] = "table_catalog";
					columnNames[1] = "table_name";
					columnNames[2] = "column_name";
					columnNames[3] = "ordinal_position";
					columnNames[4] = "is_nullable";
					columnNames[5] = "data_type";
					displayData(table, columnNames);

				} catch (RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		
		aw.getBtnEmployeesRelatives().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				try {
					String[][] table = proxy.employeeRelatives();
	                String[] columnNames = new String[5];
	                columnNames[0] = "Employee No_";
	                columnNames[1] = "Relative Code";
	                columnNames[2] = "First Name";
	                columnNames[3] = "Last Name";
	                columnNames[4] = "Birth Date";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		

		aw.getBtnEmpAbs().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
				String[][] table = proxy.employeeAbsent2004();
                String[] columnNames = new String[1];
                columnNames[0] ="Employee_Number";
                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		
		aw.getBtnMostAbsEmp().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
				String[][] table = proxy.employeeAbsentTheMost();
                String[] columnNames = new String[1];
                columnNames[0] = "First Name";
                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		
		aw.getBtnAllKeys().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					String[][] table = proxy.allKeys();
	                String[] columnNames = new String[5];
	                columnNames[0] = "Column_name";
	                columnNames[1] = "Constraint_name";
	                columnNames[2] = "Key_type";
	                columnNames[3] = "Type_desc";
	                columnNames[4] = "Object_id";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});

		aw.getBtnAllIndexes().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String[][] table = proxy.allIndexes();
	                String[] columnNames = new String[3];
	                columnNames[0] = "object_id";
	                columnNames[1] = "name";
	                columnNames[2] = "index_id";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});

		aw.getBtnAllTablesConstraint().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String[][] table = proxy.allTableConstraints();
	                String[] columnNames = new String[3];
	                columnNames[0] = "Table_Name";
	                columnNames[1] = "Column_Name";
	                columnNames[2] = "Constraint_Type";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		

		aw.getBtnAllTablesAlt1().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					String[][] table = proxy.allTables1();
	                String[] columnNames = new String[1];
	                columnNames[0] = "Tables";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});

		aw.getBtnAllTablesAlt2().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String[][] table = proxy.allTables2();
	                String[] columnNames = new String[1];
	                columnNames[0] = "Tables";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});

		aw.getBtnAllColumns1().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String[][] table = proxy.allColumns1();
	                String[] columnNames = new String[1];
	                columnNames[0] = "Columns";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});

		aw.getBtnAllColumn2().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					String[][] table = proxy.allColumns2();
	                String[] columnNames = new String[1];
	                columnNames[0] = "Columns";
	                displayData(table, columnNames);
				}
				catch(RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
	}

}
