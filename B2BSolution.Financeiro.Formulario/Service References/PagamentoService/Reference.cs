﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B2BSolution.Financeiro.Formulario.PagamentoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PagamentoService.IInserirOf_Pagamento")]
    public interface IInserirOf_Pagamento {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInserirOf_Pagamento/Incluir", ReplyAction="http://tempuri.org/IInserirOf_Pagamento/IncluirResponse")]
        int Incluir(B2BSolution.Financeiro.Entidades.Pagamento entidades);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInserirOf_Pagamento/Incluir", ReplyAction="http://tempuri.org/IInserirOf_Pagamento/IncluirResponse")]
        System.Threading.Tasks.Task<int> IncluirAsync(B2BSolution.Financeiro.Entidades.Pagamento entidades);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInserirOf_PagamentoChannel : B2BSolution.Financeiro.Formulario.PagamentoService.IInserirOf_Pagamento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InserirOf_PagamentoClient : System.ServiceModel.ClientBase<B2BSolution.Financeiro.Formulario.PagamentoService.IInserirOf_Pagamento>, B2BSolution.Financeiro.Formulario.PagamentoService.IInserirOf_Pagamento {
        
        public InserirOf_PagamentoClient() {
        }
        
        public InserirOf_PagamentoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InserirOf_PagamentoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InserirOf_PagamentoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InserirOf_PagamentoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Incluir(B2BSolution.Financeiro.Entidades.Pagamento entidades) {
            return base.Channel.Incluir(entidades);
        }
        
        public System.Threading.Tasks.Task<int> IncluirAsync(B2BSolution.Financeiro.Entidades.Pagamento entidades) {
            return base.Channel.IncluirAsync(entidades);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PagamentoService.IListarTodosOf_Pagamento")]
    public interface IListarTodosOf_Pagamento {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListarTodosOf_Pagamento/ListarTodos", ReplyAction="http://tempuri.org/IListarTodosOf_Pagamento/ListarTodosResponse")]
        B2BSolution.Financeiro.Entidades.Pagamento[] ListarTodos(B2BSolution.Financeiro.Entidades.Pagamento entidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListarTodosOf_Pagamento/ListarTodos", ReplyAction="http://tempuri.org/IListarTodosOf_Pagamento/ListarTodosResponse")]
        System.Threading.Tasks.Task<B2BSolution.Financeiro.Entidades.Pagamento[]> ListarTodosAsync(B2BSolution.Financeiro.Entidades.Pagamento entidade);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IListarTodosOf_PagamentoChannel : B2BSolution.Financeiro.Formulario.PagamentoService.IListarTodosOf_Pagamento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListarTodosOf_PagamentoClient : System.ServiceModel.ClientBase<B2BSolution.Financeiro.Formulario.PagamentoService.IListarTodosOf_Pagamento>, B2BSolution.Financeiro.Formulario.PagamentoService.IListarTodosOf_Pagamento {
        
        public ListarTodosOf_PagamentoClient() {
        }
        
        public ListarTodosOf_PagamentoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ListarTodosOf_PagamentoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListarTodosOf_PagamentoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListarTodosOf_PagamentoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public B2BSolution.Financeiro.Entidades.Pagamento[] ListarTodos(B2BSolution.Financeiro.Entidades.Pagamento entidade) {
            return base.Channel.ListarTodos(entidade);
        }
        
        public System.Threading.Tasks.Task<B2BSolution.Financeiro.Entidades.Pagamento[]> ListarTodosAsync(B2BSolution.Financeiro.Entidades.Pagamento entidade) {
            return base.Channel.ListarTodosAsync(entidade);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PagamentoService.IEntidadeOf_Pagamento")]
    public interface IEntidadeOf_Pagamento {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidadeOf_Pagamento/Entidade", ReplyAction="http://tempuri.org/IEntidadeOf_Pagamento/EntidadeResponse")]
        B2BSolution.Financeiro.Entidades.Pagamento Entidade(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidadeOf_Pagamento/Entidade", ReplyAction="http://tempuri.org/IEntidadeOf_Pagamento/EntidadeResponse")]
        System.Threading.Tasks.Task<B2BSolution.Financeiro.Entidades.Pagamento> EntidadeAsync(string codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntidadeOf_PagamentoChannel : B2BSolution.Financeiro.Formulario.PagamentoService.IEntidadeOf_Pagamento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntidadeOf_PagamentoClient : System.ServiceModel.ClientBase<B2BSolution.Financeiro.Formulario.PagamentoService.IEntidadeOf_Pagamento>, B2BSolution.Financeiro.Formulario.PagamentoService.IEntidadeOf_Pagamento {
        
        public EntidadeOf_PagamentoClient() {
        }
        
        public EntidadeOf_PagamentoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntidadeOf_PagamentoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntidadeOf_PagamentoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntidadeOf_PagamentoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public B2BSolution.Financeiro.Entidades.Pagamento Entidade(string codigo) {
            return base.Channel.Entidade(codigo);
        }
        
        public System.Threading.Tasks.Task<B2BSolution.Financeiro.Entidades.Pagamento> EntidadeAsync(string codigo) {
            return base.Channel.EntidadeAsync(codigo);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PagamentoService.IParametroListaOf_Pagamento")]
    public interface IParametroListaOf_Pagamento {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParametroListaOf_Pagamento/EntidadeParametro", ReplyAction="http://tempuri.org/IParametroListaOf_Pagamento/EntidadeParametroResponse")]
        void EntidadeParametro(B2BSolution.Financeiro.Entidades.Pagamento[] lista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParametroListaOf_Pagamento/EntidadeParametro", ReplyAction="http://tempuri.org/IParametroListaOf_Pagamento/EntidadeParametroResponse")]
        System.Threading.Tasks.Task EntidadeParametroAsync(B2BSolution.Financeiro.Entidades.Pagamento[] lista);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IParametroListaOf_PagamentoChannel : B2BSolution.Financeiro.Formulario.PagamentoService.IParametroListaOf_Pagamento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ParametroListaOf_PagamentoClient : System.ServiceModel.ClientBase<B2BSolution.Financeiro.Formulario.PagamentoService.IParametroListaOf_Pagamento>, B2BSolution.Financeiro.Formulario.PagamentoService.IParametroListaOf_Pagamento {
        
        public ParametroListaOf_PagamentoClient() {
        }
        
        public ParametroListaOf_PagamentoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ParametroListaOf_PagamentoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParametroListaOf_PagamentoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParametroListaOf_PagamentoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void EntidadeParametro(B2BSolution.Financeiro.Entidades.Pagamento[] lista) {
            base.Channel.EntidadeParametro(lista);
        }
        
        public System.Threading.Tasks.Task EntidadeParametroAsync(B2BSolution.Financeiro.Entidades.Pagamento[] lista) {
            return base.Channel.EntidadeParametroAsync(lista);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PagamentoService.IDeletar")]
    public interface IDeletar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeletar/Deletar", ReplyAction="http://tempuri.org/IDeletar/DeletarResponse")]
        void Deletar(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeletar/Deletar", ReplyAction="http://tempuri.org/IDeletar/DeletarResponse")]
        System.Threading.Tasks.Task DeletarAsync(string codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDeletarChannel : B2BSolution.Financeiro.Formulario.PagamentoService.IDeletar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeletarClient : System.ServiceModel.ClientBase<B2BSolution.Financeiro.Formulario.PagamentoService.IDeletar>, B2BSolution.Financeiro.Formulario.PagamentoService.IDeletar {
        
        public DeletarClient() {
        }
        
        public DeletarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeletarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeletarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeletarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Deletar(string codigo) {
            base.Channel.Deletar(codigo);
        }
        
        public System.Threading.Tasks.Task DeletarAsync(string codigo) {
            return base.Channel.DeletarAsync(codigo);
        }
    }
}