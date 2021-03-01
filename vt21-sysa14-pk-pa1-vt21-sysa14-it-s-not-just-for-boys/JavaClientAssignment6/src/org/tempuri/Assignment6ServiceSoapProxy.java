package org.tempuri;

public class Assignment6ServiceSoapProxy implements org.tempuri.Assignment6ServiceSoap {
  private String _endpoint = null;
  private org.tempuri.Assignment6ServiceSoap assignment6ServiceSoap = null;
  
  public Assignment6ServiceSoapProxy() {
    _initAssignment6ServiceSoapProxy();
  }
  
  public Assignment6ServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initAssignment6ServiceSoapProxy();
  }
  
  private void _initAssignment6ServiceSoapProxy() {
    try {
      assignment6ServiceSoap = (new org.tempuri.Assignment6ServiceLocator()).getAssignment6ServiceSoap();
      if (assignment6ServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)assignment6ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)assignment6ServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (assignment6ServiceSoap != null)
      ((javax.xml.rpc.Stub)assignment6ServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.Assignment6ServiceSoap getAssignment6ServiceSoap() {
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap;
  }
  
  public java.lang.String[][] metaDataForEmployeeTable() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.metaDataForEmployeeTable();
  }
  
  public java.lang.String[][] employeeRelatives() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.employeeRelatives();
  }
  
  public java.lang.String[][] employeeAbsent2004() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.employeeAbsent2004();
  }
  
  public java.lang.String[][] employeeAbsentTheMost() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.employeeAbsentTheMost();
  }
  
  public java.lang.String[][] allKeys() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.allKeys();
  }
  
  public java.lang.String[][] allIndexes() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.allIndexes();
  }
  
  public java.lang.String[][] allTableConstraints() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.allTableConstraints();
  }
  
  public java.lang.String[][] allTables1() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.allTables1();
  }
  
  public java.lang.String[][] allTables2() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.allTables2();
  }
  
  public java.lang.String[][] allColumns1() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.allColumns1();
  }
  
  public java.lang.String[][] allColumns2() throws java.rmi.RemoteException{
    if (assignment6ServiceSoap == null)
      _initAssignment6ServiceSoapProxy();
    return assignment6ServiceSoap.allColumns2();
  }
  
  
}