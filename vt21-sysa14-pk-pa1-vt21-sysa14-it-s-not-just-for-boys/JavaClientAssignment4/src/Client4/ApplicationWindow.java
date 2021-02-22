package Client4;
import javax.swing.JFrame;
import Client4.Controller;
import javax.swing.JButton;
import javax.swing.JLabel;
import java.awt.TextArea;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class ApplicationWindow {

	private JFrame frame;
	private JButton showAllAccounts;
	private JButton showAllSavingSchedulesBtn;
	private JLabel errorMessageLbl;
	private Controller controller;
	private TextArea messageTextArea;

	public ApplicationWindow() {

		frame = new JFrame();
		frame.setBounds(200, 200, 650, 500);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		showAllAccounts = new JButton("Show all accounts");
		showAllAccounts.setBounds(110, 32, 175, 23);
		frame.getContentPane().add(showAllAccounts);
		
		showAllSavingSchedulesBtn = new JButton("Show all savingschedules");
		showAllSavingSchedulesBtn.setBounds(342, 32, 180, 23);
		frame.getContentPane().add(showAllSavingSchedulesBtn);
		
		errorMessageLbl = new JLabel("");
		errorMessageLbl.setBounds(143, 415, 354, 22);
		frame.getContentPane().add(errorMessageLbl);
		
		messageTextArea = new TextArea();
		messageTextArea.setBounds(10, 71, 603, 355);
		frame.getContentPane().add(messageTextArea);
	}
	
	public JFrame getFrame() {
		return frame;
	}

	public void setFrame(JFrame frame) {
		this.frame = frame;
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

	public TextArea getMessageTextArea() {
		return messageTextArea;
	}

	public void setMessageTextArea(TextArea messageTextArea) {
		this.messageTextArea = messageTextArea;
	}

}
