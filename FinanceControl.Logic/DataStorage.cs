using System;
using System.Collections.Generic;
using FinanceControl.Logic.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using FinanceControl.Logic.Enums;

namespace FinanceControl.Logic
{
    public class DataStorage
    {
        private Dictionary<int, TransactionCategoryModel> _transactionCategorys;
        private Dictionary<int, TransactionModel> _transactions;
        private Dictionary<int, AccountModel> _clientsFinance;

        int _transactionCategorysLastId;

        public DataStorage() 
        {
            _transactionCategorys = new Dictionary<int, TransactionCategoryModel>();
            _transactions = new Dictionary<int, TransactionModel>();
            _clientsFinance = new Dictionary<int, AccountModel>();

            _transactionCategorysLastId = 1;
        }

        public void AddCategory(TransactionCategoryModel category)
        {
            category.Id = _transactionCategorysLastId;
            _transactionCategorys.Add(_transactionCategorysLastId, category);
            _transactionCategorysLastId++;
        }

        public void DetachCategory(int id)
        {
            _transactionCategorys.Remove(id);
        }

        public TransactionCategoryModel GetTransactionModelById(int id)
        {
            return _transactionCategorys[id];
        }

        public List<TransactionCategoryModel> GetTransactionsModels()
        {
            return _transactionCategorys.Values.ToList();
        }
    }
}
