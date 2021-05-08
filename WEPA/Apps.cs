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
        public static IEnumerable<string> GetList()
        {
            var apps = new List<string>
            {
                "3D Viewer`No Data`microsoft3dviewer",
                "Alarms & Clock`Personal Information, Calendar`windowsalarms",
                "Calculator`No Data`windowscalculator",
                "Camera`Personal Information, Location`windowscamera",
                "Cortana`Personal Information, Contacts, Location, Calendar, Relationships`549981C3F5F10",
                "Feedback Hub`Personal Information, Email`windowsfeedbackhub",
                "Films & TV`Personal Information, Usage Data`zunevideo",
                "Get Help`Personal Information, Email`gethelp",
                "Groove Music`Personal Information, Usage Data`zunemusic",
                "Mail and Calendar`Personal Information, Contacts, Calendar, Email, Usage Data`windowscommunicationsapps",
                "Maps`Personal Information, Location, Contacts`windowsmaps",
                "Microsoft Edge`Personal Information`microsoftedge.stable",
                "Mixed Reality Portal`Personal Information`mixedreality.portal",
                "Office Hub`Personal Information`microsoftofficehub",
                "OneNote`Personal Information, Calendar`office.onenote",
                "Paint 3D`No Data`mspaint",
                "People`Personal Information, Calendar, Contacts, Location`people",
                "Photos`Personal Information, Contacts, Location`windows.photos",
                "Skype`Personal Information, Contacts, Email`skypeapp",
                "Snip & Sketch`Personal Information, Usage Data`screensketch",
                "Solitaire Collection`Personal Information, Usage Information`microsoftsolitairecollection",
                "Sticky Notes`No Data`microsoftstickynotes",
                "Store Checkout`Personal Information, Credentials`storepurchaseapp",
                "Tips`Personal Information`getstarted",
                "Voice Recorder`Personal Information`windowssoundrecorder",
                "Wallet`Personal Information, Credentials`wallet",
                "Weather`Location`bingweather",
                "Xbox Console Companion`Personal Information, Accounts, Contacts, Location`xboxapp",
                "Xbox Game Bar Plugin`Personal Information, Accounts, Contacts, Location`xboxgameoverlay",
                "Xbox Game Bar`Personal Information, Accounts, Contacts, Location`xboxgamingoverlay",
                "Xbox Identity Provider`Personal Information, Accounts, Contacts, Location`xboxidentityprovider",
                "Xbox Speech to Text Overlay`Personal Information, Accounts, Contacts, Location`xboxspeechtotextoverlay",
                "Xbox TCUI`Personal Information, Accounts, Contacts, Location`xbox.tcui",
                "Your Phone`Personal Information, Contacts, Phone`yourphone"
            };

            return apps;
        }
    }
}