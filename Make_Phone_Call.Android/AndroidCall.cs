using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Make_Phone_Call.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidCall))]
namespace Make_Phone_Call.Droid
{
    public class AndroidCall : IMakeCall
    {
        
        public void DialCall(string number)
        {
            try
            {
                var URI = Android.Net.Uri.Parse(String.Format("tel:{0}", number));
                var intent = new Intent(Intent.ActionCall, URI);
                Android.App.Application.Context.StartActivity(intent);
            }
            catch(Exception ex)
            {
                string errMsg = ex.Message;
            }
        }
    }
}