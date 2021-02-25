/**
 * AllColumns1Response.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class AllColumns1Response  implements java.io.Serializable {
    private org.tempuri.AllColumns1ResponseAllColumns1Result allColumns1Result;

    public AllColumns1Response() {
    }

    public AllColumns1Response(
           org.tempuri.AllColumns1ResponseAllColumns1Result allColumns1Result) {
           this.allColumns1Result = allColumns1Result;
    }


    /**
     * Gets the allColumns1Result value for this AllColumns1Response.
     * 
     * @return allColumns1Result
     */
    public org.tempuri.AllColumns1ResponseAllColumns1Result getAllColumns1Result() {
        return allColumns1Result;
    }


    /**
     * Sets the allColumns1Result value for this AllColumns1Response.
     * 
     * @param allColumns1Result
     */
    public void setAllColumns1Result(org.tempuri.AllColumns1ResponseAllColumns1Result allColumns1Result) {
        this.allColumns1Result = allColumns1Result;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllColumns1Response)) return false;
        AllColumns1Response other = (AllColumns1Response) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allColumns1Result==null && other.getAllColumns1Result()==null) || 
             (this.allColumns1Result!=null &&
              this.allColumns1Result.equals(other.getAllColumns1Result())));
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
        if (getAllColumns1Result() != null) {
            _hashCode += getAllColumns1Result().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllColumns1Response.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">AllColumns1Response"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allColumns1Result");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "AllColumns1Result"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>AllColumns1Response>AllColumns1Result"));
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
