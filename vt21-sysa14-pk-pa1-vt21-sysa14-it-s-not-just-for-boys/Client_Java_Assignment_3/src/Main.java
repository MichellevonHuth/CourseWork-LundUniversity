import java.rmi.RemoteException;

import org.tempuri.Assignment3ServiceSoap;
import org.tempuri.Assignment3ServiceSoapProxy;

public class Main {

	public static void main(String[] args) {

		System.out.println("Hello");
		
		Assignment3ServiceSoap as1 = new Assignment3ServiceSoapProxy();
		// Denna använder interfacet
		
		try {
			int myInt = as1.add(4, 2);
			System.out.println(myInt);
		}
		catch(RemoteException e) {
			e.printStackTrace();
		}

	}

}
