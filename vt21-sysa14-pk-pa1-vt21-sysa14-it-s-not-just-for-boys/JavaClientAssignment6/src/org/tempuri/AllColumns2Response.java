/**
 * AllColumns2Response.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class AllColumns2Response  implements java.io.Serializable {
    private org.tempuri.AllColumns2ResponseAllColumns2Result allColumns2Result;

    public AllColumns2Response() {
    }

    public AllColumns2Response(
           org.tempuri.AllColumns2ResponseAllColumns2Result allColumns2Result) {
           this.allColumns2Result = allColumns2Result;
    }


    /**
     * Gets the allColumns2Result value for this AllColumns2Response.
     * 
     * @return allColumns2Result
     */
    public org.tempuri.AllColumns2ResponseAllColumns2Result getAllColumns2Result() {
        return allColumns2Result;
    }


    /**
     * Sets the allColumns2Result value for this AllColumns2Response.
     * 
     * @param allColumns2Result
     */
    public void setAllColumns2Result(org.tempuri.AllColumns2ResponseAllColumns2Result allColumns2Result) {
        this.allColumns2Result = allColumns2Result;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllColumns2Response)) return false;
        AllColumns2Response other = (AllColumns2Response) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allColumns2Result==null && other.getAllColumns2Result()==null) || 
             (this.allColumns2Result!=null &&
              this.allColumns2Result.equals(other.getAllColumns2Result())));
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
        if (getAllColumns2Result() != null) {
            _hashCode += getAllColumns2Result().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllColumns2Response.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">AllColumns2Response"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allColumns2Result");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "AllColumns2Result"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>AllColumns2Response>AllColumns2Result"));
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
