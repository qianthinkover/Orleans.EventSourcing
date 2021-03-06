//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Orleans.EventSourcing.SimpleGrain
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Runtime.Serialization;
    using Orleans.CodeGeneration;
    using Orleans;
    using Orleans.EventSourcing;
    using System.Runtime.InteropServices;
    using Orleans.EventSourcing.SimpleInterface;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Orleans.EventSourcing.SimpleGrain.Orleans.EventSourcing.SimpleGrain.BankAcount")]
    public class BankAcountState : global::Orleans.CodeGeneration.GrainState, IBankAcountState
    {
        

            public UInt64 Version { get; set; }

            public Dictionary<Guid,TransactionPreparation> TransactionPreparations { get; set; }

            public Guid OwnerId { get; set; }

            public Decimal Balance { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Version", out value)) Version = (UInt64) value;
                if (values.TryGetValue("TransactionPreparations", out value)) TransactionPreparations = (Dictionary<Guid,TransactionPreparation>) value;
                if (values.TryGetValue("OwnerId", out value)) OwnerId = (Guid) value;
                if (values.TryGetValue("Balance", out value)) Balance = (Decimal) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("BankAcountState( Version={0} TransactionPreparations={1} OwnerId={2} Balance={3} )", Version, TransactionPreparations, OwnerId, Balance);
            }
        
        public BankAcountState() : 
                base("Orleans.EventSourcing.SimpleGrain.BankAcount")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Version"] = this.Version;
            result["TransactionPreparations"] = this.TransactionPreparations;
            result["OwnerId"] = this.OwnerId;
            result["Balance"] = this.Balance;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Version = default(UInt64);
            this.TransactionPreparations = new Dictionary<Guid,TransactionPreparation>();
            this.OwnerId = default(Guid);
            this.Balance = default(Decimal);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            BankAcountState input = ((BankAcountState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            BankAcountState input = ((BankAcountState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            BankAcountState result = new BankAcountState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Orleans.EventSourcing.SimpleGrain.Orleans.EventSourcing.SimpleGrain.TransferTrans" +
        "action")]
    public class TransferTransactionState : global::Orleans.CodeGeneration.GrainState, ITransferTransactionState
    {
        

            public UInt64 Version { get; set; }

            public TransactionStatus Status { get; set; }

            public Boolean TransferOutPreparationConfirmed { get; set; }

            public Boolean TransferInPreparationConfirmed { get; set; }

            public Boolean TransferOutConfirmed { get; set; }

            public Boolean TransferInConfirmed { get; set; }

            public DateTime AccountValidatedAt { get; set; }

            public DateTime TransferOutPreparationConfirmedAt { get; set; }

            public DateTime TransferInPreparationConfirmedAt { get; set; }

            public DateTime TransferOutConfirmedAt { get; set; }

            public DateTime TransferInConfirmedAt { get; set; }

            public DateTime TransferCancelAt { get; set; }

            public TransferTransactionInfo TransferTransactionInfo { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Version", out value)) Version = (UInt64) value;
                if (values.TryGetValue("Status", out value)) Status = (TransactionStatus) value;
                if (values.TryGetValue("TransferOutPreparationConfirmed", out value)) TransferOutPreparationConfirmed = (Boolean) value;
                if (values.TryGetValue("TransferInPreparationConfirmed", out value)) TransferInPreparationConfirmed = (Boolean) value;
                if (values.TryGetValue("TransferOutConfirmed", out value)) TransferOutConfirmed = (Boolean) value;
                if (values.TryGetValue("TransferInConfirmed", out value)) TransferInConfirmed = (Boolean) value;
                if (values.TryGetValue("AccountValidatedAt", out value)) AccountValidatedAt = (DateTime) value;
                if (values.TryGetValue("TransferOutPreparationConfirmedAt", out value)) TransferOutPreparationConfirmedAt = (DateTime) value;
                if (values.TryGetValue("TransferInPreparationConfirmedAt", out value)) TransferInPreparationConfirmedAt = (DateTime) value;
                if (values.TryGetValue("TransferOutConfirmedAt", out value)) TransferOutConfirmedAt = (DateTime) value;
                if (values.TryGetValue("TransferInConfirmedAt", out value)) TransferInConfirmedAt = (DateTime) value;
                if (values.TryGetValue("TransferCancelAt", out value)) TransferCancelAt = (DateTime) value;
                if (values.TryGetValue("TransferTransactionInfo", out value)) TransferTransactionInfo = (TransferTransactionInfo) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("TransferTransactionState( Version={0} Status={1} TransferOutPreparationConfirmed={2} TransferInPreparationConfirmed={3} TransferOutConfirmed={4} TransferInConfirmed={5} AccountValidatedAt={6} TransferOutPreparationConfirmedAt={7} TransferInPreparationConfirmedAt={8} TransferOutConfirmedAt={9} TransferInConfirmedAt={10} TransferCancelAt={11} TransferTransactionInfo={12} )", Version, Status, TransferOutPreparationConfirmed, TransferInPreparationConfirmed, TransferOutConfirmed, TransferInConfirmed, AccountValidatedAt, TransferOutPreparationConfirmedAt, TransferInPreparationConfirmedAt, TransferOutConfirmedAt, TransferInConfirmedAt, TransferCancelAt, TransferTransactionInfo);
            }
        
        public TransferTransactionState() : 
                base("Orleans.EventSourcing.SimpleGrain.TransferTransaction")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Version"] = this.Version;
            result["Status"] = this.Status;
            result["TransferOutPreparationConfirmed"] = this.TransferOutPreparationConfirmed;
            result["TransferInPreparationConfirmed"] = this.TransferInPreparationConfirmed;
            result["TransferOutConfirmed"] = this.TransferOutConfirmed;
            result["TransferInConfirmed"] = this.TransferInConfirmed;
            result["AccountValidatedAt"] = this.AccountValidatedAt;
            result["TransferOutPreparationConfirmedAt"] = this.TransferOutPreparationConfirmedAt;
            result["TransferInPreparationConfirmedAt"] = this.TransferInPreparationConfirmedAt;
            result["TransferOutConfirmedAt"] = this.TransferOutConfirmedAt;
            result["TransferInConfirmedAt"] = this.TransferInConfirmedAt;
            result["TransferCancelAt"] = this.TransferCancelAt;
            result["TransferTransactionInfo"] = this.TransferTransactionInfo;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Version = default(UInt64);
            this.Status = default(TransactionStatus);
            this.TransferOutPreparationConfirmed = default(Boolean);
            this.TransferInPreparationConfirmed = default(Boolean);
            this.TransferOutConfirmed = default(Boolean);
            this.TransferInConfirmed = default(Boolean);
            this.AccountValidatedAt = default(DateTime);
            this.TransferOutPreparationConfirmedAt = default(DateTime);
            this.TransferInPreparationConfirmedAt = default(DateTime);
            this.TransferOutConfirmedAt = default(DateTime);
            this.TransferInConfirmedAt = default(DateTime);
            this.TransferCancelAt = default(DateTime);
            this.TransferTransactionInfo = new TransferTransactionInfo();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            TransferTransactionState input = ((TransferTransactionState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            TransferTransactionState input = ((TransferTransactionState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            TransferTransactionState result = new TransferTransactionState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
