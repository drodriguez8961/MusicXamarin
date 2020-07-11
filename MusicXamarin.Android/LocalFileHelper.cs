﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


using Xamarin.Forms;
using MusicXamarin.Droid;
using System.IO;
using MusicXamarin.Interface;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace MusicXamarin.Droid
{
    public class LocalFileHelper : IStdLocHelper
    {
       
            public string GetLocalFilePath(string filename)
            {
                string docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                string libFolder = Path.Combine(docFolder);

                return Path.Combine(libFolder, filename);
            }

        
    }
}