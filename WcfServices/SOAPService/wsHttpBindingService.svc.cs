using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServices.DataServices;

namespace WcfServices.SOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wsHttpBindingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wsHttpBindingService.svc or wsHttpBindingService.svc.cs at the Solution Explorer and start debugging.
    public class wsHttpBindingService : IwsHttpBindingService
    {
        public void DoWork(string name, int age)
        {
            Queries queries = new Queries();
            // queries.Start();

            Projections projections = new Projections();
            //projections.Start();

            ChangeTracking changeTracking = new ChangeTracking();
            //changeTracking.ContextLifeCycle();

            DataLoading dataLoading = new DataLoading();
            //dataLoading.Load();

            ConnectedContext connected = new ConnectedContext();
            //connected.CRUD_AutoDetectChanges();
            connected.CRUD_DisableProxy();

        }
    }
}
