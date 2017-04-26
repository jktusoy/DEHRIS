using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationWindow;
using DEHRIS.Properties;
namespace DEHRIS.Others
{
    public class CustomPopUpNotifier :  PopupNotifier
    {
        public enum NotificationType
	    {
	     Warning,
         Error,
         Information,
         Successful
	    }

        public CustomPopUpNotifier()
        {
         
 
        
        }

        public CustomPopUpNotifier SetNotification(NotificationType enumType,  string pBody)
        {
               CustomPopUpNotifier notif = new CustomPopUpNotifier();
              
               notif.ContentText = pBody;
               notif.ContentPadding = new System.Windows.Forms.Padding(5);
               notif.TitlePadding = new System.Windows.Forms.Padding(5);
               notif.ImageSize = new System.Drawing.Size(32, 32);
               notif.TitleFont = new System.Drawing.Font("ERAS Medium", 12);
               notif.TitleColor = System.Drawing.Color.Black;
               notif.ContentFont = new System.Drawing.Font("ERAS Light", 10);
                    
            switch (enumType)
            {
                case NotificationType.Warning:
                    notif.Image = Resources.warning;
                    notif.TitleText = "WARNING";
                    notif.BodyColor = System.Drawing.Color.Moccasin;
                    break;
                case NotificationType.Error:
                    notif.Image = Resources.error;
                    notif.ImageSize = new System.Drawing.Size(32, 32);
                    notif.TitleFont = new System.Drawing.Font("ERAS Medium", 12);
                    notif.TitleColor = System.Drawing.Color.Black;
                    notif.ContentFont = new System.Drawing.Font("ERAS Light", 10);
                    notif.TitleText = "ERROR";
                    notif.BodyColor = System.Drawing.Color.LightPink;
                    break;
                case NotificationType.Information:
                    notif.Image = Resources.information;
                    notif.TitleText = "INFORMATION";
                    notif.BodyColor = System.Drawing.Color.LightSkyBlue;
                    break;
                case NotificationType.Successful:
                    notif.Image = Resources.success;
                    notif.TitleText = "SUCCESS";
                    notif.BodyColor = System.Drawing.Color.PaleGreen;
                    break;
                default:
                    break;
            }
            notif.AnimationDuration = 30;
           // notif.AnimationInterval = 10;
            notif.Popup();
            return notif;
        
        }
    }
}
