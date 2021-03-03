package Client3;
import java.rmi.RemoteException;

public class Errorhandler {


	public String handleException(Exception ex) {
		String errorMessage = "";
		
		if (ex instanceof NullPointerException) {
			errorMessage = "This file doesn't exist";
		}

		else if (ex instanceof IndexOutOfBoundsException) {
			errorMessage = "Coudn't find what you are looking for";	
		}
		
		else if (ex instanceof RemoteException) {
			errorMessage = "Connection with web service failed";
		}
			return errorMessage;
	}
}
