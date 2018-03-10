﻿using System;

namespace Photon.Model
{
    /*
     * Format:
     *  <modifiers-combination>+<key>
     *
     */

    [Serializable]
    public class HotkeyConfig
    {
        public string SwitchSystemProxy;
        public string SwitchSystemProxyMode;
        public string SwitchAllowLan;
        public string ShowLogs;
        public string ServerMoveUp;
        public string ServerMoveDown;

        public HotkeyConfig()
        {
            SwitchSystemProxy = "";
            SwitchSystemProxyMode = "";
            SwitchAllowLan = "";
            ShowLogs = "";
            ServerMoveUp = "";
            ServerMoveDown = "";
        }
    }
}