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
    
    public class IMessageContractToViewAddInAdapter : DoubleDeckerBar.Views.IMessage
    {
        private Start9.Api.Contracts.IMessageContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IMessageContractToViewAddInAdapter()
        {
        }
        public IMessageContractToViewAddInAdapter(Start9.Api.Contracts.IMessageContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public object Object
        {
            get
            {
                return _contract.Object;
            }
        }
        public DoubleDeckerBar.Views.IMessageEntry MessageEntry
        {
            get
            {
                return DoubleDeckerBar.Adapters.IMessageEntryAddInAdapter.ContractToViewAdapter(_contract.MessageEntry);
            }
        }
        internal Start9.Api.Contracts.IMessageContract GetSourceContract()
        {
            return _contract;
        }
    }
}
