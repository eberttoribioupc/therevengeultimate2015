﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.17929
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheRevenge.SOAPTest.ServiceMedico {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMedico.IMedicosService")]
    public interface IMedicosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicosService/crearMedico", ReplyAction="http://tempuri.org/IMedicosService/crearMedicoResponse")]
        TheRevenge.Data.Dominio.Medico crearMedico(string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string correo, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicosService/consultarMedico", ReplyAction="http://tempuri.org/IMedicosService/consultarMedicoResponse")]
        TheRevenge.Data.Dominio.Medico consultarMedico(int idmedico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicosService/actualizarMedico", ReplyAction="http://tempuri.org/IMedicosService/actualizarMedicoResponse")]
        TheRevenge.Data.Dominio.Medico actualizarMedico(int idmedico, string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicosService/eliminarMedico", ReplyAction="http://tempuri.org/IMedicosService/eliminarMedicoResponse")]
        void eliminarMedico(int idmedico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicosService/ListarMedico", ReplyAction="http://tempuri.org/IMedicosService/ListarMedicoResponse")]
        TheRevenge.Data.Dominio.Medico[] ListarMedico();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMedicosServiceChannel : TheRevenge.SOAPTest.ServiceMedico.IMedicosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MedicosServiceClient : System.ServiceModel.ClientBase<TheRevenge.SOAPTest.ServiceMedico.IMedicosService>, TheRevenge.SOAPTest.ServiceMedico.IMedicosService {
        
        public MedicosServiceClient() {
        }
        
        public MedicosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MedicosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TheRevenge.Data.Dominio.Medico crearMedico(string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string correo, string password) {
            return base.Channel.crearMedico(nombre, ape_paterno, ape_materno, sexo, tipo_Documento, nro_documento, cmp, especialidad, direccion, correo, password);
        }
        
        public TheRevenge.Data.Dominio.Medico consultarMedico(int idmedico) {
            return base.Channel.consultarMedico(idmedico);
        }
        
        public TheRevenge.Data.Dominio.Medico actualizarMedico(int idmedico, string nombre, string ape_paterno, string ape_materno, string sexo, int tipo_Documento, string nro_documento, int cmp, int especialidad, string direccion, string password) {
            return base.Channel.actualizarMedico(idmedico, nombre, ape_paterno, ape_materno, sexo, tipo_Documento, nro_documento, cmp, especialidad, direccion, password);
        }
        
        public void eliminarMedico(int idmedico) {
            base.Channel.eliminarMedico(idmedico);
        }
        
        public TheRevenge.Data.Dominio.Medico[] ListarMedico() {
            return base.Channel.ListarMedico();
        }
    }
}
