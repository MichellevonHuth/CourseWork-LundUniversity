package Client5;

import java.awt.EventQueue;

import javax.swing.JFrame;
import java.awt.TextArea;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.Button;
import java.awt.Font;
import javax.swing.SwingConstants;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Color;

public class ApplicationWindow {

	private JFrame frame;
	private JTextField numberTextField;
	private JTextField firstNameTextField;
	private JTextField lastNameTextField;
	private JTextField jobTitleTextField;
	private JLabel empNbrLbl;
	private JLabel firstNameLbl;
	private JLabel lastNameLbl;
	private JLabel jobTitleLbl;
	private Button createBtn;
	private Button updateBtn;
	private Button deleteBtn;
	private Button findBtn;
	private JLabel headerLbl;
	private JLabel errorLbl;
	private TextArea textArea;



	public ApplicationWindow() {
	
		frame = new JFrame();
		frame.setBounds(200, 200, 850, 600);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		textArea = new TextArea();
		textArea.setBounds(230, 97, 567, 329);
		frame.getContentPane().add(textArea);
		
		numberTextField = new JTextField();
		numberTextField.setBounds(104, 118, 120, 20);
		frame.getContentPane().add(numberTextField);
		numberTextField.setColumns(10);
		
		firstNameTextField = new JTextField();
		firstNameTextField.setBounds(104, 203, 120, 20);
		frame.getContentPane().add(firstNameTextField);
		firstNameTextField.setColumns(10);
		
		lastNameTextField = new JTextField();
		lastNameTextField.setBounds(104, 291, 120, 20);
		frame.getContentPane().add(lastNameTextField);
		lastNameTextField.setColumns(10);
		
		jobTitleTextField = new JTextField();
		jobTitleTextField.setBounds(104, 377, 120, 20);
		frame.getContentPane().add(jobTitleTextField);
		jobTitleTextField.setColumns(10);
		
		empNbrLbl = new JLabel("Employee number:");
		empNbrLbl.setBounds(10, 118, 89, 20);
		frame.getContentPane().add(empNbrLbl);
		
		firstNameLbl = new JLabel("First name:");
		firstNameLbl.setBounds(37, 206, 57, 14);
		frame.getContentPane().add(firstNameLbl);
		
		lastNameLbl = new JLabel("Last name:");
		lastNameLbl.setBounds(37, 294, 57, 14);
		frame.getContentPane().add(lastNameLbl);
		
		jobTitleLbl = new JLabel("Job title:");
		jobTitleLbl.setBounds(37, 380, 57, 14);
		frame.getContentPane().add(jobTitleLbl);
		
		createBtn = new Button("Create");
		createBtn.setBounds(277, 444, 70, 22);
		frame.getContentPane().add(createBtn);
		
		updateBtn = new Button("Update");
		updateBtn.setBounds(431, 444, 70, 22);
		frame.getContentPane().add(updateBtn);
		
		deleteBtn = new Button("Delete");
		deleteBtn.setBounds(580, 444, 70, 22);
		frame.getContentPane().add(deleteBtn);
		
		findBtn = new Button("Find all");
		findBtn.setBounds(727, 444, 70, 22);
		frame.getContentPane().add(findBtn);
		
		headerLbl = new JLabel("EMPLOYEES AT CRONUS");
		headerLbl.setHorizontalAlignment(SwingConstants.CENTER);
		headerLbl.setFont(new Font("Segoe UI", Font.BOLD, 24));
		headerLbl.setBounds(10, 11, 787, 65);
		frame.getContentPane().add(headerLbl);
		
		errorLbl = new JLabel("");
		errorLbl.setForeground(Color.RED);
		errorLbl.setBounds(230, 510, 405, 14);
		frame.getContentPane().add(errorLbl);
	}

	public JFrame getFrame() {
		return frame;
	}

	public void setFrame(JFrame frame) {
		this.frame = frame;
	}

	public JTextField getNumberTextField() {
		return numberTextField;
	}

	public void setNumberTextField(JTextField numberTextField) {
		this.numberTextField = numberTextField;
	}

	public JTextField getFirstNameTextField() {
		return firstNameTextField;
	}

	public void setFirstNameTextField(JTextField firstNameTextField) {
		this.firstNameTextField = firstNameTextField;
	}

	public JTextField getLastNameTextField() {
		return lastNameTextField;
	}

	public void setLastNameTextField(JTextField lastNameTextField) {
		this.lastNameTextField = lastNameTextField;
	}

	public JTextField getJobTitleTextField() {
		return jobTitleTextField;
	}

	public void setJobTitleTextField(JTextField jobTitleTextField) {
		this.jobTitleTextField = jobTitleTextField;
	}

	public JLabel getEmpNbrLbl() {
		return empNbrLbl;
	}

	public void setEmpNbrLbl(JLabel empNbrLbl) {
		this.empNbrLbl = empNbrLbl;
	}

	public JLabel getFirstNameLbl() {
		return firstNameLbl;
	}

	public void setFirstNameLbl(JLabel firstNameLbl) {
		this.firstNameLbl = firstNameLbl;
	}

	public JLabel getLastNameLbl() {
		return lastNameLbl;
	}

	public void setLastNameLbl(JLabel lastNameLbl) {
		this.lastNameLbl = lastNameLbl;
	}

	public JLabel getJobTitleLbl() {
		return jobTitleLbl;
	}

	public void setJobTitleLbl(JLabel jobTitleLbl) {
		this.jobTitleLbl = jobTitleLbl;
	}

	public Button getCreateBtn() {
		return createBtn;
	}

	public void setCreateBtn(Button createBtn) {
		this.createBtn = createBtn;
	}

	public Button getUpdateBtn() {
		return updateBtn;
	}

	public void setUpdateBtn(Button updateBtn) {
		this.updateBtn = updateBtn;
	}

	public Button getDeleteBtn() {
		return deleteBtn;
	}

	public void setDeleteBtn(Button deleteBtn) {
		this.deleteBtn = deleteBtn;
	}

	public Button getFindBtn() {
		return findBtn;
	}

	public void setFindBtn(Button findBtn) {
		this.findBtn = findBtn;
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

	public TextArea getTextArea() {
		return textArea;
	}

	public void setTextArea(TextArea textArea) {
		this.textArea = textArea;
	}

}
