﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupErp.Entities;
using System.Diagnostics;

namespace SupErp.DAL.GestionComptabilityDAL
{
    public class ComptabilityDAL
    {
        #region Read

        public IEnumerable<COMPTA_ClassOfAccounts> GetAccountingClasses()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_ClassOfAccounts
                    .Include("COMPTA_ChartOfAccounts").ToList();
            }
        }

        public IEnumerable<COMPTA_ChartOfAccounts> GetAccountingAccounts()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_ChartOfAccounts
                    .Include("COMPTA_AccountingEntries")
                    .Include("COMPTA_ClassOfAccounts").ToList();
            }
        }

        public COMPTA_ExchangeRate GetLastExchangeRate()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_ExchangeRate.OrderByDescending(x => x.updatedDate).FirstOrDefault();
            }
        }

        public IEnumerable<COMPTA_Currency> GetCurrencies()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_Currency.Include("COMPTA_BankAccount");
            }
        }

        public IEnumerable<COMPTA_Bank> GetBanks()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_Bank.Include("COMPTA_BankAccount");
            }
        }

        public IEnumerable<COMPTA_BankAccount> GetBankAccounts()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_BankAccount
                    .Include("COMPTA_Bank")
                    .Include("COMPTA_BankJournalLine")
                    .Include("COMPTA_Currency");
            }
        }

        public List<COMPTA_AccountingEntries> GetAccountingEntries()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_AccountingEntries
                    .Include("COMPTA_AccountingEntries_Periodicity")
                    .Include("COMPTA_ChartOfAccounts").ToList();
            }
        }

        public List<COMPTA_AccountingEntries> GetAccountingEntriesTop1 ()
        {
            using ( SUPERPEntities context = new SUPERPEntities(false) )
            {
                return context.COMPTA_AccountingEntries
                    .Include("COMPTA_AccountingEntries_Periodicity")
                    .Include("COMPTA_ChartOfAccounts").ToList();
            }
        }

        public IEnumerable<COMPTA_BankJournalLine> GetBankJournalLines()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_BankJournalLine.Include("COMPTA_BankAccount");
            }
        }

        public IEnumerable<COMPTA_CustomerJournalLine> GetCustomerJournalLines()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_CustomerJournalLine;
            }
        }

        public IEnumerable<COMPTA_SupplierJournalLine> GetSupplierJournalLines()
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                return context.COMPTA_SupplierJournalLine;
            }
        }

        public COMPTA_AccountingEntries_Periodicity GetAccountingEntriesPeriodicityById ( long id )
        {
            using ( SUPERPEntities context = new SUPERPEntities(false) )
            {
                return context.COMPTA_AccountingEntries_Periodicity.Include("COMPTA_Periodicity").Include("COMPTA_AccountingEntries").FirstOrDefault(x => x.COMPTA_AccountingEntries.id == id );
            }
        }

        public IEnumerable<COMPTA_AccountingEntries_Periodicity> GetAccountingEntriesPeriodicity ( )
        {
            using ( SUPERPEntities context = new SUPERPEntities(false) )
            {
                return context.COMPTA_AccountingEntries_Periodicity.Include("COMPTA_Periodicity").Include("COMPTA_AccountingEntries").ToList();
            }
        }

        #endregion

        #region Create

        public COMPTA_ClassOfAccounts CreateAccountingClass(COMPTA_ClassOfAccounts accountingClassToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var accountingClass = context.COMPTA_ClassOfAccounts.Add(accountingClassToAdd);
                context.SaveChanges();
                return accountingClass;
            }
        }

        public COMPTA_ChartOfAccounts CreateAccountingAccount(COMPTA_ChartOfAccounts accountingAccountToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var accountingAccount = context.COMPTA_ChartOfAccounts.Add(accountingAccountToAdd);
                context.SaveChanges();
                return accountingAccount;
            }
        }

        public COMPTA_ExchangeRate CreateExchangeRate(COMPTA_ExchangeRate exchangeRateToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var exchangeRate = context.COMPTA_ExchangeRate.Add(exchangeRateToAdd);
                context.SaveChanges();
                return exchangeRate;
            }
        }

        public COMPTA_Currency CreateCurrency(COMPTA_Currency currencyToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var currency = context.COMPTA_Currency.Add(currencyToAdd);
                context.SaveChanges();
                return currency;
            }
        }

        public COMPTA_Bank CreateBank(COMPTA_Bank bankToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {              
                var bank = context.COMPTA_Bank.Add(bankToAdd);
                context.SaveChanges();
                return bank;
            }
        }

        public COMPTA_BankAccount CreateBankAccount(COMPTA_BankAccount bankAccountToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var bankAccount = context.COMPTA_BankAccount.Add(bankAccountToAdd);
                context.SaveChanges();
                return bankAccount;
            }
        }

        public COMPTA_AccountingEntries CreateAccountingEntry(COMPTA_AccountingEntries accountingEntryToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var accountingEntry = context.COMPTA_AccountingEntries.Add(accountingEntryToAdd);
                context.SaveChanges();
                return accountingEntry;
            }
        }

        public COMPTA_BankJournalLine CreateBankJournalLine(COMPTA_BankJournalLine bankJournalLineToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var bankJournalLine = context.COMPTA_BankJournalLine.Add(bankJournalLineToAdd);
                context.SaveChanges();
                return bankJournalLine;
            }
        }

        public COMPTA_CustomerJournalLine CreateCustomerJournalLine(COMPTA_CustomerJournalLine customerJournalLineToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var customerJournalLine = context.COMPTA_CustomerJournalLine.Add(customerJournalLineToAdd);
                context.SaveChanges();
                return customerJournalLine;
            }
        }

        public COMPTA_SupplierJournalLine CreateSupplierJournalLine(COMPTA_SupplierJournalLine supplierJournalLineToAdd)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var supplierJournalLine = context.COMPTA_SupplierJournalLine.Add(supplierJournalLineToAdd);
                context.SaveChanges();
                return supplierJournalLine;
            }
        }

        #endregion

        #region Edit

        public COMPTA_ClassOfAccounts EditAccountingClass(COMPTA_ClassOfAccounts accountingClassToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var accountingClass = context.COMPTA_ClassOfAccounts.Find(accountingClassToEdit.id);

                if (accountingClass == null)
                    return null;

                accountingClass = accountingClassToEdit;
                context.SaveChanges();
                return accountingClass;
            }
        }

        public COMPTA_ChartOfAccounts EditAccountingAccount(COMPTA_ChartOfAccounts accountingAccountToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var accountingAccount = context.COMPTA_ChartOfAccounts.Find(accountingAccountToEdit.id);

                if (accountingAccount == null)
                    return null;

                accountingAccount = accountingAccountToEdit;
                context.SaveChanges();
                return accountingAccount;
            }
        }

        public COMPTA_ExchangeRate EditExchangeRate(COMPTA_ExchangeRate exchangeRateToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var exchangeRate = context.COMPTA_ExchangeRate.Find(exchangeRateToEdit.id);

                if (exchangeRate == null)
                    return null;

                exchangeRate = exchangeRateToEdit;
                context.SaveChanges();
                return exchangeRate;
            }
        }

        public COMPTA_Currency EditCurrency(COMPTA_Currency currencyToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var currency = context.COMPTA_Currency.Find(currencyToEdit.id);

                if (currency == null)
                    return null;

                currency = currencyToEdit;
                context.SaveChanges();
                return currency;
            }
        }

        public COMPTA_Bank EditBank(COMPTA_Bank bankToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var bank = context.COMPTA_Bank.Find(bankToEdit.id);

                if (bank == null)
                    return null;

                bank = bankToEdit;
                context.SaveChanges();
                return bank;
            }
        }

        public COMPTA_BankAccount EditBankAccount(COMPTA_BankAccount bankAccountToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var bankAccount = context.COMPTA_BankAccount.Find(bankAccountToEdit.id);

                if (bankAccount == null)
                    return null;

                bankAccount = bankAccountToEdit;
                context.SaveChanges();
                return bankAccount;
            }
        }

        public COMPTA_AccountingEntries EditAccountingEntry(COMPTA_AccountingEntries accountingEntryToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var accountingEntry = context.COMPTA_AccountingEntries.Find(accountingEntryToEdit.id);

                if (accountingEntry == null)
                    return null;

                accountingEntry = accountingEntryToEdit;
                context.SaveChanges();
                return accountingEntry;
            }
        }

        public COMPTA_BankJournalLine EditBankJournalLine(COMPTA_BankJournalLine bankJournalLineToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var bankJournalLine = context.COMPTA_BankJournalLine.Find(bankJournalLineToEdit.id);

                if (bankJournalLine == null)
                    return null;

                bankJournalLine = bankJournalLineToEdit;
                context.SaveChanges();
                return bankJournalLine;
            }
        }

        public COMPTA_CustomerJournalLine EditCustomerJournalLine(COMPTA_CustomerJournalLine customerJournalLineToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var customerJournalLine = context.COMPTA_CustomerJournalLine.Find(customerJournalLineToEdit.id);

                if (customerJournalLine == null)
                    return null;

                customerJournalLine = customerJournalLineToEdit;
                context.SaveChanges();
                return customerJournalLine;
            }
        }

        public COMPTA_SupplierJournalLine EditSupplierJournalLine(COMPTA_SupplierJournalLine supplierJournalLineToEdit)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                var supplierJournalLine = context.COMPTA_SupplierJournalLine.Find(supplierJournalLineToEdit.id);

                if (supplierJournalLine == null)
                    return null;

                supplierJournalLine = supplierJournalLineToEdit;
                context.SaveChanges();
                return supplierJournalLine;
            }
        }

        #endregion

        #region Delete

        public bool DeleteAccountingClass(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_ClassOfAccounts.Remove(context.COMPTA_ClassOfAccounts.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression de la classe comptable. Message : " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteAccountingAccount(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_ChartOfAccounts.Remove(context.COMPTA_ChartOfAccounts.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression du compte comptable : " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteExchangeRate(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_ExchangeRate.Remove(context.COMPTA_ExchangeRate.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression du taux de change : " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteCurrency(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_Currency.Remove(context.COMPTA_Currency.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression de la devise : " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteBank(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_Bank.Remove(context.COMPTA_Bank.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression de la banque : " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteBankAccount(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_BankAccount.Remove(context.COMPTA_BankAccount.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression du compte bancaire : " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteAccountingEntry(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_AccountingEntries.Remove(context.COMPTA_AccountingEntries.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression de la ligne du journal général : " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteBankJournalLine(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
            {
                try
                {
                    context.COMPTA_BankJournalLine.Remove(context.COMPTA_BankJournalLine.Find(id));
                    context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression de la ligne du journal de banque " + e.Message);
                    return false;
                }
            }
        }

        public bool DeleteCustomerJournalLine(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
        {
                try
            {
                    context.COMPTA_CustomerJournalLine.Remove(context.COMPTA_CustomerJournalLine.Find(id));
                context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression de la ligne du journal client : " + e.Message);                    
                    return false;
                }
            }
        }

        public bool DeleteSupplierJournalLine(int id)
        {
            using(SUPERPEntities context = new SUPERPEntities(false))
        {
                try
            {
                    context.COMPTA_SupplierJournalLine.Remove(context.COMPTA_SupplierJournalLine.Find(id));
                context.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Echec de suppression de la ligne du journal fournisseur : " + e.Message);
                    return false;
                }
            }
        }

        #endregion       
    }
}
