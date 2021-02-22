package org.tempuri;

public class Assignment4ServiceSoapProxy implements org.tempuri.Assignment4ServiceSoap {
  private String _endpoint = null;
  private org.tempuri.Assignment4ServiceSoap assignment4ServiceSoap = null;
  
  public Assignment4ServiceSoapProxy() {
    _initAssignment4ServiceSoapProxy();
  }
  
  public Assignment4ServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initAssignment4ServiceSoapProxy();
  }
  
  private void _initAssignment4ServiceSoapProxy() {
    try {
      assignment4ServiceSoap = (new org.tempuri.Assignment4ServiceLocator()).getAssignment4ServiceSoap();
      if (assignment4ServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)assignment4ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)assignment4ServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (assignment4ServiceSoap != null)
      ((javax.xml.rpc.Stub)assignment4ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.Assignment4ServiceSoap getAssignment4ServiceSoap() {
    if (assignment4ServiceSoap == null)
      _initAssignment4ServiceSoapProxy();
    return assignment4ServiceSoap;
  }
  
  public void insertUsers(java.lang.String username, java.lang.String name, java.lang.String surename) throws java.rmi.RemoteException{
    if (assignment4ServiceSoap == null)
      _initAssignment4ServiceSoapProxy();
    assignment4ServiceSoap.insertUsers(username, name, surename);
  }
  
  public org.tempuri.Account[] getAccounts() throws java.rmi.RemoteException{
    if (assignment4ServiceSoap == null)
      _initAssignment4ServiceSoapProxy();
    return assignment4ServiceSoap.getAccounts();
  }
  
  public org.tempuri.SavingSchedule[] getSavingSchedules() throws java.rmi.RemoteException{
    if (assignment4ServiceSoap == null)
      _initAssignment4ServiceSoapProxy();
    return assignment4ServiceSoap.getSavingSchedules();
  }
  
  
}