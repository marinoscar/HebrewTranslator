using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HebrewApp
{
    public interface IActivity
    {
        T FindViewById<T>(int id) where T : View;
        void StartActivityForResult(Intent intent, int requestCode);
        event EventHandler<ActivityResultArgs> ActivityResult;
    }
}