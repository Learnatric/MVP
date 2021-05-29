using Abp.Dependency;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lean.Email
{
    public class SiteRootProvider : ISiteRootProvider,ITransientDependency
    {
        string _siteRoot;
        public SiteRootProvider()
        {
            //_siteRoot = siteRoot;
        }

        public string GetSiteRoot()
        {
            return "http://localhost:4200/";
        }
    }
}
