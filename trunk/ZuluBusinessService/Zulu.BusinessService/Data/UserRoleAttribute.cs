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
    [KnownType(typeof(UserRole))]
    public partial class UserRoleAttribute: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int UserRoleAttributeID
        {
            get { return _userRoleAttributeID; }
            set
            {
                if (_userRoleAttributeID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'UserRoleAttributeID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _userRoleAttributeID = value;
                    OnPropertyChanged("UserRoleAttributeID");
                }
            }
        }
        private int _userRoleAttributeID;
    
        [DataMember]
        public Nullable<int> UserRoleID
        {
            get { return _userRoleID; }
            set
            {
                if (_userRoleID != value)
                {
                    ChangeTracker.RecordOriginalValue("UserRoleID", _userRoleID);
                    if (!IsDeserializing)
                    {
                        if (npUserRole != null && npUserRole.UserRoleID != value)
                        {
                            npUserRole = null;
                        }
                    }
                    _userRoleID = value;
                    OnPropertyChanged("UserRoleID");
                }
            }
        }
        private Nullable<int> _userRoleID;
    
        [DataMember]
        public string AttributeKey
        {
            get { return _attributeKey; }
            set
            {
                if (_attributeKey != value)
                {
                    _attributeKey = value;
                    OnPropertyChanged("AttributeKey");
                }
            }
        }
        private string _attributeKey;
    
        [DataMember]
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged("Value");
                }
            }
        }
        private string _value;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public UserRole npUserRole
        {
            get { return _npUserRole; }
            set
            {
                if (!ReferenceEquals(_npUserRole, value))
                {
                    var previousValue = _npUserRole;
                    _npUserRole = value;
                    FixupnpUserRole(previousValue);
                    OnNavigationPropertyChanged("npUserRole");
                }
            }
        }
        private UserRole _npUserRole;

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
            npUserRole = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpUserRole(UserRole previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npUserRoleAttributes.Contains(this))
            {
                previousValue.npUserRoleAttributes.Remove(this);
            }
    
            if (npUserRole != null)
            {
                if (!npUserRole.npUserRoleAttributes.Contains(this))
                {
                    npUserRole.npUserRoleAttributes.Add(this);
                }
    
                UserRoleID = npUserRole.UserRoleID;
            }
            else if (!skipKeys)
            {
                UserRoleID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npUserRole")
                    && (ChangeTracker.OriginalValues["npUserRole"] == npUserRole))
                {
                    ChangeTracker.OriginalValues.Remove("npUserRole");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npUserRole", previousValue);
                }
                if (npUserRole != null && !npUserRole.ChangeTracker.ChangeTrackingEnabled)
                {
                    npUserRole.StartTracking();
                }
            }
        }

        #endregion
    }
}
