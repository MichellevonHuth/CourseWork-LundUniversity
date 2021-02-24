/**
 * Assignment5ServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class Assignment5ServiceLocator extends org.apache.axis.client.Service implements org.tempuri.Assignment5Service {

    public Assignment5ServiceLocator() {
    }


    public Assignment5ServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public Assignment5ServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for Assignment5ServiceSoap
    private java.lang.String Assignment5ServiceSoap_address = "http://localhost/WSAssignment5/Assignment5Service.asmx";

    public java.lang.String getAssignment5ServiceSoapAddress() {
        return Assignment5ServiceSoap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String Assignment5ServiceSoapWSDDServiceName = "Assignment5ServiceSoap";

    public java.lang.String getAssignment5ServiceSoapWSDDServiceName() {
        return Assignment5ServiceSoapWSDDServiceName;
    }

    public void setAssignment5ServiceSoapWSDDServiceName(java.lang.String name) {
        Assignment5ServiceSoapWSDDServiceName = name;
    }

    public org.tempuri.Assignment5ServiceSoap getAssignment5ServiceSoap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(Assignment5ServiceSoap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getAssignment5ServiceSoap(endpoint);
    }

    public org.tempuri.Assignment5ServiceSoap getAssignment5ServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.tempuri.Assignment5ServiceSoapStub _stub = new org.tempuri.Assignment5ServiceSoapStub(portAddress, this);
            _stub.setPortName(getAssignment5ServiceSoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setAssignment5ServiceSoapEndpointAddress(java.lang.String address) {
        Assignment5ServiceSoap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.tempuri.Assignment5ServiceSoap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.tempuri.Assignment5ServiceSoapStub _stub = new org.tempuri.Assignment5ServiceSoapStub(new java.net.URL(Assignment5ServiceSoap_address), this);
                _stub.setPortName(getAssignment5ServiceSoapWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("Assignment5ServiceSoap".equals(inputPortName)) {
            return getAssignment5ServiceSoap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "Assignment5Service");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "Assignment5ServiceSoap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("Assignment5ServiceSoap".equals(portName)) {
            setAssignment5ServiceSoapEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
