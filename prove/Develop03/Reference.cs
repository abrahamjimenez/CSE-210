using System;
namespace Develop03
{
	/// <summary>
	/// Store the reference
	/// </summary>

	public class Reference
	{
		private Scripture scripture;

		public Reference(Scripture scripture)
		{
			this.scripture = scripture;
		}

		public string ReferenceKey()
		{
			return scripture.GetRandomScripture().Key;
		}

		public string ReferenceValue()
		{
            return scripture.GetRandomScripture().Value;
        }
    }
}

