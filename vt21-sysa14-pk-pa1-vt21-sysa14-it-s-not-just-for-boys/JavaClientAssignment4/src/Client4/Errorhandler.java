package Client4;

import java.rmi.RemoteException;

public class Errorhandler {

	public String handleException(RemoteException ex) {

			String errormessage = "Something went wrong";
			return errormessage;
	}
}
