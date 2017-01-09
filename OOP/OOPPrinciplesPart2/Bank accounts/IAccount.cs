namespace Bank_accounts
{
    interface IAccount
    {
        decimal Interest();

        void DepositeMoney(decimal amount);

        void DrowMoney(decimal amount);
    }
}
