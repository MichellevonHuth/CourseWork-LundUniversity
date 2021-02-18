import java.rmi.RemoteException;

public class Errorhandler {


	public String handleException(RemoteException ex) {

			String errormessage = "The file does not exist";
			return errormessage;
	}
}
