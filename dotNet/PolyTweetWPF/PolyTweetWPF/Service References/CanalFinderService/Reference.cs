﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolyTweetWPF.CanalFinderService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://domain.j2e/", ConfigurationName="CanalFinderService.CanalFinder")]
    public interface CanalFinder {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PolyTweetWPF.CanalFinderService.findCanalByAbonneResponse findCanalByAbonne(PolyTweetWPF.CanalFinderService.findCanalByAbonne request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByAbonneResponse> findCanalByAbonneAsync(PolyTweetWPF.CanalFinderService.findCanalByAbonne request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PolyTweetWPF.CanalFinderService.findCanalByProprietaireResponse findCanalByProprietaire(PolyTweetWPF.CanalFinderService.findCanalByProprietaire request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByProprietaireResponse> findCanalByProprietaireAsync(PolyTweetWPF.CanalFinderService.findCanalByProprietaire request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PolyTweetWPF.CanalFinderService.findCanalByTypeResponse findCanalByType(PolyTweetWPF.CanalFinderService.findCanalByType request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByTypeResponse> findCanalByTypeAsync(PolyTweetWPF.CanalFinderService.findCanalByType request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PolyTweetWPF.CanalFinderService.findCanalByTagResponse findCanalByTag(PolyTweetWPF.CanalFinderService.findCanalByTag request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByTagResponse> findCanalByTagAsync(PolyTweetWPF.CanalFinderService.findCanalByTag request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://domain.j2e/")]
    public partial class canal : object, System.ComponentModel.INotifyPropertyChanged {
        
        private utilisateur[] abonnesField;
        
        private utilisateur[] attenteField;
        
        private message[] messagesField;
        
        private utilisateur[] moderateursField;
        
        private utilisateur[] proprietairesField;
        
        private string tagField;
        
        private typeCanal typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("abonnes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public utilisateur[] abonnes {
            get {
                return this.abonnesField;
            }
            set {
                this.abonnesField = value;
                this.RaisePropertyChanged("abonnes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attente", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public utilisateur[] attente {
            get {
                return this.attenteField;
            }
            set {
                this.attenteField = value;
                this.RaisePropertyChanged("attente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("messages", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public message[] messages {
            get {
                return this.messagesField;
            }
            set {
                this.messagesField = value;
                this.RaisePropertyChanged("messages");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("moderateurs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public utilisateur[] moderateurs {
            get {
                return this.moderateursField;
            }
            set {
                this.moderateursField = value;
                this.RaisePropertyChanged("moderateurs");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("proprietaires", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=4)]
        public utilisateur[] proprietaires {
            get {
                return this.proprietairesField;
            }
            set {
                this.proprietairesField = value;
                this.RaisePropertyChanged("proprietaires");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
                this.RaisePropertyChanged("tag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public typeCanal type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
                this.RaisePropertyChanged("typeSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://domain.j2e/")]
    public partial class utilisateur : object, System.ComponentModel.INotifyPropertyChanged {
        
        private canal[] canalAbonnesField;
        
        private canal[] canalAttenteField;
        
        private canal[] canalModerateursField;
        
        private canal[] canalProprietairesField;
        
        private string loginField;
        
        private message[] messagesEnvoyesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("canalAbonnes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public canal[] canalAbonnes {
            get {
                return this.canalAbonnesField;
            }
            set {
                this.canalAbonnesField = value;
                this.RaisePropertyChanged("canalAbonnes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("canalAttente", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public canal[] canalAttente {
            get {
                return this.canalAttenteField;
            }
            set {
                this.canalAttenteField = value;
                this.RaisePropertyChanged("canalAttente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("canalModerateurs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public canal[] canalModerateurs {
            get {
                return this.canalModerateursField;
            }
            set {
                this.canalModerateursField = value;
                this.RaisePropertyChanged("canalModerateurs");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("canalProprietaires", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public canal[] canalProprietaires {
            get {
                return this.canalProprietairesField;
            }
            set {
                this.canalProprietairesField = value;
                this.RaisePropertyChanged("canalProprietaires");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
                this.RaisePropertyChanged("login");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("messagesEnvoyes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public message[] messagesEnvoyes {
            get {
                return this.messagesEnvoyesField;
            }
            set {
                this.messagesEnvoyesField = value;
                this.RaisePropertyChanged("messagesEnvoyes");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://domain.j2e/")]
    public partial class message : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://domain.j2e/")]
    public enum typeCanal {
        
        /// <remarks/>
        PUBLIC,
        
        /// <remarks/>
        PRIVE,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByAbonne", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByAbonne {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public findCanalByAbonne() {
        }
        
        public findCanalByAbonne(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByAbonneResponse", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByAbonneResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PolyTweetWPF.CanalFinderService.canal[] @return;
        
        public findCanalByAbonneResponse() {
        }
        
        public findCanalByAbonneResponse(PolyTweetWPF.CanalFinderService.canal[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByProprietaire", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByProprietaire {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public findCanalByProprietaire() {
        }
        
        public findCanalByProprietaire(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByProprietaireResponse", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByProprietaireResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PolyTweetWPF.CanalFinderService.canal[] @return;
        
        public findCanalByProprietaireResponse() {
        }
        
        public findCanalByProprietaireResponse(PolyTweetWPF.CanalFinderService.canal[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByType", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByType {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PolyTweetWPF.CanalFinderService.typeCanal arg0;
        
        public findCanalByType() {
        }
        
        public findCanalByType(PolyTweetWPF.CanalFinderService.typeCanal arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByTypeResponse", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByTypeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PolyTweetWPF.CanalFinderService.canal[] @return;
        
        public findCanalByTypeResponse() {
        }
        
        public findCanalByTypeResponse(PolyTweetWPF.CanalFinderService.canal[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByTag", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByTag {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public findCanalByTag() {
        }
        
        public findCanalByTag(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findCanalByTagResponse", WrapperNamespace="http://domain.j2e/", IsWrapped=true)]
    public partial class findCanalByTagResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://domain.j2e/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PolyTweetWPF.CanalFinderService.canal @return;
        
        public findCanalByTagResponse() {
        }
        
        public findCanalByTagResponse(PolyTweetWPF.CanalFinderService.canal @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CanalFinderChannel : PolyTweetWPF.CanalFinderService.CanalFinder, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CanalFinderClient : System.ServiceModel.ClientBase<PolyTweetWPF.CanalFinderService.CanalFinder>, PolyTweetWPF.CanalFinderService.CanalFinder {
        
        public CanalFinderClient() {
        }
        
        public CanalFinderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CanalFinderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CanalFinderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CanalFinderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolyTweetWPF.CanalFinderService.findCanalByAbonneResponse PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByAbonne(PolyTweetWPF.CanalFinderService.findCanalByAbonne request) {
            return base.Channel.findCanalByAbonne(request);
        }
        
        public PolyTweetWPF.CanalFinderService.canal[] findCanalByAbonne(string arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByAbonne inValue = new PolyTweetWPF.CanalFinderService.findCanalByAbonne();
            inValue.arg0 = arg0;
            PolyTweetWPF.CanalFinderService.findCanalByAbonneResponse retVal = ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByAbonne(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByAbonneResponse> PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByAbonneAsync(PolyTweetWPF.CanalFinderService.findCanalByAbonne request) {
            return base.Channel.findCanalByAbonneAsync(request);
        }
        
        public System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByAbonneResponse> findCanalByAbonneAsync(string arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByAbonne inValue = new PolyTweetWPF.CanalFinderService.findCanalByAbonne();
            inValue.arg0 = arg0;
            return ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByAbonneAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolyTweetWPF.CanalFinderService.findCanalByProprietaireResponse PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByProprietaire(PolyTweetWPF.CanalFinderService.findCanalByProprietaire request) {
            return base.Channel.findCanalByProprietaire(request);
        }
        
        public PolyTweetWPF.CanalFinderService.canal[] findCanalByProprietaire(string arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByProprietaire inValue = new PolyTweetWPF.CanalFinderService.findCanalByProprietaire();
            inValue.arg0 = arg0;
            PolyTweetWPF.CanalFinderService.findCanalByProprietaireResponse retVal = ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByProprietaire(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByProprietaireResponse> PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByProprietaireAsync(PolyTweetWPF.CanalFinderService.findCanalByProprietaire request) {
            return base.Channel.findCanalByProprietaireAsync(request);
        }
        
        public System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByProprietaireResponse> findCanalByProprietaireAsync(string arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByProprietaire inValue = new PolyTweetWPF.CanalFinderService.findCanalByProprietaire();
            inValue.arg0 = arg0;
            return ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByProprietaireAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolyTweetWPF.CanalFinderService.findCanalByTypeResponse PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByType(PolyTweetWPF.CanalFinderService.findCanalByType request) {
            return base.Channel.findCanalByType(request);
        }
        
        public PolyTweetWPF.CanalFinderService.canal[] findCanalByType(PolyTweetWPF.CanalFinderService.typeCanal arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByType inValue = new PolyTweetWPF.CanalFinderService.findCanalByType();
            inValue.arg0 = arg0;
            PolyTweetWPF.CanalFinderService.findCanalByTypeResponse retVal = ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByType(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByTypeResponse> PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByTypeAsync(PolyTweetWPF.CanalFinderService.findCanalByType request) {
            return base.Channel.findCanalByTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByTypeResponse> findCanalByTypeAsync(PolyTweetWPF.CanalFinderService.typeCanal arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByType inValue = new PolyTweetWPF.CanalFinderService.findCanalByType();
            inValue.arg0 = arg0;
            return ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolyTweetWPF.CanalFinderService.findCanalByTagResponse PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByTag(PolyTweetWPF.CanalFinderService.findCanalByTag request) {
            return base.Channel.findCanalByTag(request);
        }
        
        public PolyTweetWPF.CanalFinderService.canal findCanalByTag(string arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByTag inValue = new PolyTweetWPF.CanalFinderService.findCanalByTag();
            inValue.arg0 = arg0;
            PolyTweetWPF.CanalFinderService.findCanalByTagResponse retVal = ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByTag(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByTagResponse> PolyTweetWPF.CanalFinderService.CanalFinder.findCanalByTagAsync(PolyTweetWPF.CanalFinderService.findCanalByTag request) {
            return base.Channel.findCanalByTagAsync(request);
        }
        
        public System.Threading.Tasks.Task<PolyTweetWPF.CanalFinderService.findCanalByTagResponse> findCanalByTagAsync(string arg0) {
            PolyTweetWPF.CanalFinderService.findCanalByTag inValue = new PolyTweetWPF.CanalFinderService.findCanalByTag();
            inValue.arg0 = arg0;
            return ((PolyTweetWPF.CanalFinderService.CanalFinder)(this)).findCanalByTagAsync(inValue);
        }
    }
}