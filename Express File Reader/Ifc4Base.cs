using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFC4
{
	public abstract class IfcBase
	{

		protected static List<string> ReadIFCDataLine(string ifcText)
        {
			List<string> outputText = new List<string>();

			char[] chars = ifcText.ToCharArray();


			int n = chars.Length;



			for(int i = 0; i < n; i++)
            {

            }



			return outputText;

		}
	}

}
