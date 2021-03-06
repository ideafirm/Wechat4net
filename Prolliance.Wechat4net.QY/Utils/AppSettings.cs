﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Web;
using System.Linq;
using System.Web.Configuration;
using System.IO;

namespace Wechat4net.QY.Utils
{
    /// <summary>
    /// 应用程序设置
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// 编译模式(Debug/Release)
        /// </summary>
        public static bool IsDebug
        {
            get
            {
#if (DEBUG)
                return true;
#else
                return false;
#endif
            }
        }

        /// <summary>
        /// Log文件路径
        /// </summary>
        public static string LogPath
        {
            get
            {
                if (IsDebug)
                {
                    return HttpContext.Current.Server.MapPath(".") + "\\log";
                }
                else
                {
                    return "";
                }
            }
        }

        public static string TempPath
        {
            get
            {
                if (!Directory.Exists(HttpContext.Current.Server.MapPath(".") + "\\temp"))
                {
                    Directory.CreateDirectory(HttpContext.Current.Server.MapPath(".") + "\\temp");
                }
                return HttpContext.Current.Server.MapPath(".") + "\\temp";
            }
        }

        //private static Dictionary<string, string> _ServiceUrl = null;
        //public static Dictionary<string, string> ServiceUrl
        //{
        //    get
        //    {
        //        if (_ServiceUrl == null)
        //        {
        //            _ServiceUrl = new Dictionary<string, string>();
        //            lock (_ServiceUrl)
        //            {
        //                var txt = File.ReadAllText(HttpContext.Current.Server.MapPath(".") + "\\ServiceUrl.json");
        //                JsonSerializer serializer = new JsonSerializer();
        //                _ServiceUrl = serializer.Deserialize<Dictionary<string, string>>(txt);
        //            }
        //        }
        //        return _ServiceUrl;
        //    }
        //}


    }
}