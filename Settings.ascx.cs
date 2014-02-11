/*
    Manages the content and functionality of the settings page for the Latch Module
    Copyright (C) 2013 Eleven Paths
 
    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.
 
    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.
 
    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;
using LatchMembership;
using System;
using System.Configuration;
using System.Web.Configuration;
using System.Web.Security;

namespace ElevenPaths.Modules.LatchDotNetNukePlugin
{
    /// <summary>
    /// This class manages the configuration of the appId and appSecret fields inside web.config.
    /// This fields must be set only once, if appId is changed all paired users related to the appId will lose the connection with Latch.
    /// </summary>
    public partial class Settings : ModuleSettingsBase
    {
        LatchMembershipProvider LatchProvider = Membership.Provider as LatchMembershipProvider;

        Configuration configuration = WebConfigurationManager.OpenWebConfiguration("~");

        public override void LoadSettings()
        {

            try
            {
                if (!Page.IsPostBack)
                {
                    displayLatchConfig();
                }
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }


        public override void UpdateSettings()
        {
            try
            {
                updateLatchConfig();
            }

            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        /// <summary>
        /// Displays the actual appId and appSecret fields on the text fields.
        /// </summary>
        public void displayLatchConfig()
        {
            var latchConfig = configuration.GetSection("latchSettings") as LatchSettingsSection;

            txtAppId.Text = latchConfig.AppId;
            txtAppSecret.Text = latchConfig.AppSecret;
        }

        /// <summary>
        /// Updates the Latch Settings with the fields the admin inserted in the text fields.
        /// </summary>
        public void updateLatchConfig()
        {
            if (!(txtAppId.Text.Length != 20 || txtAppSecret.Text.Length != 40))
            {
                var latchConfig = configuration.GetSection("latchSettings") as LatchSettingsSection;

                latchConfig.AppId = txtAppId.Text;
                latchConfig.AppSecret = txtAppSecret.Text;

                configuration.Save();
            }
        }
    }
}