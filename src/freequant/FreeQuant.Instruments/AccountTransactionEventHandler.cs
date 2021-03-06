using System;

namespace FreeQuant.Instruments
{
	public class AccountTransactionEventArgs : EventArgs
	{
		public AccountTransaction Transaction { get; set; }
        public AccountTransactionEventArgs(AccountTransaction transaction) : base()
        {
            this.Transaction = transaction;
        }
	}
	public delegate void AccountTransactionEventHandler(object sender, AccountTransactionEventArgs args);
}
