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
    [KnownType(typeof(DamageByProductVariant))]
    public partial class DamageType: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int DamageTypeID
        {
            get { return _damageTypeID; }
            set
            {
                if (_damageTypeID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'DamageTypeID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _damageTypeID = value;
                    OnPropertyChanged("DamageTypeID");
                }
            }
        }
        private int _damageTypeID;
    
        [DataMember]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChanged("Type");
                }
            }
        }
        private string _type;
    
        [DataMember]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        private string _description;
    
        [DataMember]
        public Nullable<bool> IsReturnable
        {
            get { return _isReturnable; }
            set
            {
                if (_isReturnable != value)
                {
                    _isReturnable = value;
                    OnPropertyChanged("IsReturnable");
                }
            }
        }
        private Nullable<bool> _isReturnable;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<DamageByProductVariant> npDamageByProductVariant
        {
            get
            {
                if (_npDamageByProductVariant == null)
                {
                    _npDamageByProductVariant = new TrackableCollection<DamageByProductVariant>();
                    _npDamageByProductVariant.CollectionChanged += FixupnpDamageByProductVariant;
                }
                return _npDamageByProductVariant;
            }
            set
            {
                if (!ReferenceEquals(_npDamageByProductVariant, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_npDamageByProductVariant != null)
                    {
                        _npDamageByProductVariant.CollectionChanged -= FixupnpDamageByProductVariant;
                    }
                    _npDamageByProductVariant = value;
                    if (_npDamageByProductVariant != null)
                    {
                        _npDamageByProductVariant.CollectionChanged += FixupnpDamageByProductVariant;
                    }
                    OnNavigationPropertyChanged("npDamageByProductVariant");
                }
            }
        }
        private TrackableCollection<DamageByProductVariant> _npDamageByProductVariant;

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
            npDamageByProductVariant.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpDamageByProductVariant(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (DamageByProductVariant item in e.NewItems)
                {
                    item.npDamageType = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("npDamageByProductVariant", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (DamageByProductVariant item in e.OldItems)
                {
                    if (ReferenceEquals(item.npDamageType, this))
                    {
                        item.npDamageType = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("npDamageByProductVariant", item);
                    }
                }
            }
        }

        #endregion
    }
}