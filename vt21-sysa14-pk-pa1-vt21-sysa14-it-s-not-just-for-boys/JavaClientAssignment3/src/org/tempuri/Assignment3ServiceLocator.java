/**
 * Assignment3ServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class Assignment3ServiceLocator extends org.apache.axis.client.Service implements org.tempuri.Assignment3Service {

    public Assignment3ServiceLocator() {
    }


    public Assignment3ServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public Assignment3ServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for Assignment3ServiceSoap
    private java.lang.String Assignment3ServiceSoap_address = "http://localhost/WSAssignment3/Assignment3Service.asmx";

    public java.lang.String getAssignment3ServiceSoapAddress() {
        return Assignment3ServiceSoap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String Assignment3ServiceSoapWSDDServiceName = "Assignment3ServiceSoap";

    public java.lang.String getAssignment3ServiceSoapWSDDServiceName() {
        return Assignment3ServiceSoapWSDDServiceName;
    }

    public void setAssignment3ServiceSoapWSDDServiceName(java.lang.String name) {
        Assignment3ServiceSoapWSDDServiceName = name;
    }

    public org.tempuri.Assignment3ServiceSoap getAssignment3ServiceSoap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(Assignment3ServiceSoap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getAssignment3ServiceSoap(endpoint);
    }

    public org.tempuri.Assignment3ServiceSoap getAssignment3ServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.tempuri.Assignment3ServiceSoapStub _stub = new org.tempuri.Assignment3ServiceSoapStub(portAddress, this);
            _stub.setPortName(getAssignment3ServiceSoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setAssignment3ServiceSoapEndpointAddress(java.lang.String address) {
        Assignment3ServiceSoap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.tempuri.Assignment3ServiceSoap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.tempuri.Assignment3ServiceSoapStub _stub = new org.tempuri.Assignment3ServiceSoapStub(new java.net.URL(Assignment3ServiceSoap_address), this);
                _stub.setPortName(getAssignment3ServiceSoapWSDDServiceName());
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
        if ("Assignment3ServiceSoap".equals(inputPortName)) {
            return getAssignment3ServiceSoap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "Assignment3Service");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "Assignment3ServiceSoap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("Assignment3ServiceSoap".equals(portName)) {
            setAssignment3ServiceSoapEndpointAddress(address);
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
