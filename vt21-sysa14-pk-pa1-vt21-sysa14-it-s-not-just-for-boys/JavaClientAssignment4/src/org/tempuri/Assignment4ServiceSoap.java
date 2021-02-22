/**
 * Assignment4ServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface Assignment4ServiceSoap extends java.rmi.Remote {
    public void insertUsers(java.lang.String username, java.lang.String name, java.lang.String surename) throws java.rmi.RemoteException;
    public org.tempuri.Account[] getAccounts() throws java.rmi.RemoteException;
    public org.tempuri.SavingSchedule[] getSavingSchedules() throws java.rmi.RemoteException;
}
