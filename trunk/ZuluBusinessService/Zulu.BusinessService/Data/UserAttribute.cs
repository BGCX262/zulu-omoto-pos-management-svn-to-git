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
    [KnownType(typeof(User))]
    public partial class UserAttribute: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int UserAttributeID
        {
            get { return _userAttributeID; }
            set
            {
                if (_userAttributeID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'UserAttributeID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _userAttributeID = value;
                    OnPropertyChanged("UserAttributeID");
                }
            }
        }
        private int _userAttributeID;
    
        [DataMember]
        public Nullable<int> UserID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    ChangeTracker.RecordOriginalValue("UserID", _userID);
                    if (!IsDeserializing)
                    {
                        if (npUser != null && npUser.UserID != value)
                        {
                            npUser = null;
                        }
                    }
                    _userID = value;
                    OnPropertyChanged("UserID");
                }
            }
        }
        private Nullable<int> _userID;
    
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
        public User npUser
        {
            get { return _npUser; }
            set
            {
                if (!ReferenceEquals(_npUser, value))
                {
                    var previousValue = _npUser;
                    _npUser = value;
                    FixupnpUser(previousValue);
                    OnNavigationPropertyChanged("npUser");
                }
            }
        }
        private User _npUser;

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
            npUser = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupnpUser(User previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.npUserAttributes.Contains(this))
            {
                previousValue.npUserAttributes.Remove(this);
            }
    
            if (npUser != null)
            {
                if (!npUser.npUserAttributes.Contains(this))
                {
                    npUser.npUserAttributes.Add(this);
                }
    
                UserID = npUser.UserID;
            }
            else if (!skipKeys)
            {
                UserID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("npUser")
                    && (ChangeTracker.OriginalValues["npUser"] == npUser))
                {
                    ChangeTracker.OriginalValues.Remove("npUser");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("npUser", previousValue);
                }
                if (npUser != null && !npUser.ChangeTracker.ChangeTrackingEnabled)
                {
                    npUser.StartTracking();
                }
            }
        }

        #endregion
    }
}
