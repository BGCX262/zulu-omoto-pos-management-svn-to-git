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
    [KnownType(typeof(Address))]
    [KnownType(typeof(Distributor))]
    [KnownType(typeof(WarehouseType))]
    public partial class Warehouse: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int WarehouseID
        {
            get { return _warehouseID; }
            set
            {
                if (_warehouseID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'WarehouseID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _warehouseID = value;
                    OnPropertyChanged("WarehouseID");
                }
            }
        }
        private int _warehouseID;
    
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;
    
        [DataMember]
        public Nullable<int> AddressID
        {
            get { return _addressID; }
            set
            {
                if (_addressID != value)
                {
                    ChangeTracker.RecordOriginalValue("AddressID", _addressID);
                    if (!IsDeserializing)
                    {
                        if (npAddress != null && npAddress.AddressID != value)
                        {
                            npAddress = null;
                        }
                    }
                    _addressID = value;
                    OnPropertyChanged("AddressID");
                }
            }
        }
        private Nullable<int> _addressID;
    
        [DataMember]
        public Nullable<int> WarehouseTypeID
        {
            get { return _warehouseTypeID; }
            set
            {
                if (_warehouseTypeID != value)
                {
                    ChangeTracker.RecordOriginalValue("WarehouseTypeID", _warehouseTypeID);
                    if (!IsDeserializing)
                    {
                        if (npWarehouseType != null && npWarehouseType.WarehouseTypeID != value)
                        {
                            npWarehouseType = null;
                        }
                    }
                    _warehouseTypeID = value;
                    OnPropertyChanged("WarehouseTypeID");
                }
            }
        }
        private Nullable<int> _warehouseTypeID;
    
        [DataMember]
        public Nullable<int> DistributorID
        {
            get { return _distributorID; }
            set
            {
                if (_distributorID != value)
                {
                    ChangeTracker.RecordOriginalValue("DistributorID", _distributorID);
                    if (!IsDeserializing)
                    {
                        if (npDistributor != null && npDistributor.DistributorID != value)
                        {
                            npDistributor = null;
                        }
                    }
                    _distributorID = value;
                    OnPropertyChanged("DistributorID");
                }
            }
        }
        private Nullable<int> _distributorID;
    
        [DataMember]
        public Nullable<bool> IsPublished
        {
            get { return _isPublished; }
            set
            {
                if (_isPublished != value)
                {
                    _isPublished = value;
                    OnPropertyChanged("IsPublished");
                }
            }
        }
        private Nullable<bool> _isPublished;
    
        [DataMember]
        public Nullable<int> PriceType
        {
            get { return _priceType; }
            set
            {
                if (_priceType != value)
                {
                    _priceType = value;
                    OnPropertyChanged("PriceType");
                }
            }
        }
        private Nullable<int> _priceType;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Address npAddress
        {
            get { return _npAddress; }
            set
            {
                if (!ReferenceEquals(_npAddress, value))
                {
                    var previousValue = _npAddress;
                    _npAddress = value;
                    FixupnpAddress(previousValue);
                    OnNavigationPropertyChanged("npAddress");
                }
            }
        }
        private Address _npAddress;
    
        [DataMember]
        public Distributor npDistributor
        {
            get { return _npDistributor; }
            set
            {
                if (!ReferenceEquals(_npDistributor, value))
                {
                    var previousValue = _npDistributor;
                    _npDistributor = value;
                    FixupnpDistributor(previousValue);
                    OnNavigationPropertyChanged("npDistributor");
                }
            }
        }
        private Distributor _npDistributor;
    
        [DataMember]
        public WarehouseType npWarehouseType
        {
            get { return _npWarehouseType; }
            set
            {
                if (!ReferenceEquals(_npWarehouseType, value))
                {
                    var previousValue = _npWarehouseType;
                    _npWarehouseType = value;
                    FixupnpWarehouseType(previousValue);
                    OnNavigationPropertyChanged("npWarehouseType");
                }
            }
        }
        private WarehouseType _npWarehouseType;

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
            npAddress = null;
            npDistributor = null;
            npWarehouseType = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpAddress(Address previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npWarehouse.Contains(this))
            {
                previousValue.npWarehouse.Remove(this);
            }
    
            if (npAddress != null)
            {
                if (!npAddress.npWarehouse.Contains(this))
                {
                    npAddress.npWarehouse.Add(this);
                }
    
                AddressID = npAddress.AddressID;
            }
            else if (!skipKeys)
            {
                AddressID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npAddress")
                    && (ChangeTracker.OriginalValues["npAddress"] == npAddress))
                {
                    ChangeTracker.OriginalValues.Remove("npAddress");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npAddress", previousValue);
                }
                if (npAddress != null && !npAddress.ChangeTracker.ChangeTrackingEnabled)
                {
                    npAddress.StartTracking();
                }
            }
        }
    
        private void FixupnpDistributor(Distributor previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npWarehouse.Contains(this))
            {
                previousValue.npWarehouse.Remove(this);
            }
    
            if (npDistributor != null)
            {
                if (!npDistributor.npWarehouse.Contains(this))
                {
                    npDistributor.npWarehouse.Add(this);
                }
    
                DistributorID = npDistributor.DistributorID;
            }
            else if (!skipKeys)
            {
                DistributorID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npDistributor")
                    && (ChangeTracker.OriginalValues["npDistributor"] == npDistributor))
                {
                    ChangeTracker.OriginalValues.Remove("npDistributor");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npDistributor", previousValue);
                }
                if (npDistributor != null && !npDistributor.ChangeTracker.ChangeTrackingEnabled)
                {
                    npDistributor.StartTracking();
                }
            }
        }
    
        private void FixupnpWarehouseType(WarehouseType previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npWarehouses.Contains(this))
            {
                previousValue.npWarehouses.Remove(this);
            }
    
            if (npWarehouseType != null)
            {
                if (!npWarehouseType.npWarehouses.Contains(this))
                {
                    npWarehouseType.npWarehouses.Add(this);
                }
    
                WarehouseTypeID = npWarehouseType.WarehouseTypeID;
            }
            else if (!skipKeys)
            {
                WarehouseTypeID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npWarehouseType")
                    && (ChangeTracker.OriginalValues["npWarehouseType"] == npWarehouseType))
                {
                    ChangeTracker.OriginalValues.Remove("npWarehouseType");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npWarehouseType", previousValue);
                }
                if (npWarehouseType != null && !npWarehouseType.ChangeTracker.ChangeTrackingEnabled)
                {
                    npWarehouseType.StartTracking();
                }
            }
        }

        #endregion
    }
}