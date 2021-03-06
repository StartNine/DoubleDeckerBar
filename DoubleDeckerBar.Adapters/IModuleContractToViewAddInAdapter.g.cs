//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoubleDeckerBar.Adapters
{
    
    public class IModuleContractToViewAddInAdapter : DoubleDeckerBar.Views.IModule
    {
        private Start9.Api.Contracts.IModuleContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IModuleContractToViewAddInAdapter()
        {
        }
        public IModuleContractToViewAddInAdapter(Start9.Api.Contracts.IModuleContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public DoubleDeckerBar.Views.IConfiguration Configuration
        {
            get
            {
                return DoubleDeckerBar.Adapters.IConfigurationAddInAdapter.ContractToViewAdapter(_contract.Configuration);
            }
            set
            {
                _contract.Configuration = DoubleDeckerBar.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(value);
            }
        }
        public DoubleDeckerBar.Views.IMessageContract MessageContract
        {
            get
            {
                return DoubleDeckerBar.Adapters.IMessageContractAddInAdapter.ContractToViewAdapter(_contract.MessageContract);
            }
        }
        public DoubleDeckerBar.Views.IReceiverContract ReceiverContract
        {
            get
            {
                return DoubleDeckerBar.Adapters.IReceiverContractAddInAdapter.ContractToViewAdapter(_contract.ReceiverContract);
            }
        }
        public void Initialize(DoubleDeckerBar.Views.IHost host)
        {
            _contract.Initialize(DoubleDeckerBar.Adapters.IHostAddInAdapter.ViewToContractAdapter(host));
        }
        internal Start9.Api.Contracts.IModuleContract GetSourceContract()
        {
            return _contract;
        }
    }
}

