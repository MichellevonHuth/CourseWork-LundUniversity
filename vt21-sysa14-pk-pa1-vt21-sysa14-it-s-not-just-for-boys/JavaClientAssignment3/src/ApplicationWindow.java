import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class ApplicationWindow extends JFrame {

	private JPanel contentPane;
	private JTextField messageTextField;
	private JButton showTextFileBtn;
	
	public ApplicationWindow() {
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		showTextFileBtn = new JButton("Show Text File");
		showTextFileBtn.setBounds(157, 48, 128, 23);
		contentPane.add(showTextFileBtn);
		
		messageTextField = new JTextField();
		messageTextField.setBounds(69, 103, 303, 115);
		contentPane.add(messageTextField);
		messageTextField.setColumns(10);
	}
	
	public JButton getShowTextFieldBtn() {
		return showTextFileBtn;
	}
	public void setShowTextFieldBtn(JButton showTextFileBtn) {
		this.showTextFileBtn = showTextFileBtn;
	}
	public JTextField getMessageTextField() {
		return messageTextField;
	}
	public void setMessageTextField(JTextField messageTextField) {
		this.messageTextField = messageTextField;
	}
	public JPanel getContentPane() {
		return contentPane;
	}
	public void setContentPane(JPanel contentPane) {
		this.contentPane = contentPane;
	}

}
