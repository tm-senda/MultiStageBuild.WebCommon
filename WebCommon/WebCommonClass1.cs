using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiStageBuild.Common;

namespace MultiStageBuild.WebCommon
{
    public class WebCommonClass1
    {
		public bool Method1()
		{
			return !new CommonClass1().Method1();
		}
    }
}
