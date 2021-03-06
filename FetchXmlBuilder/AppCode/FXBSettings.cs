﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XrmToolBox;

namespace Cinteros.Xrm.FetchXmlBuilder.AppCode
{
    public class FXBSettings
    {
        private static string filename = Assembly.GetExecutingAssembly().GetName().Name + ".Settings.xml";
        private bool _useFriendlyNames;

        public bool useFriendlyNames { get { return _useFriendlyNames; } set { _useFriendlyNames = value; FetchXmlBuilder.friendlyNames = value; } }
        public bool showEntitiesAll { get; set; }
        public bool showEntitiesManaged { get; set; }
        public bool showEntitiesUnmanaged { get; set; }
        public bool showEntitiesCustomizable { get; set; }
        public bool showEntitiesUncustomizable { get; set; }
        public bool showEntitiesCustom { get; set; }
        public bool showEntitiesStandard { get; set; }
        public bool showEntitiesIntersect { get; set; }
        public bool showEntitiesOnlyValidAF { get; set; }
        public bool showAttributesAll { get; set; }
        public bool showAttributesManaged { get; set; }
        public bool showAttributesUnmanaged { get; set; }
        public bool showAttributesCustomizable { get; set; }
        public bool showAttributesUncustomizable { get; set; }
        public bool showAttributesCustom { get; set; }
        public bool showAttributesStandard { get; set; }
        public bool showAttributesOnlyValidAF { get; set; }
        public bool showAttributesOnlyValidRead { get; set; }
        public int resultOption { get; set; }
        public int resultSerializeStyle { get; set; }
        public bool retrieveAllPages { get; set; } = false;
        public Size xmlWinSize { get; set; }
        public Size gridWinSize { get; set; }
        public bool gridFriendly { get; set; }
        public bool gridId { get; set; }
        public bool gridIndex { get; set; }
        public string fetchxml { get; set; }
        public bool? logUsage { get; set; }
        public string currentVersion { get; set; }
        public bool showQuickActions { get; set; }
        public bool useSingleQuotation { get; set; }

        public FXBSettings()
        {
            showEntitiesAll = true;
            showAttributesAll = true;
            showQuickActions = true;
        }
    }
}
