/**
 * EmployeeAbsent2004Response.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class EmployeeAbsent2004Response  implements java.io.Serializable {
    private org.tempuri.EmployeeAbsent2004ResponseEmployeeAbsent2004Result employeeAbsent2004Result;

    public EmployeeAbsent2004Response() {
    }

    public EmployeeAbsent2004Response(
           org.tempuri.EmployeeAbsent2004ResponseEmployeeAbsent2004Result employeeAbsent2004Result) {
           this.employeeAbsent2004Result = employeeAbsent2004Result;
    }


    /**
     * Gets the employeeAbsent2004Result value for this EmployeeAbsent2004Response.
     * 
     * @return employeeAbsent2004Result
     */
    public org.tempuri.EmployeeAbsent2004ResponseEmployeeAbsent2004Result getEmployeeAbsent2004Result() {
        return employeeAbsent2004Result;
    }


    /**
     * Sets the employeeAbsent2004Result value for this EmployeeAbsent2004Response.
     * 
     * @param employeeAbsent2004Result
     */
    public void setEmployeeAbsent2004Result(org.tempuri.EmployeeAbsent2004ResponseEmployeeAbsent2004Result employeeAbsent2004Result) {
        this.employeeAbsent2004Result = employeeAbsent2004Result;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof EmployeeAbsent2004Response)) return false;
        EmployeeAbsent2004Response other = (EmployeeAbsent2004Response) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.employeeAbsent2004Result==null && other.getEmployeeAbsent2004Result()==null) || 
             (this.employeeAbsent2004Result!=null &&
              this.employeeAbsent2004Result.equals(other.getEmployeeAbsent2004Result())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getEmployeeAbsent2004Result() != null) {
            _hashCode += getEmployeeAbsent2004Result().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(EmployeeAbsent2004Response.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">EmployeeAbsent2004Response"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employeeAbsent2004Result");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "EmployeeAbsent2004Result"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>EmployeeAbsent2004Response>EmployeeAbsent2004Result"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
