package org.tempuri;

public class Assignment5ServiceSoapProxy implements org.tempuri.Assignment5ServiceSoap {
  private String _endpoint = null;
  private org.tempuri.Assignment5ServiceSoap assignment5ServiceSoap = null;
  
  public Assignment5ServiceSoapProxy() {
    _initAssignment5ServiceSoapProxy();
  }
  
  public Assignment5ServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initAssignment5ServiceSoapProxy();
  }
  
  private void _initAssignment5ServiceSoapProxy() {
    try {
      assignment5ServiceSoap = (new org.tempuri.Assignment5ServiceLocator()).getAssignment5ServiceSoap();
      if (assignment5ServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)assignment5ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)assignment5ServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (assignment5ServiceSoap != null)
      ((javax.xml.rpc.Stub)assignment5ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.Assignment5ServiceSoap getAssignment5ServiceSoap() {
    if (assignment5ServiceSoap == null)
      _initAssignment5ServiceSoapProxy();
    return assignment5ServiceSoap;
  }
  
  public boolean createEmployee(java.lang.String no_, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle) throws java.rmi.RemoteException{
    if (assignment5ServiceSoap == null)
      _initAssignment5ServiceSoapProxy();
    return assignment5ServiceSoap.createEmployee(no_, firstName, lastName, jobTitle);
  }
  
  public java.lang.String[] readEmployees() throws java.rmi.RemoteException{
    if (assignment5ServiceSoap == null)
      _initAssignment5ServiceSoapProxy();
    return assignment5ServiceSoap.readEmployees();
  }
  
  public boolean updateEmployee(java.lang.String no_, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle) throws java.rmi.RemoteException{
    if (assignment5ServiceSoap == null)
      _initAssignment5ServiceSoapProxy();
    return assignment5ServiceSoap.updateEmployee(no_, firstName, lastName, jobTitle);
  }
  
  public boolean deleteEmployee(java.lang.String no_) throws java.rmi.RemoteException{
    if (assignment5ServiceSoap == null)
      _initAssignment5ServiceSoapProxy();
    return assignment5ServiceSoap.deleteEmployee(no_);
  }
  
  
}