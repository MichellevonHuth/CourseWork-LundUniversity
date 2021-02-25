/**
 * EmployeeAbsentTheMostResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class EmployeeAbsentTheMostResponse  implements java.io.Serializable {
    private org.tempuri.EmployeeAbsentTheMostResponseEmployeeAbsentTheMostResult employeeAbsentTheMostResult;

    public EmployeeAbsentTheMostResponse() {
    }

    public EmployeeAbsentTheMostResponse(
           org.tempuri.EmployeeAbsentTheMostResponseEmployeeAbsentTheMostResult employeeAbsentTheMostResult) {
           this.employeeAbsentTheMostResult = employeeAbsentTheMostResult;
    }


    /**
     * Gets the employeeAbsentTheMostResult value for this EmployeeAbsentTheMostResponse.
     * 
     * @return employeeAbsentTheMostResult
     */
    public org.tempuri.EmployeeAbsentTheMostResponseEmployeeAbsentTheMostResult getEmployeeAbsentTheMostResult() {
        return employeeAbsentTheMostResult;
    }


    /**
     * Sets the employeeAbsentTheMostResult value for this EmployeeAbsentTheMostResponse.
     * 
     * @param employeeAbsentTheMostResult
     */
    public void setEmployeeAbsentTheMostResult(org.tempuri.EmployeeAbsentTheMostResponseEmployeeAbsentTheMostResult employeeAbsentTheMostResult) {
        this.employeeAbsentTheMostResult = employeeAbsentTheMostResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof EmployeeAbsentTheMostResponse)) return false;
        EmployeeAbsentTheMostResponse other = (EmployeeAbsentTheMostResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.employeeAbsentTheMostResult==null && other.getEmployeeAbsentTheMostResult()==null) || 
             (this.employeeAbsentTheMostResult!=null &&
              this.employeeAbsentTheMostResult.equals(other.getEmployeeAbsentTheMostResult())));
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
        if (getEmployeeAbsentTheMostResult() != null) {
            _hashCode += getEmployeeAbsentTheMostResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(EmployeeAbsentTheMostResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">EmployeeAbsentTheMostResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employeeAbsentTheMostResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "EmployeeAbsentTheMostResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>EmployeeAbsentTheMostResponse>EmployeeAbsentTheMostResult"));
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
