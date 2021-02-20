package Client4;

import javax.swing.JFrame;
import javax.swing.JTextField;

import Client4.Controller;

import javax.swing.JButton;
import javax.swing.JLabel;

public class ApplicationWindow {

	private JFrame frame;
	private JTextField messageTextField;
	private JButton showAllAccounts;
	private JButton showAllSavingSchedulesBtn;
	private JLabel errorMessageLbl;
	private Controller controller;

	public ApplicationWindow() {

		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		messageTextField = new JTextField();
		messageTextField.setBounds(10, 77, 414, 140);
		frame.getContentPane().add(messageTextField);
		messageTextField.setColumns(10);
		
		showAllAccounts = new JButton("Show all accounts");
		showAllAccounts.setBounds(29, 32, 175, 23);
		frame.getContentPane().add(showAllAccounts);
		
		showAllSavingSchedulesBtn = new JButton("Show all savingschedules");
		showAllSavingSchedulesBtn.setBounds(227, 32, 180, 23);
		frame.getContentPane().add(showAllSavingSchedulesBtn);
		
		errorMessageLbl = new JLabel("");
		errorMessageLbl.setBounds(41, 228, 354, 22);
		frame.getContentPane().add(errorMessageLbl);
	}
	
	public JFrame getFrame() {
		return frame;
	}

	public void setFrame(JFrame frame) {
		this.frame = frame;
	}
	public JTextField getMessageTextField() {
		return messageTextField;
	}

	public void setMessageTextField(JTextField messageTextField) {
		this.messageTextField = messageTextField;
	}

	public JButton getShowAllAccounts() {
		return showAllAccounts;
	}

	public void setShowAllAccounts(JButton showAllAccounts) {
		this.showAllAccounts = showAllAccounts;
	}

	public JButton getShowAllSavingSchedulesBtn() {
		return showAllSavingSchedulesBtn;
	}

	public void setShowAllSavingSchedulesBtn(JButton showAllSavingSchedulesBtn) {
		this.showAllSavingSchedulesBtn = showAllSavingSchedulesBtn;
	}

	public JLabel getErrorMessageLbl() {
		return errorMessageLbl;
	}

	public void setErrorMessageLbl(JLabel errorMessageLbl) {
		this.errorMessageLbl = errorMessageLbl;
	}

	public Controller getController() {
		return controller;
	}

	public void setController(Controller controller) {
		this.controller = controller;
	}


}
