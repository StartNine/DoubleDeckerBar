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
    
    public class IModuleAssemblyContractToViewAddInAdapter : DoubleDeckerBar.Views.IModuleAssembly
    {
        private Start9.Api.Contracts.IModuleAssemblyContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IModuleAssemblyContractToViewAddInAdapter()
        {
        }
        public IModuleAssemblyContractToViewAddInAdapter(Start9.Api.Contracts.IModuleAssemblyContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public string Name
        {
            get
            {
                return _contract.Name;
            }
        }
        public string Description
        {
            get
            {
                return _contract.Description;
            }
        }
        public string Publisher
        {
            get
            {
                return _contract.Publisher;
            }
        }
        public System.Version Version
        {
            get
            {
                return _contract.Version;
            }
        }
        public System.Collections.Generic.IList<DoubleDeckerBar.Views.IModuleInstance> Instances
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIList<Start9.Api.Contracts.IModuleInstanceContract, DoubleDeckerBar.Views.IModuleInstance>(_contract.Instances, DoubleDeckerBar.Adapters.IModuleInstanceAddInAdapter.ContractToViewAdapter, DoubleDeckerBar.Adapters.IModuleInstanceAddInAdapter.ViewToContractAdapter);
            }
        }
        public DoubleDeckerBar.Views.IConfiguration SavedConfiguration
        {
            get
            {
                return DoubleDeckerBar.Adapters.IConfigurationAddInAdapter.ContractToViewAdapter(_contract.SavedConfiguration);
            }
        }
        public DoubleDeckerBar.Views.IConfiguration CurrentConfiguration
        {
            get
            {
                return DoubleDeckerBar.Adapters.IConfigurationAddInAdapter.ContractToViewAdapter(_contract.CurrentConfiguration);
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
        public void Kill(DoubleDeckerBar.Views.IModuleInstance instance)
        {
            _contract.Kill(DoubleDeckerBar.Adapters.IModuleInstanceAddInAdapter.ViewToContractAdapter(instance));
        }
        public void KillAll()
        {
            _contract.KillAll();
        }
        public void Activate(bool initialize)
        {
            _contract.Activate(initialize);
        }
        internal Start9.Api.Contracts.IModuleAssemblyContract GetSourceContract()
        {
            return _contract;
        }
    }
}

