﻿using System.Windows.Controls;

namespace Eddi
{
    /// <summary>
    /// The methods required for an EDDI monitor.
    /// </summary>
    public interface EDDIMonitor
    {
        /// <summary>
        /// A short name for the monitor
        /// </summary>
        string MonitorName();

        /// <summary>
        /// The version of the monitor
        /// </summary>
        string MonitorVersion();

        /// <summary>
        /// A brief description of the monitor
        /// </summary>
        string MonitorDescription();

        /// <summary>
        /// Called when this monitor is started.  This is not expected to return whilst the monitor is running
        /// </summary>
        void Start();

        /// <summary>
        /// Called when this monitor is stopped.  This should tell the monitor to shut down
        /// </summary>
        void Stop();

        /// <summary>
        /// Called when this monitor needs to reload its configuration
        /// </summary>
        void Reload();

        UserControl ConfigurationTabItem();
    }
}
