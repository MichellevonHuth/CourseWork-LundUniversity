import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.BorderLayout;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Font;
import javax.swing.JLabel;
import java.awt.Color;

public class ApplicationWindow {

	private JFrame frame;
	private JTextField messageTextField;
	private Controller controller;
	private JButton showTextFileBtn;
	private JLabel errorMessageLbl;

	public ApplicationWindow() {

		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		showTextFileBtn = new JButton("Show Text File");
		showTextFileBtn.setFont(new Font("Microsoft YaHei", Font.BOLD, 12));
		showTextFileBtn.setBounds(125, 35, 181, 23);
		frame.getContentPane().add(showTextFileBtn);
		
		messageTextField = new JTextField();
		messageTextField.setBounds(80, 81, 270, 155);
		frame.getContentPane().add(messageTextField);
		messageTextField.setColumns(10);
		
		errorMessageLbl = new JLabel("");
		errorMessageLbl.setForeground(Color.RED);
		errorMessageLbl.setBounds(80, 236, 270, 25);
		frame.getContentPane().add(errorMessageLbl);
	}

	public JFrame getFrame() {
		return frame;
	}
	
	public void setFrame(JFrame frame) {
		this.frame = frame;
	}
	
	public Controller getController() {
		return controller;
	}
	
	public void setController(Controller controller) {
		this.controller = controller;
	}

	public JLabel getErrorMessageLbl() {
		return errorMessageLbl;
	}

	public void setErrorMessageLbl(JLabel errorMessageLbl) {
		this.errorMessageLbl = errorMessageLbl;
	}
	public JTextField getMessageTextField() {
		return messageTextField;
	}

	public void setMessageTextField(JTextField messageTextField) {
		this.messageTextField = messageTextField;
	}

	public JButton getShowTextFileBtn() {
		return showTextFileBtn;
	}

	public void setShowTextFileBtn(JButton showTextFileBtn) {
		this.showTextFileBtn = showTextFileBtn;
	}


}
