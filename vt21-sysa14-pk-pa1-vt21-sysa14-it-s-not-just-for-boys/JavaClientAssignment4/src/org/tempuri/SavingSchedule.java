/**
 * SavingSchedule.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class SavingSchedule  implements java.io.Serializable {
    private java.lang.String accountUsername;

    private java.lang.String totalIncome;

    private java.lang.String fixedCost;

    private java.lang.String variableCost;

    private java.lang.String savingGoal;

    private java.lang.String savingDuration;

    public SavingSchedule() {
    }

    public SavingSchedule(
           java.lang.String accountUsername,
           java.lang.String totalIncome,
           java.lang.String fixedCost,
           java.lang.String variableCost,
           java.lang.String savingGoal,
           java.lang.String savingDuration) {
           this.accountUsername = accountUsername;
           this.totalIncome = totalIncome;
           this.fixedCost = fixedCost;
           this.variableCost = variableCost;
           this.savingGoal = savingGoal;
           this.savingDuration = savingDuration;
    }


    /**
     * Gets the accountUsername value for this SavingSchedule.
     * 
     * @return accountUsername
     */
    public java.lang.String getAccountUsername() {
        return accountUsername;
    }


    /**
     * Sets the accountUsername value for this SavingSchedule.
     * 
     * @param accountUsername
     */
    public void setAccountUsername(java.lang.String accountUsername) {
        this.accountUsername = accountUsername;
    }


    /**
     * Gets the totalIncome value for this SavingSchedule.
     * 
     * @return totalIncome
     */
    public java.lang.String getTotalIncome() {
        return totalIncome;
    }


    /**
     * Sets the totalIncome value for this SavingSchedule.
     * 
     * @param totalIncome
     */
    public void setTotalIncome(java.lang.String totalIncome) {
        this.totalIncome = totalIncome;
    }


    /**
     * Gets the fixedCost value for this SavingSchedule.
     * 
     * @return fixedCost
     */
    public java.lang.String getFixedCost() {
        return fixedCost;
    }


    /**
     * Sets the fixedCost value for this SavingSchedule.
     * 
     * @param fixedCost
     */
    public void setFixedCost(java.lang.String fixedCost) {
        this.fixedCost = fixedCost;
    }


    /**
     * Gets the variableCost value for this SavingSchedule.
     * 
     * @return variableCost
     */
    public java.lang.String getVariableCost() {
        return variableCost;
    }


    /**
     * Sets the variableCost value for this SavingSchedule.
     * 
     * @param variableCost
     */
    public void setVariableCost(java.lang.String variableCost) {
        this.variableCost = variableCost;
    }


    /**
     * Gets the savingGoal value for this SavingSchedule.
     * 
     * @return savingGoal
     */
    public java.lang.String getSavingGoal() {
        return savingGoal;
    }


    /**
     * Sets the savingGoal value for this SavingSchedule.
     * 
     * @param savingGoal
     */
    public void setSavingGoal(java.lang.String savingGoal) {
        this.savingGoal = savingGoal;
    }


    /**
     * Gets the savingDuration value for this SavingSchedule.
     * 
     * @return savingDuration
     */
    public java.lang.String getSavingDuration() {
        return savingDuration;
    }


    /**
     * Sets the savingDuration value for this SavingSchedule.
     * 
     * @param savingDuration
     */
    public void setSavingDuration(java.lang.String savingDuration) {
        this.savingDuration = savingDuration;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof SavingSchedule)) return false;
        SavingSchedule other = (SavingSchedule) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.accountUsername==null && other.getAccountUsername()==null) || 
             (this.accountUsername!=null &&
              this.accountUsername.equals(other.getAccountUsername()))) &&
            ((this.totalIncome==null && other.getTotalIncome()==null) || 
             (this.totalIncome!=null &&
              this.totalIncome.equals(other.getTotalIncome()))) &&
            ((this.fixedCost==null && other.getFixedCost()==null) || 
             (this.fixedCost!=null &&
              this.fixedCost.equals(other.getFixedCost()))) &&
            ((this.variableCost==null && other.getVariableCost()==null) || 
             (this.variableCost!=null &&
              this.variableCost.equals(other.getVariableCost()))) &&
            ((this.savingGoal==null && other.getSavingGoal()==null) || 
             (this.savingGoal!=null &&
              this.savingGoal.equals(other.getSavingGoal()))) &&
            ((this.savingDuration==null && other.getSavingDuration()==null) || 
             (this.savingDuration!=null &&
              this.savingDuration.equals(other.getSavingDuration())));
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
        if (getAccountUsername() != null) {
            _hashCode += getAccountUsername().hashCode();
        }
        if (getTotalIncome() != null) {
            _hashCode += getTotalIncome().hashCode();
        }
        if (getFixedCost() != null) {
            _hashCode += getFixedCost().hashCode();
        }
        if (getVariableCost() != null) {
            _hashCode += getVariableCost().hashCode();
        }
        if (getSavingGoal() != null) {
            _hashCode += getSavingGoal().hashCode();
        }
        if (getSavingDuration() != null) {
            _hashCode += getSavingDuration().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(SavingSchedule.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "SavingSchedule"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("accountUsername");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "AccountUsername"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("totalIncome");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "TotalIncome"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("fixedCost");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "FixedCost"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("variableCost");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "VariableCost"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("savingGoal");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "SavingGoal"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("savingDuration");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "SavingDuration"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
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
