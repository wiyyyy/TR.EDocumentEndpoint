using CoreWCF;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public partial class EFaturaFaultType : object, System.ComponentModel.INotifyPropertyChanged
{

    private int codeField;

    private bool codeFieldSpecified;

    private string msgField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public int code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
            this.RaisePropertyChanged("code");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool codeSpecified
    {
        get
        {
            return this.codeFieldSpecified;
        }
        set
        {
            this.codeFieldSpecified = value;
            this.RaisePropertyChanged("codeSpecified");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public string msg
    {
        get
        {
            return this.msgField;
        }
        set
        {
            this.msgField = value;
            this.RaisePropertyChanged("msg");
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public partial class getAppRespResponseType : object, System.ComponentModel.INotifyPropertyChanged
{

    private string applicationResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string applicationResponse
    {
        get
        {
            return this.applicationResponseField;
        }
        set
        {
            this.applicationResponseField = value;
            this.RaisePropertyChanged("applicationResponse");
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public partial class getAppRespRequestType : object, System.ComponentModel.INotifyPropertyChanged
{

    private string instanceIdentifierField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string instanceIdentifier
    {
        get
        {
            return this.instanceIdentifierField;
        }
        set
        {
            this.instanceIdentifierField = value;
            this.RaisePropertyChanged("instanceIdentifier");
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[ServiceContract(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public interface IEFaturaPortType
{

    // CODEGEN: Generating message contract since the operation getApplicationResponse is neither RPC nor document wrapped.
    [OperationContract(Action = "getApplicationResponse")]
    [FaultContractAttribute(typeof(EFaturaFaultType), Action = "getApplicationResponse", Name = "EFaturaFault")]
    [XmlSerializerFormatAttribute(SupportFaults = true)]
    getApplicationResponseResponse getApplicationResponse(getApplicationResponse request);

    // CODEGEN: Generating message contract since the operation sendDocument is neither RPC nor document wrapped.
    [OperationContract(Action = "sendDocument")]
    [FaultContractAttribute(typeof(EFaturaFaultType), Action = "sendDocument", Name = "EFaturaFault")]
    [XmlSerializerFormatAttribute(SupportFaults = true)]
    sendDocumentResponse sendDocument(sendDocument request);


}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[MessageContractAttribute(IsWrapped = false)]
public partial class getApplicationResponse
{

    [MessageBodyMemberAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura", Order = 0)]
    public getAppRespRequestType getAppRespRequest;

    public getApplicationResponse()
    {
    }

    public getApplicationResponse(getAppRespRequestType getAppRespRequest)
    {
        this.getAppRespRequest = getAppRespRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[MessageContractAttribute(IsWrapped = false)]
public partial class getApplicationResponseResponse
{

    [MessageBodyMemberAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura", Order = 0)]
    public getAppRespResponseType getAppRespResponse;

    public getApplicationResponseResponse()
    {
    }

    public getApplicationResponseResponse(getAppRespResponseType getAppRespResponse)
    {
        this.getAppRespResponse = getAppRespResponse;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public partial class documentType : object, System.ComponentModel.INotifyPropertyChanged
{

    private string fileNameField;

    private base64Binary binaryDataField;

    private string hashField;

    private int? PartnerIDField;

    private string VKNTCKNField;

    private int? ModuleIDField;

    private byte? EnvelopeTypeIDField;

    private bool? IsDespatchField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string fileName
    {
        get
        {
            return this.fileNameField;
        }
        set
        {
            this.fileNameField = value;
            this.RaisePropertyChanged("fileName");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public base64Binary binaryData
    {
        get
        {
            return this.binaryDataField;
        }
        set
        {
            this.binaryDataField = value;
            this.RaisePropertyChanged("binaryData");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public string hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
            this.RaisePropertyChanged("hash");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public int? PartnerID
    {
        get
        {
            return this.PartnerIDField;
        }
        set
        {
            this.PartnerIDField = value;
            this.RaisePropertyChanged("PartnerID");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
    public int? ModuleID
    {
        get
        {
            return this.ModuleIDField;
        }
        set
        {
            this.ModuleIDField = value;
            this.RaisePropertyChanged("ModuleID");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
    public byte? EnvelopeTypeID
    {
        get
        {
            return this.EnvelopeTypeIDField;
        }
        set
        {
            this.EnvelopeTypeIDField = value;
            this.RaisePropertyChanged("EnvelopeTypeID");
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
    public string VKNTCKN
    {
        get
        {
            return this.VKNTCKNField;
        }
        set
        {
            this.VKNTCKNField = value;
            this.RaisePropertyChanged("VKNTCKN");
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
    public bool? IsDespatch
    {
        get
        {
            return this.IsDespatchField;
        }
        set
        {
            this.IsDespatchField = value;
            this.RaisePropertyChanged("IsDespatch");
        }
    }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2005/05/xmlmime")]
public partial class base64Binary : object, System.ComponentModel.INotifyPropertyChanged
{

    private string contentTypeField;

    private byte[] valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string contentType
    {
        get
        {
            return this.contentTypeField;
        }
        set
        {
            this.contentTypeField = value;
            this.RaisePropertyChanged("contentType");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
    public byte[] Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
            this.RaisePropertyChanged("Value");
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public partial class documentReturnType : object, System.ComponentModel.INotifyPropertyChanged
{

    private string msgField;

    private string hashField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string msg
    {
        get
        {
            return this.msgField;
        }
        set
        {
            this.msgField = value;
            this.RaisePropertyChanged("msg");
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public string hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
            this.RaisePropertyChanged("hash");
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[MessageContractAttribute(IsWrapped = false)]
public partial class sendDocument
{

    [MessageBodyMemberAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura", Order = 0)]
    public documentType documentRequest;

    public sendDocument()
    {
    }

    public sendDocument(documentType documentRequest)
    {
        this.documentRequest = documentRequest;
    }
}

public partial class sendOutboundFITStatus
{

    [MessageBodyMemberAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura", Order = 0)]
    public statusType documentRequest;

    public sendOutboundFITStatus()
    {
    }

    public sendOutboundFITStatus(statusType documentRequest)
    {
        this.documentRequest = documentRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[MessageContractAttribute(IsWrapped = false)]
public partial class sendDocumentResponse
{

    [MessageBodyMemberAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura", Order = 0)]
    public documentReturnType documentResponse;

    public sendDocumentResponse()
    {
    }

    public sendDocumentResponse(documentReturnType documentResponse)
    {
        this.documentResponse = documentResponse;
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public partial class statusType : object, System.ComponentModel.INotifyPropertyChanged
{
    private string VKNField;
    private string fileNameField;
    private string statusField;
    private bool IsDespatchField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
    public string VKN
    {
        get => VKNField;
        set
        {
            VKNField = value;
            RaisePropertyChanged("VKN");
        }
    }

    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
    public string fileName
    {
        get => fileNameField;
        set
        {
            fileNameField = value;
            RaisePropertyChanged("fileName");
        }
    }

    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
    public string status
    {
        get => statusField;
        set
        {
            statusField = value;
            RaisePropertyChanged("status");
        }
    }

    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public bool isDespatch
    {
        get => IsDespatchField;
        set
        {
            IsDespatchField = value;
            RaisePropertyChanged("IsDespatch");
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gib.gov.tr/vedop3/eFatura")]
public partial class statusReturnType : object, System.ComponentModel.INotifyPropertyChanged
{
    private int codefield;
    private string messageField;

    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public int code
    {
        get => codefield;
        set
        {
            codefield = value;
            RaisePropertyChanged("code");
        }
    }

    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public string message
    {
        get => messageField;
        set
        {
            messageField = value;
            RaisePropertyChanged("message");
        }
    }

    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    protected void RaisePropertyChanged(string propertyName)
    {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
        if ((propertyChanged != null))
        {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
