/**
 * Assignment5ServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface Assignment5ServiceSoap extends java.rmi.Remote {
    public boolean createEmployee(java.lang.String no_, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle) throws java.rmi.RemoteException;
    public java.lang.String[] readEmployees() throws java.rmi.RemoteException;
    public boolean updateEmployee(java.lang.String no_, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle) throws java.rmi.RemoteException;
    public boolean deleteEmployee(java.lang.String no_) throws java.rmi.RemoteException;
}
