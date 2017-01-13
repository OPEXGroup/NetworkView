﻿using System.ComponentModel;

namespace NetworkView.Utils
{
    /// <summary>
    /// Abstract base for view-model classes that need to implement INotifyPropertyChanged.
    /// </summary>
    public abstract class AbstractModelBase : INotifyPropertyChanged
    {
#if DEBUG
        private static int nextObjectId;
        private int objectDebugId = nextObjectId++;

        public int ObjectDebugId
        {
            get
            {
                return objectDebugId;
            }
        }
#endif //  DEBUG

        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Event raised to indicate that a property value has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
