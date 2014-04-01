using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if NETFX_CORE || WINDOWS_PHONE
using Windows.ApplicationModel.Store;
#endif

namespace Windows.Plugins.Store
{
    public class CurrentApp
    {
        public CurrentApp()
        { }

        public Guid AppId
        {
            get
            {
#if NETFX_CORE || WINDOWS_PHONE
                return Windows.ApplicationModel.Store.CurrentApp.AppId;
#else
                throw new NotImplementedException();
#endif
            }
        }

        public Uri LinkUri
        {
            get { 
#if NETFX_CORE || WINDOWS_PHONE
                return Windows.ApplicationModel.Store.CurrentApp.LinkUri; 
#else
                throw new NotImplementedException();
#endif
            }
        }
    }
}
