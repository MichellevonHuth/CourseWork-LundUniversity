package org.tempuri;

public class Assignment3ServiceSoapProxy implements org.tempuri.Assignment3ServiceSoap {
  private String _endpoint = null;
  private org.tempuri.Assignment3ServiceSoap assignment3ServiceSoap = null;
  
  public Assignment3ServiceSoapProxy() {
    _initAssignment3ServiceSoapProxy();
  }
  
  public Assignment3ServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initAssignment3ServiceSoapProxy();
  }
  
  private void _initAssignment3ServiceSoapProxy() {
    try {
      assignment3ServiceSoap = (new org.tempuri.Assignment3ServiceLocator()).getAssignment3ServiceSoap();
      if (assignment3ServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)assignment3ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)assignment3ServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (assignment3ServiceSoap != null)
      ((javax.xml.rpc.Stub)assignment3ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.Assignment3ServiceSoap getAssignment3ServiceSoap() {
    if (assignment3ServiceSoap == null)
      _initAssignment3ServiceSoapProxy();
    return assignment3ServiceSoap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (assignment3ServiceSoap == null)
      _initAssignment3ServiceSoapProxy();
    return assignment3ServiceSoap.helloWorld();
  }
  
  public java.lang.String helloWld() throws java.rmi.RemoteException{
    if (assignment3ServiceSoap == null)
      _initAssignment3ServiceSoapProxy();
    return assignment3ServiceSoap.helloWld();
  }
  
  
}