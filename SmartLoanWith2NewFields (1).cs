// <copyright file="SmartLoan.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using Stratis.SmartContracts;

[Deploy]
public class SmartLoan : SmartContract
{
    public SmartLoan(ISmartContractState smartContractState)
   : base(smartContractState)
    {
    }

    private string Greeting
    {
        get
        {
            return this.State.GetString("Greeting from SmartLoanContract. Call to this method works!");
        }

        set
        {
            this.State.SetString("Greeting", value);
        }
    }

    private string OriginationDateTimeStamp
    {
        get => this.State.GetString(nameof(this.OriginationDateTimeStamp));

        set
        {
            this.State.SetString(nameof(this.OriginationDateTimeStamp), value);
        }
    }

    private string Currency
    {
        get => this.State.GetString(nameof(this.Currency));

        set => this.State.SetString(nameof(this.Currency), value);
    }

    private int LoanID
    {
        get
        {
            return this.State.GetInt32(nameof(this.LoanID));
        }

        set
        {
            this.State.SetInt32(nameof(this.LoanID), value);
        }
    }

    //  NEW CODE 
    //	Expressed in Tokens (200 Tokens. Currency Stratis)
    private int PremiumRisk
    {
        get
        {
            return this.State.GetInt32(nameof(this.PremiumRisk));
        }

        set
        {
            this.State.SetInt32(nameof(this.PremiumRisk), value);
        }
    }

    //  NEW CODE 
    // Expressed in Tokens (500 Tokens. Currency Stratis)
    private int ContractFees
    {
        get
        {
            return this.State.GetInt32(nameof(this.ContractFees));
        }

        set
        {
            this.State.SetInt32(nameof(this.ContractFees), value);
        }
    }

    private string Owner
    {
        get => this.State.GetString(nameof(this.Owner));

        set
        {
            this.State.SetString(nameof(this.Owner), value);
        }
    }

    private string OwnerAddressWallet
    {
        get => this.State.GetString(nameof(this.OwnerAddressWallet));

        set
        {
            this.State.SetString(nameof(this.OwnerAddressWallet), value);
        }
    }

    private Lender[] Lenders
    {
        get => this.State.GetArray<Lender>(nameof(this.Lenders));

        set
        {
            this.State.SetArray(nameof(this.Lenders), value);
        }
    }

    public string TestCallFromContract()
    {
        return this.Greeting;
    }
}