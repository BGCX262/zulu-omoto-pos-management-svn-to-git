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
    [KnownType(typeof(Warehouse))]
    public partial class WarehouseType: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int WarehouseTypeID
        {
            get { return _warehouseTypeID; }
            set
            {
                if (_warehouseTypeID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'WarehouseTypeID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _warehouseTypeID = value;
                    OnPropertyChanged("WarehouseTypeID");
                }
            }
        }
        private int _warehouseTypeID;
    
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
        public Nullable<bool> IsDistributor
        {
            get { return _isDistributor; }
            set
            {
                if (_isDistributor != value)
                {
                    _isDistributor = value;
                    OnPropertyChanged("IsDistributor");
                }
            }
        }
        private Nullable<bool> _isDistributor;
    
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

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<Warehouse> npWarehouses
        {
            get
            {
                if (_npWarehouses == null)
                {
                    _npWarehouses = new TrackableCollection<Warehouse>();
                    _npWarehouses.CollectionChanged += FixupnpWarehouses;
                }
                return _npWarehouses;
            }
            set
            {
                if (!ReferenceEquals(_npWarehouses, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_npWarehouses != null)
                    {
                        _npWarehouses.CollectionChanged -= FixupnpWarehouses;
                    }
                    _npWarehouses = value;
                    if (_npWarehouses != null)
                    {
                        _npWarehouses.CollectionChanged += FixupnpWarehouses;
                    }
                    OnNavigationPropertyChanged("npWarehouses");
                }
            }
        }
        private TrackableCollection<Warehouse> _npWarehouses;

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
            npWarehouses.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpWarehouses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Warehouse item in e.NewItems)
                {
                    item.npWarehouseType = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("npWarehouses", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Warehouse item in e.OldItems)
                {
                    if (ReferenceEquals(item.npWarehouseType, this))
                    {
                        item.npWarehouseType = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("npWarehouses", item);
                    }
                }
            }
        }

        #endregion
    }
}
