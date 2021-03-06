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
    [KnownType(typeof(Distributor))]
    [KnownType(typeof(User))]
    [KnownType(typeof(Warehouse))]
    public partial class Address: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int AddressID
        {
            get { return _addressID; }
            set
            {
                if (_addressID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'AddressID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _addressID = value;
                    OnPropertyChanged("AddressID");
                }
            }
        }
        private int _addressID;
    
        [DataMember]
        public string Address1
        {
            get { return _address1; }
            set
            {
                if (_address1 != value)
                {
                    _address1 = value;
                    OnPropertyChanged("Address1");
                }
            }
        }
        private string _address1;
    
        [DataMember]
        public string Address2
        {
            get { return _address2; }
            set
            {
                if (_address2 != value)
                {
                    _address2 = value;
                    OnPropertyChanged("Address2");
                }
            }
        }
        private string _address2;
    
        [DataMember]
        public Nullable<int> CityID
        {
            get { return _cityID; }
            set
            {
                if (_cityID != value)
                {
                    _cityID = value;
                    OnPropertyChanged("CityID");
                }
            }
        }
        private Nullable<int> _cityID;
    
        [DataMember]
        public Nullable<int> StateID
        {
            get { return _stateID; }
            set
            {
                if (_stateID != value)
                {
                    _stateID = value;
                    OnPropertyChanged("StateID");
                }
            }
        }
        private Nullable<int> _stateID;
    
        [DataMember]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }
        private string _phoneNumber;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<Distributor> npDistributor
        {
            get
            {
                if (_npDistributor == null)
                {
                    _npDistributor = new TrackableCollection<Distributor>();
                    _npDistributor.CollectionChanged += FixupnpDistributor;
                }
                return _npDistributor;
            }
            set
            {
                if (!ReferenceEquals(_npDistributor, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_npDistributor != null)
                    {
                        _npDistributor.CollectionChanged -= FixupnpDistributor;
                    }
                    _npDistributor = value;
                    if (_npDistributor != null)
                    {
                        _npDistributor.CollectionChanged += FixupnpDistributor;
                    }
                    OnNavigationPropertyChanged("npDistributor");
                }
            }
        }
        private TrackableCollection<Distributor> _npDistributor;
    
        [DataMember]
        public TrackableCollection<User> npUser
        {
            get
            {
                if (_npUser == null)
                {
                    _npUser = new TrackableCollection<User>();
                    _npUser.CollectionChanged += FixupnpUser;
                }
                return _npUser;
            }
            set
            {
                if (!ReferenceEquals(_npUser, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_npUser != null)
                    {
                        _npUser.CollectionChanged -= FixupnpUser;
                    }
                    _npUser = value;
                    if (_npUser != null)
                    {
                        _npUser.CollectionChanged += FixupnpUser;
                    }
                    OnNavigationPropertyChanged("npUser");
                }
            }
        }
        private TrackableCollection<User> _npUser;
    
        [DataMember]
        public TrackableCollection<Warehouse> npWarehouse
        {
            get
            {
                if (_npWarehouse == null)
                {
                    _npWarehouse = new TrackableCollection<Warehouse>();
                    _npWarehouse.CollectionChanged += FixupnpWarehouse;
                }
                return _npWarehouse;
            }
            set
            {
                if (!ReferenceEquals(_npWarehouse, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_npWarehouse != null)
                    {
                        _npWarehouse.CollectionChanged -= FixupnpWarehouse;
                    }
                    _npWarehouse = value;
                    if (_npWarehouse != null)
                    {
                        _npWarehouse.CollectionChanged += FixupnpWarehouse;
                    }
                    OnNavigationPropertyChanged("npWarehouse");
                }
            }
        }
        private TrackableCollection<Warehouse> _npWarehouse;

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
            npDistributor.Clear();
            npUser.Clear();
            npWarehouse.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpDistributor(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Distributor item in e.NewItems)
                {
                    item.npAddress = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("npDistributor", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Distributor item in e.OldItems)
                {
                    if (ReferenceEquals(item.npAddress, this))
                    {
                        item.npAddress = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("npDistributor", item);
                    }
                }
            }
        }
    
        private void FixupnpUser(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (User item in e.NewItems)
                {
                    item.npAddress = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("npUser", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (User item in e.OldItems)
                {
                    if (ReferenceEquals(item.npAddress, this))
                    {
                        item.npAddress = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("npUser", item);
                    }
                }
            }
        }
    
        private void FixupnpWarehouse(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Warehouse item in e.NewItems)
                {
                    item.npAddress = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("npWarehouse", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Warehouse item in e.OldItems)
                {
                    if (ReferenceEquals(item.npAddress, this))
                    {
                        item.npAddress = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("npWarehouse", item);
                    }
                }
            }
        }

        #endregion
    }
}
