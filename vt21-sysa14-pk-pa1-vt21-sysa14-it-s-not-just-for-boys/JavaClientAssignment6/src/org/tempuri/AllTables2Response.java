/**
 * AllTables2Response.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class AllTables2Response  implements java.io.Serializable {
    private org.tempuri.AllTables2ResponseAllTables2Result allTables2Result;

    public AllTables2Response() {
    }

    public AllTables2Response(
           org.tempuri.AllTables2ResponseAllTables2Result allTables2Result) {
           this.allTables2Result = allTables2Result;
    }


    /**
     * Gets the allTables2Result value for this AllTables2Response.
     * 
     * @return allTables2Result
     */
    public org.tempuri.AllTables2ResponseAllTables2Result getAllTables2Result() {
        return allTables2Result;
    }


    /**
     * Sets the allTables2Result value for this AllTables2Response.
     * 
     * @param allTables2Result
     */
    public void setAllTables2Result(org.tempuri.AllTables2ResponseAllTables2Result allTables2Result) {
        this.allTables2Result = allTables2Result;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllTables2Response)) return false;
        AllTables2Response other = (AllTables2Response) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allTables2Result==null && other.getAllTables2Result()==null) || 
             (this.allTables2Result!=null &&
              this.allTables2Result.equals(other.getAllTables2Result())));
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
        if (getAllTables2Result() != null) {
            _hashCode += getAllTables2Result().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllTables2Response.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">AllTables2Response"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allTables2Result");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "AllTables2Result"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>AllTables2Response>AllTables2Result"));
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
