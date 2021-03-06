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
    
    public class IModuleAssemblyViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IModuleAssemblyContract
    {
        private DoubleDeckerBar.Views.IModuleAssembly _view;
        public IModuleAssemblyViewToContractAddInAdapter(DoubleDeckerBar.Views.IModuleAssembly view)
        {
            _view = view;
        }
        public string Name
        {
            get
            {
                return _view.Name;
            }
        }
        public string Description
        {
            get
            {
                return _view.Description;
            }
        }
        public string Publisher
        {
            get
            {
                return _view.Publisher;
            }
        }
        public System.Version Version
        {
            get
            {
                return _view.Version;
            }
        }
        public System.AddIn.Contract.IListContract<Start9.Api.Contracts.IModuleInstanceContract> Instances
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<DoubleDeckerBar.Views.IModuleInstance, Start9.Api.Contracts.IModuleInstanceContract>(_view.Instances, DoubleDeckerBar.Adapters.IModuleInstanceAddInAdapter.ViewToContractAdapter, DoubleDeckerBar.Adapters.IModuleInstanceAddInAdapter.ContractToViewAdapter);
            }
        }
        public Start9.Api.Contracts.IConfigurationContract SavedConfiguration
        {
            get
            {
                return DoubleDeckerBar.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(_view.SavedConfiguration);
            }
        }
        public Start9.Api.Contracts.IConfigurationContract CurrentConfiguration
        {
            get
            {
                return DoubleDeckerBar.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(_view.CurrentConfiguration);
            }
        }
        public Start9.Api.Contracts.IMessageContractContract MessageContract
        {
            get
            {
                return DoubleDeckerBar.Adapters.IMessageContractAddInAdapter.ViewToContractAdapter(_view.MessageContract);
            }
        }
        public Start9.Api.Contracts.IReceiverContractContract ReceiverContract
        {
            get
            {
                return DoubleDeckerBar.Adapters.IReceiverContractAddInAdapter.ViewToContractAdapter(_view.ReceiverContract);
            }
        }
        public virtual void Kill(Start9.Api.Contracts.IModuleInstanceContract instance)
        {
            _view.Kill(DoubleDeckerBar.Adapters.IModuleInstanceAddInAdapter.ContractToViewAdapter(instance));
        }
        public virtual void KillAll()
        {
            _view.KillAll();
        }
        public virtual void Activate(bool initialize)
        {
            _view.Activate(initialize);
        }
        internal DoubleDeckerBar.Views.IModuleAssembly GetSourceView()
        {
            return _view;
        }
    }
}

