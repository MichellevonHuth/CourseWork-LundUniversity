/**
 * AllIndexesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class AllIndexesResponse  implements java.io.Serializable {
    private org.tempuri.AllIndexesResponseAllIndexesResult allIndexesResult;

    public AllIndexesResponse() {
    }

    public AllIndexesResponse(
           org.tempuri.AllIndexesResponseAllIndexesResult allIndexesResult) {
           this.allIndexesResult = allIndexesResult;
    }


    /**
     * Gets the allIndexesResult value for this AllIndexesResponse.
     * 
     * @return allIndexesResult
     */
    public org.tempuri.AllIndexesResponseAllIndexesResult getAllIndexesResult() {
        return allIndexesResult;
    }


    /**
     * Sets the allIndexesResult value for this AllIndexesResponse.
     * 
     * @param allIndexesResult
     */
    public void setAllIndexesResult(org.tempuri.AllIndexesResponseAllIndexesResult allIndexesResult) {
        this.allIndexesResult = allIndexesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllIndexesResponse)) return false;
        AllIndexesResponse other = (AllIndexesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allIndexesResult==null && other.getAllIndexesResult()==null) || 
             (this.allIndexesResult!=null &&
              this.allIndexesResult.equals(other.getAllIndexesResult())));
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
        if (getAllIndexesResult() != null) {
            _hashCode += getAllIndexesResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllIndexesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">AllIndexesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allIndexesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "AllIndexesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>AllIndexesResponse>AllIndexesResult"));
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
