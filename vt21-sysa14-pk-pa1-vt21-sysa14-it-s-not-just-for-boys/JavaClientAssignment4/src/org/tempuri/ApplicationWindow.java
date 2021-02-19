package org.tempuri;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.Font;
import javax.swing.JTextField;
import javax.swing.JLabel;

public class ApplicationWindow {

	private JFrame frame;
	private JTextField messageTextField;

	
	public ApplicationWindow() {

		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton getAllAccountBtn = new JButton("Get all accounts");
		getAllAccountBtn.setFont(new Font("Segoe UI Semibold", Font.BOLD, 11));
		getAllAccountBtn.setBounds(152, 49, 131, 23);
		frame.getContentPane().add(getAllAccountBtn);
		
		messageTextField = new JTextField();
		messageTextField.setBounds(64, 94, 300, 117);
		frame.getContentPane().add(messageTextField);
		messageTextField.setColumns(10);
	
}
}

