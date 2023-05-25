using System;
using System.Collections.Generic;

namespace Develop03
{
    /// <summary>
    /// Store the reference
    /// </summary>
    public class Reference
	{
		string reference1 = "Moses 1:39";
		string reference2 = "Matthew 5:14-16";

		public Reference()
		{

		}

		public List<string> SetReference()
		{
			List<string> references = new List<string>();
            references.Add(reference1);
            references.Add(reference2);

			return references;
        }

		public List<string> GetReference()
		{
			List<string> references = SetReference();
			return references;
		}
	}
}

