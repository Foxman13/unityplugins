using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if NETFX_CORE || WINDOWS_PHONE
using Windows.ApplicationModel.Store;
#endif

namespace Windows.Plugins.Store
{
    public class LicenseInformation
    {
        public delegate void LicenseChangedEventHandler();
        public event LicenseChangedEventHandler LicenseChanged;

        public LicenseInformation()
        {
#if NETFX_CORE || WINDOWS_PHONE
                //return Windows.ApplicationModel.
#endif
        }


        public DateTimeOffset ExpirationDate { 
            get 
            { 
#if NETFX_CORE || WINDOWS_PHONE
                return Windows.ApplicationModel.Store.CurrentApp.LicenseInformation.ExpirationDate;
#else
                throw new NotImplementedException();
#endif
            }
        }

        public bool IsActive { 
            get 
            {
#if NETFX_CORE || WINDOWS_PHONE
                return Windows.ApplicationModel.Store.CurrentApp.LicenseInformation.IsActive;
#else
                throw new NotImplementedException();
#endif
            } 
        }


        public bool IsTrial { 
            get 
            {
#if NETFX_CORE || WINDOWS_PHONE
                return Windows.ApplicationModel.Store.CurrentApp.LicenseInformation.IsTrial;
#else
                throw new NotImplementedException();
#endif
            } 
        }


        public Dictionary<String, ProductLicense> ProductLicenses { 
            get 
            {
#if NETFX_CORE || WINDOWS_PHONE
                
                //return Windows.ApplicationModel.Store.CurrentApp.LicenseInformation.ProductLicenses.ToDictionary<String, ProductLicense>();
                return null;
#else
                throw new NotImplementedException();
#endif
            } 
        }
    }
}
