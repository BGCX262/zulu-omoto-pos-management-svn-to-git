//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Zulu.BusinessService.Data
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Purchase))]
    public partial class PurchaseProductVariant: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int PurchaseProductVariantID
        {
            get { return _purchaseProductVariantID; }
            set
            {
                if (_purchaseProductVariantID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'PurchaseProductVariantID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _purchaseProductVariantID = value;
                    OnPropertyChanged("PurchaseProductVariantID");
                }
            }
        }
        private int _purchaseProductVariantID;
    
        [DataMember]
        public Nullable<int> PurchaseID
        {
            get { return _purchaseID; }
            set
            {
                if (_purchaseID != value)
                {
                    ChangeTracker.RecordOriginalValue("PurchaseID", _purchaseID);
                    if (!IsDeserializing)
                    {
                        if (npPurchase != null && npPurchase.PurchaseID != value)
                        {
                            npPurchase = null;
                        }
                    }
                    _purchaseID = value;
                    OnPropertyChanged("PurchaseID");
                }
            }
        }
        private Nullable<int> _purchaseID;
    
        [DataMember]
        public string PurchasedProductVariantBarcode
        {
            get { return _purchasedProductVariantBarcode; }
            set
            {
                if (_purchasedProductVariantBarcode != value)
                {
                    _purchasedProductVariantBarcode = value;
                    OnPropertyChanged("PurchasedProductVariantBarcode");
                }
            }
        }
        private string _purchasedProductVariantBarcode;
    
        [DataMember]
        public string ProductVariantName
        {
            get { return _productVariantName; }
            set
            {
                if (_productVariantName != value)
                {
                    _productVariantName = value;
                    OnPropertyChanged("ProductVariantName");
                }
            }
        }
        private string _productVariantName;
    
        [DataMember]
        public Nullable<int> Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }
        private Nullable<int> _quantity;
    
        [DataMember]
        public Nullable<decimal> BuyingPrice
        {
            get { return _buyingPrice; }
            set
            {
                if (_buyingPrice != value)
                {
                    _buyingPrice = value;
                    OnPropertyChanged("BuyingPrice");
                }
            }
        }
        private Nullable<decimal> _buyingPrice;
    
        [DataMember]
        public Nullable<int> CheckByUserID
        {
            get { return _checkByUserID; }
            set
            {
                if (_checkByUserID != value)
                {
                    _checkByUserID = value;
                    OnPropertyChanged("CheckByUserID");
                }
            }
        }
        private Nullable<int> _checkByUserID;
    
        [DataMember]
        public Nullable<int> ActualQuantity
        {
            get { return _actualQuantity; }
            set
            {
                if (_actualQuantity != value)
                {
                    _actualQuantity = value;
                    OnPropertyChanged("ActualQuantity");
                }
            }
        }
        private Nullable<int> _actualQuantity;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Purchase npPurchase
        {
            get { return _npPurchase; }
            set
            {
                if (!ReferenceEquals(_npPurchase, value))
                {
                    var previousValue = _npPurchase;
                    _npPurchase = value;
                    FixupnpPurchase(previousValue);
                    OnNavigationPropertyChanged("npPurchase");
                }
            }
        }
        private Purchase _npPurchase;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            npPurchase = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpPurchase(Purchase previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npPurchaseProductVariants.Contains(this))
            {
                previousValue.npPurchaseProductVariants.Remove(this);
            }
    
            if (npPurchase != null)
            {
                if (!npPurchase.npPurchaseProductVariants.Contains(this))
                {
                    npPurchase.npPurchaseProductVariants.Add(this);
                }
    
                PurchaseID = npPurchase.PurchaseID;
            }
            else if (!skipKeys)
            {
                PurchaseID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npPurchase")
                    && (ChangeTracker.OriginalValues["npPurchase"] == npPurchase))
                {
                    ChangeTracker.OriginalValues.Remove("npPurchase");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npPurchase", previousValue);
                }
                if (npPurchase != null && !npPurchase.ChangeTracker.ChangeTrackingEnabled)
                {
                    npPurchase.StartTracking();
                }
            }
        }

        #endregion
    }
}
