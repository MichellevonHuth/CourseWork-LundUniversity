package Client5;

import java.rmi.RemoteException;
import java.sql.SQLException;

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
	public String emptyFields() {

		String errorMessage = "Please fill in all the fields";		
		return errorMessage;
		
	}
	
	public String alreadyExist(String a) {
		String errorMessage = a + " already exists, please use another employee number";
		return errorMessage;
	}
	
	public String doesNotExistPleaseCreate(String a) {
		String errorMessage = a + " does not exists, please create this employee number";
		return errorMessage;
	}
	
	public String doesNotExist(String a) {
		String errorMessage = a + " does not exists, please use another employee number";
		return errorMessage;
	}
	

}
