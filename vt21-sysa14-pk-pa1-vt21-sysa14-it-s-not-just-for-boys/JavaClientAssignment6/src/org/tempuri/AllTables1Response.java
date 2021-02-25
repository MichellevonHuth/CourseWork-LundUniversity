/**
 * AllTables1Response.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class AllTables1Response  implements java.io.Serializable {
    private org.tempuri.AllTables1ResponseAllTables1Result allTables1Result;

    public AllTables1Response() {
    }

    public AllTables1Response(
           org.tempuri.AllTables1ResponseAllTables1Result allTables1Result) {
           this.allTables1Result = allTables1Result;
    }


    /**
     * Gets the allTables1Result value for this AllTables1Response.
     * 
     * @return allTables1Result
     */
    public org.tempuri.AllTables1ResponseAllTables1Result getAllTables1Result() {
        return allTables1Result;
    }


    /**
     * Sets the allTables1Result value for this AllTables1Response.
     * 
     * @param allTables1Result
     */
    public void setAllTables1Result(org.tempuri.AllTables1ResponseAllTables1Result allTables1Result) {
        this.allTables1Result = allTables1Result;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllTables1Response)) return false;
        AllTables1Response other = (AllTables1Response) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allTables1Result==null && other.getAllTables1Result()==null) || 
             (this.allTables1Result!=null &&
              this.allTables1Result.equals(other.getAllTables1Result())));
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
        if (getAllTables1Result() != null) {
            _hashCode += getAllTables1Result().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllTables1Response.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">AllTables1Response"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allTables1Result");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "AllTables1Result"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>AllTables1Response>AllTables1Result"));
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
