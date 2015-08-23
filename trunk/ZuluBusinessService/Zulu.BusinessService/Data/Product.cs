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
    [KnownType(typeof(Category))]
    [KnownType(typeof(ProductVariant))]
    [KnownType(typeof(CountryOfOrigin))]
    [KnownType(typeof(Supplier))]
    public partial class Product: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int ProductID
        {
            get { return _productID; }
            set
            {
                if (_productID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ProductID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _productID = value;
                    OnPropertyChanged("ProductID");
                }
            }
        }
        private int _productID;
    
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
        public Nullable<int> CountryOfOriginID
        {
            get { return _countryOfOriginID; }
            set
            {
                if (_countryOfOriginID != value)
                {
                    ChangeTracker.RecordOriginalValue("CountryOfOriginID", _countryOfOriginID);
                    if (!IsDeserializing)
                    {
                        if (npCountryOfOrigin != null && npCountryOfOrigin.CountryOfOriginID != value)
                        {
                            npCountryOfOrigin = null;
                        }
                    }
                    _countryOfOriginID = value;
                    OnPropertyChanged("CountryOfOriginID");
                }
            }
        }
        private Nullable<int> _countryOfOriginID;
    
        [DataMember]
        public Nullable<int> CategoryID
        {
            get { return _categoryID; }
            set
            {
                if (_categoryID != value)
                {
                    ChangeTracker.RecordOriginalValue("CategoryID", _categoryID);
                    if (!IsDeserializing)
                    {
                        if (npCategory != null && npCategory.CategoryID != value)
                        {
                            npCategory = null;
                        }
                    }
                    _categoryID = value;
                    OnPropertyChanged("CategoryID");
                }
            }
        }
        private Nullable<int> _categoryID;
    
        [DataMember]
        public Nullable<bool> IsActive
        {
            get { return _isActive; }
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    OnPropertyChanged("IsActive");
                }
            }
        }
        private Nullable<bool> _isActive;
    
        [DataMember]
        public Nullable<System.DateTime> CreatedOn
        {
            get { return _createdOn; }
            set
            {
                if (_createdOn != value)
                {
                    _createdOn = value;
                    OnPropertyChanged("CreatedOn");
                }
            }
        }
        private Nullable<System.DateTime> _createdOn;
    
        [DataMember]
        public Nullable<System.DateTime> UpdatedOn
        {
            get { return _updatedOn; }
            set
            {
                if (_updatedOn != value)
                {
                    _updatedOn = value;
                    OnPropertyChanged("UpdatedOn");
                }
            }
        }
        private Nullable<System.DateTime> _updatedOn;
    
        [DataMember]
        public Nullable<int> SupplierID
        {
            get { return _supplierID; }
            set
            {
                if (_supplierID != value)
                {
                    ChangeTracker.RecordOriginalValue("SupplierID", _supplierID);
                    if (!IsDeserializing)
                    {
                        if (npSupplier != null && npSupplier.SupplierID != value)
                        {
                            npSupplier = null;
                        }
                    }
                    _supplierID = value;
                    OnPropertyChanged("SupplierID");
                }
            }
        }
        private Nullable<int> _supplierID;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Category npCategory
        {
            get { return _npCategory; }
            set
            {
                if (!ReferenceEquals(_npCategory, value))
                {
                    var previousValue = _npCategory;
                    _npCategory = value;
                    FixupnpCategory(previousValue);
                    OnNavigationPropertyChanged("npCategory");
                }
            }
        }
        private Category _npCategory;
    
        [DataMember]
        public TrackableCollection<ProductVariant> npProductVariants
        {
            get
            {
                if (_npProductVariants == null)
                {
                    _npProductVariants = new TrackableCollection<ProductVariant>();
                    _npProductVariants.CollectionChanged += FixupnpProductVariants;
                }
                return _npProductVariants;
            }
            set
            {
                if (!ReferenceEquals(_npProductVariants, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_npProductVariants != null)
                    {
                        _npProductVariants.CollectionChanged -= FixupnpProductVariants;
                    }
                    _npProductVariants = value;
                    if (_npProductVariants != null)
                    {
                        _npProductVariants.CollectionChanged += FixupnpProductVariants;
                    }
                    OnNavigationPropertyChanged("npProductVariants");
                }
            }
        }
        private TrackableCollection<ProductVariant> _npProductVariants;
    
        [DataMember]
        public CountryOfOrigin npCountryOfOrigin
        {
            get { return _npCountryOfOrigin; }
            set
            {
                if (!ReferenceEquals(_npCountryOfOrigin, value))
                {
                    var previousValue = _npCountryOfOrigin;
                    _npCountryOfOrigin = value;
                    FixupnpCountryOfOrigin(previousValue);
                    OnNavigationPropertyChanged("npCountryOfOrigin");
                }
            }
        }
        private CountryOfOrigin _npCountryOfOrigin;
    
        [DataMember]
        public Supplier npSupplier
        {
            get { return _npSupplier; }
            set
            {
                if (!ReferenceEquals(_npSupplier, value))
                {
                    var previousValue = _npSupplier;
                    _npSupplier = value;
                    FixupnpSupplier(previousValue);
                    OnNavigationPropertyChanged("npSupplier");
                }
            }
        }
        private Supplier _npSupplier;

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
            npCategory = null;
            npProductVariants.Clear();
            npCountryOfOrigin = null;
            npSupplier = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpCategory(Category previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npProducts.Contains(this))
            {
                previousValue.npProducts.Remove(this);
            }
    
            if (npCategory != null)
            {
                if (!npCategory.npProducts.Contains(this))
                {
                    npCategory.npProducts.Add(this);
                }
    
                CategoryID = npCategory.CategoryID;
            }
            else if (!skipKeys)
            {
                CategoryID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npCategory")
                    && (ChangeTracker.OriginalValues["npCategory"] == npCategory))
                {
                    ChangeTracker.OriginalValues.Remove("npCategory");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npCategory", previousValue);
                }
                if (npCategory != null && !npCategory.ChangeTracker.ChangeTrackingEnabled)
                {
                    npCategory.StartTracking();
                }
            }
        }
    
        private void FixupnpCountryOfOrigin(CountryOfOrigin previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npProduct.Contains(this))
            {
                previousValue.npProduct.Remove(this);
            }
    
            if (npCountryOfOrigin != null)
            {
                if (!npCountryOfOrigin.npProduct.Contains(this))
                {
                    npCountryOfOrigin.npProduct.Add(this);
                }
    
                CountryOfOriginID = npCountryOfOrigin.CountryOfOriginID;
            }
            else if (!skipKeys)
            {
                CountryOfOriginID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npCountryOfOrigin")
                    && (ChangeTracker.OriginalValues["npCountryOfOrigin"] == npCountryOfOrigin))
                {
                    ChangeTracker.OriginalValues.Remove("npCountryOfOrigin");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npCountryOfOrigin", previousValue);
                }
                if (npCountryOfOrigin != null && !npCountryOfOrigin.ChangeTracker.ChangeTrackingEnabled)
                {
                    npCountryOfOrigin.StartTracking();
                }
            }
        }
    
        private void FixupnpSupplier(Supplier previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npProducts.Contains(this))
            {
                previousValue.npProducts.Remove(this);
            }
    
            if (npSupplier != null)
            {
                if (!npSupplier.npProducts.Contains(this))
                {
                    npSupplier.npProducts.Add(this);
                }
    
                SupplierID = npSupplier.SupplierID;
            }
            else if (!skipKeys)
            {
                SupplierID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npSupplier")
                    && (ChangeTracker.OriginalValues["npSupplier"] == npSupplier))
                {
                    ChangeTracker.OriginalValues.Remove("npSupplier");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npSupplier", previousValue);
                }
                if (npSupplier != null && !npSupplier.ChangeTracker.ChangeTrackingEnabled)
                {
                    npSupplier.StartTracking();
                }
            }
        }
    
        private void FixupnpProductVariants(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ProductVariant item in e.NewItems)
                {
                    item.npProduct = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("npProductVariants", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProductVariant item in e.OldItems)
                {
                    if (ReferenceEquals(item.npProduct, this))
                    {
                        item.npProduct = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("npProductVariants", item);
                    }
                }
            }
        }

        #endregion
    }
}
