using System;
using System.Collections.Generic;

/*
 * Hardcoded list of preinstalled Windows applications that
 * can be removed by the software.
 * 
 * Author: Ethan Pugh
 */
namespace WEPA
{
    public static class Apps
    {
        // Returns a list of applications in the form of delimiter-separated strings.
        public static List<String> GetList()
        {
            List<String> apps = new List<String>();

            apps.Add("3D Viewer`No Data`microsoft3dviewer");
            apps.Add("Alarms & Clock`Personal Information, Calendar`windowsalarms");
            apps.Add("Calculator`No Data`windowscalculator");
            apps.Add("Camera`Personal Information, Location`windowscamera");
            apps.Add("Cortana`Personal Information, Contacts, Location, Calendar, Relationships`549981C3F5F10");
            apps.Add("Feedback Hub`Personal Information, Email`windowsfeedbackhub");
            apps.Add("Films & TV`Personal Information, Usage Data`zunevideo");
            apps.Add("Get Help`Personal Information, Email`gethelp");
            apps.Add("Groove Music`Personal Information, Usage Data`zunemusic");
            apps.Add("Mail and Calendar`Personal Information, Contacts, Calendar, Email, Usage Data`windowscommunicationsapps");
            apps.Add("Maps`Personal Information, Location, Contacts`windowsmaps");
            apps.Add("Microsoft Edge`Personal Information`microsoftedge.stable");
            apps.Add("Mixed Reality Portal`Personal Information`mixedreality.portal");
            apps.Add("Office Hub`Personal Information`microsoftofficehub");
            apps.Add("OneNote`Personal Information, Calendar`office.onenote");
            apps.Add("Paint 3D`No Data`mspaint");
            apps.Add("People`Personal Information, Calendar, Contacts, Location`people");
            apps.Add("Photos`Personal Information, Contacts, Location`windows.photos");
            apps.Add("Skype`Personal Information, Contacts, Email`skypeapp");
            apps.Add("Snip & Sketch`Personal Information, Usage Data`screensketch");
            apps.Add("Solitaire Collection`Personal Information, Usage Information`microsoftsolitairecollection");
            apps.Add("Sticky Notes`No Data`microsoftstickynotes");
            apps.Add("Store Checkout`Personal Information, Credentials`storepurchaseapp");
            apps.Add("Tips`Personal Information`getstarted");
            apps.Add("Voice Recorder`Personal Information`windowssoundrecorder");
            apps.Add("Wallet`Personal Information, Credentials`wallet");
            apps.Add("Weather`Location`bingweather");
            apps.Add("Xbox Console Companion`Personal Information, Accounts, Contacts, Location`xboxapp");
            apps.Add("Xbox Game Bar Plugin`Personal Information, Accounts, Contacts, Location`xboxgameoverlay");
            apps.Add("Xbox Game Bar`Personal Information, Accounts, Contacts, Location`xboxgamingoverlay");
            apps.Add("Xbox Identity Provider`Personal Information, Accounts, Contacts, Location`xboxidentityprovider");
            apps.Add("Xbox Speech to Text Overlay`Personal Information, Accounts, Contacts, Location`xboxspeechtotextoverlay");
            apps.Add("Xbox TCUI`Personal Information, Accounts, Contacts, Location`xbox.tcui");
            apps.Add("Your Phone`Personal Information, Contacts, Phone`yourphone");

            return apps;
        }
    }
}
