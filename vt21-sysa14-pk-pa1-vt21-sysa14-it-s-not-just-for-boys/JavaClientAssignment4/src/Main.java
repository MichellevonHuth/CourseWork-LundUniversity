import java.rmi.RemoteException;

import org.tempuri.Assignment4ServiceSoap;
import org.tempuri.Assignment4ServiceSoapProxy;

public class Main {

	public static void main(String[] args) {
		System.out.println("hej");
		
		Assignment4ServiceSoap proxy = new Assignment4ServiceSoapProxy();	
		
		try {
			proxy.insertUsers("siv", "siv", "Forsell");
		} catch (RemoteException e) {
			e.printStackTrace();
		}
	}

}
