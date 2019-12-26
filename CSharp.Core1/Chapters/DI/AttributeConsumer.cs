using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DI
{
    public class AttributeConsumer
    {
        IAttributeServices _attributeService;

        public AttributeConsumer(IAttributeServices attributeService) {
            this._attributeService = attributeService;
        }

        public void Save(string name) {
            this._attributeService.Save(name);
        }
    }
}
