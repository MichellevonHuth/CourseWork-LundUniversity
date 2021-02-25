package Client6;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class ApplicationWindow {

	private JFrame frame;
	private JButton btnEmployeeTables;
	private JButton btnEmployeesRelatives;
	private JButton btnEmpAbs;
	private JButton btnMostAbsEmp;
	private JButton btnAllKeys;
	private JButton btnAllIndexes;
	private JButton btnAllTablesConstraint;
	private JButton btnAllTablesAlt1;
	private JButton btnAllTablesAlt2;
	private JButton btnAllColumns1;
	private JButton btnAllColumn2;

	
	public ApplicationWindow() {
	
		frame = new JFrame();
		frame.setBounds(200, 200, 850, 400);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		btnEmployeeTables = new JButton("Employee tables");
		btnEmployeeTables.setBounds(10, 134, 191, 23);
		frame.getContentPane().add(btnEmployeeTables);
		
		btnEmployeesRelatives = new JButton("Employees relatives");
		btnEmployeesRelatives.setBounds(10, 168, 191, 23);
		frame.getContentPane().add(btnEmployeesRelatives);
		
		btnEmpAbs = new JButton("Employee absent due to sickness");
		btnEmpAbs.setBounds(10, 202, 191, 23);
		frame.getContentPane().add(btnEmpAbs);
		
		btnMostAbsEmp = new JButton("Most absent employee");
		btnMostAbsEmp.setBounds(10, 236, 191, 23);
		frame.getContentPane().add(btnMostAbsEmp);
		
		btnAllKeys = new JButton("All keys");
		btnAllKeys.setBounds(570, 41, 191, 23);
		frame.getContentPane().add(btnAllKeys);
		
		btnAllIndexes = new JButton("All indexes");
		btnAllIndexes.setBounds(570, 75, 191, 23);
		frame.getContentPane().add(btnAllIndexes);
		
		btnAllTablesConstraint = new JButton("All tables constraint");
		btnAllTablesConstraint.setBounds(570, 108, 191, 23);
		frame.getContentPane().add(btnAllTablesConstraint);
		
		btnAllTablesAlt1 = new JButton("All tables alt. 1");
		btnAllTablesAlt1.setBounds(570, 179, 191, 23);
		frame.getContentPane().add(btnAllTablesAlt1);
		
		btnAllTablesAlt2 = new JButton("All tables alt. 2");
		btnAllTablesAlt2.setBounds(570, 213, 191, 23);
		frame.getContentPane().add(btnAllTablesAlt2);
		
		btnAllColumns1 = new JButton("All columns of emp. table alt. 1");
		btnAllColumns1.setBounds(568, 278, 193, 23);
		frame.getContentPane().add(btnAllColumns1);
		
		btnAllColumn2 = new JButton("All column of the emp. table alt. 2");
		btnAllColumn2.setBounds(568, 312, 193, 23);
		frame.getContentPane().add(btnAllColumn2);
	}
	
	public JFrame getFrame() {
		return frame;
	}


	public void setFrame(JFrame frame) {
		this.frame = frame;
	}


	public JButton getBtnEmployeeTables() {
		return btnEmployeeTables;
	}


	public void setBtnEmployeeTables(JButton btnEmployeeTables) {
		this.btnEmployeeTables = btnEmployeeTables;
	}


	public JButton getBtnEmployeesRelatives() {
		return btnEmployeesRelatives;
	}


	public void setBtnEmployeesRelatives(JButton btnEmployeesRelatives) {
		this.btnEmployeesRelatives = btnEmployeesRelatives;
	}


	public JButton getBtnEmpAbs() {
		return btnEmpAbs;
	}


	public void setBtnEmpAbs(JButton btnEmpAbs) {
		this.btnEmpAbs = btnEmpAbs;
	}


	public JButton getBtnMostAbsEmp() {
		return btnMostAbsEmp;
	}


	public void setBtnMostAbsEmp(JButton btnMostAbsEmp) {
		this.btnMostAbsEmp = btnMostAbsEmp;
	}


	public JButton getBtnAllKeys() {
		return btnAllKeys;
	}


	public void setBtnAllKeys(JButton btnAllKeys) {
		this.btnAllKeys = btnAllKeys;
	}


	public JButton getBtnAllIndexes() {
		return btnAllIndexes;
	}


	public void setBtnAllIndexes(JButton btnAllIndexes) {
		this.btnAllIndexes = btnAllIndexes;
	}


	public JButton getBtnAllTablesConstraint() {
		return btnAllTablesConstraint;
	}


	public void setBtnAllTablesConstraint(JButton btnAllTablesConstraint) {
		this.btnAllTablesConstraint = btnAllTablesConstraint;
	}


	public JButton getBtnAllTablesAlt1() {
		return btnAllTablesAlt1;
	}


	public void setBtnAllTablesAlt1(JButton btnAllTablesAlt1) {
		this.btnAllTablesAlt1 = btnAllTablesAlt1;
	}


	public JButton getBtnAllTablesAlt2() {
		return btnAllTablesAlt2;
	}


	public void setBtnAllTablesAlt2(JButton btnAllTablesAlt2) {
		this.btnAllTablesAlt2 = btnAllTablesAlt2;
	}


	public JButton getBtnAllColumns1() {
		return btnAllColumns1;
	}


	public void setBtnAllColumns1(JButton btnAllColumns1) {
		this.btnAllColumns1 = btnAllColumns1;
	}


	public JButton getBtnAllColumn2() {
		return btnAllColumn2;
	}


	public void setBtnAllColumn2(JButton btnAllColumn2) {
		this.btnAllColumn2 = btnAllColumn2;
	}

}
