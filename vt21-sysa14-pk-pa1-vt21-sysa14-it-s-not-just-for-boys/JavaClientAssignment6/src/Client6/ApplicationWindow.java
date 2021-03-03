package Client6;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.Font;
import java.awt.Color;

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
	private Controller controller;
	private JTable table;
	private JScrollPane scrollPane;
	private JLabel getMetaDataAboutlbl;
	private JLabel getAllTablesLbl;
	private JLabel getAllColumnsLbl;
	private JLabel headerLbl;
	private JLabel errorLbl;
	private JLabel getInformationAboutLbl;



	public ApplicationWindow() {
	
		frame = new JFrame();
		frame.setBounds(50, 70, 950, 600);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		btnEmployeeTables = new JButton("Employee tables");
		btnEmployeeTables.setBounds(29, 77, 191, 23);
		frame.getContentPane().add(btnEmployeeTables);
		
		btnEmployeesRelatives = new JButton("Employees relatives");
		btnEmployeesRelatives.setBounds(29, 102, 191, 23);
		frame.getContentPane().add(btnEmployeesRelatives);
		
		btnEmpAbs = new JButton("Employee absent due to sickness");
		btnEmpAbs.setBounds(29, 127, 191, 23);
		frame.getContentPane().add(btnEmpAbs);
		
		btnMostAbsEmp = new JButton("Most absent employee");
		btnMostAbsEmp.setBounds(29, 152, 191, 23);
		frame.getContentPane().add(btnMostAbsEmp);
		
		btnAllKeys = new JButton("All keys");
		btnAllKeys.setBounds(29, 230, 191, 23);
		frame.getContentPane().add(btnAllKeys);
		
		btnAllIndexes = new JButton("All indexes");
		btnAllIndexes.setBounds(29, 255, 191, 23);
		frame.getContentPane().add(btnAllIndexes);
		
		btnAllTablesConstraint = new JButton("All tables constraint");
		btnAllTablesConstraint.setBounds(29, 280, 191, 23);
		frame.getContentPane().add(btnAllTablesConstraint);
		
		btnAllTablesAlt1 = new JButton("Alternative 1");
		btnAllTablesAlt1.setBounds(29, 362, 191, 23);
		frame.getContentPane().add(btnAllTablesAlt1);
		
		btnAllTablesAlt2 = new JButton("Alternative 2");
		btnAllTablesAlt2.setBounds(29, 387, 191, 23);
		frame.getContentPane().add(btnAllTablesAlt2);
		
		btnAllColumns1 = new JButton("Alternative 1");
		btnAllColumns1.setBounds(29, 470, 193, 23);
		frame.getContentPane().add(btnAllColumns1);
		
		btnAllColumn2 = new JButton("Alternative 2");
		btnAllColumn2.setBounds(29, 495, 193, 23);
		frame.getContentPane().add(btnAllColumn2);
		
		scrollPane = new JScrollPane();
		scrollPane.setBounds(254, 55, 642, 463);
		frame.getContentPane().add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		
		getInformationAboutLbl = new JLabel("Get information about");
		getInformationAboutLbl.setFont(new Font("Malgun Gothic", Font.BOLD, 11));
		getInformationAboutLbl.setHorizontalAlignment(SwingConstants.CENTER);
		getInformationAboutLbl.setBounds(29, 55, 191, 14);
		frame.getContentPane().add(getInformationAboutLbl);
		
		getMetaDataAboutlbl = new JLabel("Get metadata about");
		getMetaDataAboutlbl.setHorizontalAlignment(SwingConstants.CENTER);
		getMetaDataAboutlbl.setFont(new Font("Malgun Gothic", Font.BOLD, 11));
		getMetaDataAboutlbl.setBounds(51, 210, 146, 14);
		frame.getContentPane().add(getMetaDataAboutlbl);
		
		getAllTablesLbl = new JLabel("Get all tables");
		getAllTablesLbl.setFont(new Font("Malgun Gothic", Font.BOLD, 11));
		getAllTablesLbl.setHorizontalAlignment(SwingConstants.CENTER);
		getAllTablesLbl.setBounds(72, 337, 107, 14);
		frame.getContentPane().add(getAllTablesLbl);
		
		getAllColumnsLbl = new JLabel("Get all columns of the Employee table");
		getAllColumnsLbl.setHorizontalAlignment(SwingConstants.CENTER);
		getAllColumnsLbl.setFont(new Font("Malgun Gothic", Font.BOLD, 11));
		getAllColumnsLbl.setBounds(10, 447, 228, 14);
		frame.getContentPane().add(getAllColumnsLbl);
		
		headerLbl = new JLabel("CRONUS DATABASE");
		headerLbl.setHorizontalAlignment(SwingConstants.CENTER);
		headerLbl.setFont(new Font("Malgun Gothic", Font.BOLD, 18));
		headerLbl.setBounds(264, 0, 628, 51);
		frame.getContentPane().add(headerLbl);
		
		errorLbl = new JLabel("");
		errorLbl.setForeground(Color.RED);
		errorLbl.setBounds(254, 529, 551, 14);
		frame.getContentPane().add(errorLbl);
	}
	

	public JTable getTable() {
		return table;
	}

	public void setTable(JTable table) {
		this.table = table;
	}

	public JScrollPane getScrollPane() {
		return scrollPane;
	}

	public void setScrollPane(JScrollPane scrollPane) {
		this.scrollPane = scrollPane;
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

	public Controller getController() {
		return controller;
	}

	public void setController(Controller controller) {
		this.controller = controller;
	}
	
	public JLabel getGetMetaDataAboutlbl() {
		return getMetaDataAboutlbl;
	}

	public void setGetMetaDataAboutlbl(JLabel getMetaDataAboutlbl) {
		this.getMetaDataAboutlbl = getMetaDataAboutlbl;
	}

	public JLabel getGetAllTablesLbl() {
		return getAllTablesLbl;
	}

	public void setGetAllTablesLbl(JLabel getAllTablesLbl) {
		this.getAllTablesLbl = getAllTablesLbl;
	}

	public JLabel getGetAllColumnsLbl() {
		return getAllColumnsLbl;
	}

	public void setGetAllColumnsLbl(JLabel getAllColumnsLbl) {
		this.getAllColumnsLbl = getAllColumnsLbl;
	}

	public JLabel getHeaderLbl() {
		return headerLbl;
	}

	public void setHeaderLbl(JLabel headerLbl) {
		this.headerLbl = headerLbl;
	}

	public JLabel getErrorLbl() {
		return errorLbl;
	}

	public void setErrorLbl(JLabel errorLbl) {
		this.errorLbl = errorLbl;
	}

	public JLabel getGetInformationAboutLbl() {
		return getInformationAboutLbl;
	}

	public void setGetInformationAboutLbl(JLabel getInformationAboutLbl) {
		this.getInformationAboutLbl = getInformationAboutLbl;
	}


}
