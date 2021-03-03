package Client6;

import java.rmi.RemoteException;
import java.sql.SQLException;

import javax.xml.soap.SOAPException;

public class Errorhandler {

	public String handleException(Exception ex) {
		String errorMessage;
			
		if (ex instanceof NullPointerException) {
			errorMessage = "This object doesn't exist";
		}

		else if (ex instanceof IndexOutOfBoundsException) {
			errorMessage = "Coudn't find what you are looking for";
		}
		else if (ex instanceof RemoteException) {
			errorMessage = "Connection with web service failed";
		}

		else if (ex instanceof SQLException) {
			int errorCode = ((SQLException) ex).getErrorCode();
			switch (errorCode) {

			case 17:
				errorMessage = "Problem with the connection to the database";
				break;

			case 0:
				errorMessage = "Connection failed, timeout reached";
				break;
				
			default:
				errorMessage = "An unexpected error has occured";
				break;
			}
		} else {
			errorMessage = "An unexpected error has occured";
		}
		
		return errorMessage; 
	}
}
