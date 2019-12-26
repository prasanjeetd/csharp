using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.EntityFramework
{
    public class EntryPoint
    {
        public void Execute()
        {
            CRUDOperations crudOperations = new CRUDOperations();
            crudOperations.ExecuteCRUD();

        }
    }
}
