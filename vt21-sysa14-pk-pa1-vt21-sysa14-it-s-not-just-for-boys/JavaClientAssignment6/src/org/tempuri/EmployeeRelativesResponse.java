/**
 * EmployeeRelativesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class EmployeeRelativesResponse  implements java.io.Serializable {
    private org.tempuri.EmployeeRelativesResponseEmployeeRelativesResult employeeRelativesResult;

    public EmployeeRelativesResponse() {
    }

    public EmployeeRelativesResponse(
           org.tempuri.EmployeeRelativesResponseEmployeeRelativesResult employeeRelativesResult) {
           this.employeeRelativesResult = employeeRelativesResult;
    }


    /**
     * Gets the employeeRelativesResult value for this EmployeeRelativesResponse.
     * 
     * @return employeeRelativesResult
     */
    public org.tempuri.EmployeeRelativesResponseEmployeeRelativesResult getEmployeeRelativesResult() {
        return employeeRelativesResult;
    }


    /**
     * Sets the employeeRelativesResult value for this EmployeeRelativesResponse.
     * 
     * @param employeeRelativesResult
     */
    public void setEmployeeRelativesResult(org.tempuri.EmployeeRelativesResponseEmployeeRelativesResult employeeRelativesResult) {
        this.employeeRelativesResult = employeeRelativesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof EmployeeRelativesResponse)) return false;
        EmployeeRelativesResponse other = (EmployeeRelativesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.employeeRelativesResult==null && other.getEmployeeRelativesResult()==null) || 
             (this.employeeRelativesResult!=null &&
              this.employeeRelativesResult.equals(other.getEmployeeRelativesResult())));
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
        if (getEmployeeRelativesResult() != null) {
            _hashCode += getEmployeeRelativesResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(EmployeeRelativesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">EmployeeRelativesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employeeRelativesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "EmployeeRelativesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>EmployeeRelativesResponse>EmployeeRelativesResult"));
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
